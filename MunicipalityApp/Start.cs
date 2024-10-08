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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.FormClosing += Start_FormClosing;  // Subscribe to the FormClosing event
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Terminate the entire application when the Start form is closed
            Application.Exit();
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// report issue button functionality
        /// </summary>
        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of ReportIssues form
            ReportIssues reportForm = new ReportIssues(this);

            // Set the Start form to hide when the ReportIssues form is opened
            this.Hide();  // Hide the Start form

            // Show the ReportIssues form
            reportForm.ShowDialog();  // Show the ReportIssues form as a modal dialog

        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// to be added
        /// </summary>
        private void eventsBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of ReportIssues form
            Events Announcements = new Events(this);

            // Set the Start form to hide when the ReportIssues form is opened
            this.Hide();  // Hide the Start form

            // Show the ReportIssues form
            Announcements.ShowDialog(); // Show the ReportIssues form as a modal dialog

        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// to be added
        /// </summary>
        private void serviceRequestBtn_Click(object sender, EventArgs e)
        {

        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        private void Start_Load(object sender, EventArgs e)
        {
            Rectangle working = Screen.PrimaryScreen.WorkingArea;

            this.Size = new Size(Convert.ToInt32(0.5 * working.Width), Convert.ToInt32(0.5 * working.Height));

            this.Location = new Point(10, 10);
        }
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
