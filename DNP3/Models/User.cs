using System.ComponentModel.DataAnnotations;

namespace DNP3.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string SecurityLevel { get; set; }
        [Required]
        public string Password { get; set; }
    }
}