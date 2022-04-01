using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DesktopUI.Utils;
using lib_books.DesktopUI.ViewModel;

namespace lib_books.DesktopUI.Commands.AuthorCommands
{
    public class ExportAuthorsCommand:ICommand
    {
        private readonly AuthorViewModel _viewModel;

        public ExportAuthorsCommand(AuthorViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CsvExporter.Export(_viewModel.Authors.ToArray(), "authors");
            MessageBox.Show("Exported", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public event EventHandler CanExecuteChanged;
    }
}
