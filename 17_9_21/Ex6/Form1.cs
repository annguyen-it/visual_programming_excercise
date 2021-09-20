using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
    public partial class Form1 : Form
    {
        private const string messageBoxTitle = "Thông báo";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstList.ColumnWidth = lstList.Width / 4;
            for (int i = 1; i <= 100; i++)
            {
                lstList.Items.Add("Item " + i.ToString());
            }
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            string selectedItems = String.Join(", ", lstList.SelectedItems.Cast<string>());
            string message = "Bạn đã chọn các phần tử: " + selectedItems;
            MessageBox.Show(message, messageBoxTitle);
        }
    }
}
