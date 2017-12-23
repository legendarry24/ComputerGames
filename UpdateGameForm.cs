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
    public partial class UpdateGameForm : Form
    {
        public UpdateGameForm()
        {
            InitializeComponent();
        }

        private void UpdateGameForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDBDataSet.Stylistics". При необходимости она может быть перемещена или удалена.
            this.stylisticsTableAdapter.Fill(this.computerGamesDBDataSet.Stylistics);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDBDataSet.Genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.computerGamesDBDataSet.Genre);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDBDataSet.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.computerGamesDBDataSet.Publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDBDataSet.Developer". При необходимости она может быть перемещена или удалена.
            this.developerTableAdapter.Fill(this.computerGamesDBDataSet.Developer);
            nameTextBox.Text = Data.StrValue[0];
            newNameTextBox.Text = Data.StrValue[0];
            yearMaskedTextBox.Text = Data.StrValue[3];
            ratingTextBox.Text = Data.StrValue[6];
            priceTextBox.Text = Data.StrValue[7];
            multiplayerCheckBox.Checked = Convert.ToBoolean(Data.StrValue[8])? true : false;
            cybersportCheckBox.Checked = Convert.ToBoolean(Data.StrValue[9])? true : false;
            developerComboBox.Text = Data.StrValue[1];
            publisherComboBox.Text = Data.StrValue[2];
            genreComboBox.Text = Data.StrValue[4];
            stylisticsComboBox.Text = Data.StrValue[5];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                queriesTableAdapter1.UpdateGame(nameTextBox.Text, newNameTextBox.Text, Convert.ToDateTime(yearMaskedTextBox.Text),
                              Convert.ToByte(ratingTextBox.Text), Convert.ToDecimal(priceTextBox.Text), multiplayerCheckBox.Checked, cybersportCheckBox.Checked,
                              Convert.ToBoolean(1), developerComboBox.Text, publisherComboBox.Text, genreComboBox.Text, stylisticsComboBox.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
