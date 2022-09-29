using Trello.Application.Handlers.CommandHandlers;
using Trello.Core.Repositories;
using Trello.Core.Repositories.Base;
using Trello.Infrastructure.Data;
using Trello.Infrastructure.Repositories;
using Trello.Infrastructure.Repositories.Base;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Employee.API
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

            services.AddControllers();
            services.AddDbContext<TrelloContext>(
                 m => m.UseSqlServer(Configuration.GetConnectionString("TrelloDB")), ServiceLifetime.Singleton);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Trello.API", Version = "v1" });
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(typeof(CreateBoardHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(CreateLabelHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(CreateColumnHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(CreateCardHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(CreateUserHandler).GetTypeInfo().Assembly);

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICardRepository, CardRepository>();
            services.AddTransient<IBoardRepository, BoardRepository>();
            services.AddTransient<ILabelRepository, LabelRepository>();
            services.AddTransient<IColumnRepository, ColumnRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Trello.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
