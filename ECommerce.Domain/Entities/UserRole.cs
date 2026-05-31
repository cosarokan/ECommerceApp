namespace ECommerce.Domain.Entities
{
    public class UserRole
    {
        /// <summary>
        /// Identifier of the related user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Identifier of the assigned role.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Date and time when the role was assigned to the user.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Navigation property to the related user.
        /// </summary>
        public User User { get; set; } = null!;

        /// <summary>
        /// Navigation property to the assigned role.
        /// </summary>
        public Role Role { get; set; } = null!;
    }
}
