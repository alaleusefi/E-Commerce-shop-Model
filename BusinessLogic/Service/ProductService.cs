using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IProductService
    {
        private readonly IDataService DataService;
        public ProductService(IDataService dataService)
        {
            DataService = dataService;
        }
        public Task<IEnumerable<Product>> GetAll()
        {
            return DataService.GetList<Product>();
        }
    }
}
