using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Service
{
    public class DataServiceMock : IDataService
    {
        private IEnumerable<Product> Products => Enumerable.Union<Product>(Books, Videos);
        private List<Book> Books = new List<Book>
        {
            new Book
            {
                Name = "Book1",
                ID = 1,
                Price = 30,
            },
            new Book
            {
                Name = "Book2",
                ID = 2,
                Price = 20,
            },
            new Book
            {
                Name = "Book3",
                ID = 3,
                Price = 250,
            }
        };
        private List<Video> Videos = new List<Video>
        {
            new Video
            {
                Name = "Video1",
                ID = 4,
                Price = 30,
            },
            new Video
            {
                Name = "Video2",
                ID = 5,
                Price = 20,
            },
            new Video
            {
                Name = "Video3",
                ID = 6,
                Price = 250,
            }
        };

        public Task<IEnumerable<T>> GetList<T>()
        {
            var propertyInfos = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.NonPublic);
            var propertyInfo = propertyInfos.SingleOrDefault(pi => pi.PropertyType == typeof(IEnumerable<T>));
            if (propertyInfo == null) throw new NullReferenceException($"{nameof(DataServiceMock)} knows no source collection of type {typeof(T)}.");
            var property = (IEnumerable<T>)propertyInfo.GetValue(this);
            return Task.FromResult(property);
        }

        public Task<T> Get<T>()
        {
            throw new NotImplementedException();
        }
    }
}
