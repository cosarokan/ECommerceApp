using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class BrandModel : BaseEntity
    {
        /// <summary>
        /// Identifier of the associated brand.
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// Category name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Navigation property to the associated brand.
        /// </summary>
        public Brand Brand { get; set; } = null!;

        /// <summary>
        /// Products belonging to this category.
        /// </summary>
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
