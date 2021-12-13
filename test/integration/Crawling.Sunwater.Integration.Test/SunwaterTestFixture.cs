using System.IO;
using System.Reflection;
using Castle.MicroKernel.Registration;
using CluedIn.Crawling.Sunwater.Core;
using CrawlerIntegrationTesting.Clues;
using Xunit.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using DebugCrawlerHost = CrawlerIntegrationTesting.CrawlerHost.DebugCrawlerHost<CluedIn.Crawling.Sunwater.Core.SunwaterCrawlJobData>;

namespace CluedIn.Crawling.Sunwater.Integration.Test
{
    public class SunwaterTestFixture
    {
        public ClueStorage ClueStorage { get; }
        private readonly DebugCrawlerHost debugCrawlerHost;

        public ILogger<SunwaterTestFixture> Log { get; }

        public SunwaterTestFixture()
        {
            var executingFolder = new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName;
            debugCrawlerHost = new DebugCrawlerHost(executingFolder, SunwaterConstants.ProviderName, c => {
                c.Register(Component.For<ILogger>().UsingFactoryMethod(_ => NullLogger.Instance).LifestyleSingleton());
                c.Register(Component.For<ILoggerFactory>().UsingFactoryMethod(_ => NullLoggerFactory.Instance).LifestyleSingleton());
            });

            ClueStorage = new ClueStorage();

            Log = debugCrawlerHost.AppContext.Container.Resolve<ILogger<SunwaterTestFixture>>();

            debugCrawlerHost.ProcessClue += ClueStorage.AddClue;

            debugCrawlerHost.Execute(SunwaterConfiguration.Create(), SunwaterConstants.ProviderId);
        }

        public void PrintClues(ITestOutputHelper output)
        {
            foreach(var clue in ClueStorage.Clues)
            {
                output.WriteLine(clue.OriginEntityCode.ToString());
            }
        }

        public void PrintLogs(ITestOutputHelper output)
        {
            //TODO:
            //output.WriteLine(Log.PrintLogs());
        }

        public void Dispose()
        {
        }

    }
}


