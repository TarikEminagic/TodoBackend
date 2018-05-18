using Microsoft.EntityFrameworkCore;
using db = Todo.Db.Models;

namespace Todo.Db.Context
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        { }

        public DbSet<db.Todo> Todos { get; set; }
    }
}
