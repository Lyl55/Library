using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;
using lib_books.DeskUI.Views;

namespace lib_books.DeskUI.Commands.BranchCommands
{
    public class OpenEditBranchWindowCommand:ICommand
    {
        public readonly BranchViewModel _viewModel;

        public OpenEditBranchWindowCommand(BranchViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var window =new EditBranchWindow();
            var viewModel = new EditBranchViewModel(window);
            viewModel.EditBranchModel = _viewModel.SelectedModel;
            window.DataContext = viewModel;
            window.Show();
        }


        public event EventHandler CanExecuteChanged;
    }
}
