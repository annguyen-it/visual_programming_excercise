using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex11
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstItem.DataSource = new List<string> {
                "Algorithms",
                "Clean Code: A Handbool of Agile Software Craftmanship",
                "Lược sử loài người",
                "Lược sử tương lai",
                "21 bài học cho thế kỷ 21",
                "Bố già",
                "Chiến binh cầu vồng",
                "Người gieo hy vọng",
                "Nhà giả kim",
                "Giêt con chim nhại",
                "Thám tử nhí",
                "Vũ trụ quan của Albert Einstein"
            };
        }

        private void lstItem_DoubleClick(object sender, EventArgs e)
        {
            int index = lstItem.IndexFromPoint(((MouseEventArgs)e).Location);
            if (index != ListBox.NoMatches)
            {
                string selectedItem = lstItem.Items[index].ToString();

                if (lstBuy.Items.Contains(selectedItem))
                {
                    MessageBox.Show(
                        String.Format("Bạn đã chọn mua cuốn \"{0}\" rồi!", selectedItem),
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    lstBuy.Items.Add(selectedItem);
                    CheckToggleOrderButton();
                }
            }
        }

        private void lstBuy_DoubleClick(object sender, EventArgs e)
        {
            int index = lstBuy.IndexFromPoint(((MouseEventArgs)e).Location);
            if (index != ListBox.NoMatches)
            {
                string selectedItem = lstBuy.Items[index].ToString();

                if (
                    MessageBox.Show(
                        String.Format("Bạn có muốn xóa \"{0}\" không?", selectedItem),
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    ) == DialogResult.Yes)
                {

                    lstBuy.Items.RemoveAt(index);
                    CheckToggleOrderButton();
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CheckToggleOrderButton();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            CheckToggleOrderButton();
        }

        private void CheckToggleOrderButton()
        {
            if (txtName.Text != "" &&
                txtPhone.Text != "" &&
                lstBuy.Items.Count != 0 &&
                grbPayment.Controls.OfType<RadioButton>().Any(r => r.Checked) &&
                grbContact.Controls.OfType<CheckBox>().Any(c => c.Checked))
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleOrderButton();
        }

        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckToggleOrderButton();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string buyItems = "";
            foreach (var item in lstBuy.Items)
            {
                buyItems += "\n- " + item.ToString();
            }

            string payment = grbPayment.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)
                .Text;

            string contacts = string.Join(
                ", ", grbContact.Controls
                    .OfType<CheckBox>()
                    .Where(c => c.Checked)
                    .Select(c => c.Text));

            MessageBox.Show(
                "Họ tên khách: " + txtName.Text +
                    "\nĐiện thoại: " + txtPhone.Text +
                    "\nDanh sách hàng đặt mua:" +
                    buyItems +
                    "\nPhương thức thanh toán: " + payment +
                    "\nHình thức liên lạc: " + contacts,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
