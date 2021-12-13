using System;
using System.Net;
using System.Threading.Tasks;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Sunwater.Core;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.Extensions.Logging;

namespace CluedIn.Crawling.Sunwater.Infrastructure
{
    // TODO - This class should act as a client to retrieve the data to be crawled.
    // It should provide the appropriate methods to get the data
    // according to the type of data source (e.g. for AD, GetUsers, GetRoles, etc.)
    // It can receive a IRestClient as a dependency to talk to a RestAPI endpoint.
    // This class should not contain crawling logic (i.e. in which order things are retrieved)
    public class SunwaterClient
    {
        private const string BaseUri = "http://sample.com";

        private readonly ILogger<SunwaterClient> log;

        private readonly IRestClient client;

        public SunwaterClient(ILogger<SunwaterClient> log, SunwaterCrawlJobData SunwaterCrawlJobData, IRestClient client) // TODO: pass on any extra dependencies
        {
            if (SunwaterCrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(SunwaterCrawlJobData));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.log = log ?? throw new ArgumentNullException(nameof(log));
            this.client = client ?? throw new ArgumentNullException(nameof(client));

            // TODO use info from SunwaterCrawlJobData to instantiate the connection
            client.BaseUrl = new Uri(BaseUri);
            client.AddDefaultParameter("api_key", SunwaterCrawlJobData.ApiKey, ParameterType.QueryString);
        }

        private async Task<T> GetAsync<T>(string url)
        {
            var request = new RestRequest(url, Method.GET);

            var response = await client.ExecuteAsync(request, request.Method);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                var diagnosticMessage = $"Request to {client.BaseUrl}{url} failed, response {response.ErrorMessage} ({response.StatusCode})";
                log.LogError(diagnosticMessage);
                throw new InvalidOperationException($"Communication to jsonplaceholder unavailable. {diagnosticMessage}");
            }

            var data = JsonConvert.DeserializeObject<T>(response.Content);

            return data;
        }

        public AccountInformation GetAccountInformation()
        {
            //TODO - return some unique information about the remote data source
            // that uniquely identifies the account
            return new AccountInformation("", "");
        }
    }
}
