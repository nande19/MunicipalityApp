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
            this.listView1 = new System.Windows.Forms.ListView();
            this.searchbyDatelbl = new System.Windows.Forms.Label();
            this.searchbyCategorylbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.clearBtn = new System.Windows.Forms.Button();
            this.recommendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // municipalityLbl
            // 
            this.municipalityLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.municipalityLbl.AutoSize = true;
            this.municipalityLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalityLbl.Location = new System.Drawing.Point(245, 29);
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
            this.backBtn.Location = new System.Drawing.Point(36, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 67);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back to Main";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(140, 215);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 397);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // searchbyDatelbl
            // 
            this.searchbyDatelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchbyDatelbl.AutoSize = true;
            this.searchbyDatelbl.Location = new System.Drawing.Point(477, 93);
            this.searchbyDatelbl.Name = "searchbyDatelbl";
            this.searchbyDatelbl.Size = new System.Drawing.Size(100, 16);
            this.searchbyDatelbl.TabIndex = 18;
            this.searchbyDatelbl.Text = "Search by Date";
            // 
            // searchbyCategorylbl
            // 
            this.searchbyCategorylbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchbyCategorylbl.AutoSize = true;
            this.searchbyCategorylbl.Location = new System.Drawing.Point(178, 93);
            this.searchbyCategorylbl.Name = "searchbyCategorylbl";
            this.searchbyCategorylbl.Size = new System.Drawing.Size(126, 16);
            this.searchbyCategorylbl.TabIndex = 20;
            this.searchbyCategorylbl.Text = "Search by Category";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(310, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(339, 156);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(132, 35);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(593, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(524, 156);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(132, 35);
            this.clearBtn.TabIndex = 24;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // recommendBtn
            // 
            this.recommendBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recommendBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.recommendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendBtn.Location = new System.Drawing.Point(625, 618);
            this.recommendBtn.Name = "recommendBtn";
            this.recommendBtn.Size = new System.Drawing.Size(174, 42);
            this.recommendBtn.TabIndex = 25;
            this.recommendBtn.Text = "Recommendations";
            this.recommendBtn.UseVisualStyleBackColor = false;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::MunicipalityApp.Properties.Resources.City_of_Tshwane_Logo_768x01;
            this.ClientSize = new System.Drawing.Size(974, 672);
            this.Controls.Add(this.recommendBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchbyCategorylbl);
            this.Controls.Add(this.searchbyDatelbl);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label searchbyDatelbl;
        private System.Windows.Forms.Label searchbyCategorylbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button recommendBtn;
    }
}