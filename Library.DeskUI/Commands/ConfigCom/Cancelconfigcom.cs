using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DeskUI.ViewModel;

namespace lib_books.DeskUI.Commands.ConfigCom
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
