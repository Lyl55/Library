using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DesktopUI.Utils;
using lib_books.DesktopUI.ViewModel;

namespace lib_books.DesktopUI.Commands.BookCommands
{
    class ExportBooksCommand:ICommand
    {
        private readonly BookViewModel _viewModel;

        public ExportBooksCommand(BookViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CsvExporter.Export(_viewModel.Books.ToArray(), "books");
            MessageBox.Show("Exported", "Success", MessageBoxButton.OK,MessageBoxImage.Information);
        }

        public event EventHandler CanExecuteChanged;
    }
}
