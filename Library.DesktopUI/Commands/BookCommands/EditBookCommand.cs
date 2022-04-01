using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.Core;
using lib_books.Core.Domain.Entities;
using lib_books.DesktopUI.ViewModel;

namespace lib_books.DesktopUI.Commands.BookCommands
{
    public class EditBookCommand:ICommand
    {
        private readonly EditBookViewModel _viewModel;

        public EditBookCommand(EditBookViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var entity = Kernel.DB.BookRepository.Get(_viewModel.Model.Id);
            entity.Name = _viewModel.Model.Name;
            entity.Language = _viewModel.Model.Language;
            entity.Genre = _viewModel.Model.Genre;
            //TODO update istranslation
            Kernel.DB.BookRepository.Update(entity);
            _viewModel.Window.Close();
        }

        public event EventHandler CanExecuteChanged;
    }
}
