using MongoDB.Driver;
using TiEventsy.TimetableService.MongoDbModels;

namespace TiEventsy.TimetableService.Requests
{
    public class GetTimetableGetIdsRequest
    {
        public string[] Ids { get; set; }
        public SortDefinition<MongoTimetable> Sort { get; set; }
    }
}