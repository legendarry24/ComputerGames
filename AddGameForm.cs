using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGames
{
    public partial class AddGameForm : Form
    {
        public AddGameForm()
        {
            InitializeComponent();
        }
        private void AddGameForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDBDataSet.Stylistics". При необходимости она может быть перемещена или удалена.
            this.stylisticsTableAdapter.Fill(this.computerGamesDBDataSet.Stylistics);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDBDataSet.Genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.computerGamesDBDataSet.Genre);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDBDataSet.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.computerGamesDBDataSet.Publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDBDataSet.Developer". При необходимости она может быть перемещена или удалена.
            this.developerTableAdapter.Fill(this.computerGamesDBDataSet.Developer);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                queriesTableAdapter1.ADDGame(nameTextBox.Text, Convert.ToDateTime(yearMaskedTextBox.Text),
                              Convert.ToByte(ratingTextBox.Text), Convert.ToDecimal(priceTextBox.Text), multiplayerCheckBox.Checked, cybersportCheckBox.Checked,
                              Convert.ToBoolean(1), developerComboBox.Text, publisherComboBox.Text, genreComboBox.Text, stylisticsComboBox.Text);
                nameTextBox.Clear();
                yearMaskedTextBox.Clear();
                ratingTextBox.Clear();
                priceTextBox.Clear();
                multiplayerCheckBox.Checked = false;
                cybersportCheckBox.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
