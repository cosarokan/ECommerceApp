using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class OrderStatus : BaseEntity
    {
        /// <summary>
        /// Name of the order status.
        /// </summary>
        public string Name { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
