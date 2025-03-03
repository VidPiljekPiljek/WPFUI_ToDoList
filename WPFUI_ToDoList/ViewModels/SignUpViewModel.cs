using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFUI_ToDoList.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        private string _userName;
        private string _password;
        public string Username
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public AsyncCommandBase SignUpCommand { get; }
    }
}
