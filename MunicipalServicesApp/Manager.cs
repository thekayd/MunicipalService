using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp
{
    public class Manager
    {
        private static List<Event> _events = new List<Event>();
        private Dictionary<string, HashSet<Event>> _eventsByCategory;
        private SortedDictionary<DateTime, List<Event>> _eventsByDate;
        private PriorityQueue<Event, DateTime> _upcomingEvents;
        private HashSet<string> _uniqueCategories; // New: Set for unique categories
        private Dictionary<string, int> _searchPatterns; // New: For tracking search patterns

        public Manager()
        {
            _eventsByCategory = new Dictionary<string, HashSet<Event>>();
            _eventsByDate = new SortedDictionary<DateTime, List<Event>>();
            _upcomingEvents = new PriorityQueue<Event, DateTime>();
            _uniqueCategories = new HashSet<string>(); // Initialize the set
            _searchPatterns = new Dictionary<string, int>(); // Initialize search patterns

            // Populate other data structures with existing events
            foreach (var ev in _events)
            {
                AddEventToDataStructures(ev);
            }
        }

        public void AddEvent(Event newEvent)
        {
            _events.Add(newEvent);
            AddEventToDataStructures(newEvent);
        }

        private void AddEventToDataStructures(Event newEvent)
        {
            if (!_eventsByCategory.ContainsKey(newEvent.Category))
            {
                _eventsByCategory[newEvent.Category] = new HashSet<Event>();
            }
            _eventsByCategory[newEvent.Category].Add(newEvent);

            if (!_eventsByDate.ContainsKey(newEvent.Date))
            {
                _eventsByDate[newEvent.Date] = new List<Event>();
            }
            _eventsByDate[newEvent.Date].Add(newEvent);

            _upcomingEvents.Enqueue(newEvent, newEvent.Date);

            _uniqueCategories.Add(newEvent.Category); // Add category to the set
        }

        public List<Event> GetEvents()
        {
            return _events;
        }

        public List<Event> SearchEvents(string searchTerm, DateTime date, string category)
        {
            // Update search patterns
            UpdateSearchPattern(searchTerm);
            UpdateSearchPattern(category);

            IEnumerable<Event> results = _events;

            if (string.IsNullOrWhiteSpace(searchTerm) && category == "All Categories")
            {
                results = results.Where(e => e.Date >= date);
                return results.ToList();
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                results = results.Where(e => e.Name.ToLower().Contains(searchTerm) || e.Description.ToLower().Contains(searchTerm));
            }

            if (category != "All Categories")
            {
                results = results.Where(e => e.Category == category);
            }

            results = results.Where(e => e.Date >= date);

            return results.ToList();
        }

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

        public List<Event> GetRecommendations(List<string> searchHistory)
        {
            var recommendedEvents = new HashSet<Event>();

            // Use search patterns for smarter recommendations
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

            // If we don't have enough recommendations, add some based on search history
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

            return recommendedEvents.Take(5).ToList();
        }

        private List<Event> GetUpcomingEvents(int count)
        {
            var upcomingEvents = new List<Event>();
            var tempQueue = new PriorityQueue<Event, DateTime>();

            // Copy elements from the original queue to the temporary queue
            foreach (var item in _upcomingEvents.UnorderedItems)
            {
                tempQueue.Enqueue(item.Element, item.Priority);
            }

            while (upcomingEvents.Count < count && tempQueue.Count > 0)
            {
                upcomingEvents.Add(tempQueue.Dequeue());
            }

            return upcomingEvents;
        }

        public List<string> GetCategories()
        {
            return _uniqueCategories.ToList(); // Use the set to return unique categories
        }
    }
}