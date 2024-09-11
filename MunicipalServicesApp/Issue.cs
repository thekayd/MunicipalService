namespace MunicipalServicesApp
{
    //constructor for location, category, description and attachment
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }

        // Parameterless constructor
        public Issue() { }

         // the constructor with parameters 
        public Issue(string location, string category, string description, string attachment)
        {
            Location = location;
            Category = category;
            Description = description;
            Attachment = attachment;
        }

        //string override for the detailing of string in list box
        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}\nAttachment: {Attachment}";
        }
    }
}