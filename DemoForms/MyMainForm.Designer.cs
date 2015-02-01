namespace DemoForms
{
    partial class MyMainForm
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
            this.lblHello = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(54, 32);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(45, 13);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "ХЕЛОУ";
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(57, 80);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(263, 141);
            this.btnHello.TabIndex = 1;
            this.btnHello.Text = "CLICK ME";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // MyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 276);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.lblHello);
            this.Name = "MyMainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnHello;
    }
}

