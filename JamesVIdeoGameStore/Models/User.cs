using System.ComponentModel.DataAnnotations;

namespace JamesVIdeoGameStore.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter a username")]
        [StringLength(20, ErrorMessage = "Username must be between 5 and 20 characters", MinimumLength = 5)]
        public string UserName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please enter an email address")]
        public string UserEmail { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateJoined { get; set; }
    }
}
