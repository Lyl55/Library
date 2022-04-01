using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DesktopUI.ViewModel;

namespace lib_books.DesktopUI.Commands.ConfigCom
{
    public class Cancelconfigcom:ICommand
    {
        private readonly DbConfviewmodel _viewmodel;

        public Cancelconfigcom(DbConfviewmodel viewmodel)
        {
            _viewmodel = viewmodel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewmodel.Window.Close();
        }

        public event EventHandler CanExecuteChanged;
    }
}
