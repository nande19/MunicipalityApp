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
    public partial class ReportIssues : Form
    {
        // List to store the reported issues
        private List<IssueDetails> issueList = new List<IssueDetails>();

        // List to store attached files
        private List<string> attachments = new List<string>();

        private Start startForm;  // Reference to the Start form

        public ReportIssues()
        {
            InitializeComponent();
            this.startForm = startForm;  // Save the Start form reference

        }

        // Populate categoryBox with predefined categories


        //Back button to return to the main 
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form and go back to the main menu

        }

        // Event handler for the Attach button to select media files
        private void attachFilesBtn_Click(object sender, EventArgs e)
        {
            // Open a file dialog to allow users to attach files (images/documents)
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,  // Allow multiple file selections
                Filter = "Images and Documents|*.jpg;*.jpeg;*.png;*.pdf;*.docx"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    attachments.Add(file);  // Add selected file paths to the list of attachments
                }

                MessageBox.Show("Files have been successfully selected.", "Files Attached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Retrieve data from the form controls
            string location = locationTxt.Text;
            string category = categoryBox.SelectedItem?.ToString();
            string description = descriptionTxt.Text;

            // Check if the required fields are filled
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all required fields: Location, Category, and Description.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulate task progress for saving the report
            progressBar.Value = 0;  // Reset progress bar to 0

            // Increment progress - this is just an example, you can adjust based on your scenario
            progressBar.Value += 30;  // Example progress increment for filling data

            // Simulating file attachment progress
            if (attachments.Count > 0)
            {
                progressBar.Value += 30;  // Example increment for attachments
            }

            // Final step: save to list and complete progress
            IssueDetails newIssue = new IssueDetails(location, category, description, attachments);
            issueList.Add(newIssue);

            progressBar.Value = 100;  // Set to maximum when done

            // Show success message
            MessageBox.Show("Your issue has been successfully reported!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the form fields for a new report
            ClearForm();

            // Open the ViewingIssues form to show the list of issues
            ViewingIssues viewingIssuesForm = new ViewingIssues(issueList);
            viewingIssuesForm.FormClosed += (s, args) => this.Close();  // Close the ReportIssues form when ViewingIssues is closed
            viewingIssuesForm.Show();  // Display the ViewingIssues form

        }

        private void ClearForm()
        {
            locationTxt.Clear();
            categoryBox.SelectedIndex = -1;  // Reset the combo box
            descriptionTxt.Clear();
            attachments.Clear();  // Clear attached files list
        }


    }

}
   
