using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;
using lib_books.Core;

namespace lib_books.DeskUI.Commands
{
    public class EditBranchCommand:ICommand
    {
        private readonly EditBranchViewModel _viewModel;

        public EditBranchCommand(EditBranchViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
        var entity = Kernel.DB.BranchRepository.Get(_viewModel.EditBranchModel.Id);
            entity.Name = _viewModel.EditBranchModel.Name;
            entity.Address = _viewModel.EditBranchModel.Address;
            Kernel.DB.BranchRepository.Update(entity);
           _viewModel.Window.Close();
        }

        public event EventHandler CanExecuteChanged;
    }
}
