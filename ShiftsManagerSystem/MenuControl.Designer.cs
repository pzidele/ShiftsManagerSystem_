namespace ShiftsManagerSystem
{
    partial class MenuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clockInOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageShiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockInOutToolStripMenuItem,
            this.viewShiftsToolStripMenuItem,
            this.manageShiftsToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clockInOutToolStripMenuItem
            // 
            this.clockInOutToolStripMenuItem.Name = "clockInOutToolStripMenuItem";
            this.clockInOutToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.clockInOutToolStripMenuItem.Text = "Clock In/Out";
            this.clockInOutToolStripMenuItem.Click += new System.EventHandler(this.clockInOutToolStripMenuItem_Click);
            // 
            // viewShiftsToolStripMenuItem
            // 
            this.viewShiftsToolStripMenuItem.Name = "viewShiftsToolStripMenuItem";
            this.viewShiftsToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.viewShiftsToolStripMenuItem.Text = "View Shifts";
            this.viewShiftsToolStripMenuItem.Click += new System.EventHandler(this.viewShiftsToolStripMenuItem_Click);
            // 
            // manageShiftsToolStripMenuItem
            // 
            this.manageShiftsToolStripMenuItem.Name = "manageShiftsToolStripMenuItem";
            this.manageShiftsToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.manageShiftsToolStripMenuItem.Text = "Manage Shifts";
            this.manageShiftsToolStripMenuItem.Click += new System.EventHandler(this.manageShiftsToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.paymentsToolStripMenuItem.Text = "Payments";
            this.paymentsToolStripMenuItem.Click += new System.EventHandler(this.paymentsToolStripMenuItem_Click);
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(692, 303);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clockInOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewShiftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageShiftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
    }
}
