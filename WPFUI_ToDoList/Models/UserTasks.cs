using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI_ToDoList.Models
{
    public class UserTasks
    {
        public List<ToDoTask> Tasks { get; set; }

        public UserTasks(List<ToDoTask> tasks)
        {
            Tasks = tasks;
        }
    }
}
