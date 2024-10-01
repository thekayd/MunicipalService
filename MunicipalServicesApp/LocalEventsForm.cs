using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        // Dictionary to store events with Date as the key
        SortedDictionary<DateTime, Event> eventsDict = new SortedDictionary<DateTime, Event>();
        Stack<Event> recentEvents = new Stack<Event>(); // Stack to manage recent events
        Queue<Event> eventQueue = new Queue<Event>(); // Queue to manage event scheduling
        HashSet<string> uniqueCategories = new HashSet<string>(); // Set for unique categories

        public LocalEventsForm()
        {
            InitializeComponent();
        }

        // Event class to store event details
        public class Event
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }

            public Event(string name, string category, string description, DateTime date)
            {
                Name = name;
                Category = category;
                Description = description;
                Date = date;
            }

            public override string ToString()
            {
                return $"{Date.ToString("d")}: {Name} - {Category}\nDescription: {Description}";
            }
        }

        // Method to handle event creation
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            string category = txtCategory.Text;
            string description = txtDescription.Text;
            DateTime eventDate = dtpEventDate.Value;

            Event newEvent = new Event(eventName, category, description, eventDate);

            // Add to sorted dictionary, stack, queue, and sets
            eventsDict[eventDate] = newEvent;
            recentEvents.Push(newEvent);
            eventQueue.Enqueue(newEvent);
            uniqueCategories.Add(category); // Adding unique category to the set

            // Clear input fields
            txtEventName.Clear();
            txtCategory.Clear();
            txtDescription.Clear();
            MessageBox.Show("Event added successfully!");
        }

        // Display all events sorted by date
        private void btnDisplayEvents_Click(object sender, EventArgs e)
        {
            lstEvents.Items.Clear();
            foreach (var eventPair in eventsDict)
            {
                lstEvents.Items.Add(eventPair.Value.ToString());
            }
        }

        // Search events by category
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstEvents.Items.Clear();
            string searchCategory = txtSearchCategory.Text;

            foreach (var eventPair in eventsDict)
            {
                if (eventPair.Value.Category.ToLower().Contains(searchCategory.ToLower()))
                {
                    lstEvents.Items.Add(eventPair.Value.ToString());
                }
            }
        }

        // Recommendation feature based on recent searches
        private void btnRecommendations_Click(object sender, EventArgs e)
        {
            lstEvents.Items.Clear();
            if (recentEvents.Count > 0)
            {
                var lastSearchedEvent = recentEvents.Peek(); // Get the last searched event
                lstEvents.Items.Add($"Recommended based on your last search:\n{lastSearchedEvent}");
            }
            else
            {
                lstEvents.Items.Add("No recommendations available.");
            }
        }
    }
}
