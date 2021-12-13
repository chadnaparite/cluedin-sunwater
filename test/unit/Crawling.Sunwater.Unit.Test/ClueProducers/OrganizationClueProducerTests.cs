using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Sunwater.ClueProducers;
using CluedIn.Crawling.Sunwater.Core.Models;

namespace Crawling.Sunwater.Unit.Test.ClueProducers
{
    public class OrganizationClueProducerTests : BaseClueProducerTest<Organization>
    {
        protected override BaseClueProducer<Organization> Sut =>
            new OrganizationClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => EntityType.Organization;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Organization organization)
        {
            var clue = Sut.MakeClue(organization, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
