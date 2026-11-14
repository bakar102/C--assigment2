using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblprecentagegram_Click(object sender, EventArgs e)
        {

        }

        private void lblfatgram_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //declaring variables
            
            double Totalcolories, fat, numberofcolories ,precentage;
            
            //initialise variables
            
            Totalcolories = int.Parse(txtcolories.Text);
            fat=int.Parse(txtfat.Text);
            
            //validation 
            
            if (Totalcolories < 0 || fat<0)
            {
                MessageBox.Show("please enter make sure number of colories and fats are not less than zero");
                txtfat.Focus();
                return;

            }
            //calculating no of colories
            
            numberofcolories = fat * 9;
            precentage = numberofcolories / Totalcolories*100;
          
            //validate number of colories can't be greater than the total
            
            if (numberofcolories> Totalcolories)
            {
                MessageBox.Show("number of colories can't greater that the tototal number of colories.");
                txtfat.Focus();
                return;
            }
            //auto check low fat
            if (precentage<30)
            {
                checkBoxlowfat.Checked = true;
            }
            //displaying
            lblfatgram.Text = numberofcolories.ToString();
            lblprecentagegram.Text = precentage.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
