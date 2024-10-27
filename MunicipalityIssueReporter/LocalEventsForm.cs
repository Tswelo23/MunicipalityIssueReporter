using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityIssueReporter
{
    public partial class LocalEventsForm : Form
    {
        // Data structure to store events, sorted by date
        private SortedDictionary<DateTime, List<Event>> events = new SortedDictionary<DateTime, List<Event>>();

        public LocalEventsForm()
        {
            InitializeComponent();

            // Initialize the event categories in the ComboBox
            cmbCategory.Items.AddRange(new string[] { "All", "Sports", "Music", "Community", "Health" });
            cmbCategory.SelectedIndex = 0; // Default to 'All'

            // Initialize sorting options in the ComboBox
            cmbSortOptions.Items.AddRange(new string[] { "Sort by Date", "Sort by Category", "Sort by Description" });
            cmbSortOptions.SelectedIndex = 0; // Default sorting option (Sort by Date)

            // Load sample events
            LoadSampleEvents();
            DisplayEvents();
        }

        // Load sample events (this would be replaced with actual data in a real app)
        private void LoadSampleEvents()
        {
            AddEvent(new Event { Date = DateTime.Now.AddDays(1), Category = "Sports", Description = "Local Football Match" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(5), Category = "Community", Description = "Community Clean-up" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(3), Category = "Music", Description = "Jazz Concert at the Town Square" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(10), Category = "Health", Description = "Health Awareness Campaign" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(7), Category = "Education", Description = "Local School Fundraiser" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(14), Category = "Environment", Description = "Tree Planting Event" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(2), Category = "Music", Description = "Open Mic Night at the Park" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(9), Category = "Politics", Description = "Town Hall Meeting on City Development" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(4), Category = "Sports", Description = "Community Basketball Tournament" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(12), Category = "Technology", Description = "Tech Expo: Future of AI" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(6), Category = "Culture", Description = "Local Art Exhibition" });
            AddEvent(new Event { Date = DateTime.Now.AddDays(15), Category = "Community", Description = "Neighborhood BBQ and Social Gathering" });
        }

        // Add an event to the SortedDictionary
        private void AddEvent(Event newEvent)
        {
            if (!events.ContainsKey(newEvent.Date))
            {
                events[newEvent.Date] = new List<Event>();
            }
            events[newEvent.Date].Add(newEvent);
        }

        // Display events with sorting
        private void DisplayEvents()
        {
            listBoxEvents.Items.Clear();

            // Determine sorting criteria based on the selected option in cmbSortOptions
            var sortingOption = cmbSortOptions.SelectedItem.ToString();

            // Flatten the SortedDictionary to a list of events
            var allEvents = events.SelectMany(e => e.Value).ToList();

            // Sort events based on the selected sorting option
            if (sortingOption == "Sort by Category")
            {
                allEvents = allEvents.OrderBy(ev => ev.Category).ThenBy(ev => ev.Date).ToList(); // Sort by Category, then Date
            }
            else if (sortingOption == "Sort by Description")
            {
                allEvents = allEvents.OrderBy(ev => ev.Description).ThenBy(ev => ev.Date).ToList(); // Sort by Description, then Date
            }
            else // Default sort by Date
            {
                // No need to sort by date as SortedDictionary already handles that
            }

            // Display the sorted events
            foreach (var ev in allEvents)
            {
                listBoxEvents.Items.Add($"{ev.Date.ToShortDateString()} - {ev.Category}: {ev.Description}");
            }
        }

        // Search events based on selected category and date
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem.ToString();
            DateTime selectedDate = dtpEventDate.Value;

            listBoxEvents.Items.Clear();

            var filteredEvents = events
                .Where(ev => ev.Key.Date == selectedDate.Date || selectedCategory == "All" || ev.Value.Any(x => x.Category == selectedCategory))
                .SelectMany(ev => ev.Value);

            foreach (var ev in filteredEvents)
            {
                listBoxEvents.Items.Add($"{ev.Date.ToShortDateString()} - {ev.Category}: {ev.Description}");
            }
        }

        // Go back to the main menu
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Form1 mainMenu = (Form1)Application.OpenForms["Form1"];
            if (mainMenu != null)
            {
                mainMenu.Show();
            }
            this.Close();
        }

        // Event handler for sorting option change
        private void cmbSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEvents();  // Re-display the events when sorting option is changed
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    internal class Event
    {
        public DateTime Date { get; set; } // The date of the event
        public string Category { get; set; } // The category of the event (e.g., Sports, Music)
        public string Description { get; set; } // A brief description of the event
    }
}
