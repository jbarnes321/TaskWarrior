namespace Agenda
{
    partial class TaskWarrior
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
            this.EventCreation_GroupBox = new System.Windows.Forms.GroupBox();
            this.Agenda_GroupBox = new System.Windows.Forms.GroupBox();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.EventNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EventDateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.EventTimeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EventLocationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EventLocationLabel = new System.Windows.Forms.Label();
            this.EventDetailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EventDetailsLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.EventCreation_GroupBox.SuspendLayout();
            this.Agenda_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventCreation_GroupBox
            // 
            this.EventCreation_GroupBox.Controls.Add(this.AlarmCheckBox);
            this.EventCreation_GroupBox.Controls.Add(this.CreateButton);
            this.EventCreation_GroupBox.Controls.Add(this.EventDetailsRichTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.EventDetailsLabel);
            this.EventCreation_GroupBox.Controls.Add(this.EventLocationRichTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.EventLocationLabel);
            this.EventCreation_GroupBox.Controls.Add(this.EventTimeRichTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.label3);
            this.EventCreation_GroupBox.Controls.Add(this.EventDateRichTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.EventDateLabel);
            this.EventCreation_GroupBox.Controls.Add(this.EventNameRichTextBox);
            this.EventCreation_GroupBox.Controls.Add(this.EventNameLabel);
            this.EventCreation_GroupBox.Location = new System.Drawing.Point(4, 4);
            this.EventCreation_GroupBox.Name = "EventCreation_GroupBox";
            this.EventCreation_GroupBox.Size = new System.Drawing.Size(217, 523);
            this.EventCreation_GroupBox.TabIndex = 0;
            this.EventCreation_GroupBox.TabStop = false;
            this.EventCreation_GroupBox.Text = "Event Creation";
            // 
            // Agenda_GroupBox
            // 
            this.Agenda_GroupBox.Controls.Add(this.listView1);
            this.Agenda_GroupBox.Controls.Add(this.vScrollBar1);
            this.Agenda_GroupBox.Location = new System.Drawing.Point(228, 4);
            this.Agenda_GroupBox.Name = "Agenda_GroupBox";
            this.Agenda_GroupBox.Size = new System.Drawing.Size(400, 506);
            this.Agenda_GroupBox.TabIndex = 1;
            this.Agenda_GroupBox.TabStop = false;
            this.Agenda_GroupBox.Text = "Agenda";
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Location = new System.Drawing.Point(8, 29);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(69, 13);
            this.EventNameLabel.TabIndex = 0;
            this.EventNameLabel.Text = "Event Name:";
            // 
            // EventNameRichTextBox
            // 
            this.EventNameRichTextBox.Location = new System.Drawing.Point(11, 46);
            this.EventNameRichTextBox.Name = "EventNameRichTextBox";
            this.EventNameRichTextBox.Size = new System.Drawing.Size(200, 21);
            this.EventNameRichTextBox.TabIndex = 1;
            this.EventNameRichTextBox.Text = "";
            // 
            // EventDateRichTextBox
            // 
            this.EventDateRichTextBox.Location = new System.Drawing.Point(11, 87);
            this.EventDateRichTextBox.Name = "EventDateRichTextBox";
            this.EventDateRichTextBox.Size = new System.Drawing.Size(200, 21);
            this.EventDateRichTextBox.TabIndex = 3;
            this.EventDateRichTextBox.Text = "";
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Location = new System.Drawing.Point(8, 70);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(64, 13);
            this.EventDateLabel.TabIndex = 2;
            this.EventDateLabel.Text = "Event Date:";
            // 
            // EventTimeRichTextBox
            // 
            this.EventTimeRichTextBox.Location = new System.Drawing.Point(11, 128);
            this.EventTimeRichTextBox.Name = "EventTimeRichTextBox";
            this.EventTimeRichTextBox.Size = new System.Drawing.Size(200, 21);
            this.EventTimeRichTextBox.TabIndex = 5;
            this.EventTimeRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Event Time:";
            // 
            // EventLocationRichTextBox
            // 
            this.EventLocationRichTextBox.Location = new System.Drawing.Point(9, 169);
            this.EventLocationRichTextBox.Name = "EventLocationRichTextBox";
            this.EventLocationRichTextBox.Size = new System.Drawing.Size(200, 21);
            this.EventLocationRichTextBox.TabIndex = 7;
            this.EventLocationRichTextBox.Text = "";
            // 
            // EventLocationLabel
            // 
            this.EventLocationLabel.AutoSize = true;
            this.EventLocationLabel.Location = new System.Drawing.Point(6, 152);
            this.EventLocationLabel.Name = "EventLocationLabel";
            this.EventLocationLabel.Size = new System.Drawing.Size(82, 13);
            this.EventLocationLabel.TabIndex = 6;
            this.EventLocationLabel.Text = "Event Location:";
            // 
            // EventDetailsRichTextBox
            // 
            this.EventDetailsRichTextBox.Location = new System.Drawing.Point(11, 210);
            this.EventDetailsRichTextBox.Name = "EventDetailsRichTextBox";
            this.EventDetailsRichTextBox.Size = new System.Drawing.Size(200, 187);
            this.EventDetailsRichTextBox.TabIndex = 9;
            this.EventDetailsRichTextBox.Text = "";
            // 
            // EventDetailsLabel
            // 
            this.EventDetailsLabel.AutoSize = true;
            this.EventDetailsLabel.Location = new System.Drawing.Point(8, 193);
            this.EventDetailsLabel.Name = "EventDetailsLabel";
            this.EventDetailsLabel.Size = new System.Drawing.Size(73, 13);
            this.EventDetailsLabel.TabIndex = 8;
            this.EventDetailsLabel.Text = "Event Details:";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(136, 426);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "CREATE";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(383, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 494);
            this.vScrollBar1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(22, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(348, 471);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AlarmCheckBox
            // 
            this.AlarmCheckBox.AutoSize = true;
            this.AlarmCheckBox.Location = new System.Drawing.Point(11, 403);
            this.AlarmCheckBox.Name = "AlarmCheckBox";
            this.AlarmCheckBox.Size = new System.Drawing.Size(52, 17);
            this.AlarmCheckBox.TabIndex = 11;
            this.AlarmCheckBox.Text = "Alarm";
            this.AlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // TaskWarrior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 522);
            this.Controls.Add(this.Agenda_GroupBox);
            this.Controls.Add(this.EventCreation_GroupBox);
            this.Name = "TaskWarrior";
            this.Text = "TASK-WARRIOR!";
            this.EventCreation_GroupBox.ResumeLayout(false);
            this.EventCreation_GroupBox.PerformLayout();
            this.Agenda_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EventCreation_GroupBox;
        private System.Windows.Forms.GroupBox Agenda_GroupBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.RichTextBox EventDetailsRichTextBox;
        private System.Windows.Forms.Label EventDetailsLabel;
        private System.Windows.Forms.RichTextBox EventLocationRichTextBox;
        private System.Windows.Forms.Label EventLocationLabel;
        private System.Windows.Forms.RichTextBox EventTimeRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox EventDateRichTextBox;
        private System.Windows.Forms.Label EventDateLabel;
        private System.Windows.Forms.RichTextBox EventNameRichTextBox;
        private System.Windows.Forms.Label EventNameLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.CheckBox AlarmCheckBox;
    }
}

