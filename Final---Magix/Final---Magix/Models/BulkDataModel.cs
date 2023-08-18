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

        [JsonPropertyName("image_uris")]
        public Image? ImageUris { get; set; }
        [ForeignKey("ImageUris")]
        public string? ImageId { get; set; }


        [JsonPropertyName("prices")]
        public Price? Prices { get; set; }
        [ForeignKey("Prices")]
        public string? PriceId { get; set; }
    }

    public class Image
    {
        [JsonPropertyName("id")]
        [Key]
        public string? Id { get; set; }
        [JsonPropertyName("small")]
        public string? Small { get; set; }
        [JsonPropertyName("normal")]
        public string? Normal { get; set; }
        [JsonPropertyName("large")]
        public string? Large { get; set; }
        [JsonPropertyName("border_crop")]
        public string? BorderCrop { get; set; }
    }

    public class Price
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("usd")]
        public decimal Usd { get; set; }
    }
}
