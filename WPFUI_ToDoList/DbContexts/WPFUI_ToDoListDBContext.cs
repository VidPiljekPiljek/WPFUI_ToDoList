using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WPFUI_ToDoList.DTOS;
using WPFUI_ToDoList.Models;

namespace WPFUI_ToDoList.DbContexts
{
    public class WPFUI_ToDoListDBContext : DbContext
    {
        public WPFUI_ToDoListDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserDTO> Users { get; set; }
        public DbSet<ToDoTaskDTO> Tasks { get; set; }
    }
}
