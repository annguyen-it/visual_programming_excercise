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

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDrink.Items.Add(new Drink("Coca cola", 0.5));
            cbDrink.Items.Add(new Drink("Pepsi", 0.8));
            cbDrink.Items.Add(new Drink("7up", 1));

            for (int i = 1; i <= 10; i++)
                cbNumerous.Items.Add(i);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtName.Text;
            item += " | " + (rdoFullDay.Checked ? "Cả ngày | $200" : "Nửa ngày | $100");
            item += " | Đồ uống $" + txtPrice.Text;
            item += " | Tổng $" + (double.Parse(txtPrice.Text) + double.Parse(txtDrinkMoney.Text)).ToString();

            lstCustomer.Items.Add(item);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "";
            rdoFullDay.Checked = false;
            rdoHalfDay.Checked = false;
            cbDrink.SelectedIndex = -1;
            cbNumerous.SelectedIndex = -1;
            txtDrinkMoney.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo
                ) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void rdoFullDay_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = "200";
        }

        private void rdoHalfDay_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = "100";
        }

        private void cbDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNumerous.SelectedIndex != -1)
                calculateDrinkPrice();
        }

        private void cbNumerous_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDrink.SelectedIndex != -1)
                calculateDrinkPrice();
        }

        private void calculateDrinkPrice()
        {
            txtDrinkMoney.Text = ((cbDrink.SelectedItem as Drink).Price * (cbNumerous.SelectedIndex + 1)).ToString();
        }
    }
}
