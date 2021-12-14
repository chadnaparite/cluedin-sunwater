using Newtonsoft.Json;

namespace CluedIn.Crawling.Sunwater.Core.Models
{
    public class SAP 
    {
        public string BusinessUnit { get; set; }
        public string Region { get; set; }
        public string Office { get; set; }
        public string ServiceContract { get; set; }
        public string ProfitCenter { get; set; }
        public string CostCenter { get; set; }
        public string CostCentreDescription { get; set; }
        public string Employee { get; set; }
        public string ContractorsFte { get; set; }
        public string PermanentFte { get; set; }
        public string CasualFte { get; set; }
        public string FixedTermFte { get; set; }
    }
}
