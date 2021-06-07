using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiEventsy.TimetableService.MongoDbModels;

namespace TiEventsy.TimetableService.Requests.UserTimetable
{
    public class GetUserTimetablesRequest
    {
        public ObjectId UserId { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
        public SortDefinition<MongoUserTimetable> Sort { get; set; }
    }
}
