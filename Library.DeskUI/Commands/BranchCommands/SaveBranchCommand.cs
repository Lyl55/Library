using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DeskUI.Models.BranchModels;
using lib_books.DeskUI.Views;
using lib_books.Core;
using lib_books.Core.Domain.Entities;
using lib_books.DeskUI.ViewModel;

namespace lib_books.DeskUI.Commands.BranchCommands
{
    public class SaveBranchCommand:ICommand
    {
        private readonly AddBranchViewModel _viewModel;

        public SaveBranchCommand(AddBranchViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Branch branch = new Branch
            {
                Name = _viewModel.AddBranchModel.Name,
                Address = _viewModel.AddBranchModel.Address
            };
            Kernel.DB.BranchRepository.Add(branch);
            var branches = _viewModel.BranchViewModel.Branches;

           var model=new BranchModel
            {
                Name=branch.Name,
                Address = branch.Address,
                Id = branch.Id
            };
           model.No = branches.Count+1;
           branches.Add(model);
            _viewModel.Window.Close();
        }

        public event EventHandler CanExecuteChanged;
    }
}
