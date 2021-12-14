using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sunwater.Vocabularies
{
    public class  PersonVocabulary : SimpleVocabulary
    {
        public  PersonVocabulary()
        {
            VocabularyName = "Sunwater Person"; 
            KeyPrefix      = "sunwater.person"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Person; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Sunwater Person Details", group =>
            {
                WamiKey = group.Add(new VocabularyKey("WamiKey", "Wami Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarCode = group.Add(new VocabularyKey("BarCode", "Bar Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarDpid = group.Add(new VocabularyKey("BarDpid", "Bar DPID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrithdayMonthDay = group.Add(new VocabularyKey("BrithdayMonthDay", "Brithday Month Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoCodeType1 = group.Add(new VocabularyKey("CoCodeType1", "CO Code Type 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoCodeType2 = group.Add(new VocabularyKey("CoCodeType2", "CO Code Type 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryCode = group.Add(new VocabularyKey("CountryCode", "Country Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfBirth = group.Add(new VocabularyKey("DateOfBirth", "Date of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfBirthDocumentCode = group.Add(new VocabularyKey("DateOfBirthDocumentCode", "Date of Birth Document Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DbCodeType = group.Add(new VocabularyKey("DbCodeType", "DB Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailAddress = group.Add(new VocabularyKey("EmailAddress", "Email Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailSearch = group.Add(new VocabularyKey("EmailSearch", "Email Search", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalEmployeeNumber = group.Add(new VocabularyKey("ExternalEmployeeNumber", "External Employee Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullName = group.Add(new VocabularyKey("FullName", "Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gender = group.Add(new VocabularyKey("Gender", "Gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GivenNames = group.Add(new VocabularyKey("GivenNames", "Given Names", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HideMobileDeprecated = group.Add(new VocabularyKey("HideMobileDeprecated", "Hide Mobile (Deprecated)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Initials = group.Add(new VocabularyKey("Initials", "Initials", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnownAs = group.Add(new VocabularyKey("KnownAs", "Known As", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnownAsSearch = group.Add(new VocabularyKey("KnownAsSearch", "Known As Search", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey("Name", "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameChangeCode = group.Add(new VocabularyKey("NameChangeCode", "Name Change code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameForHeadingsFormat = group.Add(new VocabularyKey("NameForHeadingsFormat", "Name for headings format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NcCodeType = group.Add(new VocabularyKey("NcCodeType", "NC Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganisationName = group.Add(new VocabularyKey("OrganisationName", "Organisation Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipantFlag = group.Add(new VocabularyKey("ParticipantFlag", "Participant Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonalMobile = group.Add(new VocabularyKey("PersonalMobile", "Personal Mobile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonalPhone = group.Add(new VocabularyKey("PersonalPhone", "Personal Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalAddressHome = group.Add(new VocabularyKey("PostalAddressHome", "Postal Address = Home", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCountryCode = group.Add(new VocabularyKey("PostalCountryCode", "Postal Country Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalLetterAddress = group.Add(new VocabularyKey("PostalLetterAddress", "Postal Letter Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalPostcode = group.Add(new VocabularyKey("PostalPostcode", "Postal Postcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalState = group.Add(new VocabularyKey("PostalState", "Postal State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalSteetAddress = group.Add(new VocabularyKey("PostalSteetAddress", "Postal Steet Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalSuburb = group.Add(new VocabularyKey("PostalSuburb", "Postal Suburb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Postcode = group.Add(new VocabularyKey("Postcode", "Postcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredNameSarch = group.Add(new VocabularyKey("PreferredNameSarch", "Preferred Name Sarch", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredNames = group.Add(new VocabularyKey("PreferredNames", "Preferred Names", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PresenterFlag = group.Add(new VocabularyKey("PresenterFlag", "Presenter Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorSurname = group.Add(new VocabularyKey("PriorSurname", "Prior Surname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Salutation = group.Add(new VocabularyKey("Salutation", "Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey("State", "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetAddress = group.Add(new VocabularyKey("StreetAddress", "Street Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Suburb = group.Add(new VocabularyKey("Suburb", "Suburb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Surname = group.Add(new VocabularyKey("Surname", "Surname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SurnameForLetters = group.Add(new VocabularyKey("SurnameForLetters", "Surname For Letters", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SurnamePhoneticSearch = group.Add(new VocabularyKey("SurnamePhoneticSearch", "Surname Phonetic Search", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TfnDueDate = group.Add(new VocabularyKey("TfnDueDate", "TFN Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WamiType = group.Add(new VocabularyKey("WamiType", "Wami Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkFax = group.Add(new VocabularyKey("WorkFax", "Work Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkMobile = group.Add(new VocabularyKey("WorkMobile", "Work Mobile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPhone = group.Add(new VocabularyKey("WorkPhone", "Work Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey WamiKey { get; private set; }
        public VocabularyKey BarCode { get; private set; }
        public VocabularyKey BarDpid { get; private set; }
        public VocabularyKey BrithdayMonthDay { get; private set; }
        public VocabularyKey CoCodeType1 { get; private set; }
        public VocabularyKey CoCodeType2 { get; private set; }
        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey DateOfBirth { get; private set; }
        public VocabularyKey DateOfBirthDocumentCode { get; private set; }
        public VocabularyKey DbCodeType { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey EmailSearch { get; private set; }
        public VocabularyKey ExternalEmployeeNumber { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey GivenNames { get; private set; }
        public VocabularyKey HideMobileDeprecated { get; private set; }
        public VocabularyKey Initials { get; private set; }
        public VocabularyKey KnownAs { get; private set; }
        public VocabularyKey KnownAsSearch { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NameChangeCode { get; private set; }
        public VocabularyKey NameForHeadingsFormat { get; private set; }
        public VocabularyKey NcCodeType { get; private set; }
        public VocabularyKey OrganisationName { get; private set; }
        public VocabularyKey ParticipantFlag { get; private set; }
        public VocabularyKey PersonalMobile { get; private set; }
        public VocabularyKey PersonalPhone { get; private set; }
        public VocabularyKey PostalAddressHome { get; private set; }
        public VocabularyKey PostalCountryCode { get; private set; }
        public VocabularyKey PostalLetterAddress { get; private set; }
        public VocabularyKey PostalPostcode { get; private set; }
        public VocabularyKey PostalState { get; private set; }
        public VocabularyKey PostalSteetAddress { get; private set; }
        public VocabularyKey PostalSuburb { get; private set; }
        public VocabularyKey Postcode { get; private set; }
        public VocabularyKey PreferredNameSarch { get; private set; }
        public VocabularyKey PreferredNames { get; private set; }
        public VocabularyKey PresenterFlag { get; private set; }
        public VocabularyKey PriorSurname { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey StreetAddress { get; private set; }
        public VocabularyKey Suburb { get; private set; }
        public VocabularyKey Surname { get; private set; }
        public VocabularyKey SurnameForLetters { get; private set; }
        public VocabularyKey SurnamePhoneticSearch { get; private set; }
        public VocabularyKey TfnDueDate { get; private set; }
        public VocabularyKey WamiType { get; private set; }
        public VocabularyKey WorkFax { get; private set; }
        public VocabularyKey WorkMobile { get; private set; }
        public VocabularyKey WorkPhone { get; private set; }
    }
}
