using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using lib_books.DeskUI.Commands;
using lib_books.DeskUI.Commands.AuthorCommands;
using lib_books.DeskUI.Models.AuthorModels;
using lib_books.Core;
using lib_books.DeskUI.Commands.BookCommands;

namespace lib_books.DeskUI.ViewModel
{
    public class AuthorViewModel:BaseUserControlViewModel
    {
        public AuthorViewModel(UserControl control) : base(control)
        {
            var entities = Kernel.DB.AuthorRepository.Get();
            Authors = new ObservableCollection<AuthorModel>();
            int count = 1;
            foreach (var item in entities)
            {
                Authors.Add(new AuthorModel
                {
                    Id=item.Id,
                    Name = item.Name,
                    Surname = item.Surname,
                    No =count++
                });
            }

            AddAuthor = new OpenAddAuthorCommand(this);
            DeleteAuthor = new DeleteAuthorCommand(this);
            EditAuthor = new OpenEditAuthorCommand(this);
            ExportAuthor = new ExportAuthorsCommand(this);
        }
        public ICommand AddAuthor { get; set; }
        public ICommand DeleteAuthor { get; set; }
        public ICommand EditAuthor { get; set; }
        public ObservableCollection<AuthorModel>Authors { get; set; }
        public AuthorModel SelectedModel { get; set; }
        public ICommand ExportAuthor { get; set; }
    }
}
