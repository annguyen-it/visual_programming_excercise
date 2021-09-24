using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(nudA.Value);
            int b = Convert.ToInt32(nudB.Value);
            string result = string.Format("A = {0}, B = {1}. ", a, b);

            if (a == 0)
            {
                if (b == 0)
                    result += "Phương trình vô số nghiệm";
                else
                    result += "Phương trình vô nghiệm";
            }
            else
            {
                double x = (double)-b / a;
                result += "Phương trình có nghiệm là: x = " + x.ToString();
            }

            txtResult.Text = result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
