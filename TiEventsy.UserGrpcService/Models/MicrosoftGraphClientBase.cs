using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using TiEventsy.AuthAzureB2C;

namespace TiEventsy.UserGrpcService.Models
{
    public class MicrosoftGraphClientBase
    {
        public MicrosoftGraphClientBase()
        {
            var config = AuthAzureB2CConfiguration.Configuration;
            var confidentialClientApplication = ConfidentialClientApplicationBuilder
                .Create(config["ClientId"])
                .WithTenantId(config["Domain"])
                .WithClientSecret(config["ClientSecret"])
                .Build();
            var authProvider = new ClientCredentialProvider(confidentialClientApplication);

            // Set up the Microsoft Graph service client with client credentials
            GraphClient = new GraphServiceClient(authProvider);
        }

        public GraphServiceClient GraphClient { get; }
    }
}