using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating variables
            string name, roomType;
            int age, numbeOfNights, NumberOfGuests, validation;
            double RatePerNight, BasicRoomCost, StayDiscount, SeniorDiscount, BreakFastCost, Finalcosts;
            if (int.TryParse(txtage.Text, out validation) && int.TryParse(txtnights.Text, out validation) && int.TryParse(txtguest.Text, out validation))
            {
                name = txtage.Text;
                age = int.Parse(txtage.Text);
                numbeOfNights = int.Parse(txtnights.Text);
                NumberOfGuests = int.Parse(txtguest.Text);
                if (age > 18 && age < 90)
                {
                    if (numbeOfNights >= 1 && numbeOfNights <= 30)
                    {
                        if (NumberOfGuests > 1 && NumberOfGuests <= 6)
                        {
                            if (radiohight.Checked)
                            {
                                roomType = "room type is: hight/n";
                                listBox1.Items.Add(roomType);
                                double hight = 130;
                                if (numbeOfNights >= 1 && numbeOfNights <= 4)
                                {

                                    double roomRate = hight * numbeOfNights * NumberOfGuests;
                                    listBox1.Items.Add(roomRate);
                                    if (checkBoxbreakfast.Checked)
                                    {
                                        BreakFastCost = 10 * NumberOfGuests * numbeOfNights;
                                        listBox1.Items.Add("breakfast cost: " + BreakFastCost);
                                        roomType += BreakFastCost;
                                        listBox1.Items.Add("roomrate: " + roomRate);

                                        if (NumberOfGuests > 4)
                                        {
                                            double surviceSurcharge = roomRate * 0.05;
                                            listBox1.Items.Add("survice surcharge:" + surviceSurcharge);
                                            roomRate += surviceSurcharge;
                                            if (age > 60)
                                            {
                                                SeniorDiscount = roomRate * 0.05;
                                                listBox1.Items.Add("senario discount:" + SeniorDiscount);
                                            }
                                            Finalcosts = roomRate;
                                            listBox1.Items.Add("final cost" + Finalcosts);
                                        }
                                        else
                                        {
                                            if (age > 60)
                                            {
                                                SeniorDiscount = roomRate * 0.05;
                                                listBox1.Items.Add("senario discount:" + SeniorDiscount);
                                            }

                                        }
                                    }
                                    else
                                    {
                                        roomRate = hight * numbeOfNights * NumberOfGuests;
                                        listBox1.Items.Add(roomRate);
                                    }

                                }
                                else if (numbeOfNights >= 5 && numbeOfNights <= 9)
                                {
                                    double discout = (hight * numbeOfNights * NumberOfGuests) * 0.05;
                                    double roomRate = (hight * numbeOfNights * NumberOfGuests) - discout;
                                    listBox1.Items.Add(roomRate);
                                }
                            }
                            
                            {

                            }
                        }
                        if (radiostandard.Checked)
                        {
                            if (NumberOfGuests <= 2)
                            {
                                roomType = "room type is: standard/n";
                                listBox1.Items.Add(roomType);

                            }
                            else
                            {
                                MessageBox.Show("maximum standard must be 2 ");
                            }

                        }
                        else
                        {
                            MessageBox.Show("number of guests must be 1 and 6");
                        }
                    }
                    else
                    {
                        MessageBox.Show("number of nights must be 1 and 6");
                    }
                }
                else
                {
                    MessageBox.Show("number of nights must be 1 and 30 ");
                }
            }
            else
            {
                MessageBox.Show("age must be in between 18 and 90");
            }

           



        }

    }
}
