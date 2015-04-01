namespace EventExerciseWin
{
    partial class Form1
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
            this.btnMakeVehicles = new System.Windows.Forms.Button();
            this.lstVehicles = new System.Windows.Forms.ListBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMakeVehicles
            // 
            this.btnMakeVehicles.Location = new System.Drawing.Point(27, 13);
            this.btnMakeVehicles.Name = "btnMakeVehicles";
            this.btnMakeVehicles.Size = new System.Drawing.Size(223, 23);
            this.btnMakeVehicles.TabIndex = 0;
            this.btnMakeVehicles.Text = "Make Vehicles";
            this.btnMakeVehicles.UseVisualStyleBackColor = true;
            this.btnMakeVehicles.Click += new System.EventHandler(this.btnMakeVehicles_Click);
            // 
            // lstVehicles
            // 
            this.lstVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstVehicles.FormattingEnabled = true;
            this.lstVehicles.Location = new System.Drawing.Point(27, 43);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(268, 420);
            this.lstVehicles.TabIndex = 1;
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(256, 13);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(223, 23);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit 2 Vehicles";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lstReport
            // 
            this.lstReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstReport.FormattingEnabled = true;
            this.lstReport.Location = new System.Drawing.Point(599, 40);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(268, 420);
            this.lstReport.TabIndex = 3;
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(316, 43);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(268, 420);
            this.lstHistory.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 472);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lstVehicles);
            this.Controls.Add(this.btnMakeVehicles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeVehicles;
        private System.Windows.Forms.ListBox lstVehicles;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.ListBox lstHistory;
    }
}

