using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Sunwater.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Models;

namespace CluedIn.Crawling.Sunwater.ClueProducers
{
    public class OrganizationUnitCostingClueProducer : BaseClueProducer<OrganizationUnitCosting>
    {
        private readonly IClueFactory factory;

        public OrganizationUnitCostingClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(OrganizationUnitCosting input, Guid accountId)
        {
            var organizationunitcostingVocabulary = new OrganizationUnitCostingVocabulary();
            var clue = factory.Create(organizationunitcostingVocabulary.Grouping, input.TransactionNumber.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.TransactionNumber != null)
            {
                data.Name = input.TransactionNumber;
                data.DisplayName = input.TransactionNumber;
                data.Description = input.TransactionNumber;
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
            //     data.Properties[organizationunitcostingVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[organizationunitcostingVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[organizationunitcostingVocabulary.TransactionNumber] = input.TransactionNumber.PrintIfAvailable();
            data.Properties[organizationunitcostingVocabulary.CostCentre] = input.CostCentre.PrintIfAvailable();
            data.Properties[organizationunitcostingVocabulary.CostingCode2] = input.CostingCode2.PrintIfAvailable();
            data.Properties[organizationunitcostingVocabulary.CostingCode3] = input.CostingCode3.PrintIfAvailable();
            data.Properties[organizationunitcostingVocabulary.CostingCode4] = input.CostingCode4.PrintIfAvailable();
            data.Properties[organizationunitcostingVocabulary.CostingCode5] = input.CostingCode5.PrintIfAvailable();
            data.Properties[organizationunitcostingVocabulary.CostingCode6] = input.CostingCode6.PrintIfAvailable();
            data.Properties[organizationunitcostingVocabulary.CostingCode7] = input.CostingCode7.PrintIfAvailable();
            data.Properties[organizationunitcostingVocabulary.CostingCode8] = input.CostingCode8.PrintIfAvailable();
            data.Properties[organizationunitcostingVocabulary.OrganisationUnitNumber] = input.OrganisationUnitNumber.PrintIfAvailable();

            return clue;
        }
    }
}
