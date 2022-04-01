using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DesktopUI.ViewModel;
using lib_books.DesktopUI.Views;

namespace lib_books.DesktopUI.Commands.BookCommands
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
