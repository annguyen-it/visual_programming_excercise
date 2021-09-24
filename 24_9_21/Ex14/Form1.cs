using System;
using System.Windows.Forms;

namespace Ex14
{
    public partial class Form1 : Form
    {
        bool movingRight = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr.Start();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (movingRight)
            {
                if (lblMove.Right < Width)
                    lblMove.Left += 10;
                else
                {
                    movingRight = false;
                    lblMove.Left -= 10;
                }
            }
            else
            {
                if (lblMove.Left > 0)
                    lblMove.Left -= 10;
                else
                {
                    movingRight = true;
                    lblMove.Left += 10;
                }
            }
        }
    }
}
