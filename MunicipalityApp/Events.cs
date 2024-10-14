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
        private Recommendations recommended;
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


            // Add sample events to the dictionary for demonstration
            AddSampleEvents();

            // Populate category ComboBox
            categoryPicker.DataSource = eventCategoriesSet.ToList();
            categoryPicker.SelectedIndex = -1;  // Set no selection

            // Bind search button click event
            searchBtn.Click += searchBtn_Click;

            // Bind clear button click event
            clearBtn.Click += clearBtn_Click;  // Add this line to bind the clear button event

            // Display events in the ListView
            DisplayEvents();
        }
       

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Add sample events to the SortedDictionary for testing purposes.
        /// </summary>
        private void AddSampleEvents()
        {
            // Sample event details
            var event1 = new EventDetails(new DateTime(2024, 10, 10), "Music Festival", "9pm - 12am", "Arts and Culture", "Freedom Park",
                "Join us for a vibrant music festival featuring local artists and musicians from across the country. A celebration of culture and music.");

            var event2 = new EventDetails(new DateTime(2024, 11, 15), "Art Exhibition", "9am - 2pm", "Arts and Culture", "Pretoria Showgrounds",
                "An exhibition showcasing contemporary art from local and international artists. A great event for art lovers.");

            var event3 = new EventDetails(new DateTime(2024, 12, 20), "DSTV Festival", "4pm - 11pm", "Festival", "Pretoria Showgrounds",
                "The DSTV Festival is packed with entertainment, food, and activities for the whole family. Expect live performances and celebrity appearances.");

            var event4 = new EventDetails(new DateTime(2024, 12, 10), "International Jazz Festival", "10am - 10pm", "Festival", "Pretoria National Botanical Garden",
                "A grand celebration of jazz with performances by world-renowned jazz artists. A must-attend for jazz enthusiasts.");

            var event5 = new EventDetails(new DateTime(2024, 12, 01), "Tweede Nuwejaar (Minstrels, Malay Choirs and Christmas Bands)", "4pm - 8pm", "Arts and Culture", "State Theatre",
                "A vibrant cultural celebration with colorful parades, music, and performances by minstrels, Malay choirs, and Christmas bands. " +
                "This event marks the Cape Malay community’s tradition of Tweede Nuwejaar, celebrated with joyful processions and entertainment.");

            var event6 = new EventDetails(new DateTime(2024, 11, 30), "Pretoria Carnival", "10am - 8pm", "Other", "Pretoria National Botanical Garden",
                "A family-friendly carnival filled with parades, costumes, and floats. " +
                "The Pretoria Carnival brings together various communities to celebrate diversity, culture, and creativity with lively street performances and artistic showcases.");

            var event7 = new EventDetails(new DateTime(2024, 11, 25), "Pretoria Cycle Tour", "4am - 2pm", "Sports and Recreation", "TBC",
                "The Pretoria Cycle Tour is a scenic cycling event that attracts riders of all levels. " +
                "Participants race through various routes, exploring Pretoria’s landscapes while promoting fitness and outdoor activity.");

            var event8 = new EventDetails(new DateTime(2024, 11, 20), "Discovery Triathlon World Cup Pretoria", "8am - 5pm", "Sports and Recreation", "TBC",
                "A high-level international triathlon event featuring elite athletes competing in swimming, cycling, and running. " +
                "The Discovery Triathlon World Cup Pretoria offers an exciting day of endurance sports and global competition.");

            var event9 = new EventDetails(new DateTime(2024, 11, 01), "Two Oceans Marathon", "3am - 4pm", "Sports and Recreation", "TBC",
                "One of South Africa’s most prestigious marathons, the Two Oceans Marathon takes participants through a challenging course, " +
                "offering stunning coastal views. Known for its scenic routes, it’s a test of endurance and determination.");

            var event10 = new EventDetails(new DateTime(2024, 11, 05), "Gauteng Carnival", "10am - 8pm", "Arts and Culture", "TBC",
                "A colorful and lively carnival showcasing the rich cultural heritage of Gauteng. " +
                "The event features parades, traditional dances, music, and vibrant costumes, celebrating diversity and community spirit.");

            var event11 = new EventDetails(new DateTime(2024, 11, 22), "Mokete Wa Tshwane", "11am - 5pm", "Arts and Culture", "Freedom Park",
                "An annual cultural festival celebrating the heritage and traditions of the people of Tshwane. " +
                "Mokete Wa Tshwane is a day of music, dance, and storytelling, promoting unity and cultural pride in the local community.");

            var event12 = new EventDetails(new DateTime(2024, 11, 07), "UNISA Graduation Ceremonies", "8am - 5pm", "Educational and Job Creation", "University of Pretoria Campus",
                "Celebrate the achievements of UNISA’s graduates at this prestigious ceremony. " +
                "The event honors students who have completed their academic journey and marks the beginning of their professional careers.");

            var event13 = new EventDetails(new DateTime(2024, 10, 30), "State of the Nation Address (SONA)", "6pm - ??", "Other", "Union Buildings",
                "The State of the Nation Address is a key political event where the President of South Africa delivers a speech outlining the government's plans and " +
                "priorities for the coming year. A significant event in the country’s political calendar.");

            var event14 = new EventDetails(new DateTime(2024, 10, 20), "A Re Yeng Half Marathon", "5am - 12pm", "Sports and Recreation", "Pretoria",
                "A half marathon promoting fitness and a healthy lifestyle among the residents of Pretoria. " +
                "The A Re Yeng Half Marathon takes participants through a scenic route across the city, encouraging community participation and physical wellness.");

            var event15 = new EventDetails(new DateTime(2024, 11, 13), "Jacaranda FM's Spring Walk", "10am - 2pm", "Sports and Recreation", "University of Pretoria Campus",
                "Jacaranda FM’s Spring Walk is a fun, family-friendly event celebrating the arrival of spring. " +
                "Participants can enjoy a relaxed walk through the beautiful University of Pretoria campus while taking in the stunning jacaranda blooms.");

            var event16 = new EventDetails(new DateTime(2024, 10, 05), "Freedom Day Celebrations", "9am - 5pm", "Public Holiday and Commemorations", "Pretoria North City Hall",
                "Join the nation in celebrating Freedom Day, commemorating South Africa’s first democratic elections in 1994. " +
                "The event features speeches, cultural performances, and a reflection on the country’s journey to freedom.");

            var event17 = new EventDetails(new DateTime(2024, 10, 01), "Jacaranda Festival", "11am - 8pm", "Festival", "University of Pretoria Campus",
                "A celebration of Pretoria’s famous jacaranda trees in full bloom, " +
                "the Jacaranda Festival brings together local vendors, musicians, and artists for a day of family fun. Enjoy live music, food stalls, " +
                "and activities under the iconic purple trees.");

            // Add events to SortedDictionary
            eventsDictionary[event1.Date] = event1;
            eventsDictionary[event2.Date] = event2;
            eventsDictionary[event3.Date] = event3;
            eventsDictionary[event4.Date] = event4;
            eventsDictionary[event5.Date] = event5;
            eventsDictionary[event6.Date] = event6;
            eventsDictionary[event7.Date] = event7;
            eventsDictionary[event8.Date] = event8;
            eventsDictionary[event9.Date] = event9;
            eventsDictionary[event10.Date] = event10;
            eventsDictionary[event11.Date] = event11;
            eventsDictionary[event12.Date] = event12;
            eventsDictionary[event13.Date] = event13;
            eventsDictionary[event14.Date] = event14;
            eventsDictionary[event15.Date] = event15;
            eventsDictionary[event16.Date] = event16;
            eventsDictionary[event17.Date] = event17;

            // Add events to priority queue (by date)
            priorityQueue.Enqueue(event1, event1.Date);
            priorityQueue.Enqueue(event2, event2.Date);
            priorityQueue.Enqueue(event3, event3.Date);
            priorityQueue.Enqueue(event4, event4.Date);
            priorityQueue.Enqueue(event5, event5.Date);
            priorityQueue.Enqueue(event6, event6.Date);
            priorityQueue.Enqueue(event7, event7.Date);
            priorityQueue.Enqueue(event8, event8.Date);
            priorityQueue.Enqueue(event9, event9.Date);
            priorityQueue.Enqueue(event10, event10.Date);
            priorityQueue.Enqueue(event11, event11.Date);
            priorityQueue.Enqueue(event12, event12.Date);
            priorityQueue.Enqueue(event13, event13.Date);
            priorityQueue.Enqueue(event14, event14.Date);
            priorityQueue.Enqueue(event15, event15.Date);
            priorityQueue.Enqueue(event16, event16.Date);
            priorityQueue.Enqueue(event17, event17.Date);

            // Add event categories to the HashSet (unique categories)
            eventCategoriesSet.Add(event1.Category);
            eventCategoriesSet.Add(event2.Category);
            eventCategoriesSet.Add(event3.Category);
            eventCategoriesSet.Add(event4.Category);
            eventCategoriesSet.Add(event5.Category);
            eventCategoriesSet.Add(event6.Category);
            eventCategoriesSet.Add(event7.Category);
            eventCategoriesSet.Add(event8.Category);
            eventCategoriesSet.Add(event9.Category);
            eventCategoriesSet.Add(event10.Category);
            eventCategoriesSet.Add(event11.Category);
            eventCategoriesSet.Add(event12.Category);
            eventCategoriesSet.Add(event13.Category);
            eventCategoriesSet.Add(event14.Category);
            eventCategoriesSet.Add(event15.Category);
            eventCategoriesSet.Add(event16.Category);
            eventCategoriesSet.Add(event17.Category);

        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Display events from the SortedDictionary in the ListView.
        /// </summary>
        private void DisplayEvents()
        {
            eventslstview.Items.Clear();  // Clear existing items in ListView

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

                eventslstview.Items.Add(item);  // Add item to ListView
            }
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// takes me back to main
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

//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// mouse click to view event details 
        /// </summary>
        private void eventslstview_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Get the item that was clicked
                ListViewItem selectedItem = eventslstview.GetItemAt(e.X, e.Y);
                if (selectedItem != null)
                {
                    // Extract the date of the clicked event (assumed to be in the first column)
                    DateTime eventDate = DateTime.Parse(selectedItem.SubItems[0].Text);

                    // Retrieve the event details from the SortedDictionary using the event date
                    if (eventsDictionary.TryGetValue(eventDate, out EventDetails eventDetails))
                    {
                        // Display the event description
                        MessageBox.Show(eventDetails.Description, $"About {eventDetails.EventName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying event description: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// category picker
        /// </summary>
        private void categoryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// date picker
        /// </summary>
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// allows the users to filter through data
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string selectedCategory = categoryPicker.SelectedItem?.ToString(); // Get selected category
            DateTime selectedDate;

            // Get the selected date if any (you need a date picker for this, e.g., datePicker.Value)
            if (datePicker.Value != null)
            {
                selectedDate = datePicker.Value.Date; // Assume datePicker is a DateTimePicker control
            }
            else
            {
                // If no date is selected, set to a default value (e.g., today)
                selectedDate = DateTime.Today;
            }

            // Filter events based on selected category and date
            var filteredEvents = eventsDictionary
                .Where(eventEntry =>
                    (string.IsNullOrEmpty(selectedCategory) || eventEntry.Value.Category == selectedCategory) &&
                    eventEntry.Key.Date == selectedDate) // Filter by selected date
                .Select(eventEntry => eventEntry.Value)
                .ToList();

            // Display filtered events
            DisplayFilteredEvents(filteredEvents);
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method to display events based on the selected category
        /// </summary>

        private void DisplayFilteredEvents(List<EventDetails> filteredEvents)
        {
            eventslstview.Items.Clear();  // Clear existing items in ListView

            foreach (var eventDetail in filteredEvents)
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

                eventslstview.Items.Add(item);  // Add item to ListView
            }
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// clears the filtering
        /// </summary>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Reset the DateTimePicker and the category picker
            datePicker.Value = DateTime.Now; // Set to current date or any default date
            categoryPicker.SelectedIndex = -1;  // Reset category selection

            // Display all events
            DisplayEvents();
        }

        private void recommendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the Recommendations form is null or already closed
                if (recommended == null || recommended.IsDisposed)
                {
                    recommended = new Recommendations();  // Instantiate the Recommendations form
                }

                recommended.Show();  // Show the Recommendations form
                this.Hide();  // Optionally hide the current Events form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while navigating to the Recommendations page: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
