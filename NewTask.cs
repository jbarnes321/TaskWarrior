using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskWarrior
{
    public partial class NewTask : Form
    {
        public Task task;
        Tasks parent;
        String taskName;
        String location;
        String details;
        DateTime date;
        int hour;
        int minute;
        int alarmTime;

        

        public NewTask(Tasks parent)
        {
            this.parent = parent;
            InitializeComponent();
        }


        private void addTask_Click(object sender, EventArgs e)
        {
            taskName = TaskName.Text;
            date = taskTime.Value;
            hour = Convert.ToInt32(timeHour.Text);
            minute = Convert.ToInt32(timeMinutes.Text);
            location = Location.Text;
            details = Details.Text;
            alarmTime = Convert.ToInt32(Alarm.Text);
            task = new Task(taskName, new DateTime(date.Year, date.Month, date.Day, 
                hour, minute, 0), location, details, alarmTime);

            this.parent.Show();
            this.parent.addTask();
            this.Hide();
        }

    }
}
