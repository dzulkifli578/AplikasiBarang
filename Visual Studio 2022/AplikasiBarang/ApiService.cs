using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace AplikasiBarang
{
    public class ApiService
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public ApiService()
        {
            httpClient.BaseAddress = new Uri("http://127.0.0.1:8000");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<string> PostDataToApi(string endpoint, object json)
        {
            var content = JsonContent.Create(json);
            HttpResponseMessage response = await httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> GetDataToApi(string endpoint)
        {
            HttpResponseMessage response = await httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> PutDataToApi(string endpoint, object json)
        {
            var content = JsonContent.Create(json);
            HttpResponseMessage response = await httpClient.PutAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteDataToApi(string endpoint)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
