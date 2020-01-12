using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public int Points { get; set; }
    }
}
