﻿using System;
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
        // List to store issues (accessible across forms)
        public List<IssueDetails> issueList = new List<IssueDetails>();
//        private ResizeHandler resizeHandler = new ResizeHandler();

        public Start()
        {
            InitializeComponent();
        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Start Window
        /// </summary>
        private void Start_Load(object sender, EventArgs e)
        {
            // Add controls to the ResizeHandler
            //resizeHandler.AddControl(reportIssuesBtn);
            //resizeHandler.AddControl(eventsBtn);
            //resizeHandler.AddControl(serviceRequestBtn);

        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Override the OnResize method to dynamically resize controls
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            //base.OnResize(e);  // Ensure base class functionality is preserved
            //resizeHandler.ResizeControls(this);  // Dynamically resize controls on the form
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
        /// button to access events winwow
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
        /// button to access the service request window 
        /// </summary>
        private void serviceRequestBtn_Click(object sender, EventArgs e)
            {
            // Create an instance of ReportIssues form
            ServiceRequests servReq = new ServiceRequests(issueList);

            // Set the Start form to hide when the ReportIssues form is opened
            this.Hide();  // Hide the Start form

            // Show the ReportIssues form
            servReq.ShowDialog(); // Show the ReportIssues form as a modal dialog
        }

        
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
