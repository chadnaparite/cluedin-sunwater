using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Sunwater.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Models;

namespace CluedIn.Crawling.Sunwater.ClueProducers
{
    public class OrganizationClueProducer : BaseClueProducer<Organization>
    {
        private readonly IClueFactory factory;

        public OrganizationClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Organization input, Guid accountId)
        {
            var organizationVocabulary = new OrganizationVocabulary();
            var clue = factory.Create(organizationVocabulary.Grouping, input.OrganizationUnitNumber.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.OrganizationUnit != null)
            {
                data.Name = input.OrganizationUnit;
                data.DisplayName = input.OrganizationUnit;
                data.Description = input.OrganizationUnit;
            }
            if (input.OrganizationUnitDescription != null)
                data.Description = input.OrganizationUnitDescription;

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }

            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[organizationVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[organizationVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[organizationVocabulary.OrganizationUnitNumber] = input.OrganizationUnitNumber.PrintIfAvailable();
            data.Properties[organizationVocabulary.LocationCode] = input.LocationCode.PrintIfAvailable();
            data.Properties[organizationVocabulary.LocationCodeType] = input.LocationCodeType.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationBusinessUnit] = input.OrganizationBusinessUnit.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnit] = input.OrganizationUnit.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitDescription] = input.OrganizationUnitDescription.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel01] = input.OrganizationUnitLevel01.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel02] = input.OrganizationUnitLevel02.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel03] = input.OrganizationUnitLevel03.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel04] = input.OrganizationUnitLevel04.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel05] = input.OrganizationUnitLevel05.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel06] = input.OrganizationUnitLevel06.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel07] = input.OrganizationUnitLevel07.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel08] = input.OrganizationUnitLevel08.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel09] = input.OrganizationUnitLevel09.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitLevel10] = input.OrganizationUnitLevel10.PrintIfAvailable();
            data.Properties[organizationVocabulary.OrganizationUnitStatus] = input.OrganizationUnitStatus.PrintIfAvailable();
            data.Properties[organizationVocabulary.PrimaryCostCode] = input.PrimaryCostCode.PrintIfAvailable();
            data.Properties[organizationVocabulary.SeniorEmployeeNumber] = input.SeniorEmployeeNumber.PrintIfAvailable();
            data.Properties[organizationVocabulary.SupervisorUserId] = input.SupervisorUserId.PrintIfAvailable();

            return clue;
        }
    }
}
