namespace UserInterface
{
    partial class VirusForm
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
            this.tryVirusKill = new System.Windows.Forms.Button();
            this.virusAttack = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tryVirusKill
            // 
            this.tryVirusKill.Location = new System.Drawing.Point(35, 58);
            this.tryVirusKill.Name = "tryVirusKill";
            this.tryVirusKill.Size = new System.Drawing.Size(88, 37);
            this.tryVirusKill.TabIndex = 0;
            this.tryVirusKill.Text = "Kill Virus";
            this.tryVirusKill.UseVisualStyleBackColor = true;
            this.tryVirusKill.Click += new System.EventHandler(this.tryVirusKill_Click);
            // 
            // virusAttack
            // 
            this.virusAttack.Location = new System.Drawing.Point(138, 59);
            this.virusAttack.Name = "virusAttack";
            this.virusAttack.Size = new System.Drawing.Size(90, 35);
            this.virusAttack.TabIndex = 1;
            this.virusAttack.Text = "Let it do";
            this.virusAttack.UseVisualStyleBackColor = true;
            this.virusAttack.Click += new System.EventHandler(this.virusAttack_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(46, 14);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(171, 20);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "Virus attack";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VirusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 130);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.virusAttack);
            this.Controls.Add(this.tryVirusKill);
            this.Name = "VirusForm";
            this.Text = "VirusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tryVirusKill;
        private System.Windows.Forms.Button virusAttack;
        private System.Windows.Forms.TextBox textBox;
    }
}