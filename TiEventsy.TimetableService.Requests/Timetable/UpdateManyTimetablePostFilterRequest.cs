using MongoDB.Driver;
using TiEventsy.TimetableService.MongoDbModels;

namespace TiEventsy.TimetableService.Requests
{
    public class UpdateManyTimetablePostFilterRequest
    {
        public FilterDefinition<MongoTimetable> Filter { get; set; }
        public UpdateDefinition<MongoTimetable> Update { get; set; }
    }
}