using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Pixelshift.Autorest;
using Pixelshift.Autorest.Models;
using Pixelshift.Oauth2;
using Xunit;
using Xunit.Abstractions;

namespace Pix.Autorest.Test
{
    public class UnitTest1
    {
        private ITestOutputHelper Output { get; }

        public UnitTest1(ITestOutputHelper output)
        {
            Output = output;
        }

        [Fact]
        public async Task amamzon_test()
        {
            string
                clientId =
                    "__client_id__"; //replace with "public key" from https://www.pixelshift.io/Dashboard/ApiAccess
            string
                clientSecret =
                    "__client_secret__"; //replace with "secret key" https://www.pixelshift.io/Dashboard/ApiAccess
            var baseUrl = "https://www.pixelshift.io";
            var dh = new OAuth2MessageHandler(new ClientCredentialsProvider(baseUrl, clientId, clientSecret));
            var httpClient = new HttpClient(dh);
            var api = new V1API(httpClient, true) {BaseUri = new Uri(baseUrl)};
            var graph = new TransformGraph(new List<TransformUnit>
            {
                new StorageSourceS3("sourceKey", "sourceBucket"),
                new ImageResizeMax(1024, 1024),
            }, new[]
            {
                new TransformGraph(new List<TransformUnit>
                {
                    new ImageFormatJpeg(50),
                    new StorageSinkS3("outputKey1024.jpg",
                        "outputBucket", true)
                }),
                new TransformGraph(new List<TransformUnit>
                {
                    new ImageResizeMax(128, 128),
                    new ImageFormatJpeg(50),
                    new StorageSinkS3("outputKey128.jpg",
                        "outputBucket", true)
                }),
                new TransformGraph(new List<TransformUnit>
                {
                    new ImageResizeMax(64, 64),
                    new ImageFormatJpeg(50),
                    new StorageSinkS3("outputKey64.jpg",
                        "outputBucket", true)
                })
            });
            var batch = new Batch(new[] {graph});
            BatchStartReportResponse batchStartReportResponse = await api.ProcessImageBatchAsync(batch);
            Assert.True(batchStartReportResponse.Success);

            if (batchStartReportResponse.Id != null)
            {
                var idValue = batchStartReportResponse.Id.Value;
                BatchReportResponse batchReportResponse;
                while ((batchReportResponse = await api.BatchInfoAsync(idValue)).Status ==
                       BatchStatus.Pending)
                {
                    await Task.Delay(3000);
                }
                Output.WriteLine(
                    $"completed: {batchReportResponse.Completed.Count}, failed: {batchReportResponse.Failed.Count}");
                Assert.True(batchReportResponse.Completed.Count == batch.Items.Count);
                return;
            }
            Assert.True(false); //something went wrong


        }
    }
}