using System.ComponentModel.DataAnnotations;
namespace JamesVIdeoGameStore.Models
{
    public class OrderItem
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public int OrderId { get; set; }
        
        public int GameId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Price { get; set; }

        // Nullable navigation properties
        public virtual Order? Order { get; set; }
        public virtual Game? Game { get; set; }
    }
}
