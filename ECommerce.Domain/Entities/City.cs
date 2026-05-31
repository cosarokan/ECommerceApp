using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class City : BaseEntity
    {
        /// <summary>
        /// City name.
        /// </summary>
        public string Name { get; set; } = null!;

        public ICollection<District> Districts { get; set; } = new List<District>();

        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
