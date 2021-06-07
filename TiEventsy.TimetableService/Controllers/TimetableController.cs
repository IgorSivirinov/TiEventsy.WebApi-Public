using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using TiEventsy.TimetableService.MongoDbModels;
using TiEventsy.TimetableService.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TiEventsy.TimetableService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TimetableController : ControllerBase {
        private IMongoCollection<MongoTimetable> MongoTimetableCollection { get; }
        private IMongoCollection<MongoUserTimetable> MongoUserTimetableCollection { get; }

        public TimetableController(MongoClient client) 
        {
            MongoTimetableCollection = client.GetDatabase("TiEventsy").GetCollection<MongoTimetable>("Timetable");
            MongoUserTimetableCollection = client.GetDatabase("TiEventsy").GetCollection<MongoUserTimetable>("UserTimetable");
        }

        /// <summary>
        /// Get a timetable using Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A timetable (Document MongoDB) </returns>
        [HttpPost]
        public async Task<ActionResult<MongoTimetable>> GetTimetableById([FromBody] string id)
        {
            var result = await MongoTimetableCollection
                .Find(t => t.Id.ToString() == id)
                .FirstAsync();

            return result;
        }

        /// <summary>
        /// Get Timetables by ids and sorting
        /// </summary>
        /// <param name="request">
        /// </param>
        /// <returns>Sorted timetables (Document MongoDB) </returns>
        [HttpPost]
        public async Task<ActionResult<MongoTimetable[]>> GetTimetableByIds([FromBody] GetTimetableGetIdsRequest request)
        {
            var mongoResult = await MongoTimetableCollection
                .Find(t =>
                    request.Ids.Where(id => id == t.Id.ToString()).ToArray().Length != 0)
                .Sort(request.Sort)
                .ToListAsync();

            return mongoResult.Count == 0 ? null : mongoResult.ToArray();
        }

        /// <summary>
        /// Get Timetables by filter and sorting
        /// </summary>
        /// <param name="request">
        /// </param>
        /// <returns>Sorted timetables (Document MongoDB) </returns>
        [HttpPost]
        public async Task<ActionResult<MongoTimetable[]>> GetTimetableByFilter([FromBody] GetTimetableGetFilterRequest request)
        {
            var mongoResult = await MongoTimetableCollection
                .Find(request.Filter)
                .Sort(request.Sort)
                .Skip(request.Skip)
                .Limit(request.Limit)
                .ToListAsync();

            return mongoResult.Count == 0 ? null : mongoResult.ToArray();
        }

        /// <summary>
        /// Update a timetable by id and MongoDB update
        /// </summary>
        /// <param name="request"></param>
        [HttpPost]
        public async Task UpdateTimetableById([FromBody] UpdateTimetablePostIdRequest request) =>
            await MongoTimetableCollection.UpdateOneAsync(
                ti => ti.Id.ToString() == request.Id,
                request.Update);

        /// <summary>
        /// Update timetables by ids and MongoDB update
        /// </summary>
        /// <param name="request"></param>
        [HttpPost]
        public async Task UpdateTimetableByIds([FromBody] UpdateTimetablePostIdsRequest request) =>
            await MongoTimetableCollection.UpdateOneAsync(t =>
                    request.Ids.Where(id => id == t.Id.ToString()).ToArray().Length != 0,
                    request.Update);

        /// <summary>
        /// Update a timetable by MongoDB filter and MongoDB update
        /// </summary>
        /// <param name="request"></param>
        [HttpPost]
        public async Task UpdateTimetableByFilter([FromBody] UpdateTimetablePostFilterRequest request) =>
            await MongoTimetableCollection.UpdateOneAsync(request.Filter, request.Update);

        /// <summary>
        /// Update timetables by MongoDB filter and MongoDB update
        /// </summary>
        /// <param name="request"></param>
        [HttpPost]
        public async Task UpdateTimetableManyByFilter([FromBody] UpdateManyTimetablePostFilterRequest request) =>
            await MongoTimetableCollection.UpdateManyAsync(request.Filter, request.Update);


        /// <summary>
        /// Create a timetable by MongoTimetable object
        /// </summary>
        /// <param name="timetable"></param>
        [HttpPost]
        public async Task CreateTimetableByObject([FromBody] MongoTimetable timetable)
        {
            await MongoTimetableCollection.InsertOneAsync(timetable);
            await MongoUserTimetableCollection.AsQueryable()
                .Where(usTi => usTi.UserId == timetable.CreatorId)
                .ForEachAsync(usTi => usTi.UserTimetables.Add(timetable.Id));
        }
            

        /// <summary>
        /// Create timetables by MongoTimetable objects
        /// </summary>
        /// <param name="timetables"></param>
        [HttpPost]
        public async Task CreateTimetableManyByObjects([FromBody] MongoTimetable[] timetables)
        {
            await MongoTimetableCollection.InsertManyAsync(timetables);

            await MongoUserTimetableCollection.AsQueryable()
                .Where(usTi => timetables.Any(ti=> ti.CreatorId == usTi.UserId))
                .ForEachAsync(usTi => usTi.UserTimetables.AddRange(timetables.Select(ti  => ti.CreatorId)));
        }

        /// <summary>
        /// Delete a timetable by id
        /// </summary>
        /// <param name="id"></param>
        [HttpPost]
        public async Task DeleteTimetableById([FromBody] string id) =>
            await MongoTimetableCollection.DeleteOneAsync(t => t.Id.ToString() == id);

        /// <summary>
        /// Delete timetables by ids
        /// </summary>
        /// <param name="ids"></param>
        [HttpPost]
        public async Task DeleteTimetableByIds([FromBody] string[] ids) =>
            await MongoTimetableCollection.DeleteManyAsync(t =>
                ids.Where(id => id == t.Id.ToString()).ToArray().Length != 0);

        /// <summary>
        /// Delete timetable by MongoDB filter
        /// </summary>
        /// <param name="request"></param>
        [HttpPost]
        public async Task DeleteTimetableByFilter([FromBody] DeleteTimetablePostFilterRequest request) =>
            await MongoTimetableCollection.DeleteOneAsync(request.Filter);
    }
}
