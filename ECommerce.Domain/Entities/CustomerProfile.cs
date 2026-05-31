using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class CustomerProfile : BaseEntity
    {
        /// <summary>
        /// Identifier of the related user account.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Customer's full name and surname.
        /// </summary>
        public string NameSurname { get; set; } = null!;

        /// <summary>
        /// Customer's contact phone number.
        /// </summary>
        public string Phone { get; set; } = null!;

        /// <summary>
        /// Customer's date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Navigation property to the related user account.
        /// </summary>
        public User User { get; set; } = null!;
    }
}
