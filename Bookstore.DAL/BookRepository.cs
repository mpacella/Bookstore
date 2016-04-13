using Bookstore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DAL
{
    public class BookRepository
    {
        public List<Author> GetAuthors()
        {
            using (var db = new BookContext())
            {
                return db.Authors.ToList();
            }
        }
    }
}
