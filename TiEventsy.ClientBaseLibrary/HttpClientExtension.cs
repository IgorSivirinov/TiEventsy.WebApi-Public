using System.Net.Http;

namespace TiEventsy.ClientBaseLibrary
{
    public static class HttpClientExtension
    {
        public static HttpClient AddUriAndAuth(this HttpClient httpClient, string accessToken, string baseServiceAddress)
        {
            httpClient.BaseAddress = new(baseServiceAddress);
            httpClient.DefaultRequestHeaders.Authorization = new (accessToken);
            return httpClient;
        }
    }
}