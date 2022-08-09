using System;
using System.Collections.Generic;
using System.Text;
using lib_books.Core.Domain.Entities;

namespace lib_books.Core.Domain.Entities
{
    class AuthorBook
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
