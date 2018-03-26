using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGrid
{
    public partial class frmPlayerNames : Form
    {
        private Form d_owner = null;

        public frmPlayerNames(Form aOwner = null)
        {
            d_owner = aOwner;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = d_owner as Form1;
            if (f1 != null)
            {
                f1.p1.Text = textBox1.Text;
                f1.p2.Text = textBox2.Text;
 
            }
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
