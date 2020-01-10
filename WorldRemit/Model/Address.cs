using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldRemit.Model
{
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
