using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Todo.Services.Contracts;

namespace Todo.Api.Controllers
{
    [Route("api/todos")]
    public class ToDoController: Controller
    {
        private readonly ITodoService todoService;
        private readonly IMapper mapper;

        public ToDoController(ITodoService todoService, IMapper mapper)
        {
            this.todoService = todoService;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await todoService.GetAsync(id);
            var result = mapper.Map<Models.Todo>(data);
            return Ok(result);
        }
    }
}
