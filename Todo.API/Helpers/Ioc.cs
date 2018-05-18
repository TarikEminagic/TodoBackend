using Microsoft.Extensions.DependencyInjection;
using Todo.Repositories.Contracts;
using Todo.Repositories.Implementations;
using Todo.Services.Contracts;
using Todo.Services.Implementations;

namespace Todo.Api.Helpers
{
    public static class Ioc
    {
        public static void AddIocContainer(this IServiceCollection services)
        {
            services.AddScoped<ITodoRepository, ToDoRepository>();

            services.AddScoped<ITodoService, TodoService>();
        }
    }
}
