using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testvariable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            int id;
            id = 123;
            id = 1234;

            MessageBox.Show("Your id :" + id);

            string name;
            name = "sok";
            MessageBox.Show("your name :" + name);

            double salary;
            salary = 1000.50;
            MessageBox.Show("your salary :" + salary);

            char gender;
            gender = 'F';
            MessageBox.Show("your gender is :" + gender);


            bool kh; // Boolean
            kh = true;
            if (kh==true) {
                MessageBox.Show("You are khmer ");
            }

            int x = 5;
            ++x; //x = x + 1;
            MessageBox.Show("value x :" + x);

            int x1 = 5;
            MessageBox.Show("value xx :" + x1++);

            float a, b,s; // both a and b have the same datatype
            a = 10; b = 5; s = a + b; MessageBox.Show(" a + b =" + s);

        }
    }
}
