using System.Text.Json.Serialization;

namespace DNP3Client.Models
{
    public class Job
    {
        [JsonPropertyName("JobTitle")]
        public string JobTitle { get; set; }
        [JsonPropertyName("Salary")]
        public int Salary { get; set; }
    }
}