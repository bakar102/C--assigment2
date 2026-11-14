using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating variable 

            int numberofpacages , age;
            double priceofpacage, subtotal, discountrate, discoutamount, totalamount;

            age = int.Parse(txtage.Text);
            if (age <= 25)
            {
                MessageBox.Show("please enter make sure age is greater than 25 ");
                txtage.Focus();
                return;

            }
            //validations 
            if (!int.TryParse(txtnumber.Text, out numberofpacages) || !double.TryParse(txtprice.Text, out priceofpacage))
            {
                MessageBox.Show("accepts only integer ");
                return;
            }
            





            subtotal = numberofpacages * priceofpacage;
            discountrate = 0;
            discoutamount = 0;
            if (numberofpacages >= 10 && numberofpacages <= 19)
            {
                discoutamount = subtotal * 0.2;
                discountrate = 20;
            }
            else
            {
                if (numberofpacages >= 20 && numberofpacages <= 49)
                {
                    discoutamount = subtotal * 0.3;
                    discountrate = 30;
                }

                else
                {
                    if (numberofpacages >= 50 && numberofpacages <= 99)
                    {
                        discoutamount = subtotal * 0.4;
                        discountrate = 40;
                    }


                    else
                    {
                        if (numberofpacages >= 100)
                        {
                            discoutamount = subtotal * 0.5;
                            discountrate = 50;
                        }
                    }
                    


                   


                }
                totalamount = subtotal - discoutamount;
                //displaying
                listBox1.Items.Add("number of pacages: " + numberofpacages);
                listBox1.Items.Add("price per pacage: " + priceofpacage);
                listBox1.Items.Add("subtotal: " + subtotal);
                listBox1.Items.Add("discount rate: " + discountrate);
                listBox1.Items.Add("discountm amount: " + discoutamount);
                listBox1.Items.Add("total amount: " + totalamount);


            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
