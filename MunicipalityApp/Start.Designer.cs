namespace MunicipalityApp
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.reportIssuesBtn = new System.Windows.Forms.Button();
            this.eventsBtn = new System.Windows.Forms.Button();
            this.serviceRequestBtn = new System.Windows.Forms.Button();
            this.municipalityLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportIssuesBtn
            // 
            this.reportIssuesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportIssuesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportIssuesBtn.Location = new System.Drawing.Point(345, 199);
            this.reportIssuesBtn.Name = "reportIssuesBtn";
            this.reportIssuesBtn.Size = new System.Drawing.Size(161, 51);
            this.reportIssuesBtn.TabIndex = 0;
            this.reportIssuesBtn.Text = "Report Issues";
            this.reportIssuesBtn.UseVisualStyleBackColor = false;
            this.reportIssuesBtn.Click += new System.EventHandler(this.reportIssuesBtn_Click);
            // 
            // eventsBtn
            // 
            this.eventsBtn.BackColor = System.Drawing.Color.Olive;
            this.eventsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsBtn.Location = new System.Drawing.Point(345, 125);
            this.eventsBtn.Name = "eventsBtn";
            this.eventsBtn.Size = new System.Drawing.Size(161, 51);
            this.eventsBtn.TabIndex = 1;
            this.eventsBtn.Text = "Local Events and Announcements";
            this.eventsBtn.UseVisualStyleBackColor = false;
            this.eventsBtn.Click += new System.EventHandler(this.eventsBtn_Click);
            // 
            // serviceRequestBtn
            // 
            this.serviceRequestBtn.BackColor = System.Drawing.Color.Teal;
            this.serviceRequestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceRequestBtn.Location = new System.Drawing.Point(345, 278);
            this.serviceRequestBtn.Name = "serviceRequestBtn";
            this.serviceRequestBtn.Size = new System.Drawing.Size(161, 51);
            this.serviceRequestBtn.TabIndex = 2;
            this.serviceRequestBtn.Text = "Service Request Status";
            this.serviceRequestBtn.UseVisualStyleBackColor = false;
            this.serviceRequestBtn.Click += new System.EventHandler(this.serviceRequestBtn_Click);
            // 
            // municipalityLbl
            // 
            this.municipalityLbl.AutoSize = true;
            this.municipalityLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalityLbl.Location = new System.Drawing.Point(262, 22);
            this.municipalityLbl.Name = "municipalityLbl";
            this.municipalityLbl.Size = new System.Drawing.Size(372, 30);
            this.municipalityLbl.TabIndex = 9;
            this.municipalityLbl.Text = "Welcome to the Municipality";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.municipalityLbl);
            this.Controls.Add(this.serviceRequestBtn);
            this.Controls.Add(this.eventsBtn);
            this.Controls.Add(this.reportIssuesBtn);
            this.Name = "Start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportIssuesBtn;
        private System.Windows.Forms.Button eventsBtn;
        private System.Windows.Forms.Button serviceRequestBtn;
        private System.Windows.Forms.Label municipalityLbl;
    }
}

