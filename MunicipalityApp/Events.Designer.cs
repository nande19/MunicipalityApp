namespace MunicipalityApp
{
    partial class Events
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
            this.municipalityLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.eventslstview = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchbyDatelbl = new System.Windows.Forms.Label();
            this.searchbyCategorylbl = new System.Windows.Forms.Label();
            this.categoryPicker = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.clearBtn = new System.Windows.Forms.Button();
            this.recommendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // municipalityLbl
            // 
            this.municipalityLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.municipalityLbl.AutoSize = true;
            this.municipalityLbl.BackColor = System.Drawing.Color.Transparent;
            this.municipalityLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalityLbl.Location = new System.Drawing.Point(409, 48);
            this.municipalityLbl.Name = "municipalityLbl";
            this.municipalityLbl.Size = new System.Drawing.Size(502, 30);
            this.municipalityLbl.TabIndex = 9;
            this.municipalityLbl.Text = "Upcoming Events and Announcemments";
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.Crimson;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(200, 32);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 67);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back to Main";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.eventslstview.Location = new System.Drawing.Point(31, 234);
            this.eventslstview.Name = "eventslstview";
            this.eventslstview.Size = new System.Drawing.Size(1175, 411);
            this.eventslstview.TabIndex = 16;
            this.eventslstview.UseCompatibleStateImageBehavior = false;
            this.eventslstview.View = System.Windows.Forms.View.Details;
            this.eventslstview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eventslstview_MouseClick);
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
            // searchbyDatelbl
            // 
            this.searchbyDatelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchbyDatelbl.AutoSize = true;
            this.searchbyDatelbl.BackColor = System.Drawing.Color.Transparent;
            this.searchbyDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbyDatelbl.ForeColor = System.Drawing.Color.White;
            this.searchbyDatelbl.Location = new System.Drawing.Point(445, 97);
            this.searchbyDatelbl.Name = "searchbyDatelbl";
            this.searchbyDatelbl.Size = new System.Drawing.Size(139, 20);
            this.searchbyDatelbl.TabIndex = 18;
            this.searchbyDatelbl.Text = "Search by Date";
            // 
            // searchbyCategorylbl
            // 
            this.searchbyCategorylbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchbyCategorylbl.AutoSize = true;
            this.searchbyCategorylbl.BackColor = System.Drawing.Color.Transparent;
            this.searchbyCategorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbyCategorylbl.ForeColor = System.Drawing.Color.White;
            this.searchbyCategorylbl.Location = new System.Drawing.Point(445, 141);
            this.searchbyCategorylbl.Name = "searchbyCategorylbl";
            this.searchbyCategorylbl.Size = new System.Drawing.Size(174, 20);
            this.searchbyCategorylbl.TabIndex = 20;
            this.searchbyCategorylbl.Text = "Search by Category";
            // 
            // categoryPicker
            // 
            this.categoryPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryPicker.FormattingEnabled = true;
            this.categoryPicker.Items.AddRange(new object[] {
            "Market ",
            "Festival",
            "Arts and Culture",
            "Public Holidays and Commemorations",
            "Tourism Promotion ",
            "Youth Development ",
            "Public Safety and Awareness ",
            "Sports and Recreation ",
            "Educational and Job Creation ",
            "Other"});
            this.categoryPicker.Location = new System.Drawing.Point(642, 137);
            this.categoryPicker.Name = "categoryPicker";
            this.categoryPicker.Size = new System.Drawing.Size(286, 24);
            this.categoryPicker.TabIndex = 21;
            this.categoryPicker.SelectedIndexChanged += new System.EventHandler(this.categoryPicker_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(440, 193);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(132, 35);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePicker.Location = new System.Drawing.Point(613, 97);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(225, 22);
            this.datePicker.TabIndex = 23;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(642, 193);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(132, 35);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // recommendBtn
            // 
            this.recommendBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recommendBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.recommendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendBtn.Location = new System.Drawing.Point(1000, 651);
            this.recommendBtn.Name = "recommendBtn";
            this.recommendBtn.Size = new System.Drawing.Size(174, 42);
            this.recommendBtn.TabIndex = 25;
            this.recommendBtn.Text = "Recommendations";
            this.recommendBtn.UseVisualStyleBackColor = false;
            this.recommendBtn.Click += new System.EventHandler(this.recommendBtn_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::MunicipalityApp.Properties.Resources.website_Tshwane;
            this.ClientSize = new System.Drawing.Size(1303, 710);
            this.Controls.Add(this.recommendBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.categoryPicker);
            this.Controls.Add(this.searchbyCategorylbl);
            this.Controls.Add(this.searchbyDatelbl);
            this.Controls.Add(this.eventslstview);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.municipalityLbl);
            this.Name = "Events";
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label municipalityLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListView eventslstview;
        private System.Windows.Forms.Label searchbyDatelbl;
        private System.Windows.Forms.Label searchbyCategorylbl;
        private System.Windows.Forms.ComboBox categoryPicker;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button recommendBtn;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader Event;
    }
}