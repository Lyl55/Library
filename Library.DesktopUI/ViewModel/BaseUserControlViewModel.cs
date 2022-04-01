using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace lib_books.DesktopUI.ViewModel
{
    public abstract class BaseUserControlViewModel
    {
        protected UserControl UserControl { get; set; }

        public BaseUserControlViewModel(UserControl userControl)
        {
            this.UserControl = userControl;
        }
    }
}
