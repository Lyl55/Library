using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lib_books.DeskUI.Views
{
    /// <summary>
    /// Interaction logic for BooksUserControl.xaml
    /// </summary>
    public partial class BooksUserControl : UserControl
    {
        public BooksUserControl()
        {
            InitializeComponent();
        }

        public static implicit operator BooksUserControl(Window v)
        {
            throw new NotImplementedException();
        }
    }
}
