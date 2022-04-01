using System;
using System.Collections.Generic;
using System.Text;

namespace lib_books.Core.Domain.Entities
{
    public class BranchBook
    {
        public int Id { get; set; }
        public Branch Branch { get; set; }
        public Book Book { get; set; }
    }
}
