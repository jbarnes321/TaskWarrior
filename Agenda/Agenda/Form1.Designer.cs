namespace Agenda
{
    partial class TaskWarrior
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
            this.EventCreation_GroupBox = new System.Windows.Forms.GroupBox();
            this.EventNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.EventDetailsLabel = new System.Windows.Forms.Label();
            this.EventLocationLabel = new System.Windows.Forms.Label();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.EventLocationTextBox = new System.Windows.Forms.TextBox();
            this.EventDetailsTextBox = new System.Windows.Forms.TextBox();
            this.AlarmTimeLabel = new System.Windows.Forms.Label();
            this.AlarmTimeTextBox = new System.Windows.Forms.TextBox();
            this.MinuteBeforeLabel = new System.Windows.Forms.Label();
            this.AgendaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EventHourTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EventMinTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EventSecondTextBox = new System.Windows.Forms.TextBox();
            this.EventCreation_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventCreation_GroupBox
            // 
            this.EventCreation_GroupBox.Controls.Add(this.EventSecondTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.label2);
            this.EventCreation_GroupBox.Controls.Add(this.EventMinTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.label1);
            this.EventCreation_GroupBox.Controls.Add(this.AgendaDatePicker);
            this.EventCreation_GroupBox.Controls.Add(this.MinuteBeforeLabel);
            this.EventCreation_GroupBox.Controls.Add(this.AlarmTimeTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.AlarmTimeLabel);
            this.EventCreation_GroupBox.Controls.Add(this.EventDetailsTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.EventLocationTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.EventHourTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.EventNameTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.CreateButton);
            this.EventCreation_GroupBox.Controls.Add(this.EventDetailsLabel);
            this.EventCreation_GroupBox.Controls.Add(this.EventLocationLabel);
            this.EventCreation_GroupBox.Controls.Add(this.label3);
            this.EventCreation_GroupBox.Controls.Add(this.EventDateLabel);
            this.EventCreation_GroupBox.Controls.Add(this.EventNameLabel);
            this.EventCreation_GroupBox.Location = new System.Drawing.Point(4, 4);
            this.EventCreation_GroupBox.Name = "EventCreation_GroupBox";
            this.EventCreation_GroupBox.Size = new System.Drawing.Size(217, 523);
            this.EventCreation_GroupBox.TabIndex = 0;
            this.EventCreation_GroupBox.TabStop = false;
            this.EventCreation_GroupBox.Text = "Event Creation";
            this.EventCreation_GroupBox.Enter += new System.EventHandler(this.EventCreation_GroupBox_Enter);
            // 
            // EventNameTextBox
            // 
            this.EventNameTextBox.Location = new System.Drawing.Point(11, 46);
            this.EventNameTextBox.Name = "EventNameTextBox";
            this.EventNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.EventNameTextBox.TabIndex = 12;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(124, 280);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "CREATE";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // EventDetailsLabel
            // 
            this.EventDetailsLabel.AutoSize = true;
            this.EventDetailsLabel.Location = new System.Drawing.Point(8, 192);
            this.EventDetailsLabel.Name = "EventDetailsLabel";
            this.EventDetailsLabel.Size = new System.Drawing.Size(73, 13);
            this.EventDetailsLabel.TabIndex = 8;
            this.EventDetailsLabel.Text = "Event Details:";
            // 
            // EventLocationLabel
            // 
            this.EventLocationLabel.AutoSize = true;
            this.EventLocationLabel.Location = new System.Drawing.Point(6, 151);
            this.EventLocationLabel.Name = "EventLocationLabel";
            this.EventLocationLabel.Size = new System.Drawing.Size(82, 13);
            this.EventLocationLabel.TabIndex = 6;
            this.EventLocationLabel.Text = "Event Location:";
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Location = new System.Drawing.Point(8, 29);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(69, 13);
            this.EventNameLabel.TabIndex = 0;
            this.EventNameLabel.Text = "Event Name:";
            // 
            // EventLocationTextBox
            // 
            this.EventLocationTextBox.Location = new System.Drawing.Point(11, 168);
            this.EventLocationTextBox.Name = "EventLocationTextBox";
            this.EventLocationTextBox.Size = new System.Drawing.Size(195, 20);
            this.EventLocationTextBox.TabIndex = 15;
            // 
            // EventDetailsTextBox
            // 
            this.EventDetailsTextBox.Location = new System.Drawing.Point(11, 209);
            this.EventDetailsTextBox.Name = "EventDetailsTextBox";
            this.EventDetailsTextBox.Size = new System.Drawing.Size(198, 20);
            this.EventDetailsTextBox.TabIndex = 16;
            // 
            // AlarmTimeLabel
            // 
            this.AlarmTimeLabel.AutoSize = true;
            this.AlarmTimeLabel.Location = new System.Drawing.Point(11, 236);
            this.AlarmTimeLabel.Name = "AlarmTimeLabel";
            this.AlarmTimeLabel.Size = new System.Drawing.Size(62, 13);
            this.AlarmTimeLabel.TabIndex = 17;
            this.AlarmTimeLabel.Text = "Alarm Time:";
            // 
            // AlarmTimeTextBox
            // 
            this.AlarmTimeTextBox.Location = new System.Drawing.Point(14, 253);
            this.AlarmTimeTextBox.Name = "AlarmTimeTextBox";
            this.AlarmTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlarmTimeTextBox.TabIndex = 18;
            // 
            // MinuteBeforeLabel
            // 
            this.MinuteBeforeLabel.AutoSize = true;
            this.MinuteBeforeLabel.Location = new System.Drawing.Point(121, 253);
            this.MinuteBeforeLabel.Name = "MinuteBeforeLabel";
            this.MinuteBeforeLabel.Size = new System.Drawing.Size(78, 13);
            this.MinuteBeforeLabel.TabIndex = 19;
            this.MinuteBeforeLabel.Text = "Minutes Before";
            // 
            // AgendaDatePicker
            // 
            this.AgendaDatePicker.CustomFormat = "yyyy.MM.dd HH:mm";
            this.AgendaDatePicker.Location = new System.Drawing.Point(9, 88);
            this.AgendaDatePicker.Name = "AgendaDatePicker";
            this.AgendaDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AgendaDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AgendaDatePicker.TabIndex = 20;
            // 
            // EventHourTextBox
            // 
            this.EventHourTextBox.Location = new System.Drawing.Point(11, 127);
            this.EventHourTextBox.Name = "EventHourTextBox";
            this.EventHourTextBox.Size = new System.Drawing.Size(23, 20);
            this.EventHourTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Event Time: (24:00)";
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Location = new System.Drawing.Point(8, 70);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(64, 13);
            this.EventDateLabel.TabIndex = 2;
            this.EventDateLabel.Text = "Event Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = ":";
            // 
            // EventMinTextBox
            // 
            this.EventMinTextBox.Location = new System.Drawing.Point(56, 128);
            this.EventMinTextBox.Name = "EventMinTextBox";
            this.EventMinTextBox.Size = new System.Drawing.Size(25, 20);
            this.EventMinTextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = ".";
            // 
            // EventSecondTextBox
            // 
            this.EventSecondTextBox.Location = new System.Drawing.Point(103, 127);
            this.EventSecondTextBox.Name = "EventSecondTextBox";
            this.EventSecondTextBox.Size = new System.Drawing.Size(24, 20);
            this.EventSecondTextBox.TabIndex = 24;
            // 
            // TaskWarrior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 522);
            this.Controls.Add(this.EventCreation_GroupBox);
            this.Name = "TaskWarrior";
            this.Text = "TASK-WARRIOR!";
            this.EventCreation_GroupBox.ResumeLayout(false);
            this.EventCreation_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EventCreation_GroupBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label EventDetailsLabel;
        private System.Windows.Forms.Label EventLocationLabel;
        private System.Windows.Forms.Label EventNameLabel;
        private System.Windows.Forms.TextBox EventNameTextBox;
        private System.Windows.Forms.TextBox EventDetailsTextBox;
        private System.Windows.Forms.TextBox EventLocationTextBox;
        private System.Windows.Forms.TextBox AlarmTimeTextBox;
        private System.Windows.Forms.Label AlarmTimeLabel;
        private System.Windows.Forms.Label MinuteBeforeLabel;
        private System.Windows.Forms.DateTimePicker AgendaDatePicker;
        private System.Windows.Forms.TextBox EventHourTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EventDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EventMinTextBox;
        private System.Windows.Forms.TextBox EventSecondTextBox;
        private System.Windows.Forms.Label label2;
    }
}

