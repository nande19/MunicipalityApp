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

    public partial class ServiceRequests : Form
    {

        private List<IssueDetails> issueList;

        public ServiceRequests(List<IssueDetails> issues )
        {
            InitializeComponent();
            issueList = issues;
            LoadIssueIds();
        }

        private void LoadIssueIds()
        {
            statusLst.Items.Clear();

            foreach (var issue in issueList)
            {
                statusLst.Items.Add(issue.RequestId.ToString());
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the Start form and close the current form
                if (Application.OpenForms.OfType<Start>().Any())
                {
                    Application.OpenForms.OfType<Start>().First().Show();
                }

                this.Close(); // Close the form
            }
            catch (Exception ex)
            {
                // Handle errors that occur when trying to close the form
                MessageBox.Show($"Error while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
