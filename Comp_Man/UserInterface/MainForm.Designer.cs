namespace UserInterface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.computerButton = new System.Windows.Forms.Button();
            this.hackingButton = new System.Windows.Forms.Button();
            this.bssButton = new System.Windows.Forms.Button();
            this.EntertainmentButton = new System.Windows.Forms.Button();
            this.systemProgrammingButton = new System.Windows.Forms.Button();
            this.newJobButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.computerTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.bssTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.loadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // computerButton
            // 
            this.computerButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerButton.Location = new System.Drawing.Point(395, 157);
            this.computerButton.Name = "computerButton";
            this.computerButton.Size = new System.Drawing.Size(264, 39);
            this.computerButton.TabIndex = 0;
            this.computerButton.Text = "Computer";
            this.computerButton.UseVisualStyleBackColor = true;
            this.computerButton.Click += new System.EventHandler(this.computerButton_Click);
            // 
            // hackingButton
            // 
            this.hackingButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hackingButton.Location = new System.Drawing.Point(395, 247);
            this.hackingButton.Name = "hackingButton";
            this.hackingButton.Size = new System.Drawing.Size(264, 39);
            this.hackingButton.TabIndex = 2;
            this.hackingButton.Text = "Hacking";
            this.hackingButton.UseVisualStyleBackColor = true;
            this.hackingButton.Click += new System.EventHandler(this.hackingButton_Click);
            // 
            // bssButton
            // 
            this.bssButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bssButton.Location = new System.Drawing.Point(395, 292);
            this.bssButton.Name = "bssButton";
            this.bssButton.Size = new System.Drawing.Size(264, 39);
            this.bssButton.TabIndex = 3;
            this.bssButton.Text = "BSS";
            this.bssButton.UseVisualStyleBackColor = true;
            this.bssButton.Click += new System.EventHandler(this.bssButton_Click);
            // 
            // EntertainmentButton
            // 
            this.EntertainmentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntertainmentButton.Location = new System.Drawing.Point(395, 382);
            this.EntertainmentButton.Name = "EntertainmentButton";
            this.EntertainmentButton.Size = new System.Drawing.Size(264, 39);
            this.EntertainmentButton.TabIndex = 4;
            this.EntertainmentButton.Text = "Entertainment";
            this.EntertainmentButton.UseVisualStyleBackColor = true;
            this.EntertainmentButton.Click += new System.EventHandler(this.EntertainmentButton_Click);
            // 
            // systemProgrammingButton
            // 
            this.systemProgrammingButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.systemProgrammingButton.Location = new System.Drawing.Point(395, 202);
            this.systemProgrammingButton.Name = "systemProgrammingButton";
            this.systemProgrammingButton.Size = new System.Drawing.Size(264, 39);
            this.systemProgrammingButton.TabIndex = 5;
            this.systemProgrammingButton.Text = "Sytem and Programming";
            this.systemProgrammingButton.UseVisualStyleBackColor = true;
            this.systemProgrammingButton.Click += new System.EventHandler(this.systemProgrammingButton_Click);
            // 
            // newJobButton
            // 
            this.newJobButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newJobButton.Location = new System.Drawing.Point(395, 337);
            this.newJobButton.Name = "newJobButton";
            this.newJobButton.Size = new System.Drawing.Size(264, 39);
            this.newJobButton.TabIndex = 6;
            this.newJobButton.Text = "Find new Job";
            this.newJobButton.UseVisualStyleBackColor = true;
            this.newJobButton.Click += new System.EventHandler(this.newJobButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(453, 14);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 8;
            // 
            // personTextBox
            // 
            this.personTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personTextBox.Location = new System.Drawing.Point(32, 60);
            this.personTextBox.Multiline = true;
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.ReadOnly = true;
            this.personTextBox.Size = new System.Drawing.Size(185, 152);
            this.personTextBox.TabIndex = 9;
            // 
            // computerTextBox
            // 
            this.computerTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.computerTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerTextBox.Location = new System.Drawing.Point(32, 218);
            this.computerTextBox.Multiline = true;
            this.computerTextBox.Name = "computerTextBox";
            this.computerTextBox.ReadOnly = true;
            this.computerTextBox.Size = new System.Drawing.Size(225, 201);
            this.computerTextBox.TabIndex = 11;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(456, 44);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(189, 20);
            this.dateTextBox.TabIndex = 12;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(584, 92);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(74, 34);
            this.pauseButton.TabIndex = 13;
            this.pauseButton.Text = "button1";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // bssTextBox
            // 
            this.bssTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.bssTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bssTextBox.Location = new System.Drawing.Point(32, 425);
            this.bssTextBox.Multiline = true;
            this.bssTextBox.Name = "bssTextBox";
            this.bssTextBox.ReadOnly = true;
            this.bssTextBox.Size = new System.Drawing.Size(226, 111);
            this.bssTextBox.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(687, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadButton,
            this.saveButton,
            this.saveAsButton});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // loadButton
            // 
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(114, 22);
            this.loadButton.Text = "Load";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 22);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(114, 22);
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 550);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bssTextBox);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.computerTextBox);
            this.Controls.Add(this.personTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.newJobButton);
            this.Controls.Add(this.systemProgrammingButton);
            this.Controls.Add(this.EntertainmentButton);
            this.Controls.Add(this.bssButton);
            this.Controls.Add(this.hackingButton);
            this.Controls.Add(this.computerButton);
            this.Name = "MainForm";
            this.Text = "Comp Man";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button computerButton;
        private System.Windows.Forms.Button hackingButton;
        private System.Windows.Forms.Button bssButton;
        private System.Windows.Forms.Button EntertainmentButton;
        private System.Windows.Forms.Button systemProgrammingButton;
        private System.Windows.Forms.Button newJobButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.TextBox computerTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TextBox bssTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem loadButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsButton;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
    }
}

