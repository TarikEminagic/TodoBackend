using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDo.Database.Contracts;
using ToDo.Database.Models;

namespace ToDo.Database.Repositories
{
    public class TodoRepository: IRepository<Todo, int>
    {
        private readonly ToDoContext context;

        public TodoRepository(ToDoContext context)
        {
            this.context = context;
        }

        public async Task<Todo> Create(Todo data)
        {
            context.Todos.Add(data);
            return data;
        }

        public async Task<bool> Delete(Todo data)
        {
            await context.Todos.Remove(data);
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Todo> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Todo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Todo> Update(Todo data)
        {
            throw new NotImplementedException();
        }
    }
}
