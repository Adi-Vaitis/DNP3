using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Models
{
    public class Interest
    {
        [Key]
        [JsonPropertyName("IdInterest")]
        public int IdInterest { get; set; }
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Description")]
        [Required, MaxLength(100, ErrorMessage = "Write a smaller description (100 characters max)")]
        public string Description { get; set; }
    }
}