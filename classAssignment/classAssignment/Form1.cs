using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //read price
            decimal price1 = decimal.Parse(txtprice1.Text);
            decimal price2 = decimal.Parse(txtprice2.Text);
            
            //subtotal
            decimal subtotal = price1 + price2;
            
            //precentages
            decimal Sales_Tex_Percatge = 7;   // 7%
            decimal Tips_Percatge = 15;       // 15%

            //calculating Tax,tips,total
            decimal salesTax = subtotal * Sales_Tex_Percatge / 100;
            decimal tips = subtotal * Tips_Percatge / 100;
            decimal total = subtotal + salesTax - tips;

            //show result as currency
            txtsales.Text = salesTax.ToString("C");
            txttips.Text = tips.ToString("C");
            txttotal.Text = total.ToString("C");
        }
    }
}
