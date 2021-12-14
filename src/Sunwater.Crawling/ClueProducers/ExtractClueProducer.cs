using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Sunwater.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Models;

namespace CluedIn.Crawling.Sunwater.ClueProducers
{
    public class ExtractClueProducer : BaseClueProducer<Extract>
    {
        private readonly IClueFactory factory;

        public ExtractClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Extract input, Guid accountId)
        {
            var extractVocabulary = new ExtractVocabulary();
            var clue = factory.Create(extractVocabulary.Grouping, input.Company.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.Company != null)
            {
                data.Name = input.Company;
                data.DisplayName = input.Company;
                data.Description = input.Company;
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
            //     data.Properties[extractVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[extractVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[extractVocabulary.Company] = input.Company.PrintIfAvailable();
            data.Properties[extractVocabulary.Division] = input.Division.PrintIfAvailable();
            data.Properties[extractVocabulary.Region] = input.Region.PrintIfAvailable();
            data.Properties[extractVocabulary.Location] = input.Location.PrintIfAvailable();
            data.Properties[extractVocabulary.Site] = input.Site.PrintIfAvailable();
            data.Properties[extractVocabulary.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[extractVocabulary.LatName] = input.LatName.PrintIfAvailable();
            data.Properties[extractVocabulary.Username] = input.Username.PrintIfAvailable();
            data.Properties[extractVocabulary.EmployeeId] = input.EmployeeId.PrintIfAvailable();
            data.Properties[extractVocabulary.Email] = input.Email.PrintIfAvailable();
            data.Properties[extractVocabulary.Phone] = input.Phone.PrintIfAvailable();
            data.Properties[extractVocabulary.SsoUser] = input.SsoUser.PrintIfAvailable();
            data.Properties[extractVocabulary.Password] = input.Password.PrintIfAvailable();
            data.Properties[extractVocabulary.RetypePassword] = input.RetypePassword.PrintIfAvailable();
            data.Properties[extractVocabulary.LoginRequired] = input.LoginRequired?.PrintIfAvailable();
            data.Properties[extractVocabulary.Affiliation] = input.Affiliation.PrintIfAvailable();
            data.Properties[extractVocabulary.Archived] = input.Archived.PrintIfAvailable();
            data.Properties[extractVocabulary.Occupation] = input.Occupation.PrintIfAvailable();
            data.Properties[extractVocabulary.SecondaryOccupation] = input.SecondaryOccupation.PrintIfAvailable();
            data.Properties[extractVocabulary.ExtractGroups] = input.Groups.PrintIfAvailable();
            data.Properties[extractVocabulary.Locale] = input.Locale.PrintIfAvailable();
            data.Properties[extractVocabulary.Manager] = input.Manager.PrintIfAvailable();

            return clue;
        }
    }
}
