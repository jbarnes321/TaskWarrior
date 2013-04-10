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
            //ReadTaskInfo();
            
        }

        private void createTask_Click(object sender, EventArgs e)
        {
            newTask = new NewTask(this);
            this.Hide();
            newTask.Show();
        }

        public void addTask()
        {
            this.tasks.Add(newTask.task);
            tasks.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            taskList.Items.Clear();

            foreach(Task t in tasks)
                taskList.Items.Add(t.Name + " Date:     " + t.Date);
        }



        private void ReadTaskInfo()
        {
            String path = @"C:\Users\Justin\Downloads\";
            String in1 = "text1.txt";

            try
            {
                // Read in text1
                List<String> pass1 = new List<String>();
                StreamReader sr1 = new StreamReader(path + in1);
                while (sr1.Peek() > -1)
                {
                    pass1.Add(sr1.ReadLine());
                }
                sr1.Close();

                for (int i = 0; i < pass1.Count; i++)
                {
                    //listBox1.Items.Add(pass1.ElementAt(i));
                }


            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
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
