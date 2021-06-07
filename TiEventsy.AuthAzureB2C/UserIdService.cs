using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using Grpc.Core;

namespace TiEventsy.AuthAzureB2C
{
    public static class UserIdService
    {
        public static string GetUserId(ServerCallContext context)
        {
            var accessToken = context.GetHttpContext().Request.Query["access_token"].ToString();
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(accessToken);
            return token.Claims.First(claim => claim.Type == "sub").Value;
        }
    }
}