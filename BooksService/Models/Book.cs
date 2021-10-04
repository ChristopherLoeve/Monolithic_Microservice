using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksService.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
    }
}
