using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DesktopUI.ViewModel;
using lib_books.DesktopUI.Views;

namespace lib_books.DesktopUI.Commands.LibrMainWindowCommand
{
    public class OpenBooksCommand:ICommand
    {
        private readonly LibraryViewModel _viewModel;

        public OpenBooksCommand(LibraryViewModel viewModel)
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
           var userControl = new BooksUserControl();
           userControl.DataContext = new BookViewModel(userControl);
           _viewModel.Grid.Children.Add(userControl);
        }

        public event EventHandler CanExecuteChanged;
    }
}
