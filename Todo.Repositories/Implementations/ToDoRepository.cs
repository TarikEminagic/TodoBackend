using System.Threading.Tasks;
using Todo.Db.Context;
using Todo.Repositories.Contracts;

namespace Todo.Repositories.Implementations
{
    public class ToDoRepository: ITodoRepository
    {
        private readonly TodoContext context;

        public ToDoRepository(TodoContext context)
        {
            this.context = context;
        }

        public async Task<Db.Models.Todo> GetAsync(int id)
        {
            var result = await context.Todos.FindAsync(id);
            return result;
        }
    }
}
