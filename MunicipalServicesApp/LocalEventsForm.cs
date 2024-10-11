using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        private Manager _manager;
        private Queue<string> _searchHistory;
        private const int MAX_SEARCH_HISTORY = 10;

        public LocalEventsForm()
        {
            InitializeComponent();
            _manager = new Manager();
            _searchHistory = new Queue<string>();
            PopulateEventList();
            PopulateCategoryComboBox();
        }

        private void PopulateEventList()
        {
            listViewEvents.Items.Clear();
            List<Event> events = _manager.GetEvents();
            foreach (var ev in events)
            {
                ListViewItem item = new ListViewItem(ev.Name);
                item.SubItems.Add(ev.Date.ToShortDateString());
                item.SubItems.Add(ev.Category);
                item.Tag = ev;
                listViewEvents.Items.Add(item);
            }
        }

        private void PopulateCategoryComboBox()
        {
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.Add("All Categories");
            var categories = _manager.GetCategories();
            foreach (var category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }
            comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();
            DateTime searchDate = dateTimePickerSearch.Value.Date;
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();

            List<Event> searchResults = _manager.SearchEvents(searchTerm, searchDate, selectedCategory);

            DisplaySearchResults(searchResults);
            UpdateSearchHistory(searchTerm);
            ShowRecommendations();
        }

        private void DisplaySearchResults(List<Event> events)
        {
            listViewEvents.Items.Clear();
            foreach (var ev in events)
            {
                ListViewItem item = new ListViewItem(ev.Name);
                item.SubItems.Add(ev.Date.ToShortDateString());
                item.SubItems.Add(ev.Category);
                item.Tag = ev;
                listViewEvents.Items.Add(item);
            }
        }

        private void UpdateSearchHistory(string searchTerm)
        {
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                if (_searchHistory.Count >= MAX_SEARCH_HISTORY)
                {
                    _searchHistory.Dequeue();
                }
                _searchHistory.Enqueue(searchTerm);
            }
        }

        private void ShowRecommendations()
        {
            var recommendations = _manager.GetRecommendations(_searchHistory.ToList());
            listBoxRecommendations.Items.Clear();
            foreach (var recommendation in recommendations)
            {
                listBoxRecommendations.Items.Add(recommendation.Name);
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

        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            EventCreateForm createForm = new EventCreateForm(_manager);
            createForm.FormClosed += (s, args) =>
            {
                this.Show();
                PopulateEventList();
                PopulateCategoryComboBox();
            };
            createForm.Show();
            this.Hide();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
            this.Hide();
        }

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

        }
    }
}