using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Sunwater.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Models;
using CluedIn.Crawling.Sunwater.Core;

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

            if (input.OrganizationUnit != null)
                data.Codes.Add(new EntityCode(EntityType.Organization, SunwaterConstants.CodeOrigin, input.OrganizationUnit));

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }

            if (input.SuperiorOrgUnitNumber != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.SuperiorOrgUnitNumber, input.SuperiorOrgUnitNumber);
            
            if (input.OrganizationUnitLevel01 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel01, input.OrganizationUnitLevel01);
            
            if (input.OrganizationUnitLevel01 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel01, input.OrganizationUnitLevel01);
            
            if (input.OrganizationUnitLevel02 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel02, input.OrganizationUnitLevel02);
            
            if (input.OrganizationUnitLevel03 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel03, input.OrganizationUnitLevel03);
            
            if (input.OrganizationUnitLevel04 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel04, input.OrganizationUnitLevel04);
            
            if (input.OrganizationUnitLevel05 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel05, input.OrganizationUnitLevel05);
            
            if (input.OrganizationUnitLevel06 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel06, input.OrganizationUnitLevel06);
            
            if (input.OrganizationUnitLevel07 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel07, input.OrganizationUnitLevel07);
            
            if (input.OrganizationUnitLevel08 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel08, input.OrganizationUnitLevel08);
            
            if (input.OrganizationUnitLevel09 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel09, input.OrganizationUnitLevel09);
            
            if (input.OrganizationUnitLevel10 != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganizationUnitLevel10, input.OrganizationUnitLevel10);

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
            data.Properties[organizationVocabulary.SuperiorOrgUnitNumber] = input.SuperiorOrgUnitNumber.PrintIfAvailable();
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
