using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TiEventsy.ClientBaseLibrary;
using TiEventsy.ServiceLinksLibrary;
using TiEventsy.SubscriptionGrpcService.Requests.Protos;

namespace TiEventsy.SubscriptionGrpcService.ClientLibrary
{
    public class SubscriptionClient
    {
        private SubscriptionOperations.SubscriptionOperationsClient Client { get; }

        public SubscriptionClient(string accessToken)
        {
            var channel = GrpcChannelService.GetGrpcChannel(accessToken, ServiceLinks.TimetableServiceLink);
            Client = new SubscriptionOperations.SubscriptionOperationsClient(channel);
        }

        public async Task NewUserSubscriptionsAsync()
        {
            await Client.NewUserSubscriptionsAsync(new ());
        } 
        
        public void NewUserSubscriptions()
        {
            Client.NewUserSubscriptions(new ());
        }

        public async Task DeleteUserSubscriptionsAsync()
        {
            await Client.DeleteUserSubscriptionsAsync(new());
        }

        public void DeleteUserSubscriptions()
        {
            Client.DeleteUserSubscriptions(new());
        }

        public async Task<List<string>> GetUserSubscriptionsAsync(string id)
        {
            var listSubId = await Client
                .GetUserSubscriptionsAsync(new UserId { Id = id});

            return new(listSubId.Ids);
        }
            
        

        public List<string> GetUserSubscriptions(string id)
        {
            var listSubId = Client
                .GetUserSubscriptions(new UserId { Id = id });

            return new(listSubId.Ids);
        }

        public async Task NewSubscriptionAsync(string timetableId)
        {
            await Client.NewSubscriptionAsync(new()
            {
                Id = timetableId
            });
        }
        public void NewSubscription(string timetableId)
        {
            Client.NewSubscription(new()
            {
                Id = timetableId
            });
        }

        public async Task DeleteSubscriptionAsync(string timetableId)
        {
            await Client.DeleteSubscriptionAsync(new()
            {
                Id = timetableId
            });
        }

        public void DeleteSubscription(string timetableId)
        {
            Client.DeleteSubscription(new()
            {
                Id = timetableId
            });
        }
    }
}
