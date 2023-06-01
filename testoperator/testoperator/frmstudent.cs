using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testoperator
{
    public partial class frmstudent : Form
    {
        public frmstudent()
        {
            InitializeComponent();
        }

        private void frmstudent_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ID\tName\tAddress\tGrade");
           
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            string stuinfo = txtid.Text + "\t" + txtname.Text + 
                "\t" + txtaddress.Text;
            double total = Convert.ToDouble(txtcsharp.Text) +
                      Convert.ToDouble(txtc.Text) + 
                      Convert.ToDouble(txtweb.Text);
            double avg = total / 3;
            string grade;
            if (avg >= 90)
            {
                grade = "A";
            }
            else if (avg >= 80)
            {
                grade = "B";
            }
            else if (avg >= 70)
            {
                grade = "C";
            }
            else if (avg >= 60)
            {
                grade = "D";
            }
            else {
                grade = "F";
            }

            listBox1.Items.Add(stuinfo + "\t" + grade);
        }

        private void txtclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtcsharp.Clear();
            txtc.Clear();
            txtweb.Clear();
            txtid.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
