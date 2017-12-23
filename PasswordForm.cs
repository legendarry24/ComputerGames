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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string password = "root";
            if (textBox1.Text == password)
            {
                Data.CorrectPassword = true;
                this.Hide();
            }
            else
            {
                textBox1.Clear();
                label2.Visible = true;
                label2.Text = "Неверный пароль";
            }
        }
    }
}
