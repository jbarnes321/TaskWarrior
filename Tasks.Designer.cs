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
            this.listOfTasks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createTask
            // 
            this.createTask.Location = new System.Drawing.Point(191, 311);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(75, 23);
            this.createTask.TabIndex = 0;
            this.createTask.Text = "Create Task";
            this.createTask.UseVisualStyleBackColor = true;
            this.createTask.Click += new System.EventHandler(this.createTask_Click);
            // 
            // listOfTasks
            // 
            this.listOfTasks.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfTasks.FormattingEnabled = true;
            this.listOfTasks.ItemHeight = 14;
            this.listOfTasks.Location = new System.Drawing.Point(12, 12);
            this.listOfTasks.Name = "listOfTasks";
            this.listOfTasks.Size = new System.Drawing.Size(254, 284);
            this.listOfTasks.TabIndex = 1;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 346);
            this.Controls.Add(this.listOfTasks);
            this.Controls.Add(this.createTask);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createTask;
        private System.Windows.Forms.ListBox listOfTasks;
    }
}