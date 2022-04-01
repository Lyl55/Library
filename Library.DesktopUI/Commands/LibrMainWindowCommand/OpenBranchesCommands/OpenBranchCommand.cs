using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DesktopUI.ViewModel;
using lib_books.DesktopUI.Views;

namespace lib_books.DesktopUI.Commands.LibrMainWindowCommand.OpenBranchesCommands
{
    public class OpenBranchCommand:ICommand
    {
        private readonly LibraryViewModel _viewModel;

        public OpenBranchCommand(LibraryViewModel viewModel)
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
            var branches = new BranchesUserControl();
            branches.DataContext = new BranchViewModel(branches);
            _viewModel.Grid.Children.Add(branches);
        }

        public event EventHandler CanExecuteChanged;
    }
}
