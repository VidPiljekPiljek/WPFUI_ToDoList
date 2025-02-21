using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI_ToDoList.DbContexts
{
    public class WPFUI_ToDoListDesignTimeDBContextFactory : IDesignTimeDbContextFactory<WPFUI_ToDoListDBContext>
    {
        public WPFUI_ToDoListDBContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=toDoListApp.db").Options;

            return new WPFUI_ToDoListDBContext(options);
        }
    }
}
