using System.Text.Json.Serialization;

namespace DNP3Client.Models
{
    public class Interest {
        [JsonPropertyName("Type")]
        public string Type { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
}