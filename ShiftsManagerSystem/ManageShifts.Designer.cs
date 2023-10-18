namespace ShiftsManagerSystem
{
    partial class ManageShifts
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateOutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.outDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateInBtn = new System.Windows.Forms.Button();
            this.inLbl = new System.Windows.Forms.Label();
            this.outLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resultLbl = new System.Windows.Forms.Label();
            this.deleteOutBtn = new System.Windows.Forms.Button();
            this.menuControl1 = new ShiftsManagerSystem.MenuControl();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(379, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(558, 428);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(102, 458);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(123, 34);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete Shift";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateOutBtn
            // 
            this.updateOutBtn.Location = new System.Drawing.Point(112, 306);
            this.updateOutBtn.Name = "updateOutBtn";
            this.updateOutBtn.Size = new System.Drawing.Size(87, 34);
            this.updateOutBtn.TabIndex = 2;
            this.updateOutBtn.Text = "Update";
            this.updateOutBtn.UseVisualStyleBackColor = true;
            this.updateOutBtn.Click += new System.EventHandler(this.updateOutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Clock In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Clock Out";
            // 
            // inDateTimePicker
            // 
            this.inDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inDateTimePicker.Location = new System.Drawing.Point(12, 89);
            this.inDateTimePicker.Name = "inDateTimePicker";
            this.inDateTimePicker.Size = new System.Drawing.Size(297, 26);
            this.inDateTimePicker.TabIndex = 11;
            // 
            // outDateTimePicker
            // 
            this.outDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.outDateTimePicker.Location = new System.Drawing.Point(12, 241);
            this.outDateTimePicker.Name = "outDateTimePicker";
            this.outDateTimePicker.Size = new System.Drawing.Size(297, 26);
            this.outDateTimePicker.TabIndex = 12;
            // 
            // updateInBtn
            // 
            this.updateInBtn.Location = new System.Drawing.Point(112, 147);
            this.updateInBtn.Name = "updateInBtn";
            this.updateInBtn.Size = new System.Drawing.Size(87, 34);
            this.updateInBtn.TabIndex = 13;
            this.updateInBtn.Text = "Update";
            this.updateInBtn.UseVisualStyleBackColor = true;
            this.updateInBtn.Click += new System.EventHandler(this.updateInBtn_Click);
            // 
            // inLbl
            // 
            this.inLbl.AutoSize = true;
            this.inLbl.Location = new System.Drawing.Point(108, 185);
            this.inLbl.Name = "inLbl";
            this.inLbl.Size = new System.Drawing.Size(0, 20);
            this.inLbl.TabIndex = 14;
            // 
            // outLbl
            // 
            this.outLbl.AutoSize = true;
            this.outLbl.Location = new System.Drawing.Point(108, 345);
            this.outLbl.Name = "outLbl";
            this.outLbl.Size = new System.Drawing.Size(0, 20);
            this.outLbl.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(72, 29);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 20);
            this.resultLbl.TabIndex = 16;
            // 
            // deleteOutBtn
            // 
            this.deleteOutBtn.Location = new System.Drawing.Point(37, 368);
            this.deleteOutBtn.Name = "deleteOutBtn";
            this.deleteOutBtn.Size = new System.Drawing.Size(232, 36);
            this.deleteOutBtn.TabIndex = 17;
            this.deleteOutBtn.Text = "Delete Current Clock Out";
            this.deleteOutBtn.UseVisualStyleBackColor = true;
            this.deleteOutBtn.Click += new System.EventHandler(this.deleteOutBtn_Click);
            // 
            // menuControl1
            // 
            this.menuControl1.Location = new System.Drawing.Point(-1, 1);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(971, 31);
            this.menuControl1.TabIndex = 18;
            // 
            // ManageShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 504);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.deleteOutBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.outLbl);
            this.Controls.Add(this.inLbl);
            this.Controls.Add(this.updateInBtn);
            this.Controls.Add(this.outDateTimePicker);
            this.Controls.Add(this.inDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateOutBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.listView1);
            this.Name = "ManageShifts";
            this.Text = "ManageShifts";
            this.Load += new System.EventHandler(this.ManageShifts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateOutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inDateTimePicker;
        private System.Windows.Forms.DateTimePicker outDateTimePicker;
        private System.Windows.Forms.Button updateInBtn;
        private System.Windows.Forms.Label inLbl;
        private System.Windows.Forms.Label outLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button deleteOutBtn;
        private MenuControl menuControl1;
    }
}