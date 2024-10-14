using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp
{
    public class Manager
    {
        // Store all events
        private static List<Event> _events = new List<Event>();

        // Store events categorized by category and date
        private Dictionary<string, HashSet<Event>> _eventsByCategory;
        private SortedDictionary<DateTime, List<Event>> _eventsByDate;

        // Priority queue for upcoming events, sorted by event date
        private PriorityQueue<Event, DateTime> _upcomingEvents;

        // Stores unique categories of events
        private HashSet<string> _uniqueCategories; // Set for unique categories

        // Dictionary to track search terms and patterns for recommendations
        private Dictionary<string, int> _searchPatterns; // For tracking search patterns


        // Constructor: Initializes data structures and populates them with existing events
        public Manager()
        {
            _eventsByCategory = new Dictionary<string, HashSet<Event>>();
            _eventsByDate = new SortedDictionary<DateTime, List<Event>>();
            _upcomingEvents = new PriorityQueue<Event, DateTime>();
            _uniqueCategories = new HashSet<string>(); // Initializes the set
            _searchPatterns = new Dictionary<string, int>(); // Initializes search patterns

            // Populate other data structures with existing events based on the events list
            foreach (var ev in _events)
            {
                AddEventToDataStructures(ev);
            }
        }

        // Adds a new event to the system and updates the data structures
        public void AddEvent(Event newEvent)
        {
            _events.Add(newEvent);
            AddEventToDataStructures(newEvent);
        }

        // Helper method to add an event to all relevant data structures
        private void AddEventToDataStructures(Event newEvent)
        {
            // Adds event to category-based dictionary
            if (!_eventsByCategory.ContainsKey(newEvent.Category))
            {
                _eventsByCategory[newEvent.Category] = new HashSet<Event>();
            }
            _eventsByCategory[newEvent.Category].Add(newEvent);

            // Adds event to date-based dictionary
            if (!_eventsByDate.ContainsKey(newEvent.Date))
            {
                _eventsByDate[newEvent.Date] = new List<Event>();
            }
            _eventsByDate[newEvent.Date].Add(newEvent);

            // Enqueue event to the priority queue of upcoming events
            _upcomingEvents.Enqueue(newEvent, newEvent.Date);

            // Adds the event category to the set of unique categories
            _uniqueCategories.Add(newEvent.Category); // Adds category to the set
        }

        // Retrieves the list of all events
        public List<Event> GetEvents()
        {
            return _events;
        }

        // Searches for events by name/description, category, and date
        public List<Event> SearchEvents(string searchTerm, DateTime date, string category)
        {
            // Updates search pattern tracking for both search term and category
            UpdateSearchPattern(searchTerm);
            UpdateSearchPattern(category);

            // Initially returns all events, then filter based on criteria
            IEnumerable<Event> results = _events;

            // If no search term and all categories, filter by date only
            if (string.IsNullOrWhiteSpace(searchTerm) && category == "All Categories")
            {
                results = results.Where(e => e.Date >= date);
                return results.ToList();
            }

            // Filters by search term if provided
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                results = results.Where(e => e.Name.ToLower().Contains(searchTerm) || e.Description.ToLower().Contains(searchTerm));
            }

            // Filters by category if not 'All Categories'
            if (category != "All Categories")
            {
                results = results.Where(e => e.Category == category);
            }

            // Filters by event date
            results = results.Where(e => e.Date >= date);

            return results.ToList();
        }

        // Tracks and updates search patterns for recommendations
        private void UpdateSearchPattern(string term)
        {
            if (!string.IsNullOrWhiteSpace(term))
            {
                term = term.ToLower();
                if (_searchPatterns.ContainsKey(term))
                {
                    _searchPatterns[term]++;
                }
                else
                {
                    _searchPatterns[term] = 1;
                }
            }
        }

        // Generates event recommendations based on search patterns and history
        public List<Event> GetRecommendations(List<string> searchHistory)
        {
            var recommendedEvents = new HashSet<Event>();

            // Uses search patterns for smarter recommendations
            // Gets the top 5 most frequent search patterns
            var topSearchPatterns = _searchPatterns.OrderByDescending(x => x.Value).Take(5).Select(x => x.Key);

            foreach (var pattern in topSearchPatterns)
            {
                var relatedEvents = _events.Where(e =>
                    e.Name.ToLower().Contains(pattern) ||
                    e.Description.ToLower().Contains(pattern) ||
                    e.Category.ToLower().Contains(pattern))
                    .Take(2);

                foreach (var ev in relatedEvents)
                {
                    recommendedEvents.Add(ev);
                }
            }

            // If we don't have enough recommendations, If fewer than 5 recommendations, add some based on search history
            if (recommendedEvents.Count < 5)
            {
                foreach (var searchTerm in searchHistory)
                {
                    var relatedEvents = _events.Where(e =>
                        e.Name.ToLower().Contains(searchTerm.ToLower()) ||
                        e.Description.ToLower().Contains(searchTerm.ToLower()) ||
                        e.Category.ToLower().Contains(searchTerm.ToLower()))
                        .Take(2);

                    foreach (var ev in relatedEvents)
                    {
                        recommendedEvents.Add(ev);
                        if (recommendedEvents.Count >= 5) break;
                    }
                    if (recommendedEvents.Count >= 5) break;
                }
            }

            // Returns the top 5 recommended events
            return recommendedEvents.Take(5).ToList();
        }

        // Retrieves a list of upcoming events based on a specified count
        private List<Event> GetUpcomingEvents(int count)
        {
            var upcomingEvents = new List<Event>();
            var tempQueue = new PriorityQueue<Event, DateTime>();

            // Copy items  from the original queue to the temporary queue
            foreach (var item in _upcomingEvents.UnorderedItems)
            {
                tempQueue.Enqueue(item.Element, item.Priority);
            }

            // Dequeue events up to the specified count
            while (upcomingEvents.Count < count && tempQueue.Count > 0)
            {
                upcomingEvents.Add(tempQueue.Dequeue());
            }

            return upcomingEvents;
        }

        // Returns the list of unique event categories
        public List<string> GetCategories()
        {
            return _uniqueCategories.ToList(); // Uses the set to return unique categories
        }
    }
}