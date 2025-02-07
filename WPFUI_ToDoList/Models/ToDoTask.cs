using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI_ToDoList.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Text {  get; set; }
        public string Importance { get; set; }
        public DateTime DueDate { get; set; }
        public string? Note { get; set; }
    }
}
