using Library.bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string Title,string authorName)
        {
            return DataSource().Where(x => x.title.Contains(Title) || x.author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){id = 1,title = "mvc",author="nitish"},
                new BookModel(){id = 2,title = "java",author="nishant"},
                new BookModel(){id = 3,title = "Power System",author="aniket"},
                new BookModel(){id = 4,title = "DAA",author="neeraj"},
                new BookModel(){id = 5,title = "data structure",author="nitish"},
            };
        }

    }
}
