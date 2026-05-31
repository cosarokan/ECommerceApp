using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Address : BaseEntity
    {
        /// <summary>
        /// Gets or sets the owner user identifier of the address.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the address type identifier.
        /// </summary>
        public int AddressTypeId { get; set; }

        /// <summary>
        /// Gets or sets the city identifier.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Gets or sets the district identifier.
        /// </summary>
        public int DistrictId { get; set; }

        /// <summary>
        /// Gets or sets the full address details.
        /// </summary>
        public string FullAddress { get; set; } = null!;

        /// <summary>
        /// Indicates whether this address is the default address of the user.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Indicates whether the address is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Navigation property to the user who owns the address.
        /// </summary>
        public User User { get; set; } = null!;

        /// <summary>
        /// Navigation property to the address type.
        /// </summary>
        public AddressType AddressType { get; set; } = null!;

        /// <summary>
        /// Navigation property to the city.
        /// </summary>
        public City City { get; set; } = null!;

        /// <summary>
        /// Navigation property to the district.
        /// </summary>
        public District District { get; set; } = null!;
    }
}
