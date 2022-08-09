using lib_books.Core;
using lib_books.Core.Domain.Entities;
using System;
using System.Windows.Input;
using lib_books.DeskUI.Models.BookModels;
using lib_books.DeskUI.ViewModel;

namespace lib_books.DeskUI.Commands.BookCommands
{
    public class SaveBookCommand:ICommand
    {
        private readonly AddBookViewModel _viewModel;

        public SaveBookCommand(AddBookViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Book book = new Book
            {
                Name=_viewModel.AddBookModel.Name,
                Language =_viewModel.AddBookModel.Language,
                IsTranslation = _viewModel.AddBookModel.IsTranslation,
                Genre=_viewModel.AddBookModel.Genre
            };
            Kernel.DB.BookRepository.Add(book);

            var books = _viewModel.BookViewModel.Books;

            var model = new BookModel
            {
                Name = book.Name,
                Language = book.Language,
                Genre = book.Genre,
                Id=book.Id
            };
            if (!string.IsNullOrEmpty(model.IsTranslation = "YES"))
            {
                book.IsTranslation = true;

            }
            else
            {
                book.IsTranslation = false;
            }

            model.No = books.Count+1;
            books.Add(model);
            _viewModel.Window.Close();
        }

        public event EventHandler CanExecuteChanged;
    }
}
