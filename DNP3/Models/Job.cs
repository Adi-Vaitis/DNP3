using System.ComponentModel.DataAnnotations;

namespace DNP3.Models
{
    public class Job
    {
        [Key]
        public string JobTitle { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}