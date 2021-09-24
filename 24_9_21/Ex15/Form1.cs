using System;
using System.Windows.Forms;

namespace Ex15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSecond.Text, out _))
            {
                btnRun.Enabled = true;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMinute.Text, out _))
                txtMinute.Text = "0";

            tmr.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmr.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtMinute.Text = "0";
            txtSecond.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int m = int.Parse(txtMinute.Text);
            int s = int.Parse(txtSecond.Text);

            if (s > 0)
            {
                txtSecond.Text = (s - 1).ToString();
            }
            else if (m > 0)
            {
                txtSecond.Text = "59";
                txtMinute.Text = (m - 1).ToString();
            }
            else
            {
                txtMinute.Text = "0";
                tmr.Stop();
            }
        }
    }
}
