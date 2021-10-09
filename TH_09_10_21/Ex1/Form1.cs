using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSubject.Items.Add(new Subject("Tin học đại cương", 2));
            cbSubject.Items.Add(new Subject("Giải tích F1", 3));
            cbSubject.Items.Add(new Subject("Tiếng Anh A0", 3));
            cbSubject.Items.Add(new Subject("Triết học Mác - Lênin", 2));
            cbSubject.Items.Add(new Subject("Vật lý F1", 3));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double mark = 0;

            if (txtMark.Text == "")
            {
                MessageBox.Show("Hãy nhập điểm!");
                return;
            }

            if (!double.TryParse(txtMark.Text, out mark))
            {
                MessageBox.Show("Điểm đã nhập không phải số!");
                return;
            }

            lstList.Items.Add(new SubjectResult(cbSubject.SelectedItem as Subject, mark));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (lstList.Items.Count == 0)
            {
                MessageBox.Show("Hãy thêm môn học vào danh sách!");
                return;
            }

            int totalCredits = 0;
            double totalMarks = 0;

            foreach (SubjectResult s in lstList.Items)
            {
                totalCredits += s.Subject.Credit;
                totalMarks += s.Mark * s.Subject.Credit;
            }

            txtTotalCredit.Text = totalCredits.ToString();
            txtTotalMark.Text = totalMarks.ToString();
            textBox5.Text = (totalMarks / totalCredits).ToString();
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

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCredit.Text = (cbSubject.SelectedItem as Subject).Credit.ToString();
        }
    }
}
