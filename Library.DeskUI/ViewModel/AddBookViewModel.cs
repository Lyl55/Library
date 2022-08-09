using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DeskUI.Commands.BookCommands;
using lib_books.DeskUI.Models;

namespace lib_books.DeskUI.ViewModel
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
