using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DesktopUI.Utils;
using lib_books.DesktopUI.ViewModel;

namespace lib_books.DesktopUI.Commands.BranchCommands
{
    public class ExportBranchCommand:ICommand
    {
        private readonly BranchViewModel _viewModel;

        public ExportBranchCommand(BranchViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CsvExporterBranches.Export(_viewModel.Branches.ToArray(), "branches");
            MessageBox.Show("Exported", "Success", MessageBoxButton.OK,MessageBoxImage.Information);
        }

        public event EventHandler CanExecuteChanged;
    }
}
