using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DesktopUI.ViewModel;
using lib_books.DesktopUI.Views;

namespace lib_books.DesktopUI.Commands.AuthorCommands
{
    public class OpenAddAuthorCommand:ICommand
    {
        private readonly AuthorViewModel _viewModel;

        public OpenAddAuthorCommand(AuthorViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            AddAuthorWindow window = new AddAuthorWindow();
            window.DataContext = new AddAuthorViewModel(window,_viewModel);
            window.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}
