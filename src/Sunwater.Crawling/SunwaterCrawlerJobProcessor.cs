using CluedIn.Crawling.Sunwater.Core;

namespace CluedIn.Crawling.Sunwater
{
    public class SunwaterCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<SunwaterCrawlJobData>
    {
        public SunwaterCrawlerJobProcessor(SunwaterCrawlerComponent component) : base(component)
        {
        }
    }
}
