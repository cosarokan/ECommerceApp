using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class District : BaseEntity
    {
        /// <summary>
        /// Gets or sets the owner user identifier of the city.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// District name.
        /// </summary>
        public string Name { get; set; } = null!;

        public City City { get; set; } = null!;

        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
