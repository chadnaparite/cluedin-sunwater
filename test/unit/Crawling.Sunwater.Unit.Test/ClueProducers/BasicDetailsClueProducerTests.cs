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
    public class BasicDetailsClueProducerTests : BaseClueProducerTest<BasicDetails>
    {
        protected override BaseClueProducer<BasicDetails> Sut =>
            new BasicDetailsClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => SunwaterEntities.BasicDetails;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(BasicDetails basicdetails)
        {
            var clue = Sut.MakeClue(basicdetails, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
