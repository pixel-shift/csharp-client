using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Pixelshift.Oauth2
{
    public class OAuth2MessageHandler : DelegatingHandler
    {
        private readonly ClientCredentialsProvider provider;

        private string accessToken;

        public OAuth2MessageHandler(ClientCredentialsProvider provider, HttpMessageHandler innerHandler = null)
            : base(innerHandler ?? new HttpClientHandler())
        {
            this.provider = provider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;
            for (var i = 0; i < 2; ++i)
            {
                if (accessToken == null)
                {
                    accessToken = await provider.GetAccessTokenAsync();
                }

                //Console.WriteLine($"access_token : {accessToken}");
                var header = new AuthenticationHeaderValue("Bearer", accessToken);
                request.Headers.Authorization = header;
                response = await base.SendAsync(request, cancellationToken);
                if (response.StatusCode != System.Net.HttpStatusCode.Unauthorized)
                {
                    break;
                }
                //unauthorized
                if (i == 0)
                {
                    response.Dispose();
                }

                accessToken = null;
            }

            return response;
        }

        private bool disposedValue = false;

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (!disposedValue)
            {
                if (disposing)
                {
                    provider.Dispose();
                }


                disposedValue = true;
            }
        }
    }
}