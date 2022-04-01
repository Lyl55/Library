using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.Core;
using lib_books.DesktopUI.ViewModel;
using lib_books.DesktopUI.Views;

namespace lib_books.DesktopUI.Commands.AuthorCommands
{
    public class EditAuthorCommand:ICommand
    {
        private readonly EditAuthorViewModel _viewModel;

        public EditAuthorCommand(EditAuthorViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var entity = Kernel.DB.AuthorRepository.Get(_viewModel.EditAuthorModel.Id);
            entity.Name = _viewModel.EditAuthorModel.Name;
            entity.Surname = _viewModel.EditAuthorModel.Surname;
            Kernel.DB.AuthorRepository.Update(entity);
            _viewModel.Window.Close();
        }

        public event EventHandler CanExecuteChanged;
    }
}
