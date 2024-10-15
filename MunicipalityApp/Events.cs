using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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


            // Add sample events to the dictionary for demonstration
            AddSampleEvents();

            // Populate category ComboBox
            categoryPicker.DataSource = eventCategoriesSet.ToList();
            categoryPicker.SelectedIndex = -1;  // Set no selection

            searchBtn.Click -= searchBtn_Click;
            // Bind search button click event
            searchBtn.Click += searchBtn_Click;

            // Bind clear button click event
            clearBtn.Click += clearBtn_Click;  // Add this line to bind the clear button event


            // Bind recommendations button click event
           // recommendBtn.Click += recommendBtn_Click;

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
            var event1 = new EventDetails(new DateTime(2025, 01, 10), "Origins Centre", "9am - 2pm", "Educational and Job Creation ", "Origins Centre Museum",
            "The Origins Centre boasts an extensive collection of rock art affording visitors the opportunity to view the earliest images made by humans, found in South Africa. " +
            "These include ancient tools, artefacts of spiritual significance to early humans and examples of the region’s striking rock art.");

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

            var event13 = new EventDetails(new DateTime(2025, 01, 15), "Constitution Hill", "9am - 5pm", "Educational and and Job Creation", "Constitution Hill",
            "Constitution Hill is a living museum that tells the story of South Africa’s journey to democracy");


            var event14 = new EventDetails(new DateTime(2024, 12, 21), "COAL YARD", "3pm - 9pm", "Arts and Culture", "Barney Simon",
             "Coal Yard is a play about Tshepo, a young man who flees home owing to his father's sexual assault. ");


            var event15 = new EventDetails(new DateTime(2024, 11, 13), "Jacaranda FM's Spring Walk", "10am - 2pm", "Sports and Recreation", "University of Pretoria Campus",
                "Jacaranda FM’s Spring Walk is a fun, family-friendly event celebrating the arrival of spring. " +
                "Participants can enjoy a relaxed walk through the beautiful University of Pretoria campus while taking in the stunning jacaranda blooms.");

            var event16 = new EventDetails(new DateTime(2024, 12, 12), "Black Death Festival", "9am - 9pm", "Sports and Recreation", "Flavius Mareka Sports Complex",
            "The Black Death Festival is a sports festival that will be hosting a variety of sports tournaments (u/18s) such as the Netball Championship, " +
            "Rugby Championship and the Soccer Championship.");

            var event17 = new EventDetails(new DateTime(2024, 12, 17), "SIMA & FRIENDS COMEDY SHOW", "6pm - 9pm", "Other", "Basement Theatre at Roodepoort Theatre",
             "Get ready to laugh your socks off at the upcoming Funny Galore presents Sima & Friends Comedy Show! " +
             "This highly anticipated event promises an evening filled with uproarious laughter and unforgettable entertainment.");

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
        /// Retrieves recommended events based on the user's selected search category.
        /// </summary>

        public List<EventDetails> GetRecommendedEvents(string searchCategory)
        {
            List<EventDetails> recommendedEvents = new List<EventDetails>();

            // Determine related categories based on the search category
            List<string> relatedCategories = new List<string>();

            try
            {
                if (searchCategory.Contains("Music"))
                {
                    relatedCategories.Add("Educational and Job Creation");
                    relatedCategories.Add("Arts and Culture");
                    relatedCategories.Add("Festival");
                }
                else if (searchCategory.Contains("Sports"))
                {
                    relatedCategories.Add("Festival");
                }
                else if (searchCategory.Contains("Educational"))
                {
                    relatedCategories.Add("Festival");
                }
                else if (searchCategory.Contains("Festival"))
                {
                    relatedCategories.Add("Sports and Recreation");
                    relatedCategories.Add("Arts and Culture");
                }

                // Find events with related categories
                recommendedEvents = eventsDictionary
                    .Where(eventEntry => relatedCategories.Contains(eventEntry.Value.Category))
                    .Select(eventEntry => eventEntry.Value)
                    .ToList();
            }
            catch (Exception ex)
            {
                // Log the error for debugging purposes
                Debug.WriteLine($"Error in GetRecommendedEvents: {ex.Message}");
                // Optionally inform the user about the error
                MessageBox.Show("An error occurred while retrieving recommended events.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return recommendedEvents;
        }



        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Displays recommended events in the DataGridView based on the user's selected category.
        /// </summary>
        private void DisplayRecommendedEvents(string searchCategory)
        {
            try
            {
                // Clear existing rows in the DataGridView
                recomdataGridView.Rows.Clear();

                // Get recommended events based on user search
                List<EventDetails> recommendedEvents = GetRecommendedEvents(searchCategory);

                // Log the number of recommended events
                Debug.WriteLine($"Number of recommended events: {recommendedEvents.Count}");

                // Display each recommended event in the DataGridView
                foreach (var ev in recommendedEvents)
                {
                    // Ensure ev has valid properties before adding
                    if (ev != null) // Check if ev is not null
                    {
                        recomdataGridView.Rows.Add(
                            ev.Date.ToShortDateString(),
                            ev.EventName,
                            ev.Duration,
                            ev.Category,
                            ev.Location
                        );
                    }
                }

                // Refresh the DataGridView to ensure it displays the new rows
                recomdataGridView.Refresh();
            }
            catch (Exception ex)
            {
                // Log the error for debugging purposes
                Debug.WriteLine($"Error in DisplayRecommendedEvents: {ex.Message}");
                // Optionally inform the user about the error
                MessageBox.Show("An error occurred while displaying recommended events.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }


        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Display events from the SortedDictionary in the ListView.
        /// </summary>
        private void DisplayEvents()
        {
            try
            {
                // Clear existing items in the ListView
                eventslstview.Items.Clear();

                // Loop through each event in the SortedDictionary and add it to the ListView
                foreach (var eventDetail in eventsDictionary.Values)
                {
                    if (eventDetail != null) // Check for null before accessing properties
                    {
                        ListViewItem item = new ListViewItem(eventDetail.Date.ToShortDateString());
                        item.SubItems.Add(eventDetail.EventName);
                        item.SubItems.Add(eventDetail.Duration);
                        item.SubItems.Add(eventDetail.Category);
                        item.SubItems.Add(eventDetail.Location);
                        item.SubItems.Add(eventDetail.Description);

                        eventslstview.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error for debugging purposes
                Debug.WriteLine($"Error in DisplayEvents: {ex.Message}");
                // Optionally inform the user about the error
                MessageBox.Show("An error occurred while displaying events.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (DateTime.TryParse(selectedItem.SubItems[0].Text, out DateTime eventDate))
                    {
                        // Retrieve the event details from the SortedDictionary using the event date
                        if (eventsDictionary.TryGetValue(eventDate, out EventDetails eventDetails))
                        {
                            // Display the event description
                            MessageBox.Show(eventDetails.Description, $"About {eventDetails.EventName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Event details not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid event date format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// allows the users to filter through data
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected category
                string selectedCategory = categoryPicker.SelectedItem?.ToString();

                // Check if a category is selected
                if (string.IsNullOrEmpty(selectedCategory))
                {
                    MessageBox.Show("Please select a category before searching.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if no category is selected
                }

                // Get the selected date from the datePicker
                DateTime selectedDate = datePicker.Value.Date; // Assume datePicker is a DateTimePicker control

                // Display recommended events based on the selected category
                DisplayRecommendedEvents(selectedCategory);

                // Filter events based on selected category and date
                var filteredEvents = eventsDictionary
                    .Where(eventEntry =>
                        eventEntry.Value.Category == selectedCategory &&  // Filter by selected category
                        eventEntry.Key.Date == selectedDate) // Filter by selected date
                    .Select(eventEntry => eventEntry.Value)
                    .ToList();

                // Display filtered events
                DisplayFilteredEvents(filteredEvents);
            }
            catch (Exception ex)
            {
                // Log the error for debugging purposes
                Debug.WriteLine($"Error in searchBtn_Click: {ex.Message}");
                // Optionally inform the user about the error
                MessageBox.Show("An error occurred while searching for events.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method to display events based on the selected category
        /// </summary>

        private void DisplayFilteredEvents(List<EventDetails> filteredEvents)
        {
            try
            {
                // Clear existing items in ListView
                eventslstview.Items.Clear();

                // Check if filtered events list is not null and contains items
                if (filteredEvents != null && filteredEvents.Count > 0)
                {
                    foreach (var eventDetail in filteredEvents)
                    {
                        // Check for null eventDetail before accessing its properties
                        if (eventDetail != null)
                        {
                            // Create a new ListViewItem with the event date
                            ListViewItem item = new ListViewItem(eventDetail.Date.ToString("yyyy-MM-dd"))
                            {
                                SubItems = {
                        eventDetail.EventName,   // Add event name
                        eventDetail.Duration,     // Add event duration
                        eventDetail.Category,     // Add event category
                        eventDetail.Location      // Add event location
                    }
                            };

                            // Add the constructed item to the ListView
                            eventslstview.Items.Add(item);
                        }
                    }
                }
                else
                {
                    // Show a message if no events are found based on the selected filters
                    MessageBox.Show("No events found for the selected filters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Log the exception details to debug output
                Debug.WriteLine($"An error occurred while displaying filtered events: {ex.Message}");

                // Show an error message to the user
                MessageBox.Show($"An error occurred while displaying events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            //--------------------------------------------------------------------------------------------------------//

            /// <summary>
            /// clears the filtering
            /// </summary>
            private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset the DateTimePicker to the current date
                datePicker.Value = DateTime.Now; // You can set this to any default date you prefer

                // Reset the category picker selection
                categoryPicker.SelectedIndex = -1;

                // Call method to display all events after resetting filters
                DisplayEvents();
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                Debug.WriteLine($"An error occurred while clearing filters: {ex.Message}");

                // Inform the user about the error
                MessageBox.Show($"An error occurred while clearing filters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        private void categoryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
