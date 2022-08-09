using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace lib_books.DeskUI.ViewModel
{
    public abstract class BaseWindowViewModel
    {
        public BaseWindowViewModel(Window window)
        {
            Window = window;
        }


        public Window Window { get; set; }
    }
}
