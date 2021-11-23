using System.ComponentModel.DataAnnotations;

namespace DNP3.Models {
public class Pet {
    
    [Key]
    public int Id { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Age { get; set; }
    
    
    public override string ToString()
    {
        return $"Name: {Name} Species: {Species} Age:{Age}";
    }
}
}