using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Constants;

namespace CluedIn.Crawling.Sunwater.Vocabularies
{
    public class  OrganizationUnitCostingVocabulary : SimpleVocabulary
    {
        public  OrganizationUnitCostingVocabulary()
        {
            VocabularyName = "Sunwater OrganizationUnitCosting"; 
            KeyPrefix      = "sunwater.organizationunitcosting"; 
            KeySeparator   = ".";
            Grouping       = SunwaterEntities.OrganizationUnitCosting; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Sunwater OrganizationUnitCosting Details", group =>
            {
                TransactionNumber = group.Add(new VocabularyKey("TransactionNumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostCentre = group.Add(new VocabularyKey("CostCentre", "Cost Centre", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingCode2 = group.Add(new VocabularyKey("CostingCode2", "Costing Code 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingCode3 = group.Add(new VocabularyKey("CostingCode3", "Costing Code 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingCode4 = group.Add(new VocabularyKey("CostingCode4", "Costing Code 4", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingCode5 = group.Add(new VocabularyKey("CostingCode5", "Costing Code 5", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingCode6 = group.Add(new VocabularyKey("CostingCode6", "Costing Code 6", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingCode7 = group.Add(new VocabularyKey("CostingCode7", "Costing Code 7", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingCode8 = group.Add(new VocabularyKey("CostingCode8", "Costing Code 8", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganisationUnitNumber = group.Add(new VocabularyKey("OrganisationUnitNumber", "Organisation Unit Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey CostCentre { get; private set; }
        public VocabularyKey CostingCode2 { get; private set; }
        public VocabularyKey CostingCode3 { get; private set; }
        public VocabularyKey CostingCode4 { get; private set; }
        public VocabularyKey CostingCode5 { get; private set; }
        public VocabularyKey CostingCode6 { get; private set; }
        public VocabularyKey CostingCode7 { get; private set; }
        public VocabularyKey CostingCode8 { get; private set; }
        public VocabularyKey OrganisationUnitNumber { get; private set; }
    }
}
