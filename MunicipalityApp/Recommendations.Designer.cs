namespace MunicipalityApp
{
    partial class Recommendations
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
            this.backBtn = new System.Windows.Forms.Button();
            this.municipalityLbl = new System.Windows.Forms.Label();
            this.eventslstview = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.Crimson;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(135, 25);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 67);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "Back to Main";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // municipalityLbl
            // 
            this.municipalityLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.municipalityLbl.AutoSize = true;
            this.municipalityLbl.BackColor = System.Drawing.Color.Transparent;
            this.municipalityLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalityLbl.Location = new System.Drawing.Point(500, 41);
            this.municipalityLbl.Name = "municipalityLbl";
            this.municipalityLbl.Size = new System.Drawing.Size(323, 30);
            this.municipalityLbl.TabIndex = 26;
            this.municipalityLbl.Text = "Events Recommendations";
            // 
            // eventslstview
            // 
            this.eventslstview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventslstview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Event,
            this.Duration,
            this.Category,
            this.Location});
            this.eventslstview.FullRowSelect = true;
            this.eventslstview.GridLines = true;
            this.eventslstview.HideSelection = false;
            this.eventslstview.Location = new System.Drawing.Point(64, 150);
            this.eventslstview.Name = "eventslstview";
            this.eventslstview.Size = new System.Drawing.Size(1175, 411);
            this.eventslstview.TabIndex = 36;
            this.eventslstview.UseCompatibleStateImageBehavior = false;
            this.eventslstview.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 93;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            this.Event.Width = 250;
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            this.Duration.Width = 93;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 229;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 250;
            // 
            // Recommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MunicipalityApp.Properties.Resources.website_Tshwane;
            this.ClientSize = new System.Drawing.Size(1303, 710);
            this.Controls.Add(this.eventslstview);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.municipalityLbl);
            this.Name = "Recommendations";
            this.Text = "Recommendations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label municipalityLbl;
        private System.Windows.Forms.ListView eventslstview;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Location;
    }
}