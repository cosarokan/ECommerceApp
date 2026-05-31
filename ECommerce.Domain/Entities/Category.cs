using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class Category : BaseEntity
    {
        /// <summary>
        /// Parent category identifier.
        /// Null for root categories.
        /// </summary>
        public int? ParentCategoryId { get; set; }

        /// <summary>
        /// Category name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Category description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the category is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Navigation property to the parent category.
        /// </summary>
        public Category? ParentCategory { get; set; }

        /// <summary>
        /// Child categories belonging to this category.
        /// </summary>
        public ICollection<Category> SubCategories { get; set; } = new List<Category>();

        /// <summary>
        /// Products assigned to this category.
        /// </summary>
        public ICollection<Product> Products { get; set; } = new List<Product>();

        /// <summary>
        /// Product attributes available for this category.
        /// </summary>
        public ICollection<ProductAttribute> ProductAttributes { get; set; } = new List<ProductAttribute>();
    }
}
