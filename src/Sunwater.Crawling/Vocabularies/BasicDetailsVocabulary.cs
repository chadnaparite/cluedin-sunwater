using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Constants;

namespace CluedIn.Crawling.Sunwater.Vocabularies
{
    public class  BasicDetailsVocabulary : SimpleVocabulary
    {
        public  BasicDetailsVocabulary()
        {
            VocabularyName = "Sunwater BasicDetails"; 
            KeyPrefix      = "sunwater.basicdetails"; 
            KeySeparator   = ".";
            Grouping       = SunwaterEntities.BasicDetails; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Sunwater BasicDetails Details", group =>
            {
                EmployeeNumber = group.Add(new VocabularyKey("EmployeeNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualClassBanded = group.Add(new VocabularyKey("ActualClassBanded", "Actual Class Banded", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualClassification = group.Add(new VocabularyKey("ActualClassification", "Actual Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualClassificationSort = group.Add(new VocabularyKey("ActualClassificationSort", "Actual Classification Sort", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualDateEffective = group.Add(new VocabularyKey("ActualDateEffective", "Actual Date Effective", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualDateTo = group.Add(new VocabularyKey("ActualDateTo", "Actual Date To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualIncrementPoint = group.Add(new VocabularyKey("ActualIncrementPoint", "Actual Increment Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualJobCode = group.Add(new VocabularyKey("ActualJobCode", "Actual Job Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualJobTitle = group.Add(new VocabularyKey("ActualJobTitle", "Actual Job Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualLocationCode = group.Add(new VocabularyKey("ActualLocationCode", "Actual Location Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualManagerFlag = group.Add(new VocabularyKey("ActualManagerFlag", "Actual Manager Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualMovementCode = group.Add(new VocabularyKey("ActualMovementCode", "Actual Movement Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualOrganisationalUnitLow = group.Add(new VocabularyKey("ActualOrganisationalUnitLow", "Actual Organisational Unit Low", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualOrganisationalUnitNumber = group.Add(new VocabularyKey("ActualOrganisationalUnitNumber", "Actual Organisational Unit Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualPercentActing = group.Add(new VocabularyKey("ActualPercentActing", "Actual Percent Acting ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualPlacementType = group.Add(new VocabularyKey("ActualPlacementType", "Actual Placement Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualPositionNumber = group.Add(new VocabularyKey("ActualPositionNumber", "Actual Position Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdministerPayrollFrom = group.Add(new VocabularyKey("AdministerPayrollFrom", "Administer Payroll From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttendanceTypeCodeType = group.Add(new VocabularyKey("AttendanceTypeCodeType", "Attendance  Type Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttendanceType = group.Add(new VocabularyKey("AttendanceType", "Attendance Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageHoursPerDay = group.Add(new VocabularyKey("AverageHoursPerDay", "Average Hours Per Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AwardCode = group.Add(new VocabularyKey("AwardCode", "Award Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractExpiryDate = group.Add(new VocabularyKey("ContractExpiryDate", "Contract Expiry Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CpCodeType = group.Add(new VocabularyKey("CpCodeType", "CP Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CycleNumber = group.Add(new VocabularyKey("CycleNumber", "Cycle Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateApproved = group.Add(new VocabularyKey("DateApproved", "Date Approved", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateCommenced = group.Add(new VocabularyKey("DateCommenced", "Date Commenced", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateTerminated = group.Add(new VocabularyKey("DateTerminated", "Date Terminated", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DaysPerWeek = group.Add(new VocabularyKey("DaysPerWeek", "Days Per Week", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EaCodeType = group.Add(new VocabularyKey("EaCodeType", "EA Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeStatus = group.Add(new VocabularyKey("EmployeeStatus", "Employee Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentType = group.Add(new VocabularyKey("EmploymentType", "Employment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnterpriseAgreement = group.Add(new VocabularyKey("EnterpriseAgreement", "Enterprise Agreement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EtCodeType = group.Add(new VocabularyKey("EtCodeType", "ET Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludeFromReportsFlag = group.Add(new VocabularyKey("ExcludeFromReportsFlag", "Exclude From Reports Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Fte = group.Add(new VocabularyKey("Fte", "FTE", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullName = group.Add(new VocabularyKey("FullName", "Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullTimeHoursPerWeek = group.Add(new VocabularyKey("FullTimeHoursPerWeek", "Full Time Hours Per Week", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HoursPerWeek = group.Add(new VocabularyKey("HoursPerWeek", "Hours per Week", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoCodeType = group.Add(new VocabularyKey("LoCodeType", "LO Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalDateCommenced = group.Add(new VocabularyKey("OriginalDateCommenced", "Original Date Commenced", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayBranch = group.Add(new VocabularyKey("PayBranch", "Pay Branch", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayEntity = group.Add(new VocabularyKey("PayEntity", "Pay Entity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Payroll = group.Add(new VocabularyKey("Payroll", "Payroll", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonNumber = group.Add(new VocabularyKey("PersonNumber", "Person Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryCostCode = group.Add(new VocabularyKey("PrimaryCostCode", "Primary Cost Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryRole = group.Add(new VocabularyKey("PrimaryRole", "Primary Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegionCode = group.Add(new VocabularyKey("RegionCode", "Region Code  ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCategoryCode = group.Add(new VocabularyKey("ReportingCategoryCode", "Reporting Category Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RgRegionCode = group.Add(new VocabularyKey("RgRegionCode", "RG Region Code  ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RosterCode = group.Add(new VocabularyKey("RosterCode", "Roster Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkFlag = group.Add(new VocabularyKey("WorkFlag", "Work Mon - Fri Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPattern = group.Add(new VocabularyKey("WorkPattern", "Work Pattern ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay1 = group.Add(new VocabularyKey("WorkPatternDay1", "Work Pattern Day 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay10 = group.Add(new VocabularyKey("WorkPatternDay10", "Work Pattern Day 10", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay11 = group.Add(new VocabularyKey("WorkPatternDay11", "Work Pattern Day 11", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay12 = group.Add(new VocabularyKey("WorkPatternDay12", "Work Pattern Day 12", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay13 = group.Add(new VocabularyKey("WorkPatternDay13", "Work Pattern Day 13", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay14 = group.Add(new VocabularyKey("WorkPatternDay14", "Work Pattern Day 14", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay2 = group.Add(new VocabularyKey("WorkPatternDay2", "Work Pattern Day 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay3 = group.Add(new VocabularyKey("WorkPatternDay3", "Work Pattern Day 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay4 = group.Add(new VocabularyKey("WorkPatternDay4", "Work Pattern Day 4", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay5 = group.Add(new VocabularyKey("WorkPatternDay5", "Work Pattern Day 5", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay6 = group.Add(new VocabularyKey("WorkPatternDay6", "Work Pattern Day 6", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay7 = group.Add(new VocabularyKey("WorkPatternDay7", "Work Pattern Day 7", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay8 = group.Add(new VocabularyKey("WorkPatternDay8", "Work Pattern Day 8", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternDay9 = group.Add(new VocabularyKey("WorkPatternDay9", "Work Pattern Day 9", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPatternKey = group.Add(new VocabularyKey("WorkPatternKey", "Work Pattern key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }
        
        public VocabularyKey EmployeeNumber { get; private set; }
        public VocabularyKey ActualClassBanded { get; private set; }
        public VocabularyKey ActualClassification { get; private set; }
        public VocabularyKey ActualClassificationSort { get; private set; }
        public VocabularyKey ActualDateEffective { get; private set; }
        public VocabularyKey ActualDateTo { get; private set; }
        public VocabularyKey ActualIncrementPoint { get; private set; }
        public VocabularyKey ActualJobCode { get; private set; }
        public VocabularyKey ActualJobTitle { get; private set; }
        public VocabularyKey ActualLocationCode { get; private set; }
        public VocabularyKey ActualManagerFlag { get; private set; }
        public VocabularyKey ActualMovementCode { get; private set; }
        public VocabularyKey ActualOrganisationalUnitLow { get; private set; }
        public VocabularyKey ActualOrganisationalUnitNumber { get; private set; }
        public VocabularyKey ActualPercentActing { get; private set; }
        public VocabularyKey ActualPlacementType { get; private set; }
        public VocabularyKey ActualPositionNumber { get; private set; }
        public VocabularyKey AdministerPayrollFrom { get; private set; }
        public VocabularyKey AttendanceTypeCodeType { get; private set; }
        public VocabularyKey AttendanceType { get; private set; }
        public VocabularyKey AverageHoursPerDay { get; private set; }
        public VocabularyKey AwardCode { get; private set; }
        public VocabularyKey ContractExpiryDate { get; private set; }
        public VocabularyKey CpCodeType { get; private set; }
        public VocabularyKey CycleNumber { get; private set; }
        public VocabularyKey DateApproved { get; private set; }
        public VocabularyKey DateCommenced { get; private set; }
        public VocabularyKey DateTerminated { get; private set; }
        public VocabularyKey DaysPerWeek { get; private set; }
        public VocabularyKey EaCodeType { get; private set; }
        public VocabularyKey EmployeeStatus { get; private set; }
        public VocabularyKey EmploymentType { get; private set; }
        public VocabularyKey EnterpriseAgreement { get; private set; }
        public VocabularyKey EtCodeType { get; private set; }
        public VocabularyKey ExcludeFromReportsFlag { get; private set; }
        public VocabularyKey Fte { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey FullTimeHoursPerWeek { get; private set; }
        public VocabularyKey HoursPerWeek { get; private set; }
        public VocabularyKey LoCodeType { get; private set; }
        public VocabularyKey OriginalDateCommenced { get; private set; }
        public VocabularyKey PayBranch { get; private set; }
        public VocabularyKey PayEntity { get; private set; }
        public VocabularyKey Payroll { get; private set; }
        public VocabularyKey PersonNumber { get; private set; }
        public VocabularyKey PrimaryCostCode { get; private set; }
        public VocabularyKey PrimaryRole { get; private set; }
        public VocabularyKey RegionCode { get; private set; }
        public VocabularyKey ReportingCategoryCode { get; private set; }
        public VocabularyKey RgRegionCode { get; private set; }
        public VocabularyKey RosterCode { get; private set; }
        public VocabularyKey WorkFlag	 { get; private set; }
        public VocabularyKey WorkPattern { get; private set; }
        public VocabularyKey WorkPatternDay1 { get; private set; }
        public VocabularyKey WorkPatternDay10 { get; private set; }
        public VocabularyKey WorkPatternDay11 { get; private set; }
        public VocabularyKey WorkPatternDay12 { get; private set; }
        public VocabularyKey WorkPatternDay13 { get; private set; }
        public VocabularyKey WorkPatternDay14 { get; private set; }
        public VocabularyKey WorkPatternDay2 { get; private set; }
        public VocabularyKey WorkPatternDay3 { get; private set; }
        public VocabularyKey WorkPatternDay4 { get; private set; }
        public VocabularyKey WorkPatternDay5 { get; private set; }
        public VocabularyKey WorkPatternDay6 { get; private set; }
        public VocabularyKey WorkPatternDay7 { get; private set; }
        public VocabularyKey WorkPatternDay8 { get; private set; }
        public VocabularyKey WorkPatternDay9 { get; private set; }
        public VocabularyKey WorkPatternKey { get; private set; }
    }
}
