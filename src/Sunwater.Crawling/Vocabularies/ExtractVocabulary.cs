using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Sunwater.Core.Constants;

namespace CluedIn.Crawling.Sunwater.Vocabularies
{
    public class  ExtractVocabulary : SimpleVocabulary
    {
        public  ExtractVocabulary()
        {
            VocabularyName = "Sunwater Extract"; 
            KeyPrefix      = "sunwater.extract"; 
            KeySeparator   = ".";
            Grouping       = SunwaterEntities.Extract; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Sunwater Extract Details", group =>
            {
                Company = group.Add(new VocabularyKey("Company", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Division = group.Add(new VocabularyKey("Division", "Division", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Region = group.Add(new VocabularyKey("Region", "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey("Location", "Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Site = group.Add(new VocabularyKey("Site", "Site", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey("FirstName", "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LatName = group.Add(new VocabularyKey("LatName", "Lat Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Username = group.Add(new VocabularyKey("Username", "Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeId = group.Add(new VocabularyKey("EmployeeId", "Employee ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey("Email", "Email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey("Phone", "Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SsoUser = group.Add(new VocabularyKey("SsoUser", "SSO User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Password = group.Add(new VocabularyKey("Password", "Password", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetypePassword = group.Add(new VocabularyKey("RetypePassword", "Retype Password", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoginRequired = group.Add(new VocabularyKey("LoginRequired", "Login Required?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Affiliation = group.Add(new VocabularyKey("Affiliation", "Affiliation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Archived = group.Add(new VocabularyKey("Archived", "Archived", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Occupation = group.Add(new VocabularyKey("Occupation", "Occupation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryOccupation = group.Add(new VocabularyKey("SecondaryOccupation", "Secondary Occupation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtractGroups = group.Add(new VocabularyKey("Groups", "Groups", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Locale = group.Add(new VocabularyKey("Locale", "Locale", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Manager = group.Add(new VocabularyKey("Manager", "Manager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey Company { get; private set; }
        public VocabularyKey Division { get; private set; }
        public VocabularyKey Region { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey Site { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey LatName { get; private set; }
        public VocabularyKey Username { get; private set; }
        public VocabularyKey EmployeeId { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey SsoUser { get; private set; }
        public VocabularyKey Password { get; private set; }
        public VocabularyKey RetypePassword { get; private set; }
        public VocabularyKey LoginRequired { get; private set; }
        public VocabularyKey Affiliation { get; private set; }
        public VocabularyKey Archived { get; private set; }
        public VocabularyKey Occupation { get; private set; }
        public VocabularyKey SecondaryOccupation { get; private set; }
        public VocabularyKey ExtractGroups { get; private set; }
        public VocabularyKey Locale { get; private set; }
        public VocabularyKey Manager { get; private set; }
    }
}
