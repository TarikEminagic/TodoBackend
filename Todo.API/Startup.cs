using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Todo.Api.Helpers;
using Todo.Db.Context;

namespace Todo.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMvc( cfg => {
                cfg.Filters.Add(typeof(AppExceptionFilter));
            });
            services.AddIocContainer();
            services.AddDbContext<TodoContext>(o =>
            {
                o.UseSqlServer(Configuration.GetConnectionString("Todo"));
            });
            services.AddSwashbuckle();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }

            app.UseSwashbuckle();

            app.UseMvc();
        }
    }
}
