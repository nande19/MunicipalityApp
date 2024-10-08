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
    public partial class Events : Form
    {
        private Start startForm;  // Reference to the Start form

        public Events(Start startForm)
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
            // Check if startForm is not null before attempting to show it
            if (startForm != null)
            {
                startForm.Show();  // Show the Start form when the back button is clicked
            }
            this.Close();  // Close the form
        }
    }
}
