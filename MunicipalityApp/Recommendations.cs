using Lucene.Net.Util;
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
    public partial class Recommendations : Form
    {
        private Start startForm;  // Reference to the Start form

        private SortedDictionary<DateTime, EventDetails> eventsDictionary;  // SortedDictionary to store events by date
        private PriorityQueue<EventDetails> priorityQueue;  // Custom priority queue
        private HashSet<string> eventCategoriesSet;  // Set to store unique event categories


        public Recommendations()
        {
            InitializeComponent();
            this.startForm = startForm;  // Save the Start form reference

            eventsDictionary = new SortedDictionary<DateTime, EventDetails>();
            priorityQueue = new PriorityQueue<EventDetails>();  // Use the custom priority queue
            eventCategoriesSet = new HashSet<string>();

            // Add sample events to the dictionary for demonstration
            AddSampleEvents();

            // Display events in the ListView
            DisplayEvents();
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        private void AddSampleEvents()
        {
            // Sample event details
            var event1 = new EventDetails(new DateTime(2025, 01, 10), "Origins Centre", "9am - 2pm", "Educational and and Job Creation ", "Origins Centre Museum",
                "The Origins Centre boasts an extensive collection of rock art affording visitors the opportunity to view the earliest images made by humans, found in South Africa. "+
                "These include ancient tools, artefacts of spiritual significance to early humans and examples of the region’s striking rock art.");
             
            var event2 = new EventDetails(new DateTime(2025, 01, 15), "Constitution Hill", "9am - 5pm", "Educational and and Job Creation", "Constitution Hill",
                "Constitution Hill is a living museum that tells the story of South Africa’s journey to democracy");

            var event3 = new EventDetails(new DateTime(2024, 12, 21), "COAL YARD", "3pm - 9pm", "Arts and Culture", "Barney Simon",
                "Coal Yard is a play about Tshepo, a young man who flees home owing to his father's sexual assault. ");

            var event4 = new EventDetails(new DateTime(2024, 12, 12), "Black Death Festival", "9am - 9pm", "Festival, Sports and Recreation", "Flavius Mareka Sports Complex",
                "The Black Death Festival is a sports festival that will be hosting a variety of sports tournaments (u/18s) such as the Netball Championship, " +
                "Rugby Championship and the Soccer Championship.");

            var event5 = new EventDetails(new DateTime(2024, 12, 17), "SIMA & FRIENDS COMEDY SHOW", "6pm - 9pm", "Other", "Basement Theatre at Roodepoort Theatre",
                "Get ready to laugh your socks off at the upcoming Funny Galore presents Sima & Friends Comedy Show! " +
                "This highly anticipated event promises an evening filled with uproarious laughter and unforgettable entertainment.");

            var event6 = new EventDetails(new DateTime(2025, 01, 01), "Jogging in the township", "7am - 10am", "Sports and Recreation", "Soshanguve",
                "The running tour is the perfect introduction to Soshanguve. " +
                "This experience is perfect if you want to explore the township an unconventional way.");

            var event7 = new EventDetails(new DateTime(2025, 01, 05), "Whistleblowers Awards", "7pm - 11pm", "Other", "The Maslow Time Square",
                "The Whistleblower Awards primarily aim to recognise and encourage individuals who expose unethical" +
                " behaviour while promoting ethical conduct, transparency, and accountability within organisations " +
                "and society as a whole.");

            var event8 = new EventDetails(new DateTime(2024, 12, 03), "Inanda Hoops Classic Challenge - 2024", "7:30am - 3pm", "Sports and Recreation", "St David's Marist Inanda",
                "Welcome to the 2024 Inanda Hoops Classic Challenge – a tournament of fun " +
                "Entrance is from R30 per person, which will get you into all games at St David's Marist Inanda." +
                "Enjoy an exciting match up of games.");

            var event9 = new EventDetails(new DateTime(2024, 11, 17), "Bongza’s Fitness Challenge", "6am - 10am", "Sports and Recreation", "Hennops River Valley",
                "This is a Health and fitness event.It is all about a health lifestyle." +
                "Our event is fun and exciting. We will have different instructors,each one brings a different type of workout and makes it fun");

            var event10 = new EventDetails(new DateTime(2024, 12, 03), "Rosebank Mall 5km Pink Run", "7am - 3pm", "Public Holiday and Commemorations", "Rosebank Mall",
                "Rosebank Mall is hosting a colour run in partnership with the CANSA organization to create awareness " +
                "for breast cancer and raise funds for the CANSA organization");

            var event11 = new EventDetails(new DateTime(2024, 12, 29), "Noisy Neighbors Africa Market Festival", "10am - 8pm", "Festival", "Vibez - Bar & Lounge",
                "The Noisy Neighbors Africa Market Festival is a vibrant celebration of African culture, community, and commerce. " +
                "This lively event typically features a diverse array of vendors showcasing authentic African crafts," +
                " clothing, and food." +
                " Attendees can immerse themselves through music & dance.");

            var event12 = new EventDetails(new DateTime(2024, 12, 26), "Day of Goodwill", "7am - 12am", "Public Holiday and Commemorations", "TBC",
                "In South Africa, the day after Christmas Day, 26 December, every year is designated the Day of Goodwill. " +
                "It is set aside so that South Africans may continue the spirit of Christmas to all the people in the country." +
                "It is a day South Africans will head to the beaches, enjoy leisurely long lunches, " +
                "spend time with family and friends and generally just relax and enjoy time off.");

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
        /// 
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the Recommendations form is null or already closed
                if (startForm == null || startForm.IsDisposed)
                {
                    startForm = new Start();  // Instantiate the Recommendations form
                }

                startForm.Show();  // Show the Recommendations form
                this.Hide();  // Optionally hide the current Events form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while navigating to the Recommendations page: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        private void eventslstview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        private void recommend_MouseClick(object sender, MouseEventArgs e)
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
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
