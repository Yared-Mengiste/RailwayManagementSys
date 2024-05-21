namespace Railway
{
    partial class AddMinFirst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMinFirst));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnAddScheduleOpt = new System.Windows.Forms.Button();
            this.btnViewPersonalInfo = new System.Windows.Forms.Button();
            this.btnAnalyzeRev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.Location = new System.Drawing.Point(1254, 740);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(462, 202);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 36);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "label1";
            // 
            // btnAddScheduleOpt
            // 
            this.btnAddScheduleOpt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddScheduleOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScheduleOpt.Location = new System.Drawing.Point(434, 414);
            this.btnAddScheduleOpt.Name = "btnAddScheduleOpt";
            this.btnAddScheduleOpt.Size = new System.Drawing.Size(564, 53);
            this.btnAddScheduleOpt.TabIndex = 3;
            this.btnAddScheduleOpt.Text = "2. Add or Remove Schedule";
            this.btnAddScheduleOpt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddScheduleOpt.UseVisualStyleBackColor = true;
            this.btnAddScheduleOpt.Click += new System.EventHandler(this.btnAddScheduleOpt_Click);
            // 
            // btnViewPersonalInfo
            // 
            this.btnViewPersonalInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPersonalInfo.Location = new System.Drawing.Point(434, 314);
            this.btnViewPersonalInfo.Name = "btnViewPersonalInfo";
            this.btnViewPersonalInfo.Size = new System.Drawing.Size(564, 53);
            this.btnViewPersonalInfo.TabIndex = 4;
            this.btnViewPersonalInfo.Text = "1. View Personal Information";
            this.btnViewPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPersonalInfo.UseVisualStyleBackColor = true;
            this.btnViewPersonalInfo.Click += new System.EventHandler(this.btnViewPersonalInfo_Click);
            // 
            // btnAnalyzeRev
            // 
            this.btnAnalyzeRev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnalyzeRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyzeRev.Location = new System.Drawing.Point(434, 521);
            this.btnAnalyzeRev.Name = "btnAnalyzeRev";
            this.btnAnalyzeRev.Size = new System.Drawing.Size(564, 53);
            this.btnAnalyzeRev.TabIndex = 5;
            this.btnAnalyzeRev.Text = "3. Analize Revenue";
            this.btnAnalyzeRev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyzeRev.UseVisualStyleBackColor = true;
            // 
            // AddMinFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 775);
            this.Controls.Add(this.btnAnalyzeRev);
            this.Controls.Add(this.btnViewPersonalInfo);
            this.Controls.Add(this.btnAddScheduleOpt);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMinFirst";
            this.Text = "Addministrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddMinFirst_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnAddScheduleOpt;
        private System.Windows.Forms.Button btnViewPersonalInfo;
        private System.Windows.Forms.Button btnAnalyzeRev;
    }
}