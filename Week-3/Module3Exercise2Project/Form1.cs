using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Escape)
                {
                Application.Exit();
                }
            }

        private void btnR_Click(object sender, EventArgs e)
        {
            lblMessage.Text = btnR.Text;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnRed.BackColor;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnBlue.BackColor;

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            lblMessage.Text = btnL.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
            {

            }
        }
}
