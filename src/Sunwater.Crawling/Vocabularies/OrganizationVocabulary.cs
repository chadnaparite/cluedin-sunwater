using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sunwater.Vocabularies
{
    public class  OrganizationVocabulary : SimpleVocabulary
    {
        public  OrganizationVocabulary()
        {
            VocabularyName = "Sunwater Organization"; 
            KeyPrefix      = "sunwater.organization"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Organization; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Sunwater Organization Details", group =>
            {
                OrganizationUnitNumber = group.Add(new VocabularyKey("OrganizationUnitNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationCode = group.Add(new VocabularyKey("LocationCode", "Location Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationCodeType = group.Add(new VocabularyKey("LocationCodeType", "Location Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationBusinessUnit = group.Add(new VocabularyKey("OrganizationBusinessUnit", "Organization Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnit = group.Add(new VocabularyKey("OrganizationUnit", "Organization Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitDescription = group.Add(new VocabularyKey("OrganizationUnitDescription", "Organization Unit Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel01 = group.Add(new VocabularyKey("OrganizationUnitLevel01", "Organization Unit Level 01", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel02 = group.Add(new VocabularyKey("OrganizationUnitLevel02", "Organization Unit Level 02", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel03 = group.Add(new VocabularyKey("OrganizationUnitLevel03", "Organization Unit Level 03", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel04 = group.Add(new VocabularyKey("OrganizationUnitLevel04", "Organization Unit Level 04", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel05 = group.Add(new VocabularyKey("OrganizationUnitLevel05", "Organization Unit Level 05", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel06 = group.Add(new VocabularyKey("OrganizationUnitLevel06", "Organization Unit Level 06", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel07 = group.Add(new VocabularyKey("OrganizationUnitLevel07", "Organization Unit Level 07", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel08 = group.Add(new VocabularyKey("OrganizationUnitLevel08", "Organization Unit Level 08", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel09 = group.Add(new VocabularyKey("OrganizationUnitLevel09", "Organization Unit Level 09", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitLevel10 = group.Add(new VocabularyKey("OrganizationUnitLevel10", "Organization Unit Level 10", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationUnitStatus = group.Add(new VocabularyKey("OrganizationUnitStatus", "Organization Unit Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryCostCode = group.Add(new VocabularyKey("PrimaryCostCode", "Primary Cost Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeniorEmployeeNumber = group.Add(new VocabularyKey("SeniorEmployeeNumber", "Senior Employee Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SupervisorUserId = group.Add(new VocabularyKey("SupervisorUserId", "Supervisor User ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }
        
        public VocabularyKey OrganizationUnitNumber { get; private set; }
        public VocabularyKey LocationCode { get; private set; }
        public VocabularyKey LocationCodeType { get; private set; }
        public VocabularyKey OrganizationBusinessUnit { get; private set; }
        public VocabularyKey OrganizationUnit { get; private set; }
        public VocabularyKey OrganizationUnitDescription { get; private set; }
        public VocabularyKey OrganizationUnitLevel01 { get; private set; }
        public VocabularyKey OrganizationUnitLevel02 { get; private set; }
        public VocabularyKey OrganizationUnitLevel03 { get; private set; }
        public VocabularyKey OrganizationUnitLevel04 { get; private set; }
        public VocabularyKey OrganizationUnitLevel05 { get; private set; }
        public VocabularyKey OrganizationUnitLevel06 { get; private set; }
        public VocabularyKey OrganizationUnitLevel07 { get; private set; }
        public VocabularyKey OrganizationUnitLevel08 { get; private set; }
        public VocabularyKey OrganizationUnitLevel09 { get; private set; }
        public VocabularyKey OrganizationUnitLevel10 { get; private set; }
        public VocabularyKey OrganizationUnitStatus { get; private set; }
        public VocabularyKey PrimaryCostCode { get; private set; }
        public VocabularyKey SeniorEmployeeNumber { get; private set; }
        public VocabularyKey SupervisorUserId { get; private set; }
    }
}
