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
    public partial class Tasks : Form
    {
        public List<Task> tasks;
        public List<String> tasksForListBox;
        private NewTask newTask;

        public Tasks()
        {
            InitializeComponent();
            tasks = new List<Task>();
            tasksForListBox = new List<String>();
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
            tasksForListBox.Clear();

            foreach (Task task in tasks)
                tasksForListBox.Add(task.Name + "     " + task.Date.ToString());

            listOfTasks.DataSource = null;
            listOfTasks.DataSource = this.tasksForListBox;
        }
    }
}
