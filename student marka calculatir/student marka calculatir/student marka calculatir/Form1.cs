using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_marka_calculatir
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string name = textBox1.Text;
                int test1 = int.Parse(textBox2.Text);
                int test2 = int.Parse(textBox3.Text);
                int test3 = int.Parse(textBox4.Text);
                int total = test1 + test2 + test3;
                double avg = total / 3.0;


                if (avg >= 90)
                {
                    label7.Text = "Grade A";
                }
                else if (avg >=80)
                {
                    label7.Text = "Grade B";
                }
                else if (avg >=70)
                {
                    label7.Text = "Grade C";
                }
                else if (avg >=55)
                {
                    label7.Text = "Grade D";
                }
                else
                {
                    label7.Text = "you faild";
                }

                textBox5.Text = total.ToString();
                label7.Text = avg.ToString();
            }
            catch
            {
                MessageBox.Show("fadlan gali number oo kaliya ");
           }



           
            }


        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            label6.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
