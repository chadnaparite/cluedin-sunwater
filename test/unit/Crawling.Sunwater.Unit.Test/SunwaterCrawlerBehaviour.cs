using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Sunwater;
using CluedIn.Crawling.Sunwater.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Sunwater.Unit.Test
{
    public class SunwaterCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public SunwaterCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<ISunwaterClientFactory>();

            _sut = new SunwaterCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
