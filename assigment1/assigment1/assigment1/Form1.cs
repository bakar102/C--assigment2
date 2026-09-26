using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            // creating variables for the user input
            string DayoftheWeek, Month, Day, Year, Show;

            //Assign variable to user input
            DayoftheWeek = txtdayoftheWeek.Text;
            Month = txtdayofthemonth.Text;
            Day = txtdayofthenumeric.Text;
            Year = txtyear.Text;

            //Concatenate the variables to display the date
            Show = DayoftheWeek + ", " + Month + " " + Day + ", " + Year;
            

            //Display The output
            lbldatoutput.Text = Show;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear textbox and label
            txtdayoftheWeek.Text = "";
            txtdayofthemonth.Clear();
            txtdayofthenumeric.Text = string.Empty;
            txtyear.Text = string.Empty;
            lbldatoutput.Text = string.Empty;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // exit the application
            this.Close();
        }
    }
}
