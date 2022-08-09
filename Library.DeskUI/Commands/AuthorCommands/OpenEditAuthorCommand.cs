using System;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;
using lib_books.DeskUI.Views;

namespace lib_books.DeskUI.Commands.AuthorCommands
{
    public class OpenEditAuthorCommand:ICommand
    {
        private readonly AuthorViewModel _viewModel;

        public OpenEditAuthorCommand(AuthorViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var window = new EditAuthorWindow();
            var viewmodel = new EditAuthorViewModel(window);
            viewmodel.EditAuthorModel = _viewModel.SelectedModel;
            window.DataContext = viewmodel;
            window.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}
