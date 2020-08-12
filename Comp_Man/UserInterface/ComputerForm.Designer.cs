namespace UserInterface
{
    partial class ComputerForm
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
            this.compUpgrade = new System.Windows.Forms.Button();
            this.hddUpgrade = new System.Windows.Forms.Button();
            this.modemUpgrade = new System.Windows.Forms.Button();
            this.cdUpgrade = new System.Windows.Forms.Button();
            this.memoryUpgrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compUpgrade
            // 
            this.compUpgrade.Location = new System.Drawing.Point(12, 44);
            this.compUpgrade.Name = "compUpgrade";
            this.compUpgrade.Size = new System.Drawing.Size(163, 36);
            this.compUpgrade.TabIndex = 0;
            this.compUpgrade.UseVisualStyleBackColor = true;
            this.compUpgrade.Click += new System.EventHandler(this.compUpgrade_Click);
            // 
            // hddUpgrade
            // 
            this.hddUpgrade.Location = new System.Drawing.Point(11, 129);
            this.hddUpgrade.Name = "hddUpgrade";
            this.hddUpgrade.Size = new System.Drawing.Size(163, 36);
            this.hddUpgrade.TabIndex = 2;
            this.hddUpgrade.UseVisualStyleBackColor = true;
            this.hddUpgrade.Click += new System.EventHandler(this.hddUpgrade_Click);
            // 
            // modemUpgrade
            // 
            this.modemUpgrade.Location = new System.Drawing.Point(11, 171);
            this.modemUpgrade.Name = "modemUpgrade";
            this.modemUpgrade.Size = new System.Drawing.Size(163, 36);
            this.modemUpgrade.TabIndex = 3;
            this.modemUpgrade.UseVisualStyleBackColor = true;
            this.modemUpgrade.Click += new System.EventHandler(this.modemUpgrade_Click);
            // 
            // cdUpgrade
            // 
            this.cdUpgrade.Location = new System.Drawing.Point(11, 213);
            this.cdUpgrade.Name = "cdUpgrade";
            this.cdUpgrade.Size = new System.Drawing.Size(163, 36);
            this.cdUpgrade.TabIndex = 4;
            this.cdUpgrade.UseVisualStyleBackColor = true;
            this.cdUpgrade.Click += new System.EventHandler(this.cdUpgrade_Click);
            // 
            // memoryUpgrade
            // 
            this.memoryUpgrade.Location = new System.Drawing.Point(12, 87);
            this.memoryUpgrade.Name = "memoryUpgrade";
            this.memoryUpgrade.Size = new System.Drawing.Size(163, 36);
            this.memoryUpgrade.TabIndex = 5;
            this.memoryUpgrade.UseVisualStyleBackColor = true;
            this.memoryUpgrade.Click += new System.EventHandler(this.memoryUpgrade_Click);
            // 
            // ComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 290);
            this.Controls.Add(this.memoryUpgrade);
            this.Controls.Add(this.cdUpgrade);
            this.Controls.Add(this.modemUpgrade);
            this.Controls.Add(this.hddUpgrade);
            this.Controls.Add(this.compUpgrade);
            this.Name = "ComputerForm";
            this.Text = "ComputerInterface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button compUpgrade;
        private System.Windows.Forms.Button hddUpgrade;
        private System.Windows.Forms.Button modemUpgrade;
        private System.Windows.Forms.Button cdUpgrade;
        private System.Windows.Forms.Button memoryUpgrade;
    }
}