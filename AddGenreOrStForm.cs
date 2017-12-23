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
    public partial class AddGenreOrStForm : Form
    {
        public AddGenreOrStForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Data.TableName)
                {
                    case TableName.Genre:
                        queriesTableAdapter1.ADDGenre(nameTextBox.Text, descriptionTextBox.Text);
                        nameTextBox.Clear();
                        descriptionTextBox.Clear();
                        break;
                    case TableName.Stylistics:
                        queriesTableAdapter1.ADDStylistics(nameTextBox.Text, descriptionTextBox.Text);
                        nameTextBox.Clear();
                        descriptionTextBox.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
