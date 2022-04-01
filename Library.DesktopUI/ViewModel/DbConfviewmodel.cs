using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DesktopUI.Commands.ConfigCom;
using lib_books.DesktopUI.Models.Configuration;
using lib_books.DesktopUI.Utils;

namespace lib_books.DesktopUI.ViewModel
{
    public class DbConfviewmodel
    {
        public DbConfviewmodel(Window confWindow)
        {
            this.ConfigObject = new ConfigModel();
            this.Window = confWindow;
            this.Save = new Saveconfigcom(this);
            this.Cancel = new Cancelconfigcom(this);
        }
        public ICommand Save { get; set; }
        public ICommand Cancel { get; set; }
        public Window Window { get; set; }
        public ConfigModel ConfigObject { get; set; }
        public string[] DbTypes { get; set; } = {"sql", "firebase"};
    }
}
