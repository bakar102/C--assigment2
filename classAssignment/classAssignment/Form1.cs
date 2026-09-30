using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating variables
            string costomer;
            double previous, current, unitprice;

            //getting values from texboxes 
            costomer=txtcustomer.Text;
            previous= double.Parse(txtprevious.Text);
            current= double.Parse(txtcurrent.Text);
            unitprice= double.Parse(txtunitprice.Text);

            //calculating usage and tax

            double usage= current - previous;
            double cost= usage * unitprice;

            //calculating tax (7%) and total (with $5 fixed charge )

            double tax = cost * 0.07;
            double total = cost + tax + 5;

            //displaying the result in labels

            txtusage.Text = usage.ToString();
            txttax.Text = tax.ToString("C");
            txttotal.Text = total.ToString("C");

        }
    }
}
