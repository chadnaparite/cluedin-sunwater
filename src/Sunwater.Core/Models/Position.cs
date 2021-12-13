using Newtonsoft.Json;

namespace CluedIn.Crawling.Sunwater.Core.Models
{
    public class Position 
    {
        public string PositionNumber {get; set;}
        public string AttendanceType { get; set; }
        public string AttendanceTypeCode { get; set; }
        public string Classification { get; set; }
        public string ClassificiationSort { get; set; }
        public string FaxNumber { get; set; }
        public string HoursPerWeek { get; set; }
        public string JobCode { get; set; }
        public string JobShare { get; set; }
        public string LocationCode { get; set; }
        public string LocationCodeType { get; set; }
        public string ManagerFlag { get; set; }
        public string OrganisationUnitNumber { get; set; }
        public string PositionFullTitle { get; set; }
        public string PositionStatus { get; set; }
        public string PositionTitle { get; set; }
        public string PositionType { get; set; }
        public string PrimaryCostCode { get; set; }
        public string ReportsToPosition { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
