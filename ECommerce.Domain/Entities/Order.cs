using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class Order : BaseEntity
    {
        /// <summary>
        /// Identifier of the customer who placed the order.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Identifier of the current order status.
        /// </summary>
        public int OrderStatusId { get; set; }

        /// <summary>
        /// Total amount of the order.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Identifier of the payment method used for the order.
        /// </summary>
        public int PaymentTypeId { get; set; }

        /// <summary>
        /// Navigation property to the customer who placed the order.
        /// </summary>
        public User User { get; set; } = null!;

        /// <summary>
        /// Navigation property to the current order status.
        /// </summary>
        public OrderStatus OrderStatus { get; set; } = null!;

        /// <summary>
        /// Navigation property to the payment method used for the order.
        /// </summary>
        public PaymentType PaymentType { get; set; } = null!;

        /// <summary>
        /// Collection of order items belonging to the order.
        /// </summary>
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
