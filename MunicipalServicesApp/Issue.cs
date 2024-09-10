namespace MunicipalServicesApp
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }

        // Parameterless constructor
        public Issue() { }

        // Optional: You can still keep the constructor with parameters if needed
        public Issue(string location, string category, string description, string attachment)
        {
            Location = location;
            Category = category;
            Description = description;
            Attachment = attachment;
        }

        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}\nAttachment: {Attachment}";
        }
    }
}