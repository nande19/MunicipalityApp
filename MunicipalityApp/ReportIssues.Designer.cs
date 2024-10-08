namespace MunicipalityApp
{
    partial class ReportIssues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssues));
            this.locationLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.photoAttachLbl = new System.Windows.Forms.Label();
            this.municipalityLbl = new System.Windows.Forms.Label();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.attachBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.imagePicture = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // locationLbl
            // 
            this.locationLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.Location = new System.Drawing.Point(72, 124);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(87, 20);
            this.locationLbl.TabIndex = 1;
            this.locationLbl.Text = "Location:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(72, 263);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(106, 20);
            this.descriptionLbl.TabIndex = 3;
            this.descriptionLbl.Text = "Description";
            // 
            // photoAttachLbl
            // 
            this.photoAttachLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.photoAttachLbl.AutoSize = true;
            this.photoAttachLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoAttachLbl.Location = new System.Drawing.Point(72, 387);
            this.photoAttachLbl.Name = "photoAttachLbl";
            this.photoAttachLbl.Size = new System.Drawing.Size(133, 20);
            this.photoAttachLbl.TabIndex = 4;
            this.photoAttachLbl.Text = "Attach a Photo";
            // 
            // municipalityLbl
            // 
            this.municipalityLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.municipalityLbl.AutoSize = true;
            this.municipalityLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalityLbl.Location = new System.Drawing.Point(302, 40);
            this.municipalityLbl.Name = "municipalityLbl";
            this.municipalityLbl.Size = new System.Drawing.Size(328, 30);
            this.municipalityLbl.TabIndex = 8;
            this.municipalityLbl.Text = "Please fill in your details";
            // 
            // locationTxt
            // 
            this.locationTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationTxt.Location = new System.Drawing.Point(343, 124);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(230, 22);
            this.locationTxt.TabIndex = 9;
            this.locationTxt.TextChanged += new System.EventHandler(this.locationTxt_TextChanged);
            // 
            // categoryLbl
            // 
            this.categoryLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(72, 192);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(223, 20);
            this.categoryLbl.TabIndex = 11;
            this.categoryLbl.Text = "Please select a category:";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTxt.Location = new System.Drawing.Point(343, 255);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(310, 96);
            this.descriptionTxt.TabIndex = 12;
            this.descriptionTxt.Text = "";
            this.descriptionTxt.TextChanged += new System.EventHandler(this.descriptionTxt_TextChanged);
            // 
            // categoryBox
            // 
            this.categoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities",
            "Public Safety",
            "Environment",
            "Streetlights",
            "Water Supply",
            "Waste Management"});
            this.categoryBox.Location = new System.Drawing.Point(343, 188);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(230, 24);
            this.categoryBox.TabIndex = 10;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // attachBtn
            // 
            this.attachBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachBtn.Location = new System.Drawing.Point(76, 433);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(131, 31);
            this.attachBtn.TabIndex = 13;
            this.attachBtn.Text = "Select";
            this.attachBtn.UseVisualStyleBackColor = true;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.Crimson;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(48, 27);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 67);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Back to Main";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(321, 563);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(132, 43);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // imagePicture
            // 
            this.imagePicture.BackColor = System.Drawing.Color.White;
            this.imagePicture.Location = new System.Drawing.Point(343, 387);
            this.imagePicture.Name = "imagePicture";
            this.imagePicture.Size = new System.Drawing.Size(310, 116);
            this.imagePicture.TabIndex = 17;
            this.imagePicture.TabStop = false;
            this.imagePicture.Click += new System.EventHandler(this.imagePicture_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(231, 520);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(316, 23);
            this.progressBar.TabIndex = 15;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // ReportIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.imagePicture);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.municipalityLbl);
            this.Controls.Add(this.photoAttachLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.locationLbl);
            this.Name = "ReportIssues";
            this.Text = "Report Issues";
            ((System.ComponentModel.ISupportInitialize)(this.imagePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label photoAttachLbl;
        private System.Windows.Forms.Label municipalityLbl;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button attachBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox imagePicture;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}