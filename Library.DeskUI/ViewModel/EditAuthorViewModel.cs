using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DeskUI.Commands.AuthorCommands;
using lib_books.DeskUI.Models.AuthorModels;
using lib_books.DeskUI.Commands.BookCommands;
using lib_books.DeskUI.Models;

namespace lib_books.DeskUI.ViewModel
{
    public class EditAuthorViewModel:BaseWindowViewModel
    {
        public EditAuthorViewModel(Window window):base(window)
        {
            EditAuthorModel = new AuthorModel();
            EditAuthor = new EditAuthorCommand(this);
        }
        public AuthorModel EditAuthorModel { get; set; }
        public ICommand EditAuthor { get; set; }
        //public AuthorModel SelectedItem { get; set; }

    }
}
