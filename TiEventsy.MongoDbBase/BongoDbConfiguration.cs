using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace TiEventsy.MongoDbBase
{
    public static class BongoDbConfiguration
    {
        public static IConfiguration Configuration { get; } =
            new ConfigurationBuilder().AddJsonFile("conf_mongodb.json").Build();
        public static IServiceCollection AddBaseSingletonMongoClient(this IServiceCollection services)
        {
            services.AddSingleton<IMongoClient, MongoClient>(sp => 
                new MongoClient(Configuration.GetConnectionString("MongoDbDebug")));
            return services;
        }
    }
}
