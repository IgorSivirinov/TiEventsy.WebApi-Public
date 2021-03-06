using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using TiEventsy.TimetableService.MongoDB.Models.Timetable.ModelTimetableDay;

namespace TiEventsy.TimetableService.MongoDB.Models.Timetable 
{
    public class MongoTimetable
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public ObjectId CreatorId { get; set; }

        public string Name { get; set; }
        
        public Uri UriImage { get; set; }

        public List<MongoTimetableDay> TimetableDays { get; set; }
        public List<ObjectId> cIds { get; set; }
    }
}