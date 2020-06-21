using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKolokwium.Models
{
    public class Client
    {
        
        public int IdClient { get; set; }
       
        public string FirstName { get; set; }
      
        public string Surname { get; set; }

        public List<Order> Orders { get; set; }


    }
}
