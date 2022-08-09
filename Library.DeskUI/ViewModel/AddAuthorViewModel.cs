using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DeskUI.Commands.AuthorCommands;
using lib_books.DeskUI.Models;
using lib_books.DeskUI.Models.AuthorModels;
using lib_books.DeskUI.Views;

namespace lib_books.DeskUI.ViewModel
{
    public class AddAuthorViewModel:BaseWindowViewModel
    {
        public AddAuthorViewModel(Window window, AuthorViewModel authorViewModel) : base(window)
        {
            SaveAuthor = new SaveAuthorCommand(this);
            AddAuthorModel = new AddAuthorModel();
            AuthorViewModel = authorViewModel;
        }

        public ICommand SaveAuthor { get; set; }
        public AddAuthorModel AddAuthorModel { get; set; }
        public AuthorViewModel AuthorViewModel { get; set; }
        //public AuthorModel EditAuthorModel { get; set; }
    }
}
