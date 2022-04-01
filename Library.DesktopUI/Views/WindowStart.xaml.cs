using lib_books.DesktopUI.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using lib_books.Core;
using lib_books.Core.DataAccess.Sql;
using lib_books.Core.Factories;
using lib_books.DesktopUI.ViewModel;

namespace lib_books.DesktopUI.Views
{
    /// <summary>
    /// Interaction logic for WindowStart.xaml
    /// </summary>
    public partial class WindowStart : Window
    {
        public WindowStart()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            Config curreConfiguration = Config.Get();
            if (curreConfiguration == null || curreConfiguration.Database == null)
            {
                DbConfiguration window = new DbConfiguration();
                window.DataContext = new DbConfviewmodel(window);
                window.Show();
                this.Close();
            }
            else
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.InitialCatalog = curreConfiguration.Database;
                builder.DataSource = curreConfiguration.Server;
                builder.IntegratedSecurity = curreConfiguration.IntegratedSecurity;
                if (curreConfiguration.IntegratedSecurity == false)
                {
                    builder.UserID = curreConfiguration.UserName;
                    builder.Password = curreConfiguration.Password;
                }

                if (CheckSqlCon(builder.ConnectionString))
                {
                    Kernel.DB = DbFactory.GetDb(new DbSettings
                    {
                        ConnectionString =builder.ConnectionString,
                        DbType = curreConfiguration.DbType
                    });
                    LoginUI window = new LoginUI();
                    window.DataContext = new LoginViewModel(window);
                    window.Show();
                    this.Close();
                }
                else
                {
                    DbConfiguration window = new DbConfiguration();
                    window.DataContext = new DbConfviewmodel(window);
                    window.Show();
                    this.Close();
                }
            }
        }

        private bool CheckSqlCon(string connectionString)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }

 
}
