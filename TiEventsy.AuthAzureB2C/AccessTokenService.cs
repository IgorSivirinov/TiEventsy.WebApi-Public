using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using Grpc.Core;

namespace TiEventsy.AuthAzureB2C
{
    public class AccessTokenService
    {
        public static string GetAccessToken(ServerCallContext context) =>
            context.GetHttpContext().Request.Query["access_token"].ToString();
        
    }
}