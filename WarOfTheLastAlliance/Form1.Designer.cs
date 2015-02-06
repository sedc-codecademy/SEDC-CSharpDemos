namespace WarOfTheLastAlliance
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnMakeCreature = new System.Windows.Forms.Button();
            this.lbCreatures = new System.Windows.Forms.ListBox();
            this.btnOrc = new System.Windows.Forms.Button();
            this.btnHuman = new System.Windows.Forms.Button();
            this.btnElf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(39, 23);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(227, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Armies";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnMakeCreature
            // 
            this.btnMakeCreature.Location = new System.Drawing.Point(294, 12);
            this.btnMakeCreature.Name = "btnMakeCreature";
            this.btnMakeCreature.Size = new System.Drawing.Size(177, 33);
            this.btnMakeCreature.TabIndex = 1;
            this.btnMakeCreature.Text = "Make a creature";
            this.btnMakeCreature.UseVisualStyleBackColor = true;
            this.btnMakeCreature.Click += new System.EventHandler(this.btnMakeCreature_Click);
            // 
            // lbCreatures
            // 
            this.lbCreatures.FormattingEnabled = true;
            this.lbCreatures.Location = new System.Drawing.Point(294, 52);
            this.lbCreatures.Name = "lbCreatures";
            this.lbCreatures.Size = new System.Drawing.Size(177, 355);
            this.lbCreatures.TabIndex = 2;
            // 
            // btnOrc
            // 
            this.btnOrc.Location = new System.Drawing.Point(477, 91);
            this.btnOrc.Name = "btnOrc";
            this.btnOrc.Size = new System.Drawing.Size(177, 33);
            this.btnOrc.TabIndex = 3;
            this.btnOrc.Text = "Make an orc";
            this.btnOrc.UseVisualStyleBackColor = true;
            this.btnOrc.Click += new System.EventHandler(this.btnOrc_Click);
            // 
            // btnHuman
            // 
            this.btnHuman.Location = new System.Drawing.Point(477, 52);
            this.btnHuman.Name = "btnHuman";
            this.btnHuman.Size = new System.Drawing.Size(177, 33);
            this.btnHuman.TabIndex = 4;
            this.btnHuman.Text = "Make a human";
            this.btnHuman.UseVisualStyleBackColor = true;
            this.btnHuman.Click += new System.EventHandler(this.btnHuman_Click);
            // 
            // btnElf
            // 
            this.btnElf.Location = new System.Drawing.Point(477, 13);
            this.btnElf.Name = "btnElf";
            this.btnElf.Size = new System.Drawing.Size(177, 33);
            this.btnElf.TabIndex = 5;
            this.btnElf.Text = "Make an elf";
            this.btnElf.UseVisualStyleBackColor = true;
            this.btnElf.Click += new System.EventHandler(this.btnElf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.btnElf);
            this.Controls.Add(this.btnHuman);
            this.Controls.Add(this.btnOrc);
            this.Controls.Add(this.lbCreatures);
            this.Controls.Add(this.btnMakeCreature);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnMakeCreature;
        private System.Windows.Forms.ListBox lbCreatures;
        private System.Windows.Forms.Button btnOrc;
        private System.Windows.Forms.Button btnHuman;
        private System.Windows.Forms.Button btnElf;
    }
}

