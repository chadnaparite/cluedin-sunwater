using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Sunwater.ClueProducers;
using CluedIn.Crawling.Sunwater.Core.Models;
using CluedIn.Crawling.Sunwater.Core.Constants;

namespace Crawling.Sunwater.Unit.Test.ClueProducers
{
    public class ExtractClueProducerTests : BaseClueProducerTest<Extract>
    {
        protected override BaseClueProducer<Extract> Sut =>
            new ExtractClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => SunwaterEntities.Extract;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Extract extract)
        {
            var clue = Sut.MakeClue(extract, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
