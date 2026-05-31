using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities
{
    public class Comment : BaseEntity
    {
        /// <summary>
        /// Identifier of the user who created the comment.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Identifier of the related product.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Comment content.
        /// </summary>
        public string Content { get; set; } = null!;

        /// <summary>
        /// Optional comment title.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Indicates whether the comment has been approved.
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// Identifier of the user who approved the comment.
        /// </summary>
        public int? ApprovedUserId { get; set; }

        /// <summary>
        /// Date and time when the comment was approved.
        /// </summary>
        public DateTime? ApprovedDate { get; set; }

        /// <summary>
        /// Navigation property to the comment owner.
        /// </summary>
        public User User { get; set; } = null!;

        /// <summary>
        /// Navigation property to the related product.
        /// </summary>
        public Product Product { get; set; } = null!;
    }
}
