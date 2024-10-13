using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        private static Manager _manager;
        private Queue<string> _searchHistory;
        private const int MAX_SEARCH_HISTORY = 10;

        public LocalEventsForm()
        {
            InitializeComponent();
            if (_manager == null)
            {
                _manager = new Manager();
                AddHardCodedEvents();
            }
            _searchHistory = new Queue<string>();
            PopulateEventList();
            PopulateCategoryComboBox();
            StyleControls();
        }

        private void AddHardCodedEvents()
        {
            _manager.AddEvent(new Event("Community Cleanup", DateTime.Now.AddDays(7), "Environment", "Join us for a community-wide cleanup event!"));
            _manager.AddEvent(new Event("Local Art Exhibition", DateTime.Now.AddDays(14), "Culture", "Showcasing artwork from local artists."));
            _manager.AddEvent(new Event("Town Hall Meeting", DateTime.Now.AddDays(21), "Government", "Discussing upcoming city projects and initiatives."));
        }

        private void StyleControls()
        {
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            StyleButton(buttonSearch);
            StyleButton(buttonCreateEvent);
            StyleButton(btnBackToMainMenu);

            StyleListView(listViewEvents);
            StyleTextBox(textBoxSearch);
            StyleTextBox(textBoxEventDetails);
            StyleComboBox(comboBoxCategory);
            StyleDateTimePicker(dateTimePickerSearch);
            StyleListBox(listBoxRecommendations);

            CenterControls();
        }

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

        private void CenterControls()
        {
            int centerX = (ClientSize.Width - listViewEvents.Width) / 2;
            listViewEvents.Location = new Point(centerX, listViewEvents.Location.Y);
            textBoxEventDetails.Location = new Point(centerX, textBoxEventDetails.Location.Y);
            listBoxRecommendations.Location = new Point(centerX, listBoxRecommendations.Location.Y);

            int searchControlsY = panelHeader.Bottom + 20;
            labelEventName.Location = new Point(centerX, searchControlsY + 5);
            textBoxSearch.Location = new Point(labelEventName.Right + 10, searchControlsY);
            dateTimePickerSearch.Location = new Point(textBoxSearch.Right + 10, searchControlsY);
            comboBoxCategory.Location = new Point(dateTimePickerSearch.Right + 10, searchControlsY);

            buttonSearch.Location = new Point((ClientSize.Width - buttonSearch.Width) / 2, searchControlsY + textBoxSearch.Height + 10);

            int bottomButtonsY = ClientSize.Height - buttonCreateEvent.Height - 20;
            buttonCreateEvent.Location = new Point(centerX, bottomButtonsY);
            btnBackToMainMenu.Location = new Point(buttonCreateEvent.Right + 10, bottomButtonsY);
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();
            DateTime searchDate = dateTimePickerSearch.Value.Date;
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();

            List<Event> searchResults = _manager.SearchEvents(searchTerm, searchDate, selectedCategory);

            DisplaySearchResults(searchResults);
            UpdateSearchHistory(searchTerm);
            ShowRecommendations();
            ShowCategoryBasedRecommendations();
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
            // This method is intentionally left empty
        }
    }
}