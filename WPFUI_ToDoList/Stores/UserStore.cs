using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI_ToDoList.Models;

namespace WPFUI_ToDoList.Stores
{
    public class UserStore
    {
        private User _user;
        private List<ToDoTask> _tasks;
        private Lazy<Task> _initializeLazy;

        public IEnumerable<ToDoTask> Tasks => _tasks;

        public event Action<ToDoTask> TaskAdded;
    }
}
