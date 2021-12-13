using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Sunwater.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Models;

namespace CluedIn.Crawling.Sunwater.ClueProducers
{
    public class PersonClueProducer : BaseClueProducer<Person>
    {
        private readonly IClueFactory factory;

        public PersonClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Person input, Guid accountId)
        {
            var personVocabulary = new PersonVocabulary();
            var clue = factory.Create(personVocabulary.Grouping, input.WamiKey.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.FullName != null)
            {
                data.Name = input.FullName;
                data.DisplayName = input.FullName;
                data.Description = input.FullName;
            }

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }

            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[personVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[personVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
            // }

            //TODO: Example of PersonReference
            //  if (input.UpdatedBy != null)
            // {
            //     if (input.UpdatedByName != null)
            //     {
            //         var updatedPersonReference = new PersonReference(input.UpdatedByName, new EntityCode(EntityType.Person, SunwaterConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            //     else
            //     {
            //         var updatedPersonReference = new PersonReference(new EntityCode(EntityType.Person, SunwaterConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            // }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[personVocabulary.WamiKey] = input.WamiKey.PrintIfAvailable();
            data.Properties[personVocabulary.BarCode] = input.BarCode.PrintIfAvailable();
            data.Properties[personVocabulary.BarDpid] = input.BarDpid.PrintIfAvailable();
            data.Properties[personVocabulary.BrithdayMonthDay] = input.BrithdayMonthDay.PrintIfAvailable();
            data.Properties[personVocabulary.CoCodeType1] = input.CoCodeType1.PrintIfAvailable();
            data.Properties[personVocabulary.CoCodeType2] = input.CoCodeType2.PrintIfAvailable();
            data.Properties[personVocabulary.CountryCode] = input.CountryCode.PrintIfAvailable();
            data.Properties[personVocabulary.DateOfBirth] = input.DateOfBirth.PrintIfAvailable();
            data.Properties[personVocabulary.DateOfBirthDocumentCode] = input.DateOfBirthDocumentCode.PrintIfAvailable();
            data.Properties[personVocabulary.DbCodeType] = input.DbCodeType.PrintIfAvailable();
            data.Properties[personVocabulary.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[personVocabulary.EmailSearch] = input.EmailSearch.PrintIfAvailable();
            data.Properties[personVocabulary.ExternalEmployeeNumber] = input.ExternalEmployeeNumber.PrintIfAvailable();
            data.Properties[personVocabulary.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[personVocabulary.Gender] = input.Gender.PrintIfAvailable();
            data.Properties[personVocabulary.GivenNames] = input.GivenNames.PrintIfAvailable();
            data.Properties[personVocabulary.HideMobileDeprecated] = input.HideMobileDeprecated.PrintIfAvailable();
            data.Properties[personVocabulary.Initials] = input.Initials.PrintIfAvailable();
            data.Properties[personVocabulary.KnownAs] = input.KnownAs.PrintIfAvailable();
            data.Properties[personVocabulary.KnownAsSearch] = input.KnownAsSearch.PrintIfAvailable();
            data.Properties[personVocabulary.Name] = input.Name.PrintIfAvailable();
            data.Properties[personVocabulary.NameChangeCode] = input.NameChangeCode.PrintIfAvailable();
            data.Properties[personVocabulary.NameForHeadingsFormat] = input.NameForHeadingsFormat.PrintIfAvailable();
            data.Properties[personVocabulary.NcCodeType] = input.NcCodeType.PrintIfAvailable();
            data.Properties[personVocabulary.OrganisationName] = input.OrganisationName.PrintIfAvailable();
            data.Properties[personVocabulary.ParticipantFlag] = input.ParticipantFlag.PrintIfAvailable();
            data.Properties[personVocabulary.PersonalMobile] = input.PersonalMobile.PrintIfAvailable();
            data.Properties[personVocabulary.PersonalPhone] = input.PersonalPhone.PrintIfAvailable();
            data.Properties[personVocabulary.PostalAddressHome] = input.PostalAddressHome.PrintIfAvailable();
            data.Properties[personVocabulary.PostalCountryCode] = input.PostalCountryCode.PrintIfAvailable();
            data.Properties[personVocabulary.PostalLetterAddress] = input.PostalLetterAddress.PrintIfAvailable();
            data.Properties[personVocabulary.PostalPostcode] = input.PostalPostcode.PrintIfAvailable();
            data.Properties[personVocabulary.PostalState] = input.PostalState.PrintIfAvailable();
            data.Properties[personVocabulary.PostalSteetAddress] = input.PostalSteetAddress.PrintIfAvailable();
            data.Properties[personVocabulary.PostalSuburb] = input.PostalSuburb.PrintIfAvailable();
            data.Properties[personVocabulary.Postcode] = input.Postcode.PrintIfAvailable();
            data.Properties[personVocabulary.PreferredNameSarch] = input.PreferredNameSarch.PrintIfAvailable();
            data.Properties[personVocabulary.PreferredNames] = input.PreferredNames.PrintIfAvailable();
            data.Properties[personVocabulary.PresenterFlag] = input.PresenterFlag.PrintIfAvailable();
            data.Properties[personVocabulary.PriorSurname] = input.PriorSurname.PrintIfAvailable();
            data.Properties[personVocabulary.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[personVocabulary.State] = input.State.PrintIfAvailable();
            data.Properties[personVocabulary.StreetAddress] = input.StreetAddress.PrintIfAvailable();
            data.Properties[personVocabulary.Suburb] = input.Suburb.PrintIfAvailable();
            data.Properties[personVocabulary.Surname] = input.Surname.PrintIfAvailable();
            data.Properties[personVocabulary.SurnameForLetters] = input.SurnameForLetters.PrintIfAvailable();
            data.Properties[personVocabulary.SurnamePhoneticSearch] = input.SurnamePhoneticSearch.PrintIfAvailable();
            data.Properties[personVocabulary.TfnDueDate] = input.TfnDueDate.PrintIfAvailable();
            data.Properties[personVocabulary.WamiType] = input.WamiType.PrintIfAvailable();
            data.Properties[personVocabulary.WorkFax] = input.WorkFax.PrintIfAvailable();
            data.Properties[personVocabulary.WorkMobile] = input.WorkMobile.PrintIfAvailable();
            data.Properties[personVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();

            return clue;
        }
    }
}
