using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskWarrior
{
    public class Task
    {
        private String taskName;
        private String location;
        private String details;
        private DateTime taskDate;
        private int alarm;

        public String Name
        {
            set { this.taskName = value; }
            get { return this.taskName; }
        }

        public DateTime Date
        {
            set { this.taskDate = value; }
            get { return this.taskDate; }
        }

        public String Location
        {
            set { this.location = value; }
            get { return this.location; }
        }

        public String Details
        {
            set { this.details = value; }
            get { return this.details; }
        }

        public int Alarm
        {
            set { this.alarm = value; }
            get { return this.alarm; }
        }


        

        public Task(String taskName, DateTime taskDate, String location, String details, int alarm)
        {
            this.taskName = taskName;
            this.taskDate = taskDate;
            this.location = location;
            this.details = details;
            this.alarm = alarm;
        }

    }
}
