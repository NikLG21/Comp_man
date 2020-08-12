namespace UserInterface
{
    partial class HackingForm
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
            this.hackingProgramsButton = new System.Windows.Forms.Button();
            this.exchangeProgramsButton = new System.Windows.Forms.Button();
            this.HackingTasks = new System.Windows.Forms.Button();
            this.hackingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hackingProgramsButton
            // 
            this.hackingProgramsButton.Location = new System.Drawing.Point(175, 17);
            this.hackingProgramsButton.Name = "hackingProgramsButton";
            this.hackingProgramsButton.Size = new System.Drawing.Size(110, 33);
            this.hackingProgramsButton.TabIndex = 0;
            this.hackingProgramsButton.Text = "My programs";
            this.hackingProgramsButton.UseVisualStyleBackColor = true;
            this.hackingProgramsButton.Click += new System.EventHandler(this.hackingProgramsButton_Click);
            // 
            // exchangeProgramsButton
            // 
            this.exchangeProgramsButton.Location = new System.Drawing.Point(175, 65);
            this.exchangeProgramsButton.Name = "exchangeProgramsButton";
            this.exchangeProgramsButton.Size = new System.Drawing.Size(110, 33);
            this.exchangeProgramsButton.TabIndex = 1;
            this.exchangeProgramsButton.Text = "Exchange programs";
            this.exchangeProgramsButton.UseVisualStyleBackColor = true;
            this.exchangeProgramsButton.Click += new System.EventHandler(this.exchangeProgramsButton_Click);
            // 
            // HackingTask
            // 
            this.HackingTasks.Location = new System.Drawing.Point(175, 117);
            this.HackingTasks.Name = "HackingTasks";
            this.HackingTasks.Size = new System.Drawing.Size(110, 33);
            this.HackingTasks.TabIndex = 2;
            this.HackingTasks.Text = "Tasks";
            this.HackingTasks.UseVisualStyleBackColor = true;
            this.HackingTasks.Click += new System.EventHandler(this.HackingTasks_Click);
            // 
            // hackingTextBox
            // 
            this.hackingTextBox.Location = new System.Drawing.Point(12, 27);
            this.hackingTextBox.Name = "hackingTextBox";
            this.hackingTextBox.Size = new System.Drawing.Size(145, 20);
            this.hackingTextBox.TabIndex = 3;
            // 
            // HackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 266);
            this.Controls.Add(this.hackingTextBox);
            this.Controls.Add(this.HackingTasks);
            this.Controls.Add(this.exchangeProgramsButton);
            this.Controls.Add(this.hackingProgramsButton);
            this.Name = "HackingForm";
            this.Text = "HackingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hackingProgramsButton;
        private System.Windows.Forms.Button exchangeProgramsButton;
        private System.Windows.Forms.Button HackingTasks;
        private System.Windows.Forms.TextBox hackingTextBox;
    }
}