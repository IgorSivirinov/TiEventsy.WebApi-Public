using MongoDB.Driver;
using TiEventsy.TimetableService.MongoDbModels;

namespace TiEventsy.TimetableService.Requests
{
    public class UpdateTimetablePostIdsRequest
    {
        public string[] Ids { get; set; }
        public UpdateDefinition<MongoTimetable> Update { get; set; }
    }
}