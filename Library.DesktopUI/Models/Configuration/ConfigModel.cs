using System;
using System.Collections.Generic;
using System.Text;

namespace lib_books.DesktopUI.Models.Configuration
{
    public class ConfigModel
    {
        public string DbType { get; set; }
        public string Database { get; set; }
        public string Server { get; set; }
        public bool IntegratedSecurity { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
