using System;
using System.Linq;
using System.Windows.Forms;

namespace Ex4
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            ResetMax();
            ResetMin();
        }

        private void TriggerResult(object sender, EventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) &&
                double.TryParse(txtB.Text, out double b))
            {
                RadioButton checkedRadio = grbOperator.Controls
                    .OfType<RadioButton>()
                    .FirstOrDefault(n => n.Checked);

                if (checkedRadio != null)
                {
                    try
                    {
                        double result = Calculate(a, b, checkedRadio.Name);
                        txtResult.Text = result.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mẫu = 0", "Thông báo");
                        checkedRadio.Checked = false;
                    }
                }

                RefreshMax();
                RefreshMin();
            }
            else
            {
                ResetMax();
                ResetMin();
            }
        }

        private double Calculate(double a, double b, string radioName)
        {
            switch (radioName)
            {
                case "rdoAdd":
                    return a + b;

                case "rdoMinus":
                    return a - b;

                case "rdoMultiply":
                    return a * b;

                default:
                    if (b == 0)
                    {
                        throw new Exception();
                    }

                    return a / b;
            }
        }

        private void chkMax_CheckedChanged(object sender, EventArgs e)
        {
            RefreshMax();
        }

        private void chkMin_CheckedChanged(object sender, EventArgs e)
        {
            RefreshMin();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtResult.Text = "";

            grbOperator.Controls
                .OfType<RadioButton>()
                .ToList()
                .ForEach(radio => radio.Checked = false);

            grbCompare.Controls
                .OfType<CheckBox>()
                .ToList()
                .ForEach(radio => radio.Checked = false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshMax()
        {
            if (chkMax.Checked &&
                double.TryParse(txtA.Text, out double a) &&
                double.TryParse(txtB.Text, out double b))
            {
                chkMax.Text = "Max = " + Math.Max(a, b);
            }
            else
            {
                ResetMax();
            }
        }

        private void RefreshMin()
        {
            if (chkMin.Checked &&
                double.TryParse(txtA.Text, out double a) &&
                double.TryParse(txtB.Text, out double b))
            {
                chkMin.Text = "Min = " + Math.Min(a, b);
            }
            else
            {
                ResetMin();
            }
        }

        private void ResetMax()
        {
            chkMax.Text = "Max";
        }

        private void ResetMin()
        {
            chkMin.Text = "Min";
        }
    }
}
