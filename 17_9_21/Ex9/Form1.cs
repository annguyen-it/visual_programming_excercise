using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FontFamily_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVnTime.Checked)
                txtText.Font = new Font("VnTime", 15);
            else if (rdoTimesNewRoman.Checked)
                txtText.Font = new Font("Times New Roman", 15);
            else if (rdoTahoma.Checked)
                txtText.Font = new Font("Tahoma", 15);
            else if (rdoArial.Checked)
                txtText.Font = new Font("Arial", 15);
            else
                txtText.Font = new Font("Microsoft Sans Serif", 15);
        }

        private void FontDecoration_CheckedChange(object sender, EventArgs e)
        {
            FontStyle style = new FontStyle();

            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;
            if (chkStrikeout.Checked)
                style |= FontStyle.Strikeout;
            if (chkUnderline.Checked)
                style |= FontStyle.Underline;

            txtText.Font = new Font(txtText.Font, style);
        }

        private void FontColor_CheckedChange(object sender, EventArgs e)
        {
            if (rdoBlue.Checked)
                txtText.ForeColor = Color.Blue;
            else if (rdoRed.Checked)
                txtText.ForeColor = Color.Red;
            else if (rdoGreen.Checked)
                txtText.ForeColor = Color.FromArgb(0, 192, 0);
            else if (rdoPurple.Checked)
                txtText.ForeColor = Color.FromArgb(192, 0, 192);
            else
                txtText.ForeColor = Color.Black;
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            foreach (RadioButton radio in grbFontFamily.Controls)
                radio.Checked = false;

            foreach (CheckBox checkBox in grbTextDecoration.Controls)
                checkBox.Checked = false;

            foreach (RadioButton radio in grbTextColor.Controls)
                radio.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
