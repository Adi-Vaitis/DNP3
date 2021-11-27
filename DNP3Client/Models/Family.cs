using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DNP3Client.Models
{
    public class Family {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [Required, MaxLength(256)]
        [JsonPropertyName("StreetName")]
        public string StreetName { get; set; }
        [Required, Range(1,1000, ErrorMessage = "Provide a number between 1 and 1000")]
        [JsonPropertyName("HouseNumber")]
        public int HouseNumber{ get; set; }
        
        [JsonPropertyName("Adults")]
        public List<Adult> Adults { get; set; }
        [JsonPropertyName("Children")]
        public List<Child> Children{ get; set; }
        [JsonPropertyName("Pets")]
        public List<Pet> Pets{ get; set; }

        public Family() {
            Adults = new List<Adult>();
            Children = new List<Child>();
            Pets = new List<Pet>();
        }
    }
}