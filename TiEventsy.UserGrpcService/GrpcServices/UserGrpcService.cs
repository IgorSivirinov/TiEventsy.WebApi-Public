using System.Net.Http;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Graph;
using TiEventsy.AuthAzureB2C;
using TiEventsy.SubscriptionGrpcService.ClientLibrary;
using TiEventsy.TimetableService.ClientLibrary;
using TiEventsy.UserGrpcService.Models;
using TiEventsy.UserGrpcService.Requests.Protos;

namespace TiEventsy.UserGrpcService.GrpcServices
{
    [Authorize]
    public class UserGrpcService : UserOperations.UserOperationsBase

    {
        private GraphServiceClient GraphClient { get; }
        private HttpClient RestClient { get; }

        public UserGrpcService(HttpClient client)
        {
            GraphClient = new MicrosoftGraphClientBase().GraphClient;
            RestClient = client;
        }
        
        public override async Task<Empty> NewUser(Empty request, ServerCallContext context)
        {
            var jwt = AccessTokenService.GetAccessToken(context);

            var subClient = new SubscriptionClient(jwt);
            var usTiClient = new UserTimetableClient(RestClient, jwt);

            await subClient.NewUserSubscriptionsAsync();
            await usTiClient.NewUserTimetableAsync();

            return new();
        }

        public override async Task<Empty> DeleteUser(Empty request, ServerCallContext context)
        {
            var jwt = AccessTokenService.GetAccessToken(context);

            var subClient = new SubscriptionClient(jwt);
            var usTiClient = new UserTimetableClient(RestClient, jwt);

            await subClient.DeleteUserSubscriptionsAsync();
            await usTiClient.DeleteUserTimetableAsync();

            return new();
        }

        public override async Task<PublicUserData> GetPublicUserDate(UserId request, ServerCallContext context)
        {
            var id = UserIdService.GetUserId(context);
            var jwt = AccessTokenService.GetAccessToken(context);

            var account = GraphClient.Users[request.Id].Request().Select(user => new
            {
                user.DisplayName
            }).GetAsync();

            var subClient = new SubscriptionClient(jwt);
            var userSubscriptions = await subClient.GetUserSubscriptionsAsync(id);

            var publicData = new PublicUserData
            {
                Name = account.Result.DisplayName,
                UriImage = "", //TODO: Разобраться как работать с Photo
            };
            publicData.MyTimetableIds.AddRange(userSubscriptions);

            return publicData;
        }

        public override Task<PrivateUserData> GetPrivateUserDate(Empty request, ServerCallContext context)
        {
            return base.GetPrivateUserDate(request, context);
        }

    }
}