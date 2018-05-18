using Microsoft.EntityFrameworkCore;
using ToDo.Database.Models;

namespace ToDo.Database
{
    public class ToDoContext: DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options): base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
