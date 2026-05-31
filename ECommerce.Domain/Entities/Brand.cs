using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class Brand : BaseEntity
    {
        /// <summary>
        /// Name of the brand.
        /// </summary>
        public string Name { get; set; } = null!;

        public ICollection<BrandModel> BrandModels { get; set; } = new List<BrandModel>();

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
