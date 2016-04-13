using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DAL.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Range(0, 5)]
        public int Rating { get; set; }
        public DateTime PublishDate { get; set; }

        public virtual Author author { get; set; }
    }
}
