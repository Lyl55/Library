using System;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;
using lib_books.DeskUI.Views;

namespace lib_books.DeskUI.Commands.BookCommands
{
    public class OpenEditBookCommand:ICommand
    {
        private readonly BookViewModel _viewModel;

        public OpenEditBookCommand(BookViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var window = new EditBookWindow();
            var viewmodel = new EditBookViewModel(window);
            viewmodel.Model = _viewModel.SelectedItem;
            window.DataContext = viewmodel;
            window.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}
