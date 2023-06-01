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
    public partial class frmassignmentoperator : Form
    {
        public frmassignmentoperator()
        {
            InitializeComponent();
        }
        private void btndisplay_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(txta.Text);
            int b = int.Parse(txtb.Text);
            a += b;  // a = a + b;
            //a -= b;  // a = a - b;
            //a /= b;    // a = a/b;
            txtresult.Text = a.ToString();
           
        } 
    }
}
