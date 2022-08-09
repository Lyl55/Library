using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;
using lib_books.Core;

namespace lib_books.DeskUI.Commands.BranchCommands
{
    public class DeleteBranchCommand:ICommand
    {
        private readonly BranchViewModel _branchViewModel;

        public DeleteBranchCommand(BranchViewModel branchViewModel)
        {
            _branchViewModel = branchViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           Kernel.DB.BranchRepository.Delete(_branchViewModel.SelectedModel.Id);
           _branchViewModel.Branches.Remove(_branchViewModel.SelectedModel);
        }

        public event EventHandler CanExecuteChanged;
    }
}
