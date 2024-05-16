using System.ComponentModel.DataAnnotations;

namespace JamesVIdeoGameStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter an Order Date ")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Range(0, 100)]
        public int TotalPrice { get; set; }

        [Required(ErrorMessage = "Please enter Complete or In-progress.")]
        public string Status { get; set; }

        // Collection navigation property
        public virtual ICollection<OrderItem>? OrderItems { get; set; }

    }
}
