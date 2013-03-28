using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        private JanuaryForm JanuaryMonth;
        private JanuaryForm FebruaryMonth;
        private JanuaryForm MarchMonth;
        private JanuaryForm AprilMonth;
        private JanuaryForm MayMonth;
        private JanuaryForm JuneMonth;
        private JanuaryForm JulyMonth;
        private JanuaryForm AugustMonth;
        private JanuaryForm SeptemberMonth;
        private JanuaryForm OctoberMonth;
        private JanuaryForm NovemberMonth;
        private JanuaryForm DecemberMonth;


        public Form1()
        {
            InitializeComponent();
        }

       

        private void January_Button_Click(object sender, EventArgs e)
        {
            JanuaryMonth = new JanuaryForm("January");
            
            JanuaryMonth.ShowDialog();
            

        }

        private void February_Button_Click(object sender, EventArgs e)
        {
            FebruaryMonth = new JanuaryForm("February");
          
            FebruaryMonth.ShowDialog();
        }

        private void March_Button_Click(object sender, EventArgs e)
        {
            MarchMonth = new JanuaryForm("March");
            MarchMonth.ShowDialog();
        }

        private void April_Button_Click(object sender, EventArgs e)
        {
            AprilMonth = new JanuaryForm("April");
            AprilMonth.ShowDialog();
        }

        private void May_Button_Click(object sender, EventArgs e)
        {
            MayMonth = new JanuaryForm("May");
            MayMonth.ShowDialog();
        }

        private void June_Button_Click(object sender, EventArgs e)
        {
            JuneMonth = new JanuaryForm("June");
            JuneMonth.ShowDialog();
        }

        private void July_Button_Click(object sender, EventArgs e)
        {
            JulyMonth = new JanuaryForm("July");
            JulyMonth.ShowDialog();
        }

        private void August_Button_Click(object sender, EventArgs e)
        {
            AugustMonth = new JanuaryForm("August");
            AugustMonth.ShowDialog();
        }

        private void September_Button_Click(object sender, EventArgs e)
        {
            SeptemberMonth = new JanuaryForm("September");
            SeptemberMonth.ShowDialog();
        }

        private void October_Button_Click(object sender, EventArgs e)
        {
            OctoberMonth = new JanuaryForm("October");
            OctoberMonth.ShowDialog();
        }

        private void November_Button_Click(object sender, EventArgs e)
        {
            NovemberMonth = new JanuaryForm("November");
            NovemberMonth.ShowDialog();
        }

        private void December_Button_Click(object sender, EventArgs e)
        {
            DecemberMonth = new JanuaryForm("December");
            DecemberMonth.ShowDialog();
        }
    }
}
