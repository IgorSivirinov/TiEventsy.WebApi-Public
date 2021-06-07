using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Web;

namespace TiEventsy.AuthAzureB2C
{
    public static class AuthAzureB2CConfiguration
    {
        public static IConfiguration Configuration { get; } =
            new ConfigurationBuilder().AddJsonFile("conf_azureb2c.json").Build();
        public static IServiceCollection AddConfigureAuth(this IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAdB2C"));
            return services;
        }
    }
}
