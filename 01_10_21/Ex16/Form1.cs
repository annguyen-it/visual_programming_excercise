using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex16
{
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*",
                InitialDirectory = "C:\\",
                Title = "Chọn ảnh để hiển thị"
            };

            if (dlgOpen.ShowDialog() == DialogResult.OK)
                picPicture.Image = Image.FromFile(dlgOpen.FileName);
            else
                MessageBox.Show(
                    "You clicked Cancel",
                    "Open Dialog",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }
    }
}
