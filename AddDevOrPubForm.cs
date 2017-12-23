using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ComputerGames
{
    public partial class AddDevOrPubForm : Form
    {
        public AddDevOrPubForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Data.TableName)
                {
                    case TableName.Publisher:
                        queriesTableAdapter1.ADDPublisher(nameTextBox.Text, officialSiteTextBox.Text,
                           Convert.ToDateTime(yearMaskedTextBox.Text), countryTextBox.Text,
                           cityTextBox.Text, stateTextBox.Text);
                        nameTextBox.Clear();
                        officialSiteTextBox.Clear();
                        countryTextBox.Clear();
                        cityTextBox.Clear();
                        stateTextBox.Clear();
                        break;
                    case TableName.Developer:
                        queriesTableAdapter1.ADDDeveloper(nameTextBox.Text, officialSiteTextBox.Text,
                           Convert.ToDateTime(yearMaskedTextBox.Text), countryTextBox.Text,
                           cityTextBox.Text, stateTextBox.Text);
                        nameTextBox.Clear();
                        officialSiteTextBox.Clear();
                        countryTextBox.Clear();
                        cityTextBox.Clear();
                        stateTextBox.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }

        private void officialSiteTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex reg1 = new Regex(@"^(((ht|f)tp(s?))\://)?(www.|[a-zA-Z].)[a-zA-Z0-9\-\.]+\.(com|edu|gov|mil|net|org|ru|jp|biz|info|name|museum|us|ca|uk)(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\;\?\'\\\+&amp;%\$#\=~_\-]+))*$");

            if (reg1.IsMatch(officialSiteTextBox.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
