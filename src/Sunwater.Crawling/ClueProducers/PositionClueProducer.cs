using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Sunwater.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Models;

namespace CluedIn.Crawling.Sunwater.ClueProducers
{
    public class PositionClueProducer : BaseClueProducer<Position>
    {
        private readonly IClueFactory factory;

        public PositionClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Position input, Guid accountId)
        {
            var positionVocabulary = new PositionVocabulary();
            var clue = factory.Create(positionVocabulary.Grouping, input.PositionNumber.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.PositionTitle != null)
            {
                data.Name = input.PositionTitle;
                data.DisplayName = input.PositionTitle;
            }
            if (input.PositionStatus != null)
                data.Description = input.PositionStatus;

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }

            //TODO: Examples of edge creation
            if (input.OrganisationUnitNumber != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.OrganisationUnitNumber, input.OrganisationUnitNumber);


            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[positionVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[positionVocabulary.PositionNumber] = input.PositionNumber.PrintIfAvailable();
            data.Properties[positionVocabulary.AttendanceType] = input.AttendanceType.PrintIfAvailable();
            data.Properties[positionVocabulary.AttendanceTypeCode] = input.AttendanceTypeCode.PrintIfAvailable();
            data.Properties[positionVocabulary.Classification] = input.Classification.PrintIfAvailable();
            data.Properties[positionVocabulary.ClassificiationSort] = input.ClassificiationSort.PrintIfAvailable();
            data.Properties[positionVocabulary.FaxNumber] = input.FaxNumber.PrintIfAvailable();
            data.Properties[positionVocabulary.HoursPerWeek] = input.HoursPerWeek.PrintIfAvailable();
            data.Properties[positionVocabulary.JobCode] = input.JobCode.PrintIfAvailable();
            data.Properties[positionVocabulary.JobShare] = input.JobShare.PrintIfAvailable();
            data.Properties[positionVocabulary.LocationCode] = input.LocationCode.PrintIfAvailable();
            data.Properties[positionVocabulary.LocationCodeType] = input.LocationCodeType.PrintIfAvailable();
            data.Properties[positionVocabulary.ManagerFlag] = input.ManagerFlag.PrintIfAvailable();
            data.Properties[positionVocabulary.OrganisationUnitNumber] = input.OrganisationUnitNumber.PrintIfAvailable();
            data.Properties[positionVocabulary.PositionFullTitle] = input.PositionFullTitle.PrintIfAvailable();
            data.Properties[positionVocabulary.PositionStatus] = input.PositionStatus.PrintIfAvailable();
            data.Properties[positionVocabulary.PositionTitle] = input.PositionTitle.PrintIfAvailable();
            data.Properties[positionVocabulary.PositionType] = input.PositionType.PrintIfAvailable();
            data.Properties[positionVocabulary.PrimaryCostCode] = input.PrimaryCostCode.PrintIfAvailable();
            data.Properties[positionVocabulary.ReportsToPosition] = input.ReportsToPosition.PrintIfAvailable();
            data.Properties[positionVocabulary.TelephoneNumber] = input.TelephoneNumber.PrintIfAvailable();

            return clue;
        }
    }
}
