using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TiEventsy.SubscriptionGrpcService.MongoDB.Models
{
    public class MongoUserSubscriptions
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public ObjectId UserId { get; set; }
        public List<ObjectId> TimetableSubscriptions { get; set; }
    }
}