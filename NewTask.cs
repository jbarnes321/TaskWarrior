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
               
            //set task name
            if (TaskName.Text.Length == 0)
                taskName = "New Task";
            else
                taskName = TaskName.Text;

            date = taskTime.Value;
            location = Location.Text;
            details = Details.Text;


            // This block checks the input of the alarm time, 
            // displays a message if any error in the input is found
            bool isNum = int.TryParse(Alarm.Text, out alarmTime);

            if (String.IsNullOrEmpty(Alarm.Text))
                alarmTime = 0;
            else if (!isNum)
            {
                MessageBox.Show("Invalid alarm integer entered");
                return;
            }
            else if (alarmTime < 0)
            {
                MessageBox.Show("Invalid alarm integer entered (minutes must be > 0)");
                return;
            }


            // This block checks the input of hour, displays a message if any error
            // in the input is found.
            isNum = int.TryParse(HourBox.Text, out hour);

            if (String.IsNullOrEmpty(HourBox.Text))
            {
                MessageBox.Show("Hour must have a value");
                return;
            }
            else if (!isNum)
            {
                MessageBox.Show("Invalid hour integer entered");
                return;
            }
            else if (hour < 1 || hour > 12)
            {
                MessageBox.Show("Hour must be an integer greater than 0 and less than or equal to 12 ");
                return;
            }


            // This block checks the input of minute, displays a message if any error
            // in the input is found.
            isNum = int.TryParse(MinuteBox.Text, out minute);

            if (String.IsNullOrEmpty(MinuteBox.Text))
            {
                MessageBox.Show("Minute must have a value");
                return;
            }
            else if (!isNum)
            {
                MessageBox.Show("Invalid minute integer entered");
                return;
            }
            else if (minute < 0 || minute >= 60)
            {
                MessageBox.Show("Minute must be an integer greater than or equal to 0 and less than 60.");
                return;
            }

        
            if (PMradio.Checked == true)
                hour += 12;

            task = new Task(taskName, new DateTime(date.Year, date.Month, date.Day,
                        hour, minute, 0), location, details, alarmTime);
               
            this.parent.Show();
            this.parent.addTask();
            this.Hide();
        }

        




        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            parent.Show();
        }
   
    }
}
