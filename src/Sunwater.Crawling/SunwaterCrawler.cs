using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Sunwater.Core;
using CluedIn.Crawling.Sunwater.Infrastructure.Factories;

namespace CluedIn.Crawling.Sunwater
{
    public class SunwaterCrawler : ICrawlerDataGenerator
    {
        private readonly ISunwaterClientFactory clientFactory;
        public SunwaterCrawler(ISunwaterClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is SunwaterCrawlJobData SunwatercrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(SunwatercrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
