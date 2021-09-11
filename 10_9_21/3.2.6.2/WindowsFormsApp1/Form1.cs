using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalculator : Form
    {
        private const string messageBoxTitle = "Thông báo";

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                long a = validateTextBox(txtA, "a");
                long b = validateTextBox(txtB, "b");

                if (a > b)
                {
                    long tmp = a;
                    a = b;
                    b = tmp;
                }

                long numbers = b - a + 1;
                long result = (a + b) * (numbers / 2);

                if (numbers % 2 != 0)
                {
                    result += (a + b) / 2;
                }

                lblResult.Text = string.Format("Tổng số từ {0} đến {1} là: {2}", a, b, result);
            }
            catch (Exception)
            {
                lblResult.Text = "";
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lblResult.Text = "";
            txtA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private long validateTextBox(TextBox txt, string name)
        {
            try
            {
                return long.Parse(txt.Text);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is FormatException)
                {
                    string message = string.Format("Giá trị của {0} không phải là số!", name);
                    MessageBox.Show(message, messageBoxTitle);
                }
                else if (ex is OverflowException)
                {
                    string message = string.Format("Giá trị của {0} quá lớn!", name);
                    MessageBox.Show(message, messageBoxTitle);
                }

                throw new Exception();
            }
        }
    }
}
