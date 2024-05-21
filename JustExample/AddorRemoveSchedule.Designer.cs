namespace RailWay
{
    partial class AddorRemoveSchedule
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pickDate = new System.Windows.Forms.DateTimePicker();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.HourGetter = new System.Windows.Forms.NumericUpDown();
            this.MinuteGetter = new System.Windows.Forms.NumericUpDown();
            this.ScheduleShower = new System.Windows.Forms.DataGridView();
            this.btnAddShedule = new System.Windows.Forms.Button();
            this.btnRemoveSchedule = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stationViewer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inpDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourGetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteGetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleShower)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1822, 921);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 32);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pickDate
            // 
            this.pickDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDate.Location = new System.Drawing.Point(12, 158);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(368, 30);
            this.pickDate.TabIndex = 19;
            this.pickDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTodayDate.Location = new System.Drawing.Point(1482, 65);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(80, 36);
            this.lblTodayDate.TabIndex = 20;
            this.lblTodayDate.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(439, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1465, 752);
            this.panel1.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 33);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 422);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(368, 33);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // HourGetter
            // 
            this.HourGetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourGetter.Location = new System.Drawing.Point(13, 233);
            this.HourGetter.Name = "HourGetter";
            this.HourGetter.Size = new System.Drawing.Size(79, 30);
            this.HourGetter.TabIndex = 24;
            // 
            // MinuteGetter
            // 
            this.MinuteGetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteGetter.Location = new System.Drawing.Point(137, 233);
            this.MinuteGetter.Name = "MinuteGetter";
            this.MinuteGetter.Size = new System.Drawing.Size(79, 30);
            this.MinuteGetter.TabIndex = 25;
            // 
            // ScheduleShower
            // 
            this.ScheduleShower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleShower.Location = new System.Drawing.Point(439, 122);
            this.ScheduleShower.Name = "ScheduleShower";
            this.ScheduleShower.RowHeadersWidth = 51;
            this.ScheduleShower.RowTemplate.Height = 24;
            this.ScheduleShower.Size = new System.Drawing.Size(1462, 744);
            this.ScheduleShower.TabIndex = 0;
            this.ScheduleShower.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleShower_CellDoubleClick);
            // 
            // btnAddShedule
            // 
            this.btnAddShedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShedule.Location = new System.Drawing.Point(13, 540);
            this.btnAddShedule.Name = "btnAddShedule";
            this.btnAddShedule.Size = new System.Drawing.Size(90, 32);
            this.btnAddShedule.TabIndex = 26;
            this.btnAddShedule.Text = "&Add";
            this.btnAddShedule.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSchedule
            // 
            this.btnRemoveSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSchedule.Location = new System.Drawing.Point(160, 540);
            this.btnRemoveSchedule.Name = "btnRemoveSchedule";
            this.btnRemoveSchedule.Size = new System.Drawing.Size(108, 32);
            this.btnRemoveSchedule.TabIndex = 27;
            this.btnRemoveSchedule.Text = "&Delete";
            this.btnRemoveSchedule.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.stationViewer);
            this.panel2.Location = new System.Drawing.Point(13, 624);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 250);
            this.panel2.TabIndex = 28;
            // 
            // stationViewer
            // 
            this.stationViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationViewer.Location = new System.Drawing.Point(3, 3);
            this.stationViewer.Name = "stationViewer";
            this.stationViewer.RowHeadersWidth = 51;
            this.stationViewer.RowTemplate.Height = 24;
            this.stationViewer.Size = new System.Drawing.Size(393, 244);
            this.stationViewer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(13, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Hr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(134, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(13, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Train";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(13, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Route";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Rt.id              St.pt            Ed.pt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tr.id              Name            Max";
            // 
            // inpDate
            // 
            this.inpDate.AutoSize = true;
            this.inpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inpDate.Location = new System.Drawing.Point(83, 122);
            this.inpDate.Name = "inpDate";
            this.inpDate.Size = new System.Drawing.Size(200, 16);
            this.inpDate.TabIndex = 36;
            this.inpDate.Text = "Impute Date to Enable Train";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(436, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(412, 36);
            this.label9.TabIndex = 37;
            this.label9.Text = "Create or Remove Schedule";
            // 
            // AddorRemoveSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inpDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ScheduleShower);
            this.Controls.Add(this.btnRemoveSchedule);
            this.Controls.Add(this.btnAddShedule);
            this.Controls.Add(this.MinuteGetter);
            this.Controls.Add(this.HourGetter);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.pickDate);
            this.Controls.Add(this.btnBack);
            this.Name = "AddorRemoveSchedule";
            this.Text = "AddorRemoveSchedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddorRemoveSchedule_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourGetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteGetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleShower)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker pickDate;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown HourGetter;
        private System.Windows.Forms.NumericUpDown MinuteGetter;
        private System.Windows.Forms.DataGridView ScheduleShower;
        private System.Windows.Forms.Button btnAddShedule;
        private System.Windows.Forms.Button btnRemoveSchedule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView stationViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label inpDate;
        private System.Windows.Forms.Label label9;
    }
}