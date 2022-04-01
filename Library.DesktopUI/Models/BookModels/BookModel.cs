using System;
using System.Collections.Generic;
using System.Text;

namespace lib_books.DesktopUI.Models.BookModels
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string IsTranslation { get; set; }
        public int No { get; set; }
        public string Genre { get; set; }
    }
}
