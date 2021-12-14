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
    public class SAPClueProducerTests : BaseClueProducerTest<SAP>
    {
        protected override BaseClueProducer<SAP> Sut =>
            new SAPClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => SunwaterEntities.SAP;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(SAP sap)
        {
            var clue = Sut.MakeClue(sap, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
