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

namespace course_plan_and_service_plan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int total = 0;
            if (radioButton1.Checked)
            {
                listBox1.Items.Add("Basics    $10");
                total += 10;
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.Add("Stanadard    1`$15");
                total += 15;
            }
            else if (radioButton3.Checked)
            {
                listBox1.Items.Add("Premimum   $25");
                total += 25;
            }
            if (checkBox1.Checked)
            {
                listBox1.Items.Add("lab access  + $ 5 ");
                total += 5;
            }
            if (checkBox2.Checked)
            {
                listBox1.Items.Add("libabary   + $ 3 ");
                total += 3;
            }

            label1.Text = " the total is  $ "
                + total;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}