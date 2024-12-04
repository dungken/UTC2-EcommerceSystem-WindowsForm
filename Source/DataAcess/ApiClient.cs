using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Source.Views.Custommer;
namespace Source.DataAcess
{
    public class ApiClient
    {
        private readonly RestClient _client;

        public ApiClient(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);
            var response = await _client.ExecuteAsync<T>(request);
            if (!response.IsSuccessful)
            {
                // Format JSON response
                var formattedJson = FormatJson(response.Content);
                MessageBox.Show(response.StatusCode.ToString() + "\n" + formattedJson);

                throw new Exception($"API Error: {response.ErrorMessage}");
            }
            return response.Data;
        }

        public async Task<T> PostAsync<T>(string endpoint, object body = null)
        {
            var request = new RestRequest(endpoint, Method.Post);
            if(body != null)
            {
                request.AddJsonBody(body);
            }
            var response = await _client.ExecuteAsync<T>(request);
            if (!response.IsSuccessful)
            {
                // Format JSON response
                if(response.Content != null)
                {
                    var formattedJson = FormatJson(response.Content);
                    MessageBox.Show(response.StatusCode.ToString() + "\n" + formattedJson);
                }
                else
                {
                    MessageBox.Show(response.StatusCode.ToString());
                }
                throw new Exception($"API Errorr: {response.ErrorMessage}");

            }
            return response.Data;
        }
       
    
        public async Task<T> PutAsync<T>(string endpoint, object body)
        {
            var request = new RestRequest(endpoint, Method.Put);
            request.AddJsonBody(body);
            var response = await _client.ExecuteAsync<T>(request);
            if (!response.IsSuccessful)
            {
                // Format JSON response
                var formattedJson = FormatJson(response.Content);
                MessageBox.Show(response.StatusCode.ToString() + "\n" + formattedJson);
                throw new Exception($"API Error: {response.ErrorMessage}");
            }
            return response.Data;
        }

        public async Task<bool> DeleteAsync(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Delete);
            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                // Format JSON response
                var formattedJson = FormatJson(response.Content);
                MessageBox.Show(response.StatusCode.ToString() + "\n" + formattedJson);
                throw new Exception($"API Error: {response.ErrorMessage}");
            }
            return true;
        }

        public async Task<T> PatchAsync<T>(string endpoint, object body)
        {
            var request = new RestRequest(endpoint, Method.Patch);
            request.AddJsonBody(body);
            var response = await _client.ExecuteAsync<T>(request);
            if (!response.IsSuccessful)
            {
                // Format JSON response
                var formattedJson = FormatJson(response.Content);
                MessageBox.Show(response.StatusCode.ToString() + "\n" + formattedJson);
                throw new Exception($"API Error: {response.ErrorMessage}");
            }
            return response.Data;
        }
        private string FormatJson(string json)
        {
            try
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                return JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }
            catch
            {
                return json; // Trả về JSON gốc nếu không thể định dạng
            }
        }

    }
}
