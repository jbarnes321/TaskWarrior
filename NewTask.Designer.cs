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
            this.components = new System.ComponentModel.Container();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.taskTime = new System.Windows.Forms.DateTimePicker();
            this.hourLabel = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.TextBox();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.Alarm = new System.Windows.Forms.TextBox();
            this.minutesBeforeLabel = new System.Windows.Forms.Label();
            this.addTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PMradio = new System.Windows.Forms.RadioButton();
            this.AMradio = new System.Windows.Forms.RadioButton();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.MinuteBox = new System.Windows.Forms.TextBox();
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(9, 9);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(62, 13);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Task Name";
            // 
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(11, 25);
            this.TaskName.MaxLength = 20;
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(133, 20);
            this.TaskName.TabIndex = 1;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(8, 57);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(30, 13);
            this.dateTimeLabel.TabIndex = 2;
            this.dateTimeLabel.Text = "Date";
            // 
            // taskTime
            // 
            this.taskTime.Location = new System.Drawing.Point(11, 73);
            this.taskTime.Name = "taskTime";
            this.taskTime.Size = new System.Drawing.Size(200, 20);
            this.taskTime.TabIndex = 2;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(16, 109);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(30, 13);
            this.hourLabel.TabIndex = 4;
            this.hourLabel.Text = "Hour";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(15, 168);
            this.Location.MaxLength = 30;
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(197, 20);
            this.Location.TabIndex = 5;
           
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
            this.Details.MaxLength = 50;
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(197, 20);
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
            this.Alarm.MaxLength = 3;
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(45, 20);
            this.Alarm.TabIndex = 7;
            // 
            // minutesBeforeLabel
            // 
            this.minutesBeforeLabel.AutoSize = true;
            this.minutesBeforeLabel.Location = new System.Drawing.Point(66, 249);
            this.minutesBeforeLabel.Name = "minutesBeforeLabel";
            this.minutesBeforeLabel.Size = new System.Drawing.Size(105, 13);
            this.minutesBeforeLabel.TabIndex = 14;
            this.minutesBeforeLabel.Text = "Minutes Before Task";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.PMradio);
            this.groupBox1.Controls.Add(this.AMradio);
            this.groupBox1.Location = new System.Drawing.Point(104, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 41);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-53, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 19;
            // 
            // PMradio
            // 
            this.PMradio.AutoSize = true;
            this.PMradio.Location = new System.Drawing.Point(61, 16);
            this.PMradio.Name = "PMradio";
            this.PMradio.Size = new System.Drawing.Size(41, 17);
            this.PMradio.TabIndex = 1;
            this.PMradio.Text = "PM";
            this.PMradio.UseVisualStyleBackColor = true;
            // 
            // AMradio
            // 
            this.AMradio.AutoSize = true;
            this.AMradio.Checked = true;
            this.AMradio.Location = new System.Drawing.Point(13, 16);
            this.AMradio.Name = "AMradio";
            this.AMradio.Size = new System.Drawing.Size(41, 17);
            this.AMradio.TabIndex = 0;
            this.AMradio.TabStop = true;
            this.AMradio.Text = "AM";
            this.AMradio.UseVisualStyleBackColor = true;
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(19, 122);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(32, 20);
            this.HourBox.TabIndex = 18;
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(58, 109);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(44, 13);
            this.minuteLabel.TabIndex = 19;
            this.minuteLabel.Text = "Minutes";
            // 
            // MinuteBox
            // 
            this.MinuteBox.Location = new System.Drawing.Point(61, 122);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(37, 20);
            this.MinuteBox.TabIndex = 21;
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Tick += new System.EventHandler(this.AlarmTimer_Tick);
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 347);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.minutesBeforeLabel);
            this.Controls.Add(this.alarmLabel);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.taskTime);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.taskNameLabel);
            this.Name = "NewTask";
            this.Text = "New Task";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label alarmLabel;
        private System.Windows.Forms.Label minutesBeforeLabel;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PMradio;
        private System.Windows.Forms.RadioButton AMradio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label minuteLabel;
        public System.Windows.Forms.TextBox TaskName;
        public System.Windows.Forms.DateTimePicker taskTime;
        public System.Windows.Forms.TextBox Location;
        public System.Windows.Forms.TextBox Details;
        public System.Windows.Forms.TextBox Alarm;
        public System.Windows.Forms.TextBox HourBox;
        public System.Windows.Forms.TextBox MinuteBox;
        private System.Windows.Forms.Timer AlarmTimer;

    }
}