namespace WinForm
{
    partial class FirstGUI
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
            this.BTNEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNEvents
            // 
            this.BTNEvents.Location = new System.Drawing.Point(12, 24);
            this.BTNEvents.Name = "BTNEvents";
            this.BTNEvents.Size = new System.Drawing.Size(107, 38);
            this.BTNEvents.TabIndex = 0;
            this.BTNEvents.Text = "Run Events";
            this.BTNEvents.UseVisualStyleBackColor = true;
            this.BTNEvents.Click += new System.EventHandler(this.BTNEvents_Click);
            this.BTNEvents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BTNEvents_MouseClick);
            this.BTNEvents.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTNEvents_MouseDown);
            this.BTNEvents.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTNEvents_MouseUp);
            // 
            // FirstGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 375);
            this.Controls.Add(this.BTNEvents);
            this.Name = "FirstGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNEvents;
    }
}

