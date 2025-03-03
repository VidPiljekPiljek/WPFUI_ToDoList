using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI_ToDoList.Services;
using WPFUI_ToDoList.ViewModels;

namespace WPFUI_ToDoList.Commands
{
    public class SignUpCommand : AsyncCommandBase
    {
        private readonly SignUpViewModel _signUpViewModel;
        private readonly NavigationService<ToDoTaskListPageViewModel> _navigationService;
    }
}
