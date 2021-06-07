using MongoDB.Driver;
using TiEventsy.TimetableService.MongoDbModels;

namespace TiEventsy.TimetableService.Requests
{
    public class DeleteTimetablePostFilterRequest
    {
        public FilterDefinition<MongoTimetable> Filter { get; set; }
    }
}