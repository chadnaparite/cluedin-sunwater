using CluedIn.Core;
using CluedIn.Crawling.Sunwater.Core;

using ComponentHost;

namespace CluedIn.Crawling.Sunwater
{
    [Component(SunwaterConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class SunwaterCrawlerComponent : CrawlerComponentBase
    {
        public SunwaterCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

