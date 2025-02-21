using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI_ToDoList.Models
{
    public class ToDoTask
    {
        public string Text {  get; }
        public string Importance { get; }
        public DateTime DueDate { get; }
        public string? Note { get; }
        public User UserID { get; }

        public ToDoTask(string text, string importance, DateTime dueDate, string? note, User userID)
        {
            Text = text;
            Importance = importance;
            DueDate = dueDate;
            Note = note;
            UserID = userID;
        }
    }
}
