using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.ComponentModel.DataAnnotations;

namespace Final___Magix.Models
{
    public class CardModel
    {

        [Required]
        public string Name { get; set; }
        
        public int Id { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public string Set { get; set; }

        [Required]

        public string Print { get; set; }
        [Required]
        public bool Foil { get; set; }

        public int Price { get; set; }
        
        public string image { get; set; }
           
    }
}
