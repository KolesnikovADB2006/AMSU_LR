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
        int b = 1; // начальное состояние
        
        public Form1()
        {
            InitializeComponent();
            btnB1.BackColor = Color.Orange; // отображаение начального состояния
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Обработка входного сигнала Z1
        private void btnZ1_Click(object sender, EventArgs e)
        {
            switch (b)
            {
                // Состояние b1
                case 1:
                    //Переход в состояние b2
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.Orange;
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 2;
                    //Выходной сигнал W4
                    btnW1.BackColor = Color.Green;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Lime;
                    break;
                case 2:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.Orange;
                    b = 4;
                    btnW1.BackColor = Color.Green;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Lime;
                    btnW4.BackColor = Color.Green;
                    break; 
                case 3:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.Orange;
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 2;
                    btnW1.BackColor = Color.Green;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break; 
                case 4:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.Orange;
                    b = 4;
                    btnW1.BackColor = Color.Lime;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
            }
                

        }

        //Обработка входного сигнала Z2
        private void btnZ2_Click(object sender, EventArgs e)
        {
            switch (b)
            {
                case 1:
                    btnB1.BackColor = Color.Orange;
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 1;
                    btnW1.BackColor = Color.Lime;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
                case 2:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.Orange;
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 2;
                    btnW1.BackColor = Color.Lime;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
                case 3:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.Orange;
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 3;
                    btnW1.BackColor = Color.Green;
                    btnW2.BackColor = Color.Lime;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
                case 4:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.Orange;
                    b = 4;
                    btnW1.BackColor = Color.Lime;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
            }
        }
        //Обработка входного сигнала Z3
        private void btnZ3_Click(object sender, EventArgs e)
        {
            switch (b)
            {
                case 1:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.Orange;
                    b = 4;
                    btnW1.BackColor = Color.Green;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Lime;
                    btnW4.BackColor = Color.Green;
                    break;
                case 2:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.Orange;
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 2;
                    btnW1.BackColor = Color.Green;
                    btnW2.BackColor = Color.Lime;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
                case 3:
                    btnB1.BackColor = Color.Orange;
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 1;
                    btnW1.BackColor = Color.Lime;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
                case 4:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.Orange;
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 3;
                    btnW1.BackColor = Color.Green;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Lime;
                    break;
            }
        }

        //Обработка входного сигнала Z4
        private void btnZ4_Click(object sender, EventArgs e)
        {
            switch (b)
            {
                case 1:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.Orange;
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 2;
                    btnW1.BackColor = Color.Lime;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
                case 2:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.Orange;
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 3;
                    btnW1.BackColor = Color.Lime;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
                case 3:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.Orange;
                    btnB4.BackColor = Color.FromArgb(192, 64, 0);
                    b = 3;
                    btnW1.BackColor = Color.Lime;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
                case 4:
                    btnB1.BackColor = Color.FromArgb(192, 64, 0);
                    btnB2.BackColor = Color.FromArgb(192, 64, 0);
                    btnB3.BackColor = Color.FromArgb(192, 64, 0);
                    btnB4.BackColor = Color.Orange;
                    b = 4;
                    btnW1.BackColor = Color.Lime;
                    btnW2.BackColor = Color.Green;
                    btnW3.BackColor = Color.Green;
                    btnW4.BackColor = Color.Green;
                    break;
            }

        }

        //Обработка нажатия кнопки сброс
        private void btnRS_Click(object sender, EventArgs e)
        {
            b = 1;
            btnB1.BackColor = Color.Orange;
            btnB2.BackColor = Color.FromArgb(192, 64, 0);
            btnB3.BackColor = Color.FromArgb(192, 64, 0);
            btnB4.BackColor = Color.FromArgb(192, 64, 0);

            btnW1.BackColor = Color.Green;
            btnW2.BackColor = Color.Green;
            btnW3.BackColor = Color.Green;
            btnW4.BackColor = Color.Green;
        }
    }
}
