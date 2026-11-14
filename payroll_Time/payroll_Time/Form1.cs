using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            //creating variable
            double hours_worked, payrate, grosspay;
            double validation;

            //prevent exception data convertion using try parse
            if (double.TryParse(txthours.Text, out validation) && double.TryParse(txtpayrate.Text, out validation))
            {

                //assigning variable
                hours_worked = double.Parse(txthours.Text);
                payrate = double.Parse(txtpayrate.Text);

                //check validation user
                if (hours_worked > 0 && payrate > 0)
                {
                    //calculate the gross pay
                    grosspay = hours_worked * payrate;
                    lblgrosspay.Text = grosspay.ToString("c");


                }
                else
                {
                    MessageBox.Show("please enter the a positive number for hours worked and hourly rate.");
                }
            }

            else
            {
                MessageBox.Show("please enter valid numeric values for hour worked and hourly rate only");

            }

            
            }

        private void button2_Click(object sender, EventArgs e)
        {
            txthours.Text = "";
            txtpayrate.Text = "";
            lblgrosspay.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

