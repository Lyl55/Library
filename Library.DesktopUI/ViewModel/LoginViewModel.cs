using System.Windows;
using lib_books.DesktopUI.Commands.LoginCommands;
using lib_books.DesktopUI.Models.LoginModels;
using System.Windows.Input;

namespace lib_books.DesktopUI.ViewModel
{
    public class LoginViewModel:BaseWindowViewModel
    {
        public LoginViewModel(Window window) : base(window)
        {
            Login = new LoginCommand(this);
            LoginModel = new LoginModel
            {
                Username = "lyl555"
            };
        }

        public ICommand Login { get; set; }
        public LoginModel LoginModel { get; set; }
    }
}
