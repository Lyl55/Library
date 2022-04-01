using System;
using System.Collections.Generic;
using System.Text;

namespace lib_books.Core.Domain.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<User> Users { get; set; }
    }
}
