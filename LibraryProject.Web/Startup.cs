using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Model;
using LibraryProject.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using LibraryProject.Service;

namespace LibraryProject.Web
{
    public class Startup
    {
        private readonly string _allowOrigins = "_allowOrigins";
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(
                options =>
                {
                    options.AddPolicy(_allowOrigins, builder =>
                    {
                        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowedToAllowWildcardSubdomains();
                    });
                }
                );
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddDbContext<BookContext>();
            
            services.AddControllers();

            services.AddTransientService();

            services.AddAutoMapper();



            
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(_allowOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
