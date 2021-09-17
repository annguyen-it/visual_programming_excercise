using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        private const string messageBoxTitle = "Thông báo";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!InputIsValid())
            {
                return;
            }

            if (lstList.Items.Contains(txtInput.Text))
            {
                MessageBox.Show("Đã có " + txtInput.Text, messageBoxTitle);
                return;
            }

            lstList.Items.Add(txtInput.Text);
            txtInput.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstList.SelectedIndex;

            if (selectedIndex != -1)
            {
                lstList.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!InputIsValid())
            {
                return;
            }

            bool added = lstList.Items.Contains(txtInput.Text);
            MessageBox.Show(
                (added
                    ? "Đã có \""
                    : "Chưa có \"")
                    + txtInput.Text + "\"",
                messageBoxTitle);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool InputIsValid()
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("Hãy nhập ngoại ngữ", messageBoxTitle);
                return false;
            }

            return true;
        }
    }
}
