using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        /// <summary>
        /// Identifier of the related order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Identifier of the ordered product.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Quantity of the product ordered.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Unit price of the product at the time of the order.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Navigation property to the related order.
        /// </summary>
        public Order Order { get; set; } = null!;

        /// <summary>
        /// Navigation property to the ordered product.
        /// </summary>
        public Product Product { get; set; } = null!;
    }
}
