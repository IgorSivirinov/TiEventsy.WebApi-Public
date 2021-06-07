using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;

namespace TiEventsy.ClientBaseLibrary
{
    public static class GrpcChannelService
    {
        public static GrpcChannel GetGrpcChannel(string accessToken, string serviceAddress)
        {
            var credentials = CallCredentials.FromInterceptor((context, metadata) =>
            {
                if (!string.IsNullOrEmpty(accessToken))
                {
                    metadata.Add("Authorization", $"Bearer {accessToken}");
                }
                return Task.CompletedTask;
            });

            return GrpcChannel.ForAddress(serviceAddress, new GrpcChannelOptions
            {
                Credentials = ChannelCredentials.Create(new SslCredentials(), credentials)
            });
        }
    }
}