using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using lib_books.DeskUI.Commands.BookCommands;
using lib_books.DeskUI.Models.BookModels;
using lib_books.Core;
using lib_books.DeskUI.Commands.BranchCommands;
using lib_books.DeskUI.Commands.LibrMainWindowCommand.OpenBranchesCommands;
using lib_books.DeskUI.Views;

namespace lib_books.DeskUI.ViewModel
{
    public class BookViewModel:BaseUserControlViewModel
    {

        public BookViewModel(UserControl control) : base(control)
        {
            var bs = Kernel.DB.BookRepository.Get();
            Books = new ObservableCollection<BookModel>();
            int count = 1;
            foreach (var x in bs)
            {
                var model = new BookModel
                {
                    Id = x.Id,
                    Name = x.Name,
                   // IsTranslation = x.IsTranslation,
                    Language = x.Language,
                    No = count++,
                    Genre = x.Genre
                };
                if (x.IsTranslation)
                {
                    model.IsTranslation = "YES";
                }
                else
                {
                    model.IsTranslation = "NO";

                }
            }

            AddBook = new OpenAddBookCommand(this);
            DeleteBook = new DeleteBooksCommand(this);
            ExportBooks = new ExportBooksCommand(this);
            EditBook = new OpenEditBookCommand(this);
        }
        public ICommand AddBook { get; set; }
        public ICommand DeleteBook { get; set; }
        public ICommand EditBook { get; set; }

        public ObservableCollection<BookModel> Books { get; set; }
        public BookModel SelectedItem { get; set; }
        public ICommand ExportBooks { get; set; }
    }
}
