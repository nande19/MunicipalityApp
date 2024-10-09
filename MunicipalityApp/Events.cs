using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class Events : Form
    {
        private Start startForm;  // Reference to the Start form
        private SortedDictionary<DateTime, EventDetails> eventsDictionary;  // SortedDictionary to store events by date
        private Stack<EventDetails> undoStack;  // Stack to manage undo operations
        private Queue<EventDetails> eventQueue;  // Queue to manage upcoming events
        private HashSet<string> eventCategoriesSet;  // Set to store unique event categories
        private PriorityQueue<EventDetails> priorityQueue;  // Custom priority queue

        public Events(Start startForm)
        {
            InitializeComponent();
            this.startForm = startForm;  // Save the Start form reference


            // Initialize the advanced data structures
            eventsDictionary = new SortedDictionary<DateTime, EventDetails>();
            undoStack = new Stack<EventDetails>();
            eventQueue = new Queue<EventDetails>();
            eventCategoriesSet = new HashSet<string>();
            priorityQueue = new PriorityQueue<EventDetails>();  // Use the custom priority queue

            // Setup ListView columns
            SetupListViewColumns();

            // Add sample events to the dictionary for demonstration
            AddSampleEvents();

            // Display events in the ListView
            DisplayEvents();
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Set up the ListView with the necessary columns for event data.
        /// </summary>
        private void SetupListViewColumns()
        {
            listView1.Columns.Clear();  // Clear existing columns
            listView1.View = View.Details;
            listView1.Columns.Add("Date", 150);
            listView1.Columns.Add("Event", 200);
            listView1.Columns.Add("Duration", 100);
            listView1.Columns.Add("Category", 150);
            listView1.Columns.Add("Location", 150);
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Add sample events to the SortedDictionary for testing purposes.
        /// </summary>
        private void AddSampleEvents()
        {
            // Sample event details
            var event1 = new EventDetails(new DateTime(2024, 10, 10), "Music Festival", "3 hours", "Entertainment", "Park Square");
            var event2 = new EventDetails(new DateTime(2024, 11, 15), "Art Exhibition", "5 hours", "Art", "City Hall");
            var event3 = new EventDetails(new DateTime(2024, 12, 20), "Community Meeting", "2 hours", "Community", "Community Center");

            // Add events to SortedDictionary
            eventsDictionary[event1.Date] = event1;
            eventsDictionary[event2.Date] = event2;
            eventsDictionary[event3.Date] = event3;

            // Add events to priority queue (by date)
            priorityQueue.Enqueue(event1, event1.Date);
            priorityQueue.Enqueue(event2, event2.Date);
            priorityQueue.Enqueue(event3, event3.Date);

            // Add event categories to the HashSet (unique categories)
            eventCategoriesSet.Add(event1.Category);
            eventCategoriesSet.Add(event2.Category);
            eventCategoriesSet.Add(event3.Category);
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Display events from the SortedDictionary in the ListView.
        /// </summary>
        private void DisplayEvents()
        {
            listView1.Items.Clear();  // Clear existing items in ListView

            foreach (var eventDetail in eventsDictionary.Values)
            {
                ListViewItem item = new ListViewItem(eventDetail.Date.ToString("yyyy-MM-dd"))
                {
                    SubItems = {
                        eventDetail.EventName,
                        eventDetail.Duration,
                        eventDetail.Category,
                        eventDetail.Location
                    }
                };

                listView1.Items.Add(item);  // Add item to ListView
            }
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if startForm is not null before attempting to show it
                if (startForm != null)
                {
                    startForm.Show();  // Show the Start form when the back button is clicked
                }
                this.Close();  // Close the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while navigating back: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
