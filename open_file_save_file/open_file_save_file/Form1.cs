using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace open_file_save_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" ||
            txtdepartment.Text == "" || txtmark.Text == "")
            {
                MessageBox.Show("fadlan buuxi dhamaan.");
                return;
            }

            double mark;

            if (!double.TryParse(txtmark.Text, out mark) || mark < 0)
            {
                MessageBox.Show("marks must positive mark.");
                return;
            }

            string studentType = "";

            if (radioButton1.Checked)
                studentType = "Undergraduate";
            else if (radioButton2.Checked)
                studentType = "Postgraduate";
            else
            {
                MessageBox.Show("Please select student type.");
                return;
            }

            string record = txtid.Text + "," +txtname.Text + "," + txtdepartment.Text + "," + mark + "," + studentType;

            File.AppendAllText("student.txt", record + Environment.NewLine);

            MessageBox.Show("Student saved successfully.");
        }
            
        

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists("student.txt"))
            {
                string[] records = File.ReadAllLines("student.txt");

                foreach (string record in records)
                {
                    listBox1.Items.Add(record);
                }
            }
            else
            {
                MessageBox.Show("Student file not found.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists("student.txt"))
            {
                string[] records = File.ReadAllLines("student.txt");

                foreach (string record in records)
                {
                    listBox1.Items.Add(record);
                }
            }
            else
            {
                MessageBox.Show("Student file not found.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //txtid.Clear();
            //txtname.Clear();
            //txtdepartment.Clear();
            //txtmark.Clear();

            //radioButton1.Checked = false;
            //radioButton2.Checked = false;
        }
    }
}
