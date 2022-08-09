using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using lib_books.DeskUI.Utils;
using lib_books.DeskUI.ViewModel;
using lib_books.DeskUI.Views;

namespace lib_books.DeskUI.Commands.ConfigCom
{
    public class Saveconfigcom:ICommand
    {
        private readonly DbConfviewmodel _viewmodel;
        public Saveconfigcom(DbConfviewmodel viewmodel)
        {
            _viewmodel = viewmodel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var config = Config.Get();
            config.DbType = _viewmodel.ConfigObject.DbType;
            config.Database = _viewmodel.ConfigObject.Database;
            config.Server = _viewmodel.ConfigObject.Server;
            config.IntegratedSecurity = _viewmodel.ConfigObject.IntegratedSecurity;
            config.UserName = _viewmodel.ConfigObject.UserName;
            config.Password = _viewmodel.ConfigObject.Password;
            config.Save();
            WindowStart winStart = new WindowStart();
            winStart.Show();
            _viewmodel.Window.Close();
        }

        public event EventHandler CanExecuteChanged;
    }
}
