using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Sunwater.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Models;
using CluedIn.Crawling.Sunwater.Core.Constants;

namespace CluedIn.Crawling.Sunwater.ClueProducers
{
    public class BasicDetailsClueProducer : BaseClueProducer<BasicDetails>
    {
        private readonly IClueFactory factory;

        public BasicDetailsClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(BasicDetails input, Guid accountId)
        {
            var basicdetailsVocabulary = new BasicDetailsVocabulary();
            var clue = factory.Create(basicdetailsVocabulary.Grouping, input.EmployeeNumber.ToString(), accountId);
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
            if (input.ActualPositionNumber != null)
                factory.CreateIncomingEntityReference(clue, SunwaterEntities.Position, EntityEdgeType.OwnedBy, input.ActualPositionNumber, input.ActualPositionNumber);
            
            if (input.ActualOrganisationalUnitNumber != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, input.ActualOrganisationalUnitNumber, input.ActualOrganisationalUnitNumber);
            
            if (input.WamiKey != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, input.WamiKey, input.WamiKey);

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[basicdetailsVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[basicdetailsVocabulary.EmployeeNumber] = input.EmployeeNumber.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualClassBanded] = input.ActualClassBanded.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualClassification] = input.ActualClassification.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualClassificationSort] = input.ActualClassificationSort.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualDateEffective] = input.ActualDateEffective.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualDateTo] = input.ActualDateTo.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualIncrementPoint] = input.ActualIncrementPoint.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualJobCode] = input.ActualJobCode.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualJobTitle] = input.ActualJobTitle.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualLocationCode] = input.ActualLocationCode.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualManagerFlag] = input.ActualManagerFlag.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualMovementCode] = input.ActualMovementCode.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualOrganisationalUnitLow] = input.ActualOrganisationalUnitLow.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualOrganisationalUnitNumber] = input.ActualOrganisationalUnitNumber.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualPercentActing] = input.ActualPercentActing.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualPlacementType] = input.ActualPlacementType.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ActualPositionNumber] = input.ActualPositionNumber.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.AdministerPayrollFrom] = input.AdministerPayrollFrom.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.AttendanceTypeCodeType] = input.AttendanceTypeCodeType.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.AttendanceType] = input.AttendanceType.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.AverageHoursPerDay] = input.AverageHoursPerDay.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.AwardCode] = input.AwardCode.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ContractExpiryDate] = input.ContractExpiryDate.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.CpCodeType] = input.CpCodeType.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.CycleNumber] = input.CycleNumber.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.DateApproved] = input.DateApproved.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.DateCommenced] = input.DateCommenced.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.DateTerminated] = input.DateTerminated.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.DaysPerWeek] = input.DaysPerWeek.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.EaCodeType] = input.EaCodeType.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.EmployeeStatus] = input.EmployeeStatus.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.EmploymentType] = input.EmploymentType.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.EnterpriseAgreement] = input.EnterpriseAgreement.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.EtCodeType] = input.EtCodeType.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ExcludeFromReportsFlag] = input.ExcludeFromReportsFlag.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.Fte] = input.Fte.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.FullTimeHoursPerWeek] = input.FullTimeHoursPerWeek.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.HoursPerWeek] = input.HoursPerWeek.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.LoCodeType] = input.LoCodeType.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.OriginalDateCommenced] = input.OriginalDateCommenced.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.PayBranch] = input.PayBranch.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.PayEntity] = input.PayEntity.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.Payroll] = input.Payroll.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WamiKey] = input.WamiKey.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.PrimaryCostCode] = input.PrimaryCostCode.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.PrimaryRole] = input.PrimaryRole.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.RegionCode] = input.RegionCode.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.ReportingCategoryCode] = input.ReportingCategoryCode.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.RgRegionCode] = input.RgRegionCode.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.RosterCode] = input.RosterCode.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkFlag] = input.WorkFlag.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPattern] = input.WorkPattern.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay1] = input.WorkPatternDay1.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay10] = input.WorkPatternDay10.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay11] = input.WorkPatternDay11.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay12] = input.WorkPatternDay12.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay13] = input.WorkPatternDay13.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay14] = input.WorkPatternDay14.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay2] = input.WorkPatternDay2.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay3] = input.WorkPatternDay3.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay4] = input.WorkPatternDay4.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay5] = input.WorkPatternDay5.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay6] = input.WorkPatternDay6.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay7] = input.WorkPatternDay7.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay8] = input.WorkPatternDay8.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternDay9] = input.WorkPatternDay9.PrintIfAvailable();
            data.Properties[basicdetailsVocabulary.WorkPatternKey] = input.WorkPatternKey.PrintIfAvailable();

            return clue;
        }
    }
}
