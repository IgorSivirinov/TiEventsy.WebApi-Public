using MongoDB.Driver;
using TiEventsy.TimetableService.MongoDbModels;

namespace TiEventsy.TimetableService.Requests
{
    public class UpdateTimetablePostIdRequest
    {
        public string Id { get; set; }
        public UpdateDefinition<MongoTimetable> Update { get; set; }
    }
}