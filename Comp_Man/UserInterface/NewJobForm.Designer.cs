namespace UserInterface
{
    partial class NewJobForm
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
            this.job1Button = new System.Windows.Forms.Button();
            this.job2Button = new System.Windows.Forms.Button();
            this.job3Button = new System.Windows.Forms.Button();
            this.job4Button = new System.Windows.Forms.Button();
            this.job5Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // job1Button
            // 
            this.job1Button.Location = new System.Drawing.Point(145, 16);
            this.job1Button.Name = "job1Button";
            this.job1Button.Size = new System.Drawing.Size(155, 33);
            this.job1Button.TabIndex = 0;
            this.job1Button.UseVisualStyleBackColor = true;
            this.job1Button.Click += new System.EventHandler(this.job1Button_Click);
            // 
            // job2Button
            // 
            this.job2Button.Location = new System.Drawing.Point(145, 55);
            this.job2Button.Name = "job2Button";
            this.job2Button.Size = new System.Drawing.Size(155, 33);
            this.job2Button.TabIndex = 1;
            this.job2Button.Text = "button2";
            this.job2Button.UseVisualStyleBackColor = true;
            this.job2Button.Click += new System.EventHandler(this.job2Button_Click);
            // 
            // job3Button
            // 
            this.job3Button.Location = new System.Drawing.Point(145, 94);
            this.job3Button.Name = "job3Button";
            this.job3Button.Size = new System.Drawing.Size(155, 33);
            this.job3Button.TabIndex = 2;
            this.job3Button.Text = "button3";
            this.job3Button.UseVisualStyleBackColor = true;
            this.job3Button.Click += new System.EventHandler(this.job3Button_Click);
            // 
            // job4Button
            // 
            this.job4Button.Location = new System.Drawing.Point(145, 133);
            this.job4Button.Name = "job4Button";
            this.job4Button.Size = new System.Drawing.Size(155, 33);
            this.job4Button.TabIndex = 3;
            this.job4Button.Text = "button4";
            this.job4Button.UseVisualStyleBackColor = true;
            this.job4Button.Click += new System.EventHandler(this.job4Button_Click);
            // 
            // job5Button
            // 
            this.job5Button.Location = new System.Drawing.Point(145, 172);
            this.job5Button.Name = "job5Button";
            this.job5Button.Size = new System.Drawing.Size(155, 33);
            this.job5Button.TabIndex = 4;
            this.job5Button.Text = "button5";
            this.job5Button.UseVisualStyleBackColor = true;
            this.job5Button.Click += new System.EventHandler(this.job5Button_Click);
            // 
            // NewJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 236);
            this.Controls.Add(this.job5Button);
            this.Controls.Add(this.job4Button);
            this.Controls.Add(this.job3Button);
            this.Controls.Add(this.job2Button);
            this.Controls.Add(this.job1Button);
            this.Name = "NewJobForm";
            this.Text = "NewJobForm";
            this.Load += new System.EventHandler(this.NewJobForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button job1Button;
        private System.Windows.Forms.Button job2Button;
        private System.Windows.Forms.Button job3Button;
        private System.Windows.Forms.Button job4Button;
        private System.Windows.Forms.Button job5Button;
    }
}