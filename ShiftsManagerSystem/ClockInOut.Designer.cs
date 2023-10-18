namespace ShiftsManagerSystem
{
    partial class ClockInOut
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
            this.clockInBtn = new System.Windows.Forms.Button();
            this.clockOutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.resultLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuControl1 = new ShiftsManagerSystem.MenuControl();
            this.SuspendLayout();
            // 
            // clockInBtn
            // 
            this.clockInBtn.Location = new System.Drawing.Point(568, 158);
            this.clockInBtn.Name = "clockInBtn";
            this.clockInBtn.Size = new System.Drawing.Size(96, 43);
            this.clockInBtn.TabIndex = 0;
            this.clockInBtn.Text = "Clock In";
            this.clockInBtn.UseVisualStyleBackColor = true;
            this.clockInBtn.Click += new System.EventHandler(this.clockInBtn_Click);
            // 
            // clockOutBtn
            // 
            this.clockOutBtn.Location = new System.Drawing.Point(568, 273);
            this.clockOutBtn.Name = "clockOutBtn";
            this.clockOutBtn.Size = new System.Drawing.Size(96, 43);
            this.clockOutBtn.TabIndex = 3;
            this.clockOutBtn.Text = "Clock Out";
            this.clockOutBtn.UseVisualStyleBackColor = true;
            this.clockOutBtn.Click += new System.EventHandler(this.clockOutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose user to clock in or out:";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(130, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(218, 261);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(585, 364);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 20);
            this.resultLbl.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuControl1
            // 
            this.menuControl1.Location = new System.Drawing.Point(13, 1);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(879, 34);
            this.menuControl1.TabIndex = 8;
            // 
            // ClockInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 503);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clockOutBtn);
            this.Controls.Add(this.clockInBtn);
            this.Name = "ClockInOut";
            this.Text = "Clock In/Out";
            this.Load += new System.EventHandler(this.ClockInOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clockInBtn;
        private System.Windows.Forms.Button clockOutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Timer timer1;
        private MenuControl menuControl1;
    }
}