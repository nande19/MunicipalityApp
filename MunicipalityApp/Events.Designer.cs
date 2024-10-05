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
            this.SuspendLayout();
            // 
            // municipalityLbl
            // 
            this.municipalityLbl.AutoSize = true;
            this.municipalityLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipalityLbl.Location = new System.Drawing.Point(321, 29);
            this.municipalityLbl.Name = "municipalityLbl";
            this.municipalityLbl.Size = new System.Drawing.Size(328, 30);
            this.municipalityLbl.TabIndex = 9;
            this.municipalityLbl.Text = "Please fill in your details";
            // 
            // backBtn
            // 
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
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(125, 208);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 397);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(974, 635);
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
    }
}