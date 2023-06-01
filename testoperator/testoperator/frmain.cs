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
    public partial class frmain : Form
    {
        public frmain()
        {
            InitializeComponent();
        }

        private void comparisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmassignmentoperator frmass = new frmassignmentoperator();
            frmass.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudent frmstu = new frmstudent();
            frmstu.ShowDialog();
        }
    }
}
