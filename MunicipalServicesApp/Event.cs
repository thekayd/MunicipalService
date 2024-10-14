using System;

namespace MunicipalServicesApp
{
    public class Event
    {
        // Properties to store event information: name, date, category, and description
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        // Constructor to initialize a new Event with given details
        public Event(string name, DateTime date, string category, string description)
        {
            Name = name;
            Date = date;
            Category = category;
            Description = description;
        }
    }
}