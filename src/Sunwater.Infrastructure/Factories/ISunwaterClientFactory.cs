using CluedIn.Crawling.Sunwater.Core;

namespace CluedIn.Crawling.Sunwater.Infrastructure.Factories
{
    public interface ISunwaterClientFactory
    {
        SunwaterClient CreateNew(SunwaterCrawlJobData SunwaterCrawlJobData);
    }
}
