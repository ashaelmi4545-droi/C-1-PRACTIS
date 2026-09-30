using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Assement
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtnamefood1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            // create variable
            string food1 = txtnamefood1.Text;
            int pricefood1 = int.Parse(txtpricefood1.Text);
            string food2 = txtenamefood2.Text;
            int pricefood2 = int.Parse(txtpricefood2.Text);

            //calculating tax bynmultiplaying 0.06
            double tax = (pricefood1 + pricefood2) * 0.06;


            // calculating final total
            double total = pricefood1 + pricefood2 + tax;

            //output
            outputlbl.Text = "total is:" + total.ToString();



        }
        
    }
    }

