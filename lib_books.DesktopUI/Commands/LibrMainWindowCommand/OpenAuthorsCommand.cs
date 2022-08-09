using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;
using lib_books.DeskUI.Views;

namespace lib_books.DeskUI.Commands.LibrMainWindowCommand
{
    public class OpenAuthorsCommand:ICommand
    {
        private readonly LibraryViewModel _viewModel;

        public OpenAuthorsCommand(LibraryViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.Grid.Children.Clear();
            var usercont = new AuthoruserControl();
            usercont.DataContext = new AuthorViewModel(usercont);
            _viewModel.Grid.Children.Add(usercont);
        }

        public event EventHandler CanExecuteChanged;
    }
}
