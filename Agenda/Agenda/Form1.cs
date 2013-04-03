using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agenda
{
    public partial class TaskWarrior : Form
    {

        public TaskWarrior()
        {
            InitializeComponent();
        }

        private void EventCreation_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string sEventName;
            DateTime dtEventDate;
            DateTime dtEventDateClick;
            string sEventHour;
            string sEventMinute;
            string sEventSecond;
            string sEventLocation;
            string sEventDetails;
            string sAlarmTime;
            int iEventHour;
            int iEventMinute;
            int iEventSecond;

            sEventName = EventNameTextBox.Text;
            dtEventDateClick = AgendaDatePicker.Value;
            sEventHour = EventHourTextBox.Text;
            sEventMinute = EventMinTextBox.Text;
            sEventSecond = EventSecondTextBox.Text;
            sEventLocation = EventLocationTextBox.Text;
            sEventDetails = EventDetailsTextBox.Text;
            sAlarmTime = AlarmTimeTextBox.Text;
            iEventHour = Convert.ToInt32(sEventHour);
            iEventMinute = Convert.ToInt32(sEventMinute);
            iEventSecond = Convert.ToInt32(sEventSecond);
            dtEventDate = new DateTime(dtEventDateClick.Year, dtEventDateClick.Month,
                dtEventDateClick.Day, iEventHour, iEventMinute, iEventSecond);

            System.Console.WriteLine(sEventName + " " + dtEventDate + " " +
                sEventLocation + " " + sEventDetails + " " + sAlarmTime);
            //sEventName = Name of event
            //dtEventDate = Datetime of event
            //sEventLocation = Event Location
            //sEventDetails = Extra info
            //sAlarmTime is how far ahead they want the alarm sounded
            //These all are the variables that the info the user entered is saved into when they hit create

          EventNameTextBox.Text = "";
          EventHourTextBox.Text = "";
          EventLocationTextBox.Text = "";
          EventDetailsTextBox.Text = "";
          AlarmTimeTextBox.Text = "";
        }

    }    
}
