using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class ProductAttribute : BaseEntity
    {
        /// <summary>
        /// Identifier of the category to which the attribute belongs.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Name of the product attribute.
        /// Example: Color, Size, Storage, Material.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Navigation property to the category associated with the attribute.
        /// </summary>
        public Category Category { get; set; } = null!;

        /// <summary>
        /// Collection of product attribute values associated with this attribute.
        /// </summary>
        public ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>();
    }
}
