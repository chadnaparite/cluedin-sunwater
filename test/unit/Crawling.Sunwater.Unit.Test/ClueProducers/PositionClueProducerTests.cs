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
    public class PositionClueProducerTests : BaseClueProducerTest<Position>
    {
        protected override BaseClueProducer<Position> Sut =>
            new PositionClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => SunwaterEntities.Position;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Position position)
        {
            var clue = Sut.MakeClue(position, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
