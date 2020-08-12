namespace UserInterface
{
    partial class BssForm
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
            this.connectBssButton = new System.Windows.Forms.Button();
            this.makeMyBss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectBssButton
            // 
            this.connectBssButton.Location = new System.Drawing.Point(35, 28);
            this.connectBssButton.Name = "connectBssButton";
            this.connectBssButton.Size = new System.Drawing.Size(138, 35);
            this.connectBssButton.TabIndex = 0;
            this.connectBssButton.Text = "Connect to sins BSS";
            this.connectBssButton.UseVisualStyleBackColor = true;
            this.connectBssButton.Click += new System.EventHandler(this.connectBssButton_Click);
            // 
            // makeMyBss
            // 
            this.makeMyBss.Location = new System.Drawing.Point(35, 82);
            this.makeMyBss.Name = "makeMyBss";
            this.makeMyBss.Size = new System.Drawing.Size(138, 35);
            this.makeMyBss.TabIndex = 1;
            this.makeMyBss.Text = "Create my BSS";
            this.makeMyBss.UseVisualStyleBackColor = true;
            this.makeMyBss.Click += new System.EventHandler(this.makeMyBss_Click);
            // 
            // BssForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.makeMyBss);
            this.Controls.Add(this.connectBssButton);
            this.Name = "BssForm";
            this.Text = "BssForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectBssButton;
        private System.Windows.Forms.Button makeMyBss;
    }
}