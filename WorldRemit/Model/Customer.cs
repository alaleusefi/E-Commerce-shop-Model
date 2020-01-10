using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldRemit.Model
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
         
        public Address Address { get; set; }
    }
}
