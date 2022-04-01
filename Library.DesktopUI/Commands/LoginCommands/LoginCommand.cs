using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using lib_books.DesktopUI.ViewModel;
using lib_books.DesktopUI.Views;

namespace lib_books.DesktopUI.Commands.LoginCommands
{
    public class LoginCommand:ICommand
    {
        private readonly LoginViewModel _loginViewModel;

        public LoginCommand(LoginViewModel loginViewModel)
        {
            _loginViewModel = loginViewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string username = "lyl555";
            string password = "23456";
            var passwordBox = (PasswordBox) parameter;//==parameter as PasswordBox//referans typeler(only)
            string inputpassword = passwordBox.Password;
            string inputusername = _loginViewModel.LoginModel.Username;
            if (inputpassword==password && inputusername==username)
            {
                LibraryMainWindow window = new LibraryMainWindow();
                var viewModel = new LibraryViewModel(window);
                window.DataContext = viewModel;
                var usercont = new BranchesUserControl();
                usercont.DataContext = new BranchViewModel(usercont);
                window.GrdCenter.Children.Add(usercont);
                viewModel.Grid = window.GrdCenter;
                window.Show();
                _loginViewModel.Window.Close();
            }
        }
        public event EventHandler CanExecuteChanged;
    }
}
