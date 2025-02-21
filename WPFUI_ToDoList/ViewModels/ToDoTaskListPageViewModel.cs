using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI_ToDoList.Models;

namespace WPFUI_ToDoList.ViewModels
{
    public class ToDoTaskListPageViewModel
    {
        private readonly ObservableCollection<ToDoTask> _tasks;
        public IEnumerable<ToDoTask> Tasks => _tasks;
    }
}
