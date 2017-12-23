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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        private void DeleteForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Data.StrValue[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(Data.TableName)
            {
                case TableName.Game:
                    queriesTableAdapter1.DeleteLastGame(textBox1.Text);
                    textBox1.Clear();
                    break;
                case TableName.Developer:
                    queriesTableAdapter1.DeleteLastDev(textBox1.Text);
                    textBox1.Clear();
                    break;
                case TableName.Publisher:
                    queriesTableAdapter1.DeleteLastPub(textBox1.Text);
                    textBox1.Clear();
                    break;
                case TableName.Genre:
                    queriesTableAdapter1.DeleteLastGenre(textBox1.Text);
                    textBox1.Clear();
                    break;
                case TableName.Stylistics:
                    queriesTableAdapter1.DeleteLastStylistics(textBox1.Text);
                    textBox1.Clear();
                    break;
            }
            this.Close();            
        }
    }
}
