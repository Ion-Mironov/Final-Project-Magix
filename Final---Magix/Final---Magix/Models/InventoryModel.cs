using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final___Magix.Models
{
    public class Inventory
    {

        [NotMapped]
        public string? Object { get; set; }
        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }

        public string? ImageSmall { get; set; }
        public string? ImageNormal { get; set; }
        public string? ImageLarge { get; set; }
        public string? ImageBorderCrop { get; set; }
		
		public decimal? Price { get; set; }

        public int? Quantity { get; set; }
    }
}
