using System;
using System.Collections.Generic;
using System.Drawing;
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
        ///   Event handler for attaching files
        /// </summary>
        private void attachBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Filter = "Image files | *.bmp;*.jpg;*.png",
                FilterIndex = 1,
                Multiselect = false // Allow only one file selection
            };

            if (openDialog.ShowDialog() == DialogResult.OK) // Correct comparison
            {
                // Add the file path to the attachments list
                attachments.Add(openDialog.FileName);

                // Display the attached image in a PictureBox
                // Ensure you have a PictureBox control named 'imagePicture'
                imagePicture.Image = Image.FromFile(openDialog.FileName); // Use Image.FromFile for WinForms

                MessageBox.Show("File has been successfully selected.", "File Attached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Save button event handler
        /// </summary>
       
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the issue: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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