using System;
using System.Linq;
using System.Windows.Forms;

namespace Ex8
{
    public partial class Form1 : Form
    {
        private static string messageBoxTitle = "Thông báo";

        private static string[] foods =
        {
            "Cơm",
            "Cá",
            "Thịt kho",
            "Cháo",
            "Mỳ"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clbFood.ColumnWidth = clbFood.Width / 2;
            foreach (string food in foods)
            {
                clbFood.Items.Add(food);
            }
        }

        private void clbFood_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Bạn vừa thêm món: " + clbFood.SelectedItem, messageBoxTitle);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string selectedFoods = String.Join(", ", clbFood.CheckedItems.Cast<string>());
            string message = "Bạn đã chọn các món sau: " + selectedFoods;
            MessageBox.Show(message, messageBoxTitle);
        }
    }
}
