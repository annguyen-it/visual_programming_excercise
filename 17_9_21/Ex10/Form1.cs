using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10
{
    public partial class QuizForm : Form
    {
        private readonly Dictionary<string, string> dictionary = new Dictionary<string, string>();
        RadioButton checkedCountryRadio;

        public QuizForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tuple<List<string>, List<string>> data = LoadData();

            LoadCountryRadios(data.Item1);
            LoadCapitalRadios(data.Item2);

            MoveExitButton();
            MoveHintLabel();

            Size = new Size(Size.Width, btnExit.Location.Y + btnExit.Size.Height + 50);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Tuple<List<string>, List<string>> LoadData()
        {
            dictionary.Add("France", "Paris");
            dictionary.Add("Japan", "Tokyo");
            dictionary.Add("Hungary", "Budapest");
            dictionary.Add("Spain", "Madrid");
            dictionary.Add("Turkey", "Ankara");
            dictionary.Add("The UK", "London");
            dictionary.Add("Italy", "Rome");
            dictionary.Add("Argentina", "Buenos Aires");
            dictionary.Add("The US", "Washington");

            List<string> countries = new List<string>();
            List<string> capitals = new List<string>();

            foreach (var item in dictionary)
            {
                countries.Add(item.Key);
                capitals.Add(item.Value);
            }

            countries.Sort();
            capitals.Sort();

            return Tuple.Create(countries, capitals);
        }

        private void LoadCountryRadios(List<string> countries)
        {
            int index = 0;
            foreach (string country in countries)
            {
                int y = grbCountry.Location.Y + 25 * index++ - 5;

                RadioButton rb = new RadioButton
                {
                    Text = country,
                    Location = new Point(20, y)
                };

                rb.Click += new EventHandler((object sender, EventArgs e) =>
                {
                    lblHint.Text = "Bạn hãy chọn thủ đô cho " + country;
                    grbCapital.Enabled = true;
                    checkedCountryRadio = rb;
                });

                grbCountry.Controls.Add(rb);
            }

            grbCountry.Size = new Size(grbCountry.Size.Width, grbCountry.Location.Y + 20 * index + 45);
        }

        private void LoadCapitalRadios(List<string> capitals)
        {
            int index = 0;
            foreach (string capital in capitals)
            {
                int y = grbCapital.Location.Y + 25 * index++ - 5;

                RadioButton rb = new RadioButton
                {
                    Text = capital,
                    Location = new Point(20, y)
                };

                rb.Click += new EventHandler((object sender, EventArgs e) =>
                {
                    string checkedCountry = checkedCountryRadio.Text;
                    if (dictionary[checkedCountry].Equals(capital))
                        MessageBox.Show(String.Format("Chúc mừng bạn, thủ đô của {0} là {1}", checkedCountry, capital));

                    else
                        MessageBox.Show(String.Format("Bạn sai rồi, thủ đô của {0} không phải là {1}", checkedCountry, capital));
                });

                grbCapital.Controls.Add(rb);
            }

            grbCapital.Size = new Size(grbCapital.Size.Width, grbCapital.Location.Y + 20 * index + 45);
            grbCapital.Enabled = false;
        }

        private void MoveExitButton()
        {
            btnExit.Location = new Point(
                btnExit.Location.X,
                Math.Max(grbCountry.Size.Height, grbCapital.Size.Height)
                    + grbCountry.Location.Y
                    + 20);
        }

        private void MoveHintLabel()
        {
            lblHint.Location = new Point(
                lblHint.Location.X,
                btnExit.Location.Y);
        }
    }
}
