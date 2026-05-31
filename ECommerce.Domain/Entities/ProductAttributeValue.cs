using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class ProductAttributeValue : BaseEntity
    {
        /// <summary>
        /// Identifier of the related product.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Identifier of the related product attribute.
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Value assigned to the product attribute.
        /// </summary>
        public string Value { get; set; } = null!;

        /// <summary>
        /// Navigation property to the related product.
        /// </summary>
        public Product Product { get; set; } = null!;

        /// <summary>
        /// Navigation property to the related product attribute.
        /// </summary>
        public ProductAttribute ProductAttribute { get; set; } = null!;
    }
}
