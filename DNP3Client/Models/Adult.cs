using System.Text.Json.Serialization;

namespace DNP3Client.Models
{
    public class Adult : Person {
        [JsonPropertyName("JobTitle")]
        public Job JobTitle { get; set; }

        public Adult()
        {
            JobTitle = new Job();
        }
    }
}