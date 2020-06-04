using System.ComponentModel.DataAnnotations;

namespace Eksamen.Models
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; } // SessionID f.eks. 

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; } // Godt at gemme hvornår kunden har lagt noget i kurven

        public System.DateTime Fullfilled { get; set; } // Hvornår er købet gennemført

        public int ProductId { get; set; } //Hjelmens ID 

        public virtual Product Product { get; set; } // Den kan udelades 


    }
}