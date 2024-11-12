using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        // Manager class handles event management
        private static Manager _manager;
        private Queue<string> _searchHistory;
        private const int MAX_SEARCH_HISTORY = 10;

        public LocalEventsForm()
        {
            InitializeComponent();
            // Initializes manager and hardcode events only if _manager is null
            if (_manager == null)
            {
                _manager = new Manager();
                AddHardCodedEvents();
            }
            // Initialize the search history queue
            _searchHistory = new Queue<string>();
            PopulateEventList(); // Load events into the ListView
            PopulateCategoryComboBox(); // Populate category dropdown
            StyleControls(); // Apply custom styling to controls
        }

        // Adds predefined events to the manager
        private void AddHardCodedEvents()
        {
            _manager.AddEvent(new Event("Community Cleanup", DateTime.Now.AddDays(7), "Environment", "Join us for a community-wide cleanup event!"));
            _manager.AddEvent(new Event("Local Art Exhibition", DateTime.Now.AddDays(14), "Culture", "Showcasing artwork from local artists."));
            _manager.AddEvent(new Event("Town Hall Meeting", DateTime.Now.AddDays(21), "Government", "Discussing upcoming city projects and initiatives."));
            _manager.AddEvent(new Event("Youth Sports Festival", DateTime.Now.AddDays(10), "Sports", "A day filled with fun sports activities for all ages."));
            _manager.AddEvent(new Event("Music in the Park", DateTime.Now.AddDays(30), "Entertainment", "Enjoy live performances by local bands."));
         
        }

        // Applies custom styles to all controls on the form
        private void StyleControls()
        {
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Style individual controls like buttons, list views
            StyleButton(buttonSearch);
           // StyleButton(buttonCreateEvent);
            StyleButton(btnBackToMainMenu);

            StyleListView(listViewEvents);
            StyleTextBox(textBoxSearch);
            StyleTextBox(textBoxEventDetails);
            StyleComboBox(comboBoxCategory);
            StyleDateTimePicker(dateTimePickerSearch);
            StyleListBox(listBoxRecommendations);
            StyleLabel(labelEventDetails);
            StyleLabel(labelRecommendations);

            CenterControls(); // Centers key controls within the form
        }

        // Custom style for buttons
        private void StyleButton(Button button)
        {
            button.BackColor = Color.FromArgb(0, 120, 215);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button.Padding = new Padding(10, 5, 10, 5);
        }

        private void StyleListView(ListView listView)
        {
            listView.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.BorderStyle = BorderStyle.None;
        }

        private void StyleTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StyleComboBox(ComboBox comboBox)
        {
            comboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox.FlatStyle = FlatStyle.Flat;
        }

        private void StyleDateTimePicker(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void StyleListBox(ListBox listBox)
        {
            listBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StyleLabel(Label label)
        {
            label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.FromArgb(0, 120, 215);
        }

        private void CenterControls()
        {
            int centerX = (ClientSize.Width - listViewEvents.Width) / 2;
            listViewEvents.Location = new Point(centerX, listViewEvents.Location.Y);

            labelEventDetails.Location = new Point(centerX, labelEventDetails.Location.Y);
            textBoxEventDetails.Location = new Point(centerX, textBoxEventDetails.Location.Y);

            labelRecommendations.Location = new Point(centerX, labelRecommendations.Location.Y);
            listBoxRecommendations.Location = new Point(centerX, listBoxRecommendations.Location.Y);

            int searchControlsY = panelHeader.Bottom + 20;
            labelEventName.Location = new Point(centerX, searchControlsY + 5);
            textBoxSearch.Location = new Point(labelEventName.Right + 10, searchControlsY);
            dateTimePickerSearch.Location = new Point(textBoxSearch.Right + 10, searchControlsY);
            comboBoxCategory.Location = new Point(dateTimePickerSearch.Right + 10, searchControlsY);

            buttonSearch.Location = new Point((ClientSize.Width - buttonSearch.Width) / 2, searchControlsY + textBoxSearch.Height + 10);

          //  int bottomButtonsY = ClientSize.Height - buttonCreateEvent.Height - 20;
          //  buttonCreateEvent.Location = new Point(centerX, bottomButtonsY);
          //  btnBackToMainMenu.Location = new Point(buttonCreateEvent.Right + 10, bottomButtonsY);
        }

        // Populates the ListView with all events from the manager
        private void PopulateEventList()
        {
            listViewEvents.Items.Clear();
            List<Event> events = _manager.GetEvents();
            foreach (var ev in events)
            {
                ListViewItem item = new ListViewItem(ev.Name);
                item.SubItems.Add(ev.Date.ToShortDateString()); // Add event date as a sub-item
                item.SubItems.Add(ev.Category); // Add event category as a sub-item
                item.Tag = ev; // Store event object in Tag for future use
                listViewEvents.Items.Add(item);
            }
        }

        // Populates the category dropdown with event categories
        private void PopulateCategoryComboBox()
        {
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.Add("All Categories"); // Default category option
            var categories = _manager.GetCategories();
            foreach (var category in categories)
            {
                comboBoxCategory.Items.Add(category); // Add all available categories
            }
            comboBoxCategory.SelectedIndex = 0;  // Set default selection to 'All Categories'
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCategoryBasedRecommendations(); 
        }

        private void ShowCategoryBasedRecommendations()
        {
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();
            List<Event> recommendations;

            if (selectedCategory == "All Categories")
            {
                recommendations = _manager.GetRecommendations(_searchHistory.ToList());
            }
            else
            {
                recommendations = GetCategoryBasedRecommendations(selectedCategory);
            }

            listBoxRecommendations.Items.Clear();
            foreach (var recommendation in recommendations)
            {
                listBoxRecommendations.Items.Add(recommendation.Name);
            }
        }

        private List<Event> GetCategoryBasedRecommendations(string category)
        {
            var allEvents = _manager.GetEvents();
            return allEvents
                .Where(e => e.Category == category)
                .OrderBy(e => e.Date)
                .Take(5)
                .ToList();
        }

        // Updates the search results and recommendations when search button is clicked
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();
            DateTime searchDate = dateTimePickerSearch.Value.Date;
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();

            // Search for events based on input criteria
            List<Event> searchResults = _manager.SearchEvents(searchTerm, searchDate, selectedCategory);

            DisplaySearchResults(searchResults); // Display found events in ListView
            UpdateSearchHistory(searchTerm); // Update search history with the new term
            ShowRecommendations();  // Display event recommendations based on history
            ShowCategoryBasedRecommendations(); // Update recommendations for selected category
        }

        // Displays the search results in the ListView
        private void DisplaySearchResults(List<Event> events)
        {
            listViewEvents.Items.Clear();
            foreach (var ev in events)
            {
                ListViewItem item = new ListViewItem(ev.Name);
                item.SubItems.Add(ev.Date.ToShortDateString()); // Add date sub-item
                item.SubItems.Add(ev.Category); // Add category sub-item
                item.Tag = ev; // Store the event object in Tag
                listViewEvents.Items.Add(item);
            }

            if (events.Count > 0)
            {
                if (events.Count == 1)
                {
                    // Display details of the single event
                    Event ev = events[0];
                    textBoxEventDetails.Text = $"Name: {ev.Name}\r\n" +
                                               $"Date: {ev.Date.ToShortDateString()}\r\n" +
                                               $"Category: {ev.Category}\r\n" +
                                               $"Description: {ev.Description}";
                }
                else
                {
                    // Display a summary of all events
                    textBoxEventDetails.Text = $"Found {events.Count} events:\r\n\r\n" +
                        string.Join("\r\n", events.Select(ev => $"- {ev.Name} ({ev.Date.ToShortDateString()})"));
                }
            }
            else
            {
                textBoxEventDetails.Text = "No events found matching the search criteria.";
            }
        }

        // Updates the search history queue
        private void UpdateSearchHistory(string searchTerm)
        {
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                if (_searchHistory.Count >= MAX_SEARCH_HISTORY)
                {
                    _searchHistory.Dequeue(); // Remove oldest search term if history exceeds the limit
                }
                _searchHistory.Enqueue(searchTerm); // Add new search term to history
            }
        }

        // Displays event recommendations based on search history
        private void ShowRecommendations()
        {
            var recommendations = _manager.GetRecommendations(_searchHistory.ToList());
            listBoxRecommendations.Items.Clear();
            foreach (var recommendation in recommendations)
            {
                listBoxRecommendations.Items.Add(recommendation.Name); // Show recommended event names
            }
        }

        private void listViewEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count > 0)
            {
                Event selectedEvent = (Event)listViewEvents.SelectedItems[0].Tag;
                textBoxEventDetails.Text = $"Name: {selectedEvent.Name}\r\n" +
                                           $"Date: {selectedEvent.Date.ToShortDateString()}\r\n" +
                                           $"Category: {selectedEvent.Category}\r\n" +
                                           $"Description: {selectedEvent.Description}";
            }
            else
            {
                textBoxEventDetails.Text = string.Empty;
            }
        }

        // Opens the EventCreateForm to allow users to create a new event
        //private void buttonCreateEvent_Click(object sender, EventArgs e)
        //{
        //    EventCreateForm createForm = new EventCreateForm(_manager);
        //    createForm.FormClosed += (s, args) =>
        //    {
        //        this.Show();
        //        PopulateEventList(); // Refreshes event list after new event creation
        //        PopulateCategoryComboBox(); // Refreshes categories
        //    };
        //    createForm.Show();
        //    this.Hide();
        //}

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
            this.Hide();
        }

        // Handles form closing behavior, ensures the app exits cleanly when the form is closed
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void LocalEventsForm_Load(object sender, EventArgs e)
        {
            // This method is intentionally left empty
        }
    }
}