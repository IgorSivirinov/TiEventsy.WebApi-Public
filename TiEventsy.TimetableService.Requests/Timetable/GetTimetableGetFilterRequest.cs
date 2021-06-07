using MongoDB.Driver;
using TiEventsy.TimetableService.MongoDbModels;

namespace TiEventsy.TimetableService.Requests
{
    public class GetTimetableGetFilterRequest
    {
        public FilterDefinition<MongoTimetable> Filter { get; set; }
        public SortDefinition<MongoTimetable> Sort { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }
}