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
        private NewTask newTask;

        public Tasks()
        {
            InitializeComponent();
            tasks = new List<Task>();
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
        }
    }
}
