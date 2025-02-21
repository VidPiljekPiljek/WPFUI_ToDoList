using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI_ToDoList.Models;

namespace WPFUI_ToDoList.DTOS
{
    public class ToDoTaskDTO
    {
        [Key]
        public Guid ToDoTaskID { get; set; }
        public string Importance { get; set; }
        public DateTime DueDate { get; set; }
        public string? Note { get; set; }
        public User UserID { get; set; }
    }
}
