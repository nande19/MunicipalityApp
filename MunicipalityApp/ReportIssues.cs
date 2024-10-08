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


        //--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Constructor that accepts the Start form reference
        /// </summary>

        public ReportIssues(Start startForm)
        {
            InitializeComponent();
            this.startForm = startForm;  // Save the Start form reference

        }


        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Back button to return to the main form
        /// </summary>

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Check if startForm is not null before attempting to show it
            if (startForm != null)
            {
                startForm.Show();  // Show the Start form when the back button is clicked
            }
            this.Close();  // Close the form
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        ///   Event handler for attaching files
        /// </summary>
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
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Save button event handler
        /// </summary>
       
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

            // Check if all attachments exist
            foreach (var attachment in attachments)
            {
                if (!System.IO.File.Exists(attachment))
                {
                    MessageBox.Show($"File does not exist: {attachment}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Exit the method if any file is not found
                }
            }

            // For debugging: Print out attachment paths
            MessageBox.Show("Attachments:\n" + string.Join("\n", attachments), "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// This method clears all the input fields on the form.
        /// </summary>
        private void ClearForm()
        {
            locationTxt.Clear();
            categoryBox.SelectedIndex = -1;
            descriptionTxt.Clear();
            attachments.Clear();
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Event handler for when the BindingNavigator is refreshed.
        /// </summary>

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

      
        }


    }
        //---------------------------------------- END OF FILE -------------------------------------------------------//