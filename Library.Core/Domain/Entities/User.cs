using System;
using System.Collections.Generic;
using System.Text;

namespace lib_books.Core.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public Branch Branch { get; set; }
    }
}
