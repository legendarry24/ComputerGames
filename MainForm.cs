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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void наВесьЭкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Computer Games App\nВерсия 1.3.3.7 Limited edition\nНезависимый разработчик Legendarry, 2017\nВсе права защищены.", "О программе Computer Games App");
        }
        private void техническаяПоддержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По всем вопросам и предложениям звоните по телефону 8 800 555 35 35");
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.gameRequirementsTableAdapter.Fill(this.computerGamesDBDataSet.GameRequirements);
            this.developerTableAdapter.Fill(this.computerGamesDBDataSet.Developer);
            this.publisherTableAdapter.Fill(this.computerGamesDBDataSet.Publisher);
            this.stylisticsTableAdapter.Fill(this.computerGamesDBDataSet.Stylistics);
            this.genreTableAdapter.Fill(this.computerGamesDBDataSet.Genre);
            this.searchGameTableAdapter.Fill(this.computerGamesDBDataSet.SearchGame);
            this.searchGameByPlatformTableAdapter.Fill(this.computerGamesDBDataSet.SearchGameByPlatform, "%", "%");        
            nameTextBox.Text = "Поиск по названию"; // подсказка
            nameTextBox.ForeColor = Color.Gray;
            developerTextBox.Text = "Поиск по разработчику";
            developerTextBox.ForeColor = Color.Gray;
            publisherTextBox.Text = "Поиск по издателю";
            publisherTextBox.ForeColor = Color.Gray;
            genreTextBox.Text = "Поиск по жанру";
            genreTextBox.ForeColor = Color.Gray;
            StylisticsTextBox.Text = "Поиск по стилистике";
            StylisticsTextBox.ForeColor = Color.Gray;
        }
        private void DeleteGenre_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Genre;
                DeleteForm newForm = new DeleteForm();
                newForm.Show();
            }
            else
            {
                queriesTableAdapter.DeleteLastGenre(null);
                this.genreTableAdapter.Fill(this.computerGamesDBDataSet.Genre);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data.StrValue[0] = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            Data.StrValue[1] = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
        }

        private void UpdateGenre_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Genre;
                UpdateGenreOrStForm newForm = new UpdateGenreOrStForm();
                newForm.Show();
            }
            else this.genreTableAdapter.Fill(this.computerGamesDBDataSet.Genre);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data.StrValue[0] = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
            Data.StrValue[1] = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
        }

        private void UpdateStylistics_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Stylistics;
                UpdateGenreOrStForm newForm = new UpdateGenreOrStForm();
                newForm.Show();
            }
            else this.stylisticsTableAdapter.Fill(this.computerGamesDBDataSet.Stylistics);
        }

        private void DeleteStylistics_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Stylistics;
                DeleteForm newForm = new DeleteForm();
                newForm.Show();
            }
            else
            {
                queriesTableAdapter.DeleteLastStylistics(null);
                this.stylisticsTableAdapter.Fill(this.computerGamesDBDataSet.Stylistics);
            }
        }

        private void AddGenre_Click(object sender, EventArgs e)
        {
            Data.TableName = TableName.Genre;
            AddGenreOrStForm f = new AddGenreOrStForm();
            f.Show();
        }
        private void AddStylistics_Click(object sender, EventArgs e)
        {
            Data.TableName = TableName.Stylistics;
            AddGenreOrStForm f = new AddGenreOrStForm();
            f.Show();
        }

        private void publisherDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data.StrValue[0] = Convert.ToString(publisherDataGridView.CurrentRow.Cells[0].Value);
            Data.StrValue[1] = Convert.ToString(publisherDataGridView.CurrentRow.Cells[1].Value);
            Data.StrValue[2] = Convert.ToString(publisherDataGridView.CurrentRow.Cells[2].Value);
            Data.StrValue[3] = Convert.ToString(publisherDataGridView.CurrentRow.Cells[3].Value);
            Data.StrValue[4] = Convert.ToString(publisherDataGridView.CurrentRow.Cells[4].Value);
            Data.StrValue[5] = Convert.ToString(publisherDataGridView.CurrentRow.Cells[5].Value);
        }

        private void DeletePublisher_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Publisher;
                DeleteForm newForm = new DeleteForm();
                newForm.Show();
            }
            else
            {
                queriesTableAdapter.DeleteLastPub(null);
                this.publisherTableAdapter.Fill(this.computerGamesDBDataSet.Publisher);
            }
        }

        private void AddPublisher_Click(object sender, EventArgs e)
        {
            Data.TableName = TableName.Publisher;
            AddDevOrPubForm f = new AddDevOrPubForm();
            f.Show();
        }

        private void UpdatePublisher_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Publisher;
                UpdateDevOrPubForm newForm = new UpdateDevOrPubForm();
                newForm.Show();
            }
            else this.publisherTableAdapter.Fill(this.computerGamesDBDataSet.Publisher);
        }
        private void AddDeveloper_Click(object sender, EventArgs e)
        {
            Data.TableName = TableName.Developer;
            AddDevOrPubForm f = new AddDevOrPubForm();
            f.Show();
        }

        private void UpdateDeveloper_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Developer;
                UpdateDevOrPubForm newForm = new UpdateDevOrPubForm();
                newForm.Show();
            }
            else this.developerTableAdapter.Fill(this.computerGamesDBDataSet.Developer);
        }

        private void DeveloperDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data.StrValue[0] = Convert.ToString(DeveloperDataGridView.CurrentRow.Cells[0].Value);
            Data.StrValue[1] = Convert.ToString(DeveloperDataGridView.CurrentRow.Cells[1].Value);
            Data.StrValue[2] = Convert.ToString(DeveloperDataGridView.CurrentRow.Cells[2].Value);
            Data.StrValue[3] = Convert.ToString(DeveloperDataGridView.CurrentRow.Cells[3].Value);
            Data.StrValue[4] = Convert.ToString(DeveloperDataGridView.CurrentRow.Cells[4].Value);
            Data.StrValue[5] = Convert.ToString(DeveloperDataGridView.CurrentRow.Cells[5].Value);
        }

        private void DeleteDeveloper_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Developer;
                DeleteForm newForm = new DeleteForm();
                newForm.Show();
            }
            else
            {
                queriesTableAdapter.DeleteLastDev(null);
                this.developerTableAdapter.Fill(this.computerGamesDBDataSet.Developer);
            }
        }

        private void searchGameDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {     
            this.gameRequirementsTableAdapter.FillByName(this.computerGamesDBDataSet.GameRequirements, Convert.ToString(searchGameDataGridView.CurrentRow.Cells[0].Value));
            this.searchGameByPlatformTableAdapter.Fill(this.computerGamesDBDataSet.SearchGameByPlatform, "%", Convert.ToString(searchGameDataGridView.CurrentRow.Cells[0].Value));
            Data.StrValue[0] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[0].Value);
            Data.StrValue[1] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[1].Value);
            Data.StrValue[2] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[2].Value);
            Data.StrValue[3] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[3].Value);
            Data.StrValue[4] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[4].Value);
            Data.StrValue[5] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[5].Value);
            Data.StrValue[6] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[6].Value);
            Data.StrValue[7] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[7].Value);
            Data.StrValue[8] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[8].Value);
            Data.StrValue[9] = Convert.ToString(searchGameDataGridView.CurrentRow.Cells[9].Value);          
        }

        private void UpdateGame_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Game;
                UpdateGameForm newForm = new UpdateGameForm();
                newForm.Show();
            }
            else this.searchGameTableAdapter.Fill(this.computerGamesDBDataSet.SearchGame);
        }

        private void DeleteGame_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                Data.TableName = TableName.Game;
                DeleteForm newForm = new DeleteForm();
                newForm.Show();
            }
            else
            {
                queriesTableAdapter.DeleteLastGame(null);
                this.searchGameTableAdapter.Fill(this.computerGamesDBDataSet.SearchGame);
            }
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            Data.TableName = TableName.Game;
            AddGameForm f = new AddGameForm();
            f.Show();
        }

        private void consoleButton_Click(object sender, EventArgs e)
        {
            this.searchGameByPlatformTableAdapter.Fill(this.computerGamesDBDataSet.SearchGameByPlatform, "Игровая консоль", "%");
        }

        private void windowsButton_Click(object sender, EventArgs e)
        {
            this.searchGameByPlatformTableAdapter.Fill(this.computerGamesDBDataSet.SearchGameByPlatform, "Windows", "%");
        }

        private void androidButton_Click(object sender, EventArgs e)
        {
            this.searchGameByPlatformTableAdapter.Fill(this.computerGamesDBDataSet.SearchGameByPlatform, "Android", "%");
        }

        private void deleteLock_Click(object sender, EventArgs e)
        {       
            var passForm = new PasswordForm();
            passForm.ShowDialog();
            if (Data.CorrectPassword)
            {
                DeleteGame.Enabled = true;
                deleteLock.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.searchGameTableAdapter.FillByFreeToPlay(this.computerGamesDBDataSet.SearchGame);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.searchGameTableAdapter.FillByMultiplayer(this.computerGamesDBDataSet.SearchGame);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.searchGameTableAdapter.FillByCybersport(this.computerGamesDBDataSet.SearchGame);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.searchGameTableAdapter.FillByTOP5(this.computerGamesDBDataSet.SearchGame);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.searchGameTableAdapter.Fill(this.computerGamesDBDataSet.SearchGame);
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            nameTextBox.Text = null;
            nameTextBox.ForeColor = Color.Black;
        }

        private void developerTextBox_Enter(object sender, EventArgs e)
        {
            developerTextBox.Text = null;
            developerTextBox.ForeColor = Color.Black;
        }

        private void publisherTextBox_Enter(object sender, EventArgs e)
        {
            publisherTextBox.Text = null;
            publisherTextBox.ForeColor = Color.Black;
        }

        private void genreTextBox_Enter(object sender, EventArgs e)
        {
            genreTextBox.Text = null;
            genreTextBox.ForeColor = Color.Black;
        }

        private void StylisticsTextBox_Enter(object sender, EventArgs e)
        {
            StylisticsTextBox.Text = null;
            StylisticsTextBox.ForeColor = Color.Black;
        }

        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = null;
            this.searchGameTableAdapter.FillByAll(this.computerGamesDBDataSet.SearchGame, nameTextBox.Text, developerTextBox.Text,
                publisherTextBox.Text, genreTextBox.Text, StylisticsTextBox.Text);
            nameTextBox.Text = "Поиск по названию";
            nameTextBox.ForeColor = Color.Gray;
        }
       
    }
}
