using System;
using System.Collections.Generic;
using System.Text;
using lib_books.Core.Domain.Entities;

namespace lib_books.Core.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Book> Books { get; set; }
    }
}
