using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using DocumentFormat.OpenXml.EMMA;
using lib_books.DesktopUI.Commands.AuthorCommands;
using lib_books.DesktopUI.Commands.BookCommands;
using lib_books.DesktopUI.Models;
using lib_books.DesktopUI.Models.AuthorModels;

namespace lib_books.DesktopUI.ViewModel
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
