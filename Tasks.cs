using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace TaskWarrior
{
    public partial class Tasks : Form
    {
        public List<Task> currentTasks;
        public List<Task> previousTasks;
        public List<Task> allTasks;
        public Task edittedTask;
        private NewTask newTask;
        public DateTime alarmSoundTime;
        private bool viewingCurrentTasks;
        public string AlarmSoundChoice = "DarkLord.wav";

        public Tasks()
        {
            InitializeComponent();
            currentTasks = new List<Task>();
            previousTasks = new List<Task>();
            allTasks = new List<Task>();
            viewingCurrentTasks = true;
            readTaskInfo();
            AlarmTimer.Enabled = true;
            
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
            allTasks.Add(newTask.task);
            allTasks.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            taskList.Items.Clear();

            foreach (Task t in allTasks)
            {
                if (t.Date > DateTime.Now)
                {
                    if (!currentTasks.Contains(t))
                    {
                        currentTasks.Add(t);
                        alarmSoundTime = currentTasks.ElementAt(0).Date;
                        alarmSoundTime = alarmSoundTime.AddMinutes(-(currentTasks.ElementAt(0).Alarm));
                    }

                }
                else
                {
                    if (!previousTasks.Contains(t))
                        previousTasks.Add(t);
                }
            }

            currentTasks.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            previousTasks.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            currentTaskButton_Click(null, null);
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

                    if (location.Equals("EMPTY"))
                        location = "";
                    if (details.Equals("EMPTY"))
                        details = "";

                    allTasks.Add(new Task(name, new DateTime(year, month, day, hour, 
                        minute, 0), location, details, alarm));
                }


                allTasks.Sort((x, y) => DateTime.Compare(x.Date, y.Date));

                foreach (Task t in allTasks)
                {
                    if (t.Date > DateTime.Now)
                    {
                        if (!currentTasks.Contains(t))
                            currentTasks.Add(t);
                    }
                    else
                    {
                        if (!previousTasks.Contains(t))
                            previousTasks.Add(t);
                    }
                }

                foreach (Task t in currentTasks)
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

            foreach (Task task in allTasks)
            {
                tw.WriteLine(task.Name);
                tw.WriteLine(task.Date.Month);
                tw.WriteLine(task.Date.Day);
                tw.WriteLine(task.Date.Year);
                tw.WriteLine(task.Date.Hour);
                tw.WriteLine(task.Date.Minute);
                tw.WriteLine(task.Alarm);

                if (String.IsNullOrEmpty(task.Location))
                    tw.WriteLine("EMPTY");
                else
                    tw.WriteLine(task.Location);

                if (String.IsNullOrEmpty(task.Details))
                    tw.WriteLine("EMPTY");
                else
                    tw.WriteLine(task.Details);
            }

            tw.Close();
        }

        public void editTask_Click(object sender, EventArgs e)
        {
            try
            {
                edittedTask = currentTasks[taskList.SelectedIndex];
                int editIndex = taskList.SelectedIndex;

                newTask = new NewTask(this);
                newTask.TaskName.Text = edittedTask.Name;
                newTask.taskTime.Value = Convert.ToDateTime(edittedTask.Date);
                newTask.HourBox.Text = Convert.ToString(edittedTask.Date.Hour);
                newTask.MinuteBox.Text = Convert.ToString(edittedTask.Date.Minute);
                newTask.Location.Text = edittedTask.Location;
                newTask.Details.Text = edittedTask.Details;
                newTask.Alarm.Text = edittedTask.Alarm.ToString();

                newTask.editing = true;
                this.Hide();
                newTask.Show();

                allTasks.Remove(edittedTask);
                currentTasks.Remove(edittedTask);
                taskList.Items.RemoveAt(editIndex);
            }
            catch { }
        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            int selectedIndex = taskList.SelectedIndex;
            try
            {   
                if (viewingCurrentTasks)
                {
                    Task deleteTask = currentTasks[taskList.SelectedIndex];
                    currentTasks.RemoveAt(selectedIndex);
                    taskList.Items.RemoveAt(selectedIndex);
                    allTasks.Remove(deleteTask);                    
                    currentTaskButton_Click(null, null);
                }
                else
                {
                    Task deleteTask = previousTasks[taskList.SelectedIndex];
                    previousTasks.RemoveAt(selectedIndex);
                    taskList.Items.RemoveAt(selectedIndex);
                    allTasks.Remove(deleteTask);                    
                    previousTasksButton_Click(null, null);
                }

            }
            catch { }
        }

        private void currentTaskButton_Click(object sender, EventArgs e)
        {
            editTask.Enabled = true;
            viewingCurrentTasks = true;
            taskList.Items.Clear();
            foreach(Task t in currentTasks)
                taskList.Items.Add(t.Name + " Date:     " + t.Date);
        }

        private void previousTasksButton_Click(object sender, EventArgs e)
        {
            editTask.Enabled = false;
            viewingCurrentTasks = false;
            taskList.Items.Clear();
            foreach (Task t in previousTasks)
                taskList.Items.Add(t.Name + " Date:     " + t.Date);
        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(currentTasks.Count);
            if (currentTasks.Count > 0)
            {
                alarmSoundTime = currentTasks.ElementAt(0).Date;
                alarmSoundTime = alarmSoundTime.AddMinutes(-(currentTasks.ElementAt(0).Alarm));
            }
            if (alarmSoundTime > DateTime.Now.AddSeconds(-.1) && alarmSoundTime < DateTime.Now.AddSeconds(.1))
            {
                // Console.WriteLine(DateTime.Now + " " + alarmSoundTime);
                Console.WriteLine(AlarmSoundChoice);

                AlarmTimer.Enabled = true;
                MessageBox.Show("ALARM!");

                    
                Task tempTask = currentTasks.ElementAt(0);
                currentTasks.Remove(tempTask);
                previousTasks.Add(tempTask);

                taskList.Items.Clear();
                foreach (Task t in currentTasks)
                    taskList.Items.Add(t.Name + " Date:     " + t.Date);

                if (AlarmSoundChoice == "DarkLord.wav")
                {
                    SoundPlayer playSound = new SoundPlayer(@"DarkLord.wav");
                    playSound.Play();
                }
                if (AlarmSoundChoice == "phonedial.wav")
                {
                    SoundPlayer playSound = new SoundPlayer(@"phonedial.wav");
                    playSound.Play();
                }
                if (AlarmSoundChoice == "Synth.wav")
                {
                    SoundPlayer playSound = new SoundPlayer(@"Synth.wav");
                    playSound.Play();
                }
                if (AlarmSoundChoice == "BabyCry.wav")
                {
                    SoundPlayer playSound = new SoundPlayer(@"BabyCry.wav");
                    playSound.Play();
                }
                if (AlarmSoundChoice == "Ascent.wav")
                {
                    SoundPlayer playSound = new SoundPlayer(@"Ascent.wav");
                    playSound.Play();
                }
            }

        }

        private void AlarmSoundPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlarmSoundChoice = AlarmSoundPicker.Text;
            Console.WriteLine(AlarmSoundChoice);
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            String detailsMessage;
            Task selectedTask;
            try
            {
                if (viewingCurrentTasks)
                    selectedTask = currentTasks[taskList.SelectedIndex];
                else
                    selectedTask = previousTasks[taskList.SelectedIndex];

                detailsMessage = "Name: " + selectedTask.Name
                                + "\nDate: " + selectedTask.Date
                                + "\nLocation: " + selectedTask.Location
                                + "\nDetails: " + selectedTask.Details
                                + "\nAlarm: " + selectedTask.Alarm;


                MessageBox.Show(detailsMessage);
            }
            catch { }
        }

       

        
    }
}
