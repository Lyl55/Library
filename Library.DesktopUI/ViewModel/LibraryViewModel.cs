using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using lib_books.DesktopUI.Commands.LibrMainWindowCommand;
using lib_books.DesktopUI.Commands.LibrMainWindowCommand.OpenBranchesCommands;

namespace lib_books.DesktopUI.ViewModel
{
    public class LibraryViewModel:BaseWindowViewModel
    {
        public LibraryViewModel(Window window) : base(window)
        {
            OpenBooks = new OpenBooksCommand(this);
            OpenBranches = new OpenBranchCommand(this);
            OpenAuthors = new OpenAuthorsCommand(this);
        }
        public ICommand OpenBooks { get; set; }
        public ICommand OpenBranches { get; set; }
        public ICommand OpenAuthors { get; set; }
        public Grid Grid { get; set; }
    }
}
