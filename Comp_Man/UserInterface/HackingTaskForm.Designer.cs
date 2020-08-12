namespace UserInterface
{
    partial class HackingTaskForm
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
            this.hackingTaskTextBox = new System.Windows.Forms.TextBox();
            this.takeTaskButton = new System.Windows.Forms.Button();
            this.passwordCrackButton = new System.Windows.Forms.Button();
            this.systemAccessCrackButton = new System.Windows.Forms.Button();
            this.disguiseButton = new System.Windows.Forms.Button();
            this.superDisguiseButton = new System.Windows.Forms.Button();
            this.bombFileButton = new System.Windows.Forms.Button();
            this.networkVirusButton = new System.Windows.Forms.Button();
            this.networkAntivirusButton = new System.Windows.Forms.Button();
            this.rejectTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hackingTaskTextBox
            // 
            this.hackingTaskTextBox.Location = new System.Drawing.Point(26, 27);
            this.hackingTaskTextBox.Multiline = true;
            this.hackingTaskTextBox.Name = "hackingTaskTextBox";
            this.hackingTaskTextBox.ReadOnly = true;
            this.hackingTaskTextBox.Size = new System.Drawing.Size(346, 215);
            this.hackingTaskTextBox.TabIndex = 0;
            // 
            // takeTaskButton
            // 
            this.takeTaskButton.Location = new System.Drawing.Point(400, 36);
            this.takeTaskButton.Name = "takeTaskButton";
            this.takeTaskButton.Size = new System.Drawing.Size(130, 41);
            this.takeTaskButton.TabIndex = 1;
            this.takeTaskButton.Text = "Take This Task";
            this.takeTaskButton.UseVisualStyleBackColor = true;
            this.takeTaskButton.Click += new System.EventHandler(this.takeTaskButton_Click);
            // 
            // passwordCrackButton
            // 
            this.passwordCrackButton.Enabled = false;
            this.passwordCrackButton.Location = new System.Drawing.Point(21, 262);
            this.passwordCrackButton.Name = "passwordCrackButton";
            this.passwordCrackButton.Size = new System.Drawing.Size(119, 41);
            this.passwordCrackButton.TabIndex = 2;
            this.passwordCrackButton.Text = "Password Crack";
            this.passwordCrackButton.UseVisualStyleBackColor = true;
            this.passwordCrackButton.Click += new System.EventHandler(this.passwordCrackButton_Click);
            // 
            // systemAccessCrackButton
            // 
            this.systemAccessCrackButton.Enabled = false;
            this.systemAccessCrackButton.Location = new System.Drawing.Point(146, 262);
            this.systemAccessCrackButton.Name = "systemAccessCrackButton";
            this.systemAccessCrackButton.Size = new System.Drawing.Size(119, 41);
            this.systemAccessCrackButton.TabIndex = 3;
            this.systemAccessCrackButton.Text = "System Access";
            this.systemAccessCrackButton.UseVisualStyleBackColor = true;
            this.systemAccessCrackButton.Click += new System.EventHandler(this.systemAccessCrackButton_Click);
            // 
            // disguiseButton
            // 
            this.disguiseButton.Enabled = false;
            this.disguiseButton.Location = new System.Drawing.Point(271, 262);
            this.disguiseButton.Name = "disguiseButton";
            this.disguiseButton.Size = new System.Drawing.Size(119, 41);
            this.disguiseButton.TabIndex = 4;
            this.disguiseButton.Text = "Disguise";
            this.disguiseButton.UseVisualStyleBackColor = true;
            this.disguiseButton.Click += new System.EventHandler(this.disguiseButton_Click);
            // 
            // superDisguiseButton
            // 
            this.superDisguiseButton.Enabled = false;
            this.superDisguiseButton.Location = new System.Drawing.Point(396, 262);
            this.superDisguiseButton.Name = "superDisguiseButton";
            this.superDisguiseButton.Size = new System.Drawing.Size(119, 41);
            this.superDisguiseButton.TabIndex = 5;
            this.superDisguiseButton.Text = "Super disguise";
            this.superDisguiseButton.UseVisualStyleBackColor = true;
            this.superDisguiseButton.Click += new System.EventHandler(this.superDisguiseButton_Click);
            // 
            // bombFileButton
            // 
            this.bombFileButton.Enabled = false;
            this.bombFileButton.Location = new System.Drawing.Point(21, 309);
            this.bombFileButton.Name = "bombFileButton";
            this.bombFileButton.Size = new System.Drawing.Size(119, 41);
            this.bombFileButton.TabIndex = 6;
            this.bombFileButton.Text = "Bomb file";
            this.bombFileButton.UseVisualStyleBackColor = true;
            this.bombFileButton.Click += new System.EventHandler(this.bombFileButton_Click);
            // 
            // networkVirusButton
            // 
            this.networkVirusButton.Enabled = false;
            this.networkVirusButton.Location = new System.Drawing.Point(146, 310);
            this.networkVirusButton.Name = "networkVirusButton";
            this.networkVirusButton.Size = new System.Drawing.Size(119, 41);
            this.networkVirusButton.TabIndex = 7;
            this.networkVirusButton.Text = "Network virus";
            this.networkVirusButton.UseVisualStyleBackColor = true;
            this.networkVirusButton.Click += new System.EventHandler(this.networkVirusButton_Click);
            // 
            // networkAntivirusButton
            // 
            this.networkAntivirusButton.Enabled = false;
            this.networkAntivirusButton.Location = new System.Drawing.Point(271, 309);
            this.networkAntivirusButton.Name = "networkAntivirusButton";
            this.networkAntivirusButton.Size = new System.Drawing.Size(119, 41);
            this.networkAntivirusButton.TabIndex = 8;
            this.networkAntivirusButton.Text = "Network antivirus";
            this.networkAntivirusButton.UseVisualStyleBackColor = true;
            this.networkAntivirusButton.Click += new System.EventHandler(this.networkAntivirusButton_Click);
            // 
            // rejectTaskButton
            // 
            this.rejectTaskButton.Location = new System.Drawing.Point(400, 83);
            this.rejectTaskButton.Name = "rejectTaskButton";
            this.rejectTaskButton.Size = new System.Drawing.Size(130, 41);
            this.rejectTaskButton.TabIndex = 9;
            this.rejectTaskButton.Text = "Reject this task";
            this.rejectTaskButton.UseVisualStyleBackColor = true;
            this.rejectTaskButton.Click += new System.EventHandler(this.rejectTaskButton_Click);
            // 
            // HackingTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 363);
            this.Controls.Add(this.rejectTaskButton);
            this.Controls.Add(this.networkAntivirusButton);
            this.Controls.Add(this.networkVirusButton);
            this.Controls.Add(this.bombFileButton);
            this.Controls.Add(this.superDisguiseButton);
            this.Controls.Add(this.disguiseButton);
            this.Controls.Add(this.systemAccessCrackButton);
            this.Controls.Add(this.passwordCrackButton);
            this.Controls.Add(this.takeTaskButton);
            this.Controls.Add(this.hackingTaskTextBox);
            this.Name = "HackingTaskForm";
            this.Text = "HackingTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hackingTaskTextBox;
        private System.Windows.Forms.Button takeTaskButton;
        private System.Windows.Forms.Button passwordCrackButton;
        private System.Windows.Forms.Button systemAccessCrackButton;
        private System.Windows.Forms.Button disguiseButton;
        private System.Windows.Forms.Button superDisguiseButton;
        private System.Windows.Forms.Button bombFileButton;
        private System.Windows.Forms.Button networkVirusButton;
        private System.Windows.Forms.Button networkAntivirusButton;
        private System.Windows.Forms.Button rejectTaskButton;
    }
}