using Bot.Messenger.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Tools
{
    public class RequestHandler
    {
        public static async Task<T> GetAsync<T>(string requestUrl)
            where T : WebResponse, new()
        {
            using (HttpClient client = new HttpClient())
            {
                SetDefaultHeaders(client);

                HttpResponseMessage response = await client.GetAsync(requestUrl);

                return await ProcessResult<T>(response);
            }
        }

        public static async Task<T> PostAsync<T>(JObject json, string requestUrl)
            where T : WebResponse, new ()
        {
            using (HttpClient client = new HttpClient())
            {
                SetDefaultHeaders(client);

                string requestBody = json.ToString();

                HttpResponseMessage response = await client.PostAsync(requestUrl,
                    new StringContent(requestBody, Encoding.UTF8, "application/json"));

                return await ProcessResult<T>(response, requestBody);
            }
        }

        public static async Task<T> DeleteAsync<T>(string requestUrl)
            where T : WebResponse, new()
        {
            using (HttpClient client = new HttpClient())
            {
                SetDefaultHeaders(client);

                HttpResponseMessage response = await client.DeleteAsync(requestUrl);

                return await ProcessResult<T>(response);
            }
        }

        public static async Task<T> DeleteAsync<T>(JObject json, string requestUrl)
            where T : WebResponse, new()
        {
            using (HttpClient client = new HttpClient())
            {
                SetDefaultHeaders(client);

                string requestBody = json.ToString();

                HttpResponseMessage response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Delete, requestUrl)
                { Content = new StringContent(requestBody, Encoding.UTF8, "application/json") });

                return await ProcessResult<T>(response, requestBody);
            }
        }

        private static void SetDefaultHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private static async Task<T> ProcessResult<T>(HttpResponseMessage httpResponse, string requestBody = null)
            where T : WebResponse, new()
        {
            T webResponse = new T();

            if (httpResponse != null && httpResponse.Content != null)
            {
                string responseJsonString = await httpResponse.Content.ReadAsStringAsync();

                if (httpResponse.IsSuccessStatusCode)
                {
                    webResponse = JsonConvert.DeserializeObject<T>(responseJsonString);
                    webResponse.IsSuccessful = true;
                }
                else
                {
                    webResponse.ErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseJsonString);
                    webResponse.IsSuccessful = false;
                }

                webResponse.HttpRequest = httpResponse.RequestMessage?.ToString() + "\nRequest Body: " + requestBody;
                webResponse.HttpResponse = httpResponse.ToString() + "\nResponse Content: " + responseJsonString;
            }

            return webResponse;
        }
    }
}
