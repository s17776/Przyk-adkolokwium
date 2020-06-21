using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKolokwium.Models
{
    public class Order
    {   
       
        public int IdOrder { get; set; }
        
        public DateTime OrderDate { get; set; }

        public DateTime? RealizationDate { get; set; }
       
        public string Notes { get; set; }

        public int IdClient { get; set; }
       
        public int IdEmployee { get; set; }

        public Employee Employee { get; set; }

        public Client Client { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
