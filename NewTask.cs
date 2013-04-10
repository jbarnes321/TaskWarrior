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

                //check alarm time
                int temp;
                bool isNum = int.TryParse(Alarm.Text, out temp);

                if (Alarm.Text.Length == 0)
                    alarmTime = 0;

                else if (!isNum)
                {
                    MessageBox.Show("Invalid Alarm Ingeter entered");
                }

                else if (isNum && temp < 0)
                {
                    MessageBox.Show("Invalid Alarm Ingeter entered (minutes must be > 0)");
                }

                else
                    alarmTime = Convert.ToInt32(Alarm.Text);


                hour = Convert.ToInt32(HourBox.Text);
                minute = Convert.ToInt32(MinuteBox.Text);

        
                if (PMradio.Checked == true)
                    hour += 12;

                task = new Task(taskName, new DateTime(date.Year, date.Month, date.Day,
                            hour, minute, 0), location, details, alarmTime);

                this.parent.Show();
                this.parent.addTask();
                this.Hide();
            }

        




    }
}
