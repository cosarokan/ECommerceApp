using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class PaymentType : BaseEntity
    {
        /// <summary>
        /// Name of the payment type.
        /// </summary>
        public string Name { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
