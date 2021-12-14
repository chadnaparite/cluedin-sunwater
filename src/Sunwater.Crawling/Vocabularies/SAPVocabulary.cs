using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Constants;

namespace CluedIn.Crawling.Sunwater.Vocabularies
{
    public class  SAPVocabulary : SimpleVocabulary
    {
        public  SAPVocabulary()
        {
            VocabularyName = "Sunwater SAP"; 
            KeyPrefix      = "sunwater.sap"; 
            KeySeparator   = ".";
            Grouping       = SunwaterEntities.SAP; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Sunwater SAP Details", group =>
            {
                BusinessUnit = group.Add(new VocabularyKey("BusinessUnit", "Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Region = group.Add(new VocabularyKey("Region", "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Office = group.Add(new VocabularyKey("Office", "Office", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceContract = group.Add(new VocabularyKey("ServiceContract", "Service Contract", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfitCenter = group.Add(new VocabularyKey("ProfitCenter", "Profit Center", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostCenter = group.Add(new VocabularyKey("CostCenter", "Cost Center", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostCentreDescription = group.Add(new VocabularyKey("CostCentreDescription", "Cost Centre Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Employee = group.Add(new VocabularyKey("Employee", "Employee", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractorsFte = group.Add(new VocabularyKey("ContractorsFte", "Contractors FTE", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PermanentFte = group.Add(new VocabularyKey("PermanentFte", "Permanent FTE", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CasualFte = group.Add(new VocabularyKey("CasualFte", "Casual FTE", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedTermFte = group.Add(new VocabularyKey("FixedTermFte", "Fixed Term FTE", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey BusinessUnit { get; private set; }
        public VocabularyKey Region { get; private set; }
        public VocabularyKey Office { get; private set; }
        public VocabularyKey ServiceContract { get; private set; }
        public VocabularyKey ProfitCenter { get; private set; }
        public VocabularyKey CostCenter { get; private set; }
        public VocabularyKey CostCentreDescription { get; private set; }
        public VocabularyKey Employee { get; private set; }
        public VocabularyKey ContractorsFte { get; private set; }
        public VocabularyKey PermanentFte { get; private set; }
        public VocabularyKey CasualFte { get; private set; }
        public VocabularyKey FixedTermFte { get; private set; }
    }
}
