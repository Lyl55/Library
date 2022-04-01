using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DesktopUI.Commands.BookCommands;
using lib_books.DesktopUI.Models;

namespace lib_books.DesktopUI.ViewModel
{
    public class AddBookViewModel:BaseWindowViewModel
    {
        public AddBookViewModel(Window window,BookViewModel bookViewModel) : base(window)
        {
            SaveBook = new SaveBookCommand(this);
            AddBookModel = new AddBookModel();
            BookViewModel = bookViewModel;
        }
        public ICommand SaveBook { get; set; }
        public AddBookModel AddBookModel { get; set; }
        public BookViewModel BookViewModel { get; set; }
    }
}
