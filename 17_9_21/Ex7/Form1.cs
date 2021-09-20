using System;
using System.Windows.Forms;

namespace Ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] directories = System.IO.Directory.GetDirectories("C:\\");
            cboDirectory.DataSource = directories;
        }
    }
}
