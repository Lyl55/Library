using lib_books.Core;
using System;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;

namespace lib_books.DeskUI.Commands.AuthorCommands
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
