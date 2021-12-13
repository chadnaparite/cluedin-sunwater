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
    public class OrganizationUnitCostingClueProducerTests : BaseClueProducerTest<OrganizationUnitCosting>
    {
        protected override BaseClueProducer<OrganizationUnitCosting> Sut =>
            new OrganizationUnitCostingClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => SunwaterEntities.OrganizationUnitCosting;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(OrganizationUnitCosting organizationunitcosting)
        {
            var clue = Sut.MakeClue(organizationunitcosting, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
