using Newtonsoft.Json;

namespace CluedIn.Crawling.Sunwater.Core.Models
{
    public class Extract 
    {
        public string Company { get; set; }
        public string Division { get; set; }
        public string Region { get; set; }
        public string Location { get; set; }
        public string Site { get; set; }
        public string FirstName { get; set; }
        public string LatName { get; set; }
        public string Username { get; set; }
        public string EmployeeId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SsoUser { get; set; }
        public string Password { get; set; }
        public string RetypePassword { get; set; }
        public string LoginRequired {get; set;}
        public string Affiliation { get; set; }
        public string Archived { get; set; }
        public string Occupation { get; set; }
        public string SecondaryOccupation { get; set; }
        public string Groups { get; set; }
        public string Locale { get; set; }
        public string Manager { get; set; }
    }
}
