﻿namespace MunicipalityApp
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.recomdataGridView = new System.Windows.Forms.DataGridView();
            this.recDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryPicker = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.Recommendations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recomdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // municipalityLbl
            // 
            this.municipalityLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.municipalityLbl.AutoSize = true;
            this.municipalityLbl.BackColor = System.Drawing.Color.Transparent;
            this.municipalityLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalityLbl.Location = new System.Drawing.Point(440, 27);
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
            this.backBtn.Location = new System.Drawing.Point(231, 11);
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
            this.eventslstview.Location = new System.Drawing.Point(62, 213);
            this.eventslstview.Name = "eventslstview";
            this.eventslstview.Size = new System.Drawing.Size(1175, 371);
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
            this.searchbyDatelbl.Location = new System.Drawing.Point(476, 76);
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
            this.searchbyCategorylbl.Location = new System.Drawing.Point(476, 120);
            this.searchbyCategorylbl.Name = "searchbyCategorylbl";
            this.searchbyCategorylbl.Size = new System.Drawing.Size(174, 20);
            this.searchbyCategorylbl.TabIndex = 20;
            this.searchbyCategorylbl.Text = "Search by Category";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(471, 172);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(132, 35);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(673, 172);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(132, 35);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // recomdataGridView
            // 
            this.recomdataGridView.AllowUserToOrderColumns = true;
            this.recomdataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recomdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recomdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recDate,
            this.recEvent,
            this.recDuration,
            this.recCategory,
            this.recLocation});
            this.recomdataGridView.Location = new System.Drawing.Point(128, 640);
            this.recomdataGridView.Name = "recomdataGridView";
            this.recomdataGridView.RowHeadersWidth = 51;
            this.recomdataGridView.RowTemplate.Height = 24;
            this.recomdataGridView.Size = new System.Drawing.Size(1009, 98);
            this.recomdataGridView.TabIndex = 26;
            // 
            // recDate
            // 
            this.recDate.HeaderText = "Date";
            this.recDate.MinimumWidth = 6;
            this.recDate.Name = "recDate";
            this.recDate.Width = 125;
            // 
            // recEvent
            // 
            this.recEvent.HeaderText = "Event";
            this.recEvent.MinimumWidth = 6;
            this.recEvent.Name = "recEvent";
            this.recEvent.Width = 250;
            // 
            // recDuration
            // 
            this.recDuration.HeaderText = "Duration";
            this.recDuration.MinimumWidth = 6;
            this.recDuration.Name = "recDuration";
            this.recDuration.Width = 93;
            // 
            // recCategory
            // 
            this.recCategory.HeaderText = "Category";
            this.recCategory.MinimumWidth = 6;
            this.recCategory.Name = "recCategory";
            this.recCategory.Width = 229;
            // 
            // recLocation
            // 
            this.recLocation.HeaderText = "Location";
            this.recLocation.MinimumWidth = 6;
            this.recLocation.Name = "recLocation";
            this.recLocation.Width = 250;
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
            this.categoryPicker.Location = new System.Drawing.Point(673, 116);
            this.categoryPicker.Name = "categoryPicker";
            this.categoryPicker.Size = new System.Drawing.Size(286, 24);
            this.categoryPicker.TabIndex = 21;
            this.categoryPicker.SelectedIndexChanged += new System.EventHandler(this.categoryPicker_SelectedIndexChanged);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePicker.Location = new System.Drawing.Point(644, 76);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(225, 22);
            this.datePicker.TabIndex = 23;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // Recommendations
            // 
            this.Recommendations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Recommendations.AutoSize = true;
            this.Recommendations.BackColor = System.Drawing.Color.Transparent;
            this.Recommendations.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recommendations.ForeColor = System.Drawing.Color.White;
            this.Recommendations.Location = new System.Drawing.Point(425, 604);
            this.Recommendations.Name = "Recommendations";
            this.Recommendations.Size = new System.Drawing.Size(370, 22);
            this.Recommendations.TabIndex = 27;
            this.Recommendations.Text = "Upcoming Events and Announcemments";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::MunicipalityApp.Properties.Resources.website_Tshwane;
            this.ClientSize = new System.Drawing.Size(1303, 869);
            this.Controls.Add(this.Recommendations);
            this.Controls.Add(this.recomdataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.recomdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label municipalityLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListView eventslstview;
        private System.Windows.Forms.Label searchbyDatelbl;
        private System.Windows.Forms.Label searchbyCategorylbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.DataGridView recomdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn recDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn recEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn recDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn recCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn recLocation;
        private System.Windows.Forms.ComboBox categoryPicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label Recommendations;
    }
}