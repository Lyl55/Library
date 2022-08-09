using System.Windows;
using System.Windows.Input;
using lib_books.DeskUI.Commands.LoginCommands;
using lib_books.DeskUI.Models.LoginModels;

namespace lib_books.DeskUI.ViewModel
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
