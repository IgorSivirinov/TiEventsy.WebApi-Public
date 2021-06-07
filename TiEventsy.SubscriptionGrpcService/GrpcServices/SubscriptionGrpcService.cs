using System;
using System.Collections.Generic;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
using TiEventsy.AuthAzureB2C;
using TiEventsy.SubscriptionGrpcService.MongoDB.Models;
using TiEventsy.SubscriptionGrpcService.Requests.Protos;

namespace TiEventsy.SubscriptionGrpcService.GrpcServices
{
    [Authorize]
    public class SubscriptionGrpcService: SubscriptionOperations.SubscriptionOperationsBase
    {
        private IMongoCollection<MongoUserSubscriptions> MongoUserSubscriptionsCollection { get; } 
        public SubscriptionGrpcService(MongoClient client)
        {
            MongoUserSubscriptionsCollection = client
                .GetDatabase("TiEventsy")
                .GetCollection<MongoUserSubscriptions>("UserSubscriptions");
        }

        public override async Task<Empty> NewUserSubscriptions(Empty request, ServerCallContext context)
        {
            var id = UserIdService.GetUserId(context);

            if (!await MongoUserSubscriptionsCollection
                .Find(acSub => acSub.Id.ToString() == id).AnyAsync())
                await MongoUserSubscriptionsCollection.InsertOneAsync(new MongoUserSubscriptions
                {
                    Id = new ObjectId(id),
                    UserId = new ObjectId(id),
                    TimetableSubscriptions = new()
                });
            else throw new Exception("The Bible already exists");

            return new();
        }

        public override async Task<Empty> DeleteUserSubscriptions(Empty request, ServerCallContext context)
        {
            var id = UserIdService.GetUserId(context);
            await MongoUserSubscriptionsCollection.DeleteOneAsync(usSu => usSu.UserId.ToString() == id);
            return new();
        }

        public override async Task<UserId> GetUserId(SubId request, ServerCallContext context)
        {
            var accountSub = await MongoUserSubscriptionsCollection.Find(acSub =>
                acSub.TimetableSubscriptions.Any(sub => sub.ToString() == request.Id)).FirstAsync()
                ?? throw new Exception("The account doesn’t exist");

            return new UserId
            {
                Id = accountSub.UserId.ToString()
            };
        }

        public override async Task<ListSubId> GetUserSubscriptions(UserId request, ServerCallContext context)
        {
            var accountSub = await MongoUserSubscriptionsCollection.Find(acSub=> 
                    acSub.UserId.ToString() == request.Id).FirstAsync()
                ?? throw new Exception("The account doesn’t exist");

            var subIds = new ListSubId();
            subIds.Ids.AddRange(accountSub.TimetableSubscriptions.Select(id => id.ToString()).ToList());

            return subIds;
        }

        public override async Task<Empty> NewSubscription(SubId request, ServerCallContext context)
        {
            var id = UserIdService.GetUserId(context);

            var accountSub = await MongoUserSubscriptionsCollection.Find(acSub => 
                                 acSub.UserId.ToString() == id).FirstAsync() 
                             ?? throw new Exception("The account doesn’t exist");
            await MongoUserSubscriptionsCollection.UpdateOneAsync(accSub =>
                        accSub.UserId.ToString() == accountSub.UserId.ToString(),
                    Builders<MongoUserSubscriptions>.Update.AddToSet(accSub =>
                        accSub.TimetableSubscriptions, new ObjectId(request.Id)));                 
            return new ();
        }

        public override async Task<Empty> DeleteSubscription(SubId request, ServerCallContext context)
        {
            var id = UserIdService.GetUserId(context);

            var accountSub = await MongoUserSubscriptionsCollection.Find(acSub =>
                                 acSub.UserId.ToString() == id).FirstAsync()
                             ?? throw new Exception("The account doesn’t exist");
            await MongoUserSubscriptionsCollection.UpdateOneAsync(accSub =>
                    accSub.UserId.ToString() == accountSub.UserId.ToString(),
                Builders<MongoUserSubscriptions>.Update.Pull(accSub =>
                    accSub.TimetableSubscriptions, new ObjectId(request.Id)));
            return new();
        }

    }
}