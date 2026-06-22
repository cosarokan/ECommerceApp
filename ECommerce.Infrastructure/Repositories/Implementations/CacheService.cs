using ECommerce.Application.Interfaces;
using StackExchange.Redis;
using System.Text.Json;

namespace ECommerce.Infrastructure.Repositories.Implementations
{
    public class CacheService : ICacheService
    {
        private readonly IDatabase _database;

        public CacheService(IConnectionMultiplexer redis)
        {
            _database = redis.GetDatabase();    
        }

        /// <summary>
        /// Get.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<T?> GetAsync<T>(string key)
        {
            var value = await _database.StringGetAsync(key);

            if (string.IsNullOrWhiteSpace(value))
            {
                return default;
            }

            return JsonSerializer.Deserialize<T>(value!);    
        }

        /// <summary>
        /// Remove.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task RemoveAsync(string key)
        {
            await _database.KeyDeleteAsync(key);
        }

        /// <summary>
        /// Set
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expiration"></param>
        /// <returns></returns>
        public async Task SetAsync<T>(string key, T value, TimeSpan expiration)
        {
            await _database.StringSetAsync(key, JsonSerializer.Serialize(value), expiration);
        }
    }
}
