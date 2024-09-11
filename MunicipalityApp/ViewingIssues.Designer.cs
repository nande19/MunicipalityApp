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
            this.viewingLbl = new System.Windows.Forms.Label();
            this.viewLstVw = new System.Windows.Forms.ListView();
            this.backBtn = new System.Windows.Forms.Button();
            this.attachmentsImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // viewingLbl
            // 
            this.viewingLbl.AutoSize = true;
            this.viewingLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.viewingLbl.Location = new System.Drawing.Point(386, 41);
            this.viewingLbl.Name = "viewingLbl";
            this.viewingLbl.Size = new System.Drawing.Size(228, 30);
            this.viewingLbl.TabIndex = 1;
            this.viewingLbl.Text = "View your details";
            // 
            // viewLstVw
            // 
            this.viewLstVw.HideSelection = false;
            this.viewLstVw.Location = new System.Drawing.Point(100, 150);
            this.viewLstVw.Name = "viewLstVw";
            this.viewLstVw.Size = new System.Drawing.Size(800, 397);
            this.viewLstVw.TabIndex = 2;
            this.viewLstVw.UseCompatibleStateImageBehavior = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Crimson;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(54, 30);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 56);
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
            // ViewingIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1101, 653);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.viewLstVw);
            this.Controls.Add(this.viewingLbl);
            this.Name = "ViewingIssues";
            this.Text = "ViewingIssues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label viewingLbl;
        private System.Windows.Forms.ListView viewLstVw;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ImageList attachmentsImageList;
    }
}