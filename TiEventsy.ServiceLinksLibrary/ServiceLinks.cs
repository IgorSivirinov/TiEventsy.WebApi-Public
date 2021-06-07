using Microsoft.Extensions.Configuration;

namespace TiEventsy.ServiceLinksLibrary
{
    public static class ServiceLinks
    {
        private static string LinksType { get; } = "localhost";
        private static IConfiguration Configuration { get; } = 
            new ConfigurationBuilder().AddJsonFile("service_links.json").Build().GetSection(LinksType);

        public static string TimetableServiceLink => Configuration["timetable"];
        public static string UserServiceLink => Configuration["user"];
        public static string SubscriptionServiceLink => Configuration["subscription"];
    }
}
