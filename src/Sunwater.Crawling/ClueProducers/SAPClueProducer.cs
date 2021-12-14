using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Sunwater.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Models;

namespace CluedIn.Crawling.Sunwater.ClueProducers
{
    public class SAPClueProducer : BaseClueProducer<SAP>
    {
        private readonly IClueFactory factory;

        public SAPClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(SAP input, Guid accountId)
        {
            var sapVocabulary = new SAPVocabulary();
            var clue = factory.Create(sapVocabulary.Grouping, input.BusinessUnit.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.BusinessUnit != null)
            {
                data.Name = input.BusinessUnit;
                data.DisplayName = input.BusinessUnit;
                data.Description = input.BusinessUnit;
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
            //     data.Properties[sapVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[sapVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[sapVocabulary.BusinessUnit] = input.BusinessUnit.PrintIfAvailable();
            data.Properties[sapVocabulary.Region] = input.Region.PrintIfAvailable();
            data.Properties[sapVocabulary.Office] = input.Office.PrintIfAvailable();
            data.Properties[sapVocabulary.ServiceContract] = input.ServiceContract.PrintIfAvailable();
            data.Properties[sapVocabulary.ProfitCenter] = input.ProfitCenter.PrintIfAvailable();
            data.Properties[sapVocabulary.CostCenter] = input.CostCenter.PrintIfAvailable();
            data.Properties[sapVocabulary.CostCentreDescription] = input.CostCentreDescription.PrintIfAvailable();
            data.Properties[sapVocabulary.Employee] = input.Employee.PrintIfAvailable();
            data.Properties[sapVocabulary.ContractorsFte] = input.ContractorsFte.PrintIfAvailable();
            data.Properties[sapVocabulary.PermanentFte] = input.PermanentFte.PrintIfAvailable();
            data.Properties[sapVocabulary.CasualFte] = input.CasualFte.PrintIfAvailable();
            data.Properties[sapVocabulary.FixedTermFte] = input.FixedTermFte.PrintIfAvailable();

            return clue;
        }
    }
}
