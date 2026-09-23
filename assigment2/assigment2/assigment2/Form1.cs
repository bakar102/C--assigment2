using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment2
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            int id = int.Parse(txtid.Text);
            string department = txtdepartment.Text;
            int semester = int.Parse(txtsemester.Text);
            lbloutput.Text = $"Name: {name} ID: {id} Department: {department} Semester: {semester}";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";    
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
