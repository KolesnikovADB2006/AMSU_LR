using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string b1 = "b1";
        string b2 = "b2";
        string b3 = "b3";
        string b4 = "b4";
        int i;
        
        public Form1()
        {
            InitializeComponent();
            tbState.Text = b1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZ1_Click(object sender, EventArgs e)
        {
            btnZ1.BackColor = Color.Red;
            btnZ2.BackColor = Color.Maroon;
            btnZ3.BackColor = Color.Maroon;
            btnZ4.BackColor = Color.Maroon;
            i = 1;
            if (tbState.Text == "b1")
            {
                btnW4.BackColor = Color.Lime;
            }
            else if (tbState.Text == "b2")
            {

            }
            else if(tbState.Text == "b3")
            {

            }

        }

        private void btnZ2_Click(object sender, EventArgs e)
        {
            btnZ1.BackColor = Color.Maroon;
            btnZ2.BackColor = Color.Red;
            btnZ3.BackColor = Color.Maroon;
            btnZ4.BackColor = Color.Maroon;
            i = 2;
        }

        private void btnZ3_Click(object sender, EventArgs e)
        {
            btnZ1.BackColor = Color.Maroon;
            btnZ2.BackColor = Color.Maroon;
            btnZ3.BackColor = Color.Red;
            btnZ4.BackColor = Color.Maroon;
            i = 3;
        }

        private void btnZ4_Click(object sender, EventArgs e)
        {
            btnZ1.BackColor = Color.Maroon;
            btnZ2.BackColor = Color.Maroon;
            btnZ3.BackColor = Color.Maroon;
            btnZ4.BackColor = Color.Red;
            i = 4;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
