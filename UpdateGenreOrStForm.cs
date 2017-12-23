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
    public partial class UpdateGenreOrStForm : Form
    {
        public UpdateGenreOrStForm()
        {
            InitializeComponent();
        }

        private void UpdateGenreOrStForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = Data.StrValue[0];
            newNameTextBox.Text = Data.StrValue[0];
            descriptionTextBox.Text = Data.StrValue[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Data.TableName)
                {
                    case TableName.Genre:
                        queriesTableAdapter1.UpdateGenre(nameTextBox.Text, newNameTextBox.Text, descriptionTextBox.Text);
                        this.Close();
                        break;
                    case TableName.Stylistics:
                        queriesTableAdapter1.UpdateStylistics(nameTextBox.Text, newNameTextBox.Text, descriptionTextBox.Text);
                        this.Close();
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
