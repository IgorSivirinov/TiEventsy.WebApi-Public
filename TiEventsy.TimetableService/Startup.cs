using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MongoDB.Driver;
using TiEventsy.AuthAzureB2C;

namespace TiEventsy.TimetableService
{
    public class Startup
    {
        private static MongoClient MongoDbClient { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            MongoDbClient = new MongoClient(Configuration.GetConnectionString("MongoDB"));
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddConfigureAuth();
            services.AddSingleton<IMongoClient, MongoClient>(sp => MongoDbClient);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TiEventsy.TimetableService", Version = "v1" });

                var filePath = Path.Combine(AppContext.BaseDirectory, "TiEventsy.TimetableService.xml");                
                c.IncludeXmlComments(filePath); 
            });

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TiEventsy.TimetableService v1"));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
