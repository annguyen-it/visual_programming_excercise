using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert(txtA.Text);
                double b = Convert(txtB.Text);
                double c = Convert(txtC.Text);

                Tuple<double, double, string> result = Solve(a, b, c);

                if (result.Item3 != "")
                {
                    txtResult.Text = result.Item3;
                    return;
                }

                if (!double.IsNaN(result.Item2))
                {
                    txtResult.Text = string.Format("Phương trình có 2 nghiệm:\r\nx1 = {0}\r\nx2 = {1}", result.Item1, result.Item2);
                    return;
                }

                txtResult.Text = string.Format("Phương trình có nghiệm kép:\r\nx = {0}", result.Item1);

            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không phải là sô!\r\nHãy thử lại");
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        double Convert(string s)
        {
            if (s == "")
                return 0;

            return System.Convert.ToInt32(s);
        }

        Tuple<double, double, string> Solve(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        return Tuple.Create(double.NaN, double.NaN, "Vô số nghiệm");

                    return Tuple.Create(double.NaN, double.NaN, "Vô nghiệm");
                }

                return Tuple.Create(-c / b, double.NaN, "");
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
                return Tuple.Create(double.NaN, double.NaN, "Vô nghiệm");


            if (delta == 0)
                return Tuple.Create(-b / (2 * a), double.NaN, "");

            return Tuple.Create((-b + Math.Sqrt(delta)) / (2 * a), (-b - Math.Sqrt(delta)) / (2 * a), "");
        }
    }
}
