using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIJAABO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinformatio_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string studentId = txtstudentid.Text;
            string department = txtdepartement.Text;
            string semester = txtsemester.Text;

            lbloutput.Text =
                "Student Name: " + name + Environment.NewLine +
                "Student ID: " + studentId + Environment.NewLine +
                "Department: " + department + Environment.NewLine +
                "Semester: " + semester;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartement.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";

            txtname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
