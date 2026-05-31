namespace ECommerce.Domain.Common
{
    /// <summary>
    /// BaseEntity
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// CreatedUser
        /// </summary>
        public string? CreatedUser { get; set; }

        /// <summary>
        /// ModifiedDate
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// ModifiedUser
        /// </summary>
        public string? ModifiedUser { get; set; }
    }
}
