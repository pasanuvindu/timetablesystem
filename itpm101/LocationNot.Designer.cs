namespace itpm101
{
    partial class LocationNot
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
            this.tab3_notAvailableTimes = new System.Windows.Forms.TabControl();
            this.tab = new System.Windows.Forms.TabPage();
            this.cmbSelectRoom = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab3_notAvailableTimes.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab3_notAvailableTimes
            // 
            this.tab3_notAvailableTimes.Controls.Add(this.tab);
            this.tab3_notAvailableTimes.Location = new System.Drawing.Point(22, 24);
            this.tab3_notAvailableTimes.Name = "tab3_notAvailableTimes";
            this.tab3_notAvailableTimes.SelectedIndex = 0;
            this.tab3_notAvailableTimes.Size = new System.Drawing.Size(1369, 615);
            this.tab3_notAvailableTimes.TabIndex = 0;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.cmbSelectRoom);
            this.tab.Controls.Add(this.dateTimePicker1);
            this.tab.Controls.Add(this.btnAddSession);
            this.tab.Controls.Add(this.btnClear);
            this.tab.Controls.Add(this.txtEndTime);
            this.tab.Controls.Add(this.txtStartTime);
            this.tab.Controls.Add(this.label4);
            this.tab.Controls.Add(this.label3);
            this.tab.Controls.Add(this.label2);
            this.tab.Controls.Add(this.label1);
            this.tab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.tab.Location = new System.Drawing.Point(4, 25);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(1361, 586);
            this.tab.TabIndex = 2;
            this.tab.Text = "Not Available Times";
            this.tab.UseVisualStyleBackColor = true;
            this.tab.Click += new System.EventHandler(this.tab_Click);
            // 
            // cmbSelectRoom
            // 
            this.cmbSelectRoom.FormattingEnabled = true;
            this.cmbSelectRoom.Items.AddRange(new object[] {
            "Room 1",
            "Room 2",
            "Room 3",
            "Room 4"});
            this.cmbSelectRoom.Location = new System.Drawing.Point(475, 255);
            this.cmbSelectRoom.Name = "cmbSelectRoom";
            this.cmbSelectRoom.Size = new System.Drawing.Size(205, 24);
            this.cmbSelectRoom.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(475, 322);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnAddSession
            // 
            this.btnAddSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.btnAddSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSession.Location = new System.Drawing.Point(525, 431);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(155, 53);
            this.btnAddSession.TabIndex = 10;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = false;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(705, 431);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 53);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(864, 322);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(186, 22);
            this.txtEndTime.TabIndex = 8;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(864, 255);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(186, 22);
            this.txtStartTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(746, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(746, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(339, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(339, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Room";
            // 
            // LocationNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1403, 637);
            this.Controls.Add(this.tab3_notAvailableTimes);
            this.Name = "LocationNot";
            this.Text = "Add Rooms and Times";
            this.tab3_notAvailableTimes.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab3_notAvailableTimes;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbSelectRoom;
    }
}