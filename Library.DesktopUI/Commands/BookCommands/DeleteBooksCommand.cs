using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.Core;
using lib_books.DesktopUI.ViewModel;

namespace lib_books.DesktopUI.Commands.BookCommands
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
