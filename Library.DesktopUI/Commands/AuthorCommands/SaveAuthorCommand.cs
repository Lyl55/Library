using lib_books.Core;
using lib_books.DesktopUI.Models.AuthorModels;
using lib_books.DesktopUI.ViewModel;
using System;
using System.Windows.Input;
using Author = lib_books.Core.Domain.Entities.Author;

namespace lib_books.DesktopUI.Commands.AuthorCommands
{
    public class SaveAuthorCommand:ICommand
    {
        private readonly AddAuthorViewModel _viewModel;

        public SaveAuthorCommand(AddAuthorViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Author author = new Author
            {
                Name = _viewModel.AddAuthorModel.Name,
                Surname = _viewModel.AddAuthorModel.Surname
            };
            Kernel.DB.AuthorRepository.Add(author);
            var authors = _viewModel.AuthorViewModel.Authors;
            var model=new AuthorModel
            {
                Name=author.Name,
                Surname =author.Surname,
                Id=author.Id
            };
            model.No = authors.Count + 1;
            authors.Add(model);
            _viewModel.Window.Close();
        }
        public event EventHandler CanExecuteChanged;
    }
}
