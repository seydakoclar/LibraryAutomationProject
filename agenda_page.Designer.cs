namespace Library
{
    partial class agenda_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agenda_page));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAnAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myCalendarToolStripMenuItem,
            this.makeAnAppointmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myCalendarToolStripMenuItem
            // 
            this.myCalendarToolStripMenuItem.Name = "myCalendarToolStripMenuItem";
            this.myCalendarToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.myCalendarToolStripMenuItem.Text = "Make an Appointment";
            this.myCalendarToolStripMenuItem.Click += new System.EventHandler(this.myCalendarToolStripMenuItem_Click);
            // 
            // makeAnAppointmentToolStripMenuItem
            // 
            this.makeAnAppointmentToolStripMenuItem.Name = "makeAnAppointmentToolStripMenuItem";
            this.makeAnAppointmentToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.makeAnAppointmentToolStripMenuItem.Text = "My Calendar";
            this.makeAnAppointmentToolStripMenuItem.Click += new System.EventHandler(this.makeAnAppointmentToolStripMenuItem_Click);
            // 
            // agenda_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 431);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "agenda_page";
            this.Text = "Agenda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAnAppointmentToolStripMenuItem;
    }
}