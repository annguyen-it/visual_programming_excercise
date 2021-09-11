using System;
using System.Windows.Forms;

namespace _3._2._6
{
    public partial class Form1 : Form
    {
        private const string messageBoxTitle = "Thông báo";
        private int[] daysInMonthOfNormalYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                int month = commonnValidateTextBox(txtMonth, "tháng");
                int year = commonnValidateTextBox(txtYear, "năm");

                specificValidateTextBox(month, validateMonth);
                specificValidateTextBox(year, validateYear);

                int daysInMonth = daysInMonthOfNormalYear[month - 1];
                if (month == 2 && isLeapYear(year))
                {
                    daysInMonth++;
                }

                lblResult.Text = string.Format("Tháng {0} năm {1} có {2} ngày", month, year, daysInMonth);
            }
            catch (Exception) {
                lblResult.Text = "";
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            txtMonth.Clear();
            txtYear.Clear();
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int commonnValidateTextBox(TextBox txt, string name)
        {
            try
            {
                return int.Parse(txt.Text);
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

        private void specificValidateTextBox(int value, Func<int, string> validateFunction)
        {
            string error = validateFunction(value);
            if (error.Length != 0)
            {
                MessageBox.Show(error, messageBoxTitle);
                throw new Exception();
            }
        }

        private string validateMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                return "Giá trị của tháng không hợp lệ!";
            }

            return "";
        }

        private string validateYear(int year)
        {
            if (year < 1000 || year > 9999)
            {
                return "Giá trị của năm không hợp lệ!";
            }

            return "";
        }

        private bool isLeapYear(int year)
        {
            return year % 4 == 0 ||
                (year % 100 == 0 && year % 400 == 0);
        }
    }
}
