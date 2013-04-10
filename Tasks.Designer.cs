namespace TaskWarrior
{
    partial class Tasks
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
            this.createTask = new System.Windows.Forms.Button();
            this.editTask = new System.Windows.Forms.Button();
            this.deleteTask = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListBox();
            this.currentTaskButton = new System.Windows.Forms.Button();
            this.previousTasksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTask
            // 
            this.createTask.Location = new System.Drawing.Point(12, 227);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(75, 23);
            this.createTask.TabIndex = 0;
            this.createTask.Text = "Create Task";
            this.createTask.UseVisualStyleBackColor = true;
            this.createTask.Click += new System.EventHandler(this.createTask_Click);
            // 
            // editTask
            // 
            this.editTask.Location = new System.Drawing.Point(106, 227);
            this.editTask.Name = "editTask";
            this.editTask.Size = new System.Drawing.Size(75, 23);
            this.editTask.TabIndex = 2;
            this.editTask.Text = "Edit";
            this.editTask.UseVisualStyleBackColor = true;
            this.editTask.Click += new System.EventHandler(this.editTask_Click);
            // 
            // deleteTask
            // 
            this.deleteTask.Location = new System.Drawing.Point(197, 227);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(75, 23);
            this.deleteTask.TabIndex = 3;
            this.deleteTask.Text = "Delete";
            this.deleteTask.UseVisualStyleBackColor = true;
            this.deleteTask.Click += new System.EventHandler(this.deleteTask_Click);
            // 
            // taskList
            // 
            this.taskList.FormattingEnabled = true;
            this.taskList.Location = new System.Drawing.Point(13, 13);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(259, 199);
            this.taskList.TabIndex = 4;
            // 
            // currentTaskButton
            // 
            this.currentTaskButton.Location = new System.Drawing.Point(12, 257);
            this.currentTaskButton.Name = "currentTaskButton";
            this.currentTaskButton.Size = new System.Drawing.Size(75, 35);
            this.currentTaskButton.TabIndex = 5;
            this.currentTaskButton.Text = "Current Tasks";
            this.currentTaskButton.UseVisualStyleBackColor = true;
            this.currentTaskButton.Click += new System.EventHandler(this.currentTaskButton_Click);
            // 
            // previousTasksButton
            // 
            this.previousTasksButton.Location = new System.Drawing.Point(106, 257);
            this.previousTasksButton.Name = "previousTasksButton";
            this.previousTasksButton.Size = new System.Drawing.Size(75, 35);
            this.previousTasksButton.TabIndex = 6;
            this.previousTasksButton.Text = "Previous Tasks";
            this.previousTasksButton.UseVisualStyleBackColor = true;
            this.previousTasksButton.Click += new System.EventHandler(this.previousTasksButton_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 317);
            this.Controls.Add(this.previousTasksButton);
            this.Controls.Add(this.currentTaskButton);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.deleteTask);
            this.Controls.Add(this.editTask);
            this.Controls.Add(this.createTask);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createTask;
        private System.Windows.Forms.Button editTask;
        private System.Windows.Forms.Button deleteTask;
        private System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.Button currentTaskButton;
        private System.Windows.Forms.Button previousTasksButton;
    }
}