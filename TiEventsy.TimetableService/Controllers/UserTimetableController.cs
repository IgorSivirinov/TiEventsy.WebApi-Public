using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MongoDB.Driver;
using TiEventsy.TimetableService.MongoDbModels;
using TiEventsy.TimetableService.Requests.UserTimetable;

namespace TiEventsy.TimetableService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class UserTimetableController : ControllerBase
    {
        private IMongoCollection<MongoUserTimetable> MongoCollection { get; }

        public UserTimetableController(MongoClient client)
        {
            MongoCollection = client.GetDatabase("TiEventsy").GetCollection<MongoUserTimetable>("UserTimetable");
        }

        [HttpPost]
        public async Task NewUserTimetable()
        {
            var id = await HttpContext.GetTokenAsync("access_token");
            await MongoCollection.InsertOneAsync(new()
            {
                Id = new(id),
                UserId = new(id),
                UserTimetables = new()
            });
        }

        [HttpDelete]
        public async Task DeleteUserTimetable()
        {
            var id = await HttpContext.GetTokenAsync("access_token");
            await MongoCollection.DeleteOneAsync(usTi => usTi.UserId.ToString() == id);
        }

        [HttpPost]
        public async Task<ActionResult<MongoUserTimetable[]>> GetUserTimetables(GetUserTimetablesRequest request)
        {
            var mongoUserTimetables = await MongoCollection.Find(usTi => usTi.UserId.ToString() == request.UserId.ToString()).Sort(request.Sort)
                .Skip(request.Skip).Limit(request.Limit)
                .ToListAsync();

            return mongoUserTimetables.ToArray();
        }
    }
}
