using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class AddressType : BaseEntity
    {
        /// <summary>
        /// Name of the address type.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Indicates whether the address type is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Collection of addresses associated with this address type.
        /// </summary>
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
