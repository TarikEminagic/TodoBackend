using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Todo.Api.Helpers
{
    public static class Swashbuckle
    {
        public static void AddSwashbuckle(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("TodoApi", new Info { Version = "v1", Title = "Todo API" });
            });
        }

        public static void UseSwashbuckle(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/TodoApi/swagger.json", "TODO API");
            });
        }
    }
}
