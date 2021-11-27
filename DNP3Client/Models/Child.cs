using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DNP3Client.Models
{
    public class Child : Person {
    
            [JsonPropertyName("Interests")]
            public List<Interest> Interests { get; set; }
            [JsonPropertyName("Pets")]
            public List<Pet> Pets { get; set; }
        }
    }