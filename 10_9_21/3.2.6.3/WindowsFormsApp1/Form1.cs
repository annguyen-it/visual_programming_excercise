using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NumberForm : Form
    {
        private const string messageBoxTitle = "Thông báo";
        private List<int> list = new List<int>();

        public NumberForm()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                int n = validateInputAndParseToInt();
                list.Clear();
                Random rand = new Random();

                for (int i = 0; i < n; i++)
                {
                    list.Add(rand.Next(0, 100));
                }

                lblSequence.Text = "Dãy số: " + string.Join(", ", list);
                lblSum.Text = "";
                lblSort.Text = "";
            }
            catch (Exception) { }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (list.Any())
            {
                lblSum.Text = "Tổng dãy số là: " + list.Sum();
            }
            else
            {
                MessageBox.Show("Hãy nhập n!", messageBoxTitle);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (list.Any())
            {
                lblSum.Text = "Tổng dãy số là: " + list.Sum();
            }
            else
            {
                List<int> cloneList = list.ToList();
                cloneList.Sort((a, b) => b.CompareTo(a));

                lblSort.Text = "Dãy số sắp xếp giảm dần là: " + string.Join(", ", cloneList);
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            lblSequence.Text = "";
            lblSum.Text = "";
            lblSort.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int validateInputAndParseToInt()
        {
            try
            {
                return int.Parse(txtNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Số nhập vào không hợp lệ!", messageBoxTitle);
                throw new Exception();
            }
        }
    }
}
