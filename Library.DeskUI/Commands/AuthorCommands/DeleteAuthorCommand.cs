using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.Core;
using lib_books.DesktopUI.ViewModel;

namespace lib_books.DesktopUI.Commands
{
    public class DeleteAuthorCommand:ICommand
    {
        private readonly AuthorViewModel _viewModel;

        public DeleteAuthorCommand(AuthorViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Kernel.DB.AuthorRepository.Delete(_viewModel.SelectedModel.Id);
            _viewModel.Authors.Remove(_viewModel.SelectedModel);
        }

        public event EventHandler CanExecuteChanged;
    }
}
