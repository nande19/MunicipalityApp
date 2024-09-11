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
        }

        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of ReportIssues form
            ReportIssues reportForm = new ReportIssues(this);

            // Set the Start form to hide when the ReportIssues form is opened
            this.Hide();  // Hide the Start form

            // Show the ReportIssues form
            reportForm.ShowDialog();  // Show the ReportIssues form as a modal dialog

        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {

        }

        private void serviceRequestBtn_Click(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
