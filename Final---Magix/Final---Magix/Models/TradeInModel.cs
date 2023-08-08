using System.ComponentModel.DataAnnotations;

namespace Final___Magix.Models
{
    public class TradeInModel
    {
        
        public int Id { get; set; } 

        public virtual IEnumerable<CardModel>? Cards { get; set; }

        //public int price { get; set; }



    }
}
