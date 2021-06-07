using MongoDB.Driver;
using TiEventsy.TimetableService.MongoDbModels;

namespace TiEventsy.TimetableService.Requests
{
    public class DeleteManyTimetablePostFilterRequest
    {
        public FilterDefinition<MongoTimetable> Filter { get; set; }
    }
}