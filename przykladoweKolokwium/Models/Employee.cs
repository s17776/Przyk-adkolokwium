﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKolokwium.Models
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        
        public string FirstName { get; set; }
        
        public string Surname { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
