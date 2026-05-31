using ECommerce.Domain.Common;
namespace ECommerce.Domain.Entities
{
    public class User : BaseEntity
    {
        /// <summary>
        /// Username used for authentication and identification.
        /// </summary>
        public string Username { get; set; } = null!;

        /// <summary>
        /// Email address of the user.
        /// </summary>
        public string Email { get; set; } = null!;

        /// <summary>
        /// Hashed password of the user.
        /// </summary>
        public string PasswordHash { get; set; } = null!;

        /// <summary>
        /// Indicates whether the user account is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Navigation property to the customer profile.
        /// </summary>
        public CustomerProfile? CustomerProfile { get; set; }

        /// <summary>
        /// Collection of addresses associated with the user.
        /// </summary>
        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        /// <summary>
        /// Collection of roles assigned to the user.
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

        /// <summary>
        /// Collection of comments created by the user.
        /// </summary>
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        /// <summary>
        /// Collection of orders placed by the user.
        /// </summary>
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
