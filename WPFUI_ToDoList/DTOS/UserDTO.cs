using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI_ToDoList.DTOS
{
    public class UserDTO
    {
        [Key]
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
