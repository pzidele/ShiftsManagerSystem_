namespace ShiftsManagerSystem
{
    partial class Payments
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
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resultLbl = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.changeRateBtn = new System.Windows.Forms.Button();
            this.viewUnpaidBtn = new System.Windows.Forms.Button();
            this.unpaidAmtLbl = new System.Windows.Forms.Label();
            this.menuControl1 = new ShiftsManagerSystem.MenuControl();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Make payment:";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(782, 417);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 20);
            this.resultLbl.TabIndex = 7;
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(709, 440);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(125, 41);
            this.payBtn.TabIndex = 6;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter amount:";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(171, 342);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose user:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose date:";
            // 
            // paymentDateTimePicker
            // 
            this.paymentDateTimePicker.Location = new System.Drawing.Point(628, 254);
            this.paymentDateTimePicker.Name = "paymentDateTimePicker";
            this.paymentDateTimePicker.Size = new System.Drawing.Size(320, 26);
            this.paymentDateTimePicker.TabIndex = 0;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(728, 366);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 26);
            this.amountTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Change rate:";
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(391, 254);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 26);
            this.rateTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter new rate for chosen user:";
            // 
            // changeRateBtn
            // 
            this.changeRateBtn.Location = new System.Drawing.Point(376, 313);
            this.changeRateBtn.Name = "changeRateBtn";
            this.changeRateBtn.Size = new System.Drawing.Size(125, 41);
            this.changeRateBtn.TabIndex = 12;
            this.changeRateBtn.Text = "Change Rate";
            this.changeRateBtn.UseVisualStyleBackColor = true;
            this.changeRateBtn.Click += new System.EventHandler(this.changeRateBtn_Click);
            // 
            // viewUnpaidBtn
            // 
            this.viewUnpaidBtn.Location = new System.Drawing.Point(391, 431);
            this.viewUnpaidBtn.Name = "viewUnpaidBtn";
            this.viewUnpaidBtn.Size = new System.Drawing.Size(107, 59);
            this.viewUnpaidBtn.TabIndex = 13;
            this.viewUnpaidBtn.Text = "View Unpaid Amount";
            this.viewUnpaidBtn.UseVisualStyleBackColor = true;
            this.viewUnpaidBtn.Click += new System.EventHandler(this.viewUnpaidBtn_Click);
            // 
            // unpaidAmtLbl
            // 
            this.unpaidAmtLbl.AutoSize = true;
            this.unpaidAmtLbl.Location = new System.Drawing.Point(422, 512);
            this.unpaidAmtLbl.Name = "unpaidAmtLbl";
            this.unpaidAmtLbl.Size = new System.Drawing.Size(0, 20);
            this.unpaidAmtLbl.TabIndex = 14;
            // 
            // menuControl1
            // 
            this.menuControl1.Location = new System.Drawing.Point(1, 0);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(964, 34);
            this.menuControl1.TabIndex = 15;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 582);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.unpaidAmtLbl);
            this.Controls.Add(this.viewUnpaidBtn);
            this.Controls.Add(this.changeRateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentDateTimePicker);
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker paymentDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button changeRateBtn;
        private System.Windows.Forms.Button viewUnpaidBtn;
        private System.Windows.Forms.Label unpaidAmtLbl;
        private MenuControl menuControl1;
    }
}