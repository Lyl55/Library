using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DesktopUI.ViewModel;
using lib_books.DesktopUI.Views;

namespace lib_books.DesktopUI.Commands.BookCommands
{
    public class OpenAddBookCommand:ICommand
    {
        private readonly BookViewModel _bookviewModel;

        public OpenAddBookCommand(BookViewModel bookviewModel)
        {
            _bookviewModel = bookviewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            AddBookWindow window = new AddBookWindow();
            window.DataContext = new AddBookViewModel(window,_bookviewModel);
            window.Show();
        }

        public event EventHandler CanExecuteChanged;
    }
}
