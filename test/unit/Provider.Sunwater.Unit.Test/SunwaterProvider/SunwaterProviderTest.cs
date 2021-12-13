using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Sunwater.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Sunwater.Unit.Test.SunwaterProvider
{
    public abstract class SunwaterProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<ISunwaterClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected SunwaterProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<ISunwaterClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Sunwater.SunwaterProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
