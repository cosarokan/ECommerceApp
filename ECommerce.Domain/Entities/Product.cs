using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        /// <summary>
        /// Identifier of the category to which the product belongs.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Identifier of the product brand.
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// Identifier of the product model.
        /// Null if the product is not associated with a specific model.
        /// </summary>
        public int? BrandModelId { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Current selling price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Available stock quantity.
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Navigation property to the category of the product.
        /// </summary>
        public Category Category { get; set; } = null!;

        /// <summary>
        /// Navigation property to the brand of the product.
        /// </summary>
        public Brand Brand { get; set; } = null!;

        /// <summary>
        /// Navigation property to the model of the product.
        /// </summary>
        public BrandModel? BrandModel { get; set; }

        /// <summary>
        /// Customer comments and reviews related to the product.
        /// </summary>
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        /// <summary>
        /// Order items that reference this product.
        /// </summary>
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        /// <summary>
        /// Collection of attribute values assigned to the product.
        /// </summary>
        public ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>();
    }
}
