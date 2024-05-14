using System.ComponentModel.DataAnnotations;
namespace JamesVIdeoGameStore.Models
{
    public class Review
    {
        [Key]
        [StringLength(10)]
        public int ReviewId { get; set; }

        [Required(ErrorMessage = "Please enter a GameId.")]
        [StringLength(10)]
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please enter an OrderId.")]
        [StringLength(10)]
        public int OrderId { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please add a comment for your review.")]
        public string Comment { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }

        // Collection navigation property
        public virtual ICollection<OrderItem>? OrderItems { get; set; }
    }
}
