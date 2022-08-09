using lib_books.Core;
using System;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;

namespace lib_books.DeskUI.Commands.BookCommands
{
    public class DeleteBooksCommand:ICommand
    {
        private readonly BookViewModel _bookViewModel;

        public DeleteBooksCommand(BookViewModel bookViewModel)
        {
            _bookViewModel = bookViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Kernel.DB.BookRepository.Delete(_bookViewModel.SelectedItem.Id);
            _bookViewModel.Books.Remove(_bookViewModel.SelectedItem);
        }

        public event EventHandler CanExecuteChanged;
    }
}
