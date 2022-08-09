using System;
using System.Collections.Generic;
using System.Text;
using lib_books.Core.Domain.Entities;

namespace lib_books.Core.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public bool IsTranslation { get; set; }
        public List<Author> Authors { get; set; }
        public List<Branch> Branches { get; set; }
        public string Genre { get; set; }
    }
}
