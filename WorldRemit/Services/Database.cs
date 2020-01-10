using WorldRemit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldRemit.Services
{
    public class Database
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Name = "Iphone",
                ID = 1,
                Company = "Apple"
            },
            new Product
            {
                Name = "Android",
                ID = 2,
                Company = "Samsung"
            },
            new Product
            {
                Name = "Windows",
                ID = 3,
                Company = "Microsoft"
            }
        };


    }
}
