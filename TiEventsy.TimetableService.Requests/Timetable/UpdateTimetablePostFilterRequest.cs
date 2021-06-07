using MongoDB.Driver;
using TiEventsy.TimetableService.MongoDbModels;

namespace TiEventsy.TimetableService.Requests
{
    public class UpdateTimetablePostFilterRequest
    {
        public FilterDefinition<MongoTimetable> Filter { get; set; }
        public UpdateDefinition<MongoTimetable> Update { get; set; }
    }
}