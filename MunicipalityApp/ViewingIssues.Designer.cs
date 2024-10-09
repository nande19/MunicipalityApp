namespace MunicipalityApp
{
    partial class ViewingIssues
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewingIssues));
            this.viewingLbl = new System.Windows.Forms.Label();
            this.viewLstVw = new System.Windows.Forms.ListView();
            this.backBtn = new System.Windows.Forms.Button();
            this.attachmentsImageList = new System.Windows.Forms.ImageList(this.components);
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Attachment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewingLbl
            // 
            this.viewingLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewingLbl.AutoSize = true;
            this.viewingLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.viewingLbl.Location = new System.Drawing.Point(386, 50);
            this.viewingLbl.Name = "viewingLbl";
            this.viewingLbl.Size = new System.Drawing.Size(228, 30);
            this.viewingLbl.TabIndex = 1;
            this.viewingLbl.Text = "View your details";
            // 
            // viewLstVw
            // 
            this.viewLstVw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewLstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Location,
            this.Category,
            this.Description,
            this.Attachment});
            this.viewLstVw.FullRowSelect = true;
            this.viewLstVw.GridLines = true;
            this.viewLstVw.HideSelection = false;
            this.viewLstVw.Location = new System.Drawing.Point(78, 159);
            this.viewLstVw.Name = "viewLstVw";
            this.viewLstVw.Size = new System.Drawing.Size(852, 450);
            this.viewLstVw.TabIndex = 2;
            this.viewLstVw.UseCompatibleStateImageBehavior = false;
            this.viewLstVw.View = System.Windows.Forms.View.Details;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.Crimson;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(54, 39);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 65);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back to Main";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // attachmentsImageList
            // 
            this.attachmentsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.attachmentsImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.attachmentsImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 150;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 150;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 200;
            // 
            // Attachment
            // 
            this.Attachment.Text = "Attachment";
            this.Attachment.Width = 300;
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(936, 605);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 16;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // ViewingIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1053, 670);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.viewLstVw);
            this.Controls.Add(this.viewingLbl);
            this.Name = "ViewingIssues";
            this.Text = "Viewing Issues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label viewingLbl;
        private System.Windows.Forms.ListView viewLstVw;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ImageList attachmentsImageList;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Attachment;
        private System.Windows.Forms.Button removeBtn;
    }
}