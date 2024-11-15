namespace MunicipalityApp
{
    partial class ServiceRequests
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
            this.statusLst = new System.Windows.Forms.ListView();
            this.requestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.submittedRequest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requestDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requestStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.servicerequestLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLst
            // 
            this.statusLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.requestID,
            this.submittedRequest,
            this.requestDescription,
            this.requestStatus});
            this.statusLst.GridLines = true;
            this.statusLst.HideSelection = false;
            this.statusLst.Location = new System.Drawing.Point(111, 196);
            this.statusLst.Name = "statusLst";
            this.statusLst.Size = new System.Drawing.Size(909, 338);
            this.statusLst.TabIndex = 0;
            this.statusLst.UseCompatibleStateImageBehavior = false;
            this.statusLst.View = System.Windows.Forms.View.Details;
            // 
            // requestID
            // 
            this.requestID.Text = "Request ID";
            this.requestID.Width = 115;
            // 
            // submittedRequest
            // 
            this.submittedRequest.Text = "Submitted Request";
            this.submittedRequest.Width = 183;
            // 
            // requestDescription
            // 
            this.requestDescription.Text = "Request Description";
            this.requestDescription.Width = 319;
            // 
            // requestStatus
            // 
            this.requestStatus.Text = "Request Status";
            this.requestStatus.Width = 288;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(353, 133);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(161, 22);
            this.searchTxt.TabIndex = 3;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(646, 100);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(132, 35);
            this.searchBtn.TabIndex = 23;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // servicerequestLbl
            // 
            this.servicerequestLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicerequestLbl.AutoSize = true;
            this.servicerequestLbl.BackColor = System.Drawing.Color.Transparent;
            this.servicerequestLbl.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.servicerequestLbl.Location = new System.Drawing.Point(418, 33);
            this.servicerequestLbl.Name = "servicerequestLbl";
            this.servicerequestLbl.Size = new System.Drawing.Size(214, 30);
            this.servicerequestLbl.TabIndex = 24;
            this.servicerequestLbl.Text = "Service Requests";
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.Crimson;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(155, 52);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 65);
            this.backBtn.TabIndex = 25;
            this.backBtn.Text = "Back to Main";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // ServiceRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::MunicipalityApp.Properties.Resources.website_Tshwane;
            this.ClientSize = new System.Drawing.Size(1122, 631);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.servicerequestLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.statusLst);
            this.Name = "ServiceRequests";
            this.Text = "ServiceRequests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView statusLst;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ColumnHeader requestID;
        private System.Windows.Forms.ColumnHeader submittedRequest;
        private System.Windows.Forms.ColumnHeader requestDescription;
        private System.Windows.Forms.ColumnHeader requestStatus;
        private System.Windows.Forms.Label servicerequestLbl;
        private System.Windows.Forms.Button backBtn;
    }
}