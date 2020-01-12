using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class Database
    {
        public static List<Book> Books = new List<Book>
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
        public static List<Video> Videos = new List<Video>
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

    }
}
