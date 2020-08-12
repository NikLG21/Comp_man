namespace UserInterface
{
    partial class EntertainmentForm
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
            this.entertainment1Button = new System.Windows.Forms.Button();
            this.entertainment2Button = new System.Windows.Forms.Button();
            this.entertainment3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entertainment1Button
            // 
            this.entertainment1Button.Location = new System.Drawing.Point(189, 12);
            this.entertainment1Button.Name = "entertainment1Button";
            this.entertainment1Button.Size = new System.Drawing.Size(131, 43);
            this.entertainment1Button.TabIndex = 1;
            this.entertainment1Button.Text = "button1";
            this.entertainment1Button.UseVisualStyleBackColor = true;
            this.entertainment1Button.Click += new System.EventHandler(this.entertainment1Button_Click);
            // 
            // entertainment2Button
            // 
            this.entertainment2Button.Location = new System.Drawing.Point(189, 83);
            this.entertainment2Button.Name = "entertainment2Button";
            this.entertainment2Button.Size = new System.Drawing.Size(131, 43);
            this.entertainment2Button.TabIndex = 2;
            this.entertainment2Button.Text = "button2";
            this.entertainment2Button.UseVisualStyleBackColor = true;
            this.entertainment2Button.Click += new System.EventHandler(this.entertainment2Button_Click);
            // 
            // entertainment3Button
            // 
            this.entertainment3Button.Location = new System.Drawing.Point(189, 158);
            this.entertainment3Button.Name = "entertainment3Button";
            this.entertainment3Button.Size = new System.Drawing.Size(131, 43);
            this.entertainment3Button.TabIndex = 3;
            this.entertainment3Button.Text = "button3";
            this.entertainment3Button.UseVisualStyleBackColor = true;
            this.entertainment3Button.Click += new System.EventHandler(this.entertainment3Button_Click);
            // 
            // EntertainmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 257);
            this.Controls.Add(this.entertainment3Button);
            this.Controls.Add(this.entertainment2Button);
            this.Controls.Add(this.entertainment1Button);
            this.Name = "EntertainmentForm";
            this.Text = "EntertainmentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button entertainment1Button;
        private System.Windows.Forms.Button entertainment2Button;
        private System.Windows.Forms.Button entertainment3Button;
    }
}