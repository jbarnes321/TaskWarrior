namespace TaskWarrior
{
    partial class NewTask
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
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.taskTime = new System.Windows.Forms.DateTimePicker();
            this.hourLabel = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.timeHour = new System.Windows.Forms.TextBox();
            this.timeMinutes = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.TextBox();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.Alarm = new System.Windows.Forms.TextBox();
            this.minutesBeforeLabel = new System.Windows.Forms.Label();
            this.addTask = new System.Windows.Forms.Button();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(9, 26);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(62, 13);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Task Name";
            // 
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(12, 43);
            this.TaskName.MaxLength = 20;
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(100, 20);
            this.TaskName.TabIndex = 1;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(9, 66);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(30, 13);
            this.dateTimeLabel.TabIndex = 2;
            this.dateTimeLabel.Text = "Date";
            // 
            // taskTime
            // 
            this.taskTime.Location = new System.Drawing.Point(12, 82);
            this.taskTime.Name = "taskTime";
            this.taskTime.Size = new System.Drawing.Size(200, 20);
            this.taskTime.TabIndex = 2;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(12, 109);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(30, 13);
            this.hourLabel.TabIndex = 4;
            this.hourLabel.Text = "Hour";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(15, 168);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(100, 20);
            this.Location.TabIndex = 5;
            // 
            // timeHour
            // 
            this.timeHour.Location = new System.Drawing.Point(15, 125);
            this.timeHour.Name = "timeHour";
            this.timeHour.Size = new System.Drawing.Size(32, 20);
            this.timeHour.TabIndex = 3;
            // 
            // timeMinutes
            // 
            this.timeMinutes.Location = new System.Drawing.Point(62, 125);
            this.timeMinutes.Name = "timeMinutes";
            this.timeMinutes.Size = new System.Drawing.Size(32, 20);
            this.timeMinutes.TabIndex = 4;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(12, 152);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(12, 191);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(39, 13);
            this.detailsLabel.TabIndex = 11;
            this.detailsLabel.Text = "Details";
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(15, 207);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(100, 20);
            this.Details.TabIndex = 6;
            // 
            // alarmLabel
            // 
            this.alarmLabel.AutoSize = true;
            this.alarmLabel.Location = new System.Drawing.Point(12, 230);
            this.alarmLabel.Name = "alarmLabel";
            this.alarmLabel.Size = new System.Drawing.Size(33, 13);
            this.alarmLabel.TabIndex = 13;
            this.alarmLabel.Text = "Alarm";
            // 
            // Alarm
            // 
            this.Alarm.Location = new System.Drawing.Point(15, 246);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(100, 20);
            this.Alarm.TabIndex = 7;
            // 
            // minutesBeforeLabel
            // 
            this.minutesBeforeLabel.AutoSize = true;
            this.minutesBeforeLabel.Location = new System.Drawing.Point(121, 249);
            this.minutesBeforeLabel.Name = "minutesBeforeLabel";
            this.minutesBeforeLabel.Size = new System.Drawing.Size(78, 13);
            this.minutesBeforeLabel.TabIndex = 14;
            this.minutesBeforeLabel.Text = "Minutes Before";
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(137, 288);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(75, 23);
            this.addTask.TabIndex = 15;
            this.addTask.Text = "Save";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(59, 109);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(44, 13);
            this.minutesLabel.TabIndex = 16;
            this.minutesLabel.Text = "Minutes";
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 347);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.minutesBeforeLabel);
            this.Controls.Add(this.alarmLabel);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.timeMinutes);
            this.Controls.Add(this.timeHour);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.taskTime);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.taskNameLabel);
            this.Name = "NewTask";
            this.Text = "New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.DateTimePicker taskTime;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.TextBox timeHour;
        private System.Windows.Forms.TextBox timeMinutes;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox Details;
        private System.Windows.Forms.Label alarmLabel;
        private System.Windows.Forms.TextBox Alarm;
        private System.Windows.Forms.Label minutesBeforeLabel;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Label minutesLabel;

    }
}