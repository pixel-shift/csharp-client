using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Pixelshift.Oauth2
{
    public class ClientCredentialsProvider : IDisposable
    {
        private readonly string baseUrl;
        private readonly HttpClient client;
        private readonly string clientId;
        private readonly string clientSecret;

        public ClientCredentialsProvider(string baseUrl, string clientId, string clientSecret)
        {
            this.baseUrl = baseUrl;
            client = new HttpClient() {BaseAddress = new Uri(baseUrl)};
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            Console.WriteLine("fetching token");

            var paramDic = new Dictionary<string, string> {{"grant_type", "client_credentials"}};
            var byteArray = Encoding.ASCII.GetBytes($"{clientId}:{clientSecret}");
            var base64String = Convert.ToBase64String(byteArray);
            JObject jobj;

            using (var req = new HttpRequestMessage(HttpMethod.Post, "/connect/token"))
            {
                req.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64String);

                req.Content = new FormUrlEncodedContent(paramDic);
                req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                req.Headers.Accept.Clear();
                req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var httpResponseMessage = await client.SendAsync(req))
                {
                    httpResponseMessage.EnsureSuccessStatusCode();
                    jobj = await httpResponseMessage.Content.ReadAsAsync<JObject>();
                }
            }

            var accessToken = jobj["access_token"].Value<string>();
            return accessToken;
        }

        private bool disposedValue = false;

        void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    client.Dispose();
                }


                disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(true);
        }
    }

}