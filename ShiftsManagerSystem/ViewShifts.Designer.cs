namespace ShiftsManagerSystem
{
    partial class ViewShifts
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.viewBtn = new System.Windows.Forms.Button();
            this.goDateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuControl1 = new ShiftsManagerSystem.MenuControl();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(904, 413);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(29, 57);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(128, 27);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "View All Shifts";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // goDateBtn
            // 
            this.goDateBtn.Location = new System.Drawing.Point(867, 53);
            this.goDateBtn.Name = "goDateBtn";
            this.goDateBtn.Size = new System.Drawing.Size(58, 33);
            this.goDateBtn.TabIndex = 13;
            this.goDateBtn.Text = "Go";
            this.goDateBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "to";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(575, 57);
            this.endDateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(277, 26);
            this.endDateTimePicker.TabIndex = 11;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(265, 57);
            this.startDateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(270, 26);
            this.startDateTimePicker.TabIndex = 10;
            // 
            // menuControl1
            // 
            this.menuControl1.Location = new System.Drawing.Point(1, 0);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(950, 35);
            this.menuControl1.TabIndex = 14;
            // 
            // ViewShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 521);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.goDateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.listView1);
            this.Name = "ViewShifts";
            this.Text = "ViewShifts";
            this.Load += new System.EventHandler(this.ViewShifts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button goDateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private MenuControl menuControl1;
    }
}