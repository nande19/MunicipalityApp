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

        public Recommendations()
        {
            InitializeComponent();
            this.startForm = startForm;  // Save the Start form reference

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


    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
