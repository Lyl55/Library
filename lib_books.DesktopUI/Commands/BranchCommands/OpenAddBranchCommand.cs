using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;
using lib_books.DeskUI.Views;

namespace lib_books.DeskUI.Commands.BranchCommands
{
    public class OpenAddBranchCommand:ICommand
    {
        private readonly BranchViewModel _branchViewModel;

        public OpenAddBranchCommand(BranchViewModel viewModel)
        {
            _branchViewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            AddBranchWindow window = new AddBranchWindow();
            window.DataContext = new AddBranchViewModel(window,_branchViewModel);
            window.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}
