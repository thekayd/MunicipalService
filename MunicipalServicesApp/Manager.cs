using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp
{
    public class Manager
    {
        private static List<Event> _events = new List<Event>(); // Changed to static
        private Dictionary<string, HashSet<Event>> _eventsByCategory;
        private SortedDictionary<DateTime, List<Event>> _eventsByDate;
        private PriorityQueue<Event, DateTime> _upcomingEvents;

        public Manager()
        {
            _eventsByCategory = new Dictionary<string, HashSet<Event>>();
            _eventsByDate = new SortedDictionary<DateTime, List<Event>>();
            _upcomingEvents = new PriorityQueue<Event, DateTime>();

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
        }

        public List<Event> GetEvents()
        {
            return _events;
        }

        public List<Event> SearchEvents(string searchTerm, DateTime date, string category)
        {
            IEnumerable<Event> results = _events;

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

        public List<Event> GetRecommendations(List<string> searchHistory)
        {
            if (searchHistory.Count == 0)
            {
                return GetUpcomingEvents(5);
            }

            var recommendedEvents = new HashSet<Event>();
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
            return _eventsByCategory.Keys.ToList();
        }
    }
}