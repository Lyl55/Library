using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DeskUI.Commands.BookCommands;
using lib_books.DeskUI.Models.BookModels;

namespace lib_books.DeskUI.ViewModel
{
    public class EditBookViewModel:BaseWindowViewModel
    {
        public EditBookViewModel(Window window) : base(window)
        {
            Model = new BookModel();
            EditBook = new EditBookCommand(this);
        }
        public BookModel Model { get; set; }
        public ICommand EditBook { get; set; }

    }
}
