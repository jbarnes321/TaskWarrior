using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TaskWarrior
{
    public partial class Tasks : Form
    {
        public List<Task> tasks;
        private NewTask newTask;
        public DateTime alarmSoundTime;

        public Tasks()
        {
            InitializeComponent();
            tasks = new List<Task>();
            readTaskInfo();
        }

        private void createTask_Click(object sender, EventArgs e)
        {
            newTask = new NewTask(this);
            this.Hide();
            newTask.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            writeTaskInfo();
        }

        public void addTask()
        {
            this.tasks.Add(newTask.task);
            tasks.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            taskList.Items.Clear();

            foreach(Task t in tasks)
                taskList.Items.Add(t.Name + " Date:     " + t.Date);
        }



        private void readTaskInfo()
        {
            String line;
            String name, location, details;
            int month, day, year, hour, minute, alarm;
            try
            {
                TextReader tr = new StreamReader("input.txt");

                // This loops reads in all the data stored in the text file.  If
                // there was no data, then it simply 
                while ((line = tr.ReadLine()) != null)
                {
                    name = line;
                    month = Convert.ToInt32(tr.ReadLine());
                    day = Convert.ToInt32(tr.ReadLine());
                    year = Convert.ToInt32(tr.ReadLine());
                    hour = Convert.ToInt32(tr.ReadLine());
                    minute = Convert.ToInt32(tr.ReadLine());
                    alarm = Convert.ToInt32(tr.ReadLine());
                    location = tr.ReadLine();
                    details = tr.ReadLine();

                    if (location.Equals("FUCK"))
                        location = "";
                    if (details.Equals("FUCK"))
                        details = "";

                    tasks.Add(new Task(name, new DateTime(year, month, day, hour, 
                        minute, 0), location, details, alarm));
                }


                tasks.Sort((x, y) => DateTime.Compare(x.Date, y.Date));

                foreach (Task t in tasks)
                    taskList.Items.Add(t.Name + " Date:     " + t.Date);
                tr.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void writeTaskInfo()
        {
            TextWriter tw = new StreamWriter("input.txt");

            foreach (Task task in tasks)
            {
                tw.WriteLine(task.Name);
                tw.WriteLine(task.Date.Month);
                tw.WriteLine(task.Date.Day);
                tw.WriteLine(task.Date.Year);
                tw.WriteLine(task.Date.Hour);
                tw.WriteLine(task.Date.Minute);
                tw.WriteLine(task.Alarm);

                if (String.IsNullOrEmpty(task.Location))
                    tw.WriteLine("FUCK");
                else
                    tw.WriteLine(task.Location);

                if (String.IsNullOrEmpty(task.Details))
                    tw.WriteLine("FUCK");
                else
                    tw.WriteLine(task.Details);
            }

            tw.Close();
        }

        public void editTask_Click(object sender, EventArgs e)
        {
            try
            {
                Task edittedTask = tasks[taskList.SelectedIndex];
                int editIndex = taskList.SelectedIndex;

                newTask = new NewTask(this);
                newTask.TaskName.Text = edittedTask.Name;
                newTask.taskTime.Value = Convert.ToDateTime(edittedTask.Date);
                newTask.HourBox.Text = Convert.ToString(edittedTask.Date.Hour);
                newTask.MinuteBox.Text = Convert.ToString(edittedTask.Date.Minute);
                newTask.Location.Text = edittedTask.Location;
                newTask.Details.Text = edittedTask.Details;
                newTask.Alarm.Text = edittedTask.Alarm.ToString();
            
                this.Hide();
                newTask.Show();
            
                tasks.Remove(edittedTask);
                taskList.Items.RemoveAt(editIndex);
            }
            catch { }
        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            int selectedIndex = taskList.SelectedIndex;
            try
            {
                tasks.RemoveAt(selectedIndex);
                taskList.Items.RemoveAt(selectedIndex);
            }
            catch { }
        }





    }
}
