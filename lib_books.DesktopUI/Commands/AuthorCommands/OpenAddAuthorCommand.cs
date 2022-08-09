using System;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;
using lib_books.DeskUI.Views;

namespace lib_books.DeskUI.Commands.AuthorCommands
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
