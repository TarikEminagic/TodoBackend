using AutoMapper;
using db = Todo.Db.Models;
using service = Todo.Services.Models;
using api = Todo.Api.Models;

namespace Todo.Mapper.Configurations
{
    public class TodoProfile: Profile
    {
        public TodoProfile()
        {
            CreateMap<db.Todo, service.Todo>().ReverseMap();
            CreateMap<service.Todo, api.Todo>().ReverseMap();
        }
    }
}
