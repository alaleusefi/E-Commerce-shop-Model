using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IDataService
    {
        public Task<IEnumerable<T>> GetList<T>();
        public Task<T> Get<T>();
    }
}
