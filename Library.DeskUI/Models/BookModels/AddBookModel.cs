using System;
using System.Collections.Generic;
using System.Text;

namespace lib_books.DeskUI.Models
{
    public class AddBookModel
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public bool IsTranslation { get; set; }
        public string Genre { get; set; }
    }
}
