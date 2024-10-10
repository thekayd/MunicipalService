using System;

namespace MunicipalServicesApp
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Event(string name, DateTime date, string category, string description)
        {
            Name = name;
            Date = date;
            Category = category;
            Description = description;
        }
    }
}