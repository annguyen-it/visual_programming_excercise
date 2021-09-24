using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ColorChange();
        }

        private void hsbRed_ValueChanged(object sender, EventArgs e)
        {
            ColorChange();
            lblRedValue.Text = hsbRed.Value.ToString();
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            ColorChange();
            lblGreenValue.Text = hsbGreen.Value.ToString();
        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            ColorChange();
            lblBlueValue.Text = hsbBlue.Value.ToString();
        }

        private void ColorChange()
        {
            int r = hsbRed.Value;
            int g = hsbGreen.Value;
            int b = hsbBlue.Value;

            txtColor.BackColor = Color.FromArgb(r, g, b);
        }

    }
}
