using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Constants;

namespace CluedIn.Crawling.Sunwater.Vocabularies
{
    public class  PositionVocabulary : SimpleVocabulary
    {
        public  PositionVocabulary()
        {
            VocabularyName = "Sunwater Position"; 
            KeyPrefix      = "sunwater.position"; 
            KeySeparator   = ".";
            Grouping       = SunwaterEntities.Position; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Sunwater Position Details", group =>
            {
                PositionNumber = group.Add(new VocabularyKey("PositionNumber", "Position Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttendanceType = group.Add(new VocabularyKey("AttendanceType", "Attendance Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttendanceTypeCode = group.Add(new VocabularyKey("AttendanceTypeCode", "Attendance Type Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Classification = group.Add(new VocabularyKey("Classification", "Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassificiationSort = group.Add(new VocabularyKey("ClassificiationSort", "Classificiation Sort", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FaxNumber = group.Add(new VocabularyKey("FaxNumber", "Fax Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HoursPerWeek = group.Add(new VocabularyKey("HoursPerWeek", "Hours per Week", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobCode = group.Add(new VocabularyKey("JobCode", "Job Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobShare = group.Add(new VocabularyKey("JobShare", "Job Share", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationCode = group.Add(new VocabularyKey("LocationCode", "Location Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationCodeType = group.Add(new VocabularyKey("LocationCodeType", "Location Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManagerFlag = group.Add(new VocabularyKey("ManagerFlag", "Manager Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganisationUnitNumber = group.Add(new VocabularyKey("OrganisationUnitNumber", "Organisation Unit Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionFullTitle = group.Add(new VocabularyKey("PositionFullTitle", "Position Full Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionStatus = group.Add(new VocabularyKey("PositionStatus", "Position Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionTitle = group.Add(new VocabularyKey("PositionTitle", "Position Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionType = group.Add(new VocabularyKey("PositionType", "Position Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryCostCode = group.Add(new VocabularyKey("PrimaryCostCode", "Primary Cost Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportsToPosition = group.Add(new VocabularyKey("ReportsToPosition", "Reports to Position", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TelephoneNumber = group.Add(new VocabularyKey("TelephoneNumber", "Telephone Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey PositionNumber { get; private set; }
        public VocabularyKey AttendanceType { get; private set; }
        public VocabularyKey AttendanceTypeCode { get; private set; }
        public VocabularyKey Classification { get; private set; }
        public VocabularyKey ClassificiationSort { get; private set; }
        public VocabularyKey FaxNumber { get; private set; }
        public VocabularyKey HoursPerWeek { get; private set; }
        public VocabularyKey JobCode { get; private set; }
        public VocabularyKey JobShare { get; private set; }
        public VocabularyKey LocationCode { get; private set; }
        public VocabularyKey LocationCodeType { get; private set; }
        public VocabularyKey ManagerFlag { get; private set; }
        public VocabularyKey OrganisationUnitNumber { get; private set; }
        public VocabularyKey PositionFullTitle { get; private set; }
        public VocabularyKey PositionStatus { get; private set; }
        public VocabularyKey PositionTitle { get; private set; }
        public VocabularyKey PositionType { get; private set; }
        public VocabularyKey PrimaryCostCode { get; private set; }
        public VocabularyKey ReportsToPosition { get; private set; }
        public VocabularyKey TelephoneNumber { get; private set; }
    }
}
