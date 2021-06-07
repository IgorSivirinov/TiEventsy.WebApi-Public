using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TiEventsy.TimetableService.MongoDbModels
{
    public class MongoUserTimetable
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public ObjectId UserId { get; set; }
        public List<ObjectId> UserTimetables { get; set; }
    }
}