using AutoMapper;
using System.Threading.Tasks;
using Todo.Api.Exceptions;
using Todo.Repositories.Contracts;
using Todo.Services.Contracts;

namespace Todo.Services.Implementations
{
    public class TodoService: ITodoService
    {
        private readonly ITodoRepository todoRepo;
        private readonly IMapper mapper;

        public TodoService(ITodoRepository todoRepo, IMapper mapper)
        {
            this.todoRepo = todoRepo;
            this.mapper = mapper;
        }

        public async Task<Models.Todo> GetAsync(int id)
        {
            var data = await todoRepo.GetAsync(id);

            if (data == null)
            {
                throw new RecordNotFoundException();
            }

            var result = mapper.Map<Models.Todo>(data);
            return result;
        }
    }
}
