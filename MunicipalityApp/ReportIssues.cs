using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ReportIssues : Form
    {
        // List to store the reported issues
        private List<IssueDetails> issueList = new List<IssueDetails>();

        // List to store attached files
        private List<string> attachments = new List<string>();

        private Start startForm;  // Reference to the Start form

        // Constructor that accepts the Start form reference
        public ReportIssues(Start startForm)
        {
            InitializeComponent();
            this.startForm = startForm;  // Save the Start form reference
        }

        // Back button to return to the main form
        private void backBtn_Click(object sender, EventArgs e)
        {
            // Check if startForm is not null before attempting to show it
            if (startForm != null)
            {
                startForm.Show();  // Show the Start form when the back button is clicked
            }
            this.Close();  // Close the ReportIssues form
        }

        // Event handler for attaching files
        private void attachBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Images and Documents|*.jpg;*.jpeg;*.png;*.pdf;*.docx"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    attachments.Add(file);
                }

                MessageBox.Show("Files have been successfully selected.", "Files Attached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Save button event handler
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string location = locationTxt.Text;
            string category = categoryBox.SelectedItem?.ToString();
            string description = descriptionTxt.Text;

            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all required fields: Location, Category, and Description.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progressBar.Value = 0;

            progressBar.Value += 30;

            if (attachments.Count > 0)
            {
                progressBar.Value += 30;
            }

            IssueDetails newIssue = new IssueDetails(location, category, description, attachments);
            issueList.Add(newIssue);

            progressBar.Value = 100;

            MessageBox.Show("Your issue has been successfully reported!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();

            ViewingIssues viewingIssuesForm = new ViewingIssues(issueList);

            this.Hide();

            viewingIssuesForm.FormClosed += (s, args) => this.Close();

            viewingIssuesForm.Show();
        }

        private void ClearForm()
        {
            locationTxt.Clear();
            categoryBox.SelectedIndex = -1;
            descriptionTxt.Clear();
            attachments.Clear();
        }
    


private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

      
        }
    }


   
