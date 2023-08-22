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
		
		public Price? Prices { get; set; }

        [ForeignKey("InventoryPrices")]
        public string? PriceId { get; set; }
        public int? Quantity { get; set; }
		public InventoryPrice InventoryPrice { get; set; }
	}



    public class InventoryPrice
    {
        public string? Id { get; set; }
        public decimal Usd { get; set; }
		public Inventory Inventory { get; set; }
	}
}
