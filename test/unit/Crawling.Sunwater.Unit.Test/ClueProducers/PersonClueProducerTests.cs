using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Sunwater.ClueProducers;
using CluedIn.Crawling.Sunwater.Core.Models;

namespace Crawling.Sunwater.Unit.Test.ClueProducers
{
    public class PersonClueProducerTests : BaseClueProducerTest<Person>
    {
        protected override BaseClueProducer<Person> Sut =>
            new PersonClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => EntityType.Person;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Person person)
        {
            var clue = Sut.MakeClue(person, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
