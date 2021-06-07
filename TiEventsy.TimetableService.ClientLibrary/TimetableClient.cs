using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TiEventsy.TimetableService.MongoDbModels;
using TiEventsy.ClientBaseLibrary;
using TiEventsy.TimetableService.Requests;
using TiEventsy.ServiceLinksLibrary;

namespace TiEventsy.TimetableService.ClientLibrary
{
    public class TimetableClient
    {
        private HttpClient Client { get; }
        public TimetableClient(HttpClient httpClient, string accessToken)
        {
            httpClient.AddUriAndAuth(accessToken, ServiceLinks.TimetableServiceLink);
            Client = httpClient;
        }

        public async Task<MongoTimetable> GetTimetableAsync(string id)
        {
           var response = await Client.PostAsJsonAsync("api/Timetable/GetTimetableById", id);
           return await response.Content.ReadFromJsonAsync<MongoTimetable>();
        }


        public async Task<MongoTimetable[]> GetTimetableAsync(GetTimetableGetIdsRequest request)
        {
            var response = await Client.PostAsJsonAsync("api/Timetable/GetTimetableByIds", request);
            return await response.Content.ReadFromJsonAsync<MongoTimetable[]>();
        }

        public async Task<MongoTimetable[]> GetTimetableAsync(GetTimetableGetFilterRequest request)
        {
            var response = await Client.PostAsJsonAsync("api/Timetable/GetTimetableByFilter", request);
            return await response.Content.ReadFromJsonAsync<MongoTimetable[]>();
        }

        public async Task UpdateTimetableAsync(UpdateTimetablePostIdRequest request)
        {
            var response = await Client.PostAsJsonAsync("api​/Timetable​/UpdateTimetableById", request);
        }

        public async Task UpdateTimetableAsync(UpdateTimetablePostIdsRequest request)
        {
            var response = await Client.PostAsJsonAsync("api​/Timetable​/UpdateTimetableByIds", request);
        }

        public async Task UpdateTimetableAsync(UpdateTimetablePostFilterRequest request)
        {
            var response = await Client.PostAsJsonAsync("api​/Timetable​/UpdateTimetableByFilter", request);
        }

        public async Task UpdateTimetableAsync(UpdateManyTimetablePostFilterRequest request)
        {
            var response = await Client.PostAsJsonAsync("api​/Timetable​/UpdateTimetableManyByFilter", request);
        }

        public async Task CreateTimetable(MongoTimetable timetable)
        {
            var response = await Client.PostAsJsonAsync("api/Timetable/CreateTimetableByObject", timetable);
        }

        public async Task CreateTimetableAsync(MongoTimetable[] timetables)
        {
            var response = await Client.PostAsJsonAsync("api/Timetable/CreateTimetableManyByObjects", timetables);
        }

        public async Task DeleteTimetableAsync(string id)
        {
            var response = await Client.PostAsJsonAsync("api/Timetable/DeleteTimetableById", id);
        }

        public async Task DeleteTimetableAsync(string[] ids)
        {
            var response = await Client.PostAsJsonAsync("api/Timetable/DeleteTimetableByIds", ids);
        }

        public async Task DeleteTimetableAsync(DeleteTimetablePostFilterRequest request)
        {
            var response = await Client.PostAsJsonAsync("api/Timetable/DeleteTimetableByFilter", request);
        }

        public async Task DeleteTimetableAsync(DeleteManyTimetablePostFilterRequest request)
        {
            var response = await Client.PostAsJsonAsync("api/Timetable/DeleteTimetableManyByFilter", request);
        }
    }
}
