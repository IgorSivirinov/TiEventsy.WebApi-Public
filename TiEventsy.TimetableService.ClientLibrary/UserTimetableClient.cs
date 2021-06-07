using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TiEventsy.ClientBaseLibrary;
using TiEventsy.TimetableService.MongoDbModels;
using TiEventsy.TimetableService.Requests.UserTimetable;
using TiEventsy.ServiceLinksLibrary;

namespace TiEventsy.TimetableService.ClientLibrary
{
    public class UserTimetableClient
    {
        private HttpClient Client { get; }
        public UserTimetableClient(HttpClient httpClient, string accessToken)
        {
            httpClient.AddUriAndAuth(accessToken, ServiceLinks.TimetableServiceLink);
            Client = httpClient;
        }

        public async Task NewUserTimetableAsync()
        {
            await Client.PostAsync("api/Timetable/NewUserTimetable", null);
        }

        public async Task DeleteUserTimetableAsync()
        {
            await Client.PostAsync("api/Timetable/DeleteUserTimetable", null);
        }

        public async Task<MongoUserTimetable> GetUserTimetablesAsync(GetUserTimetablesRequest request)
        {
            var response = await Client.PostAsJsonAsync("api/Timetable/GetUserTimetables", request);
            return await response.Content.ReadFromJsonAsync<MongoUserTimetable>();
        }
    }
}
