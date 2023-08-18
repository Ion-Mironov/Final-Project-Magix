using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Final___Magix.Models
{
    public class BulkData
    {
        [JsonPropertyName("object")]
        [NotMapped]
        public string? Object { get; set; }
        [JsonPropertyName("id")]
        [Key]
        public string? Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("imagesmall")]
        public string? ImageSmall { get; set; }
        [JsonPropertyName("imagenormal")]
        public string? ImageNormal { get; set; }
        [JsonPropertyName("imagelarge")]
        public string? ImageLarge { get; set; }
        [JsonPropertyName("imagebordercrop")]
        public string? ImageBorderCrop { get; set; }
        
        [JsonPropertyName("prices")]
        public Price? Prices { get; set; }
        [ForeignKey("Prices")]
        public string? PriceId { get; set; }
    }



    public class Price
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("usd")]
        public decimal Usd { get; set; }
    }
}
