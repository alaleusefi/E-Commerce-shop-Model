using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}
