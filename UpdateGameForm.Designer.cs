namespace ComputerGames
{
    partial class UpdateGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label newNameLabel;
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label multiplayerLabel;
            System.Windows.Forms.Label cybersportLabel;
            System.Windows.Forms.Label developerIDLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label stylisticsLabel;
            System.Windows.Forms.Label label1;
            this.computerGamesDBDataSet = new ComputerGames.ComputerGamesDBDataSet();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.GameTableAdapter();
            this.tableAdapterManager = new ComputerGames.ComputerGamesDBDataSetTableAdapters.TableAdapterManager();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.multiplayerCheckBox = new System.Windows.Forms.CheckBox();
            this.cybersportCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.yearMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.developerComboBox = new System.Windows.Forms.ComboBox();
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherComboBox = new System.Windows.Forms.ComboBox();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stylisticsComboBox = new System.Windows.Forms.ComboBox();
            this.stylisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.DeveloperTableAdapter();
            this.publisherTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.PublisherTableAdapter();
            this.genreTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.GenreTableAdapter();
            this.stylisticsTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.StylisticsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.queriesTableAdapter1 = new ComputerGames.ComputerGamesDBDataSetTableAdapters.QueriesTableAdapter();
            newNameLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            multiplayerLabel = new System.Windows.Forms.Label();
            cybersportLabel = new System.Windows.Forms.Label();
            developerIDLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            stylisticsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylisticsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newNameLabel
            // 
            newNameLabel.AutoSize = true;
            newNameLabel.Location = new System.Drawing.Point(41, 79);
            newNameLabel.Name = "newNameLabel";
            newNameLabel.Size = new System.Drawing.Size(60, 13);
            newNameLabel.TabIndex = 3;
            newNameLabel.Text = "NewName:";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(41, 216);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(75, 13);
            releaseDateLabel.TabIndex = 5;
            releaseDateLabel.Text = "Release Date:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(41, 241);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 7;
            ratingLabel.Text = "Rating:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(41, 267);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price:";
            // 
            // multiplayerLabel
            // 
            multiplayerLabel.AutoSize = true;
            multiplayerLabel.Location = new System.Drawing.Point(41, 295);
            multiplayerLabel.Name = "multiplayerLabel";
            multiplayerLabel.Size = new System.Drawing.Size(60, 13);
            multiplayerLabel.TabIndex = 11;
            multiplayerLabel.Text = "Multiplayer:";
            // 
            // cybersportLabel
            // 
            cybersportLabel.AutoSize = true;
            cybersportLabel.Location = new System.Drawing.Point(41, 325);
            cybersportLabel.Name = "cybersportLabel";
            cybersportLabel.Size = new System.Drawing.Size(60, 13);
            cybersportLabel.TabIndex = 13;
            cybersportLabel.Text = "Cybersport:";
            // 
            // developerIDLabel
            // 
            developerIDLabel.AutoSize = true;
            developerIDLabel.Location = new System.Drawing.Point(41, 105);
            developerIDLabel.Name = "developerIDLabel";
            developerIDLabel.Size = new System.Drawing.Size(62, 13);
            developerIDLabel.TabIndex = 17;
            developerIDLabel.Text = "Developer :";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(41, 131);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(56, 13);
            publisherLabel.TabIndex = 19;
            publisherLabel.Text = "Publisher :";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(41, 157);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(42, 13);
            genreLabel.TabIndex = 21;
            genreLabel.Text = "Genre :";
            // 
            // stylisticsLabel
            // 
            stylisticsLabel.AutoSize = true;
            stylisticsLabel.Location = new System.Drawing.Point(41, 183);
            stylisticsLabel.Name = "stylisticsLabel";
            stylisticsLabel.Size = new System.Drawing.Size(53, 13);
            stylisticsLabel.TabIndex = 23;
            stylisticsLabel.Text = "Stylistics :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(41, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 25;
            label1.Text = "Name:";
            // 
            // computerGamesDBDataSet
            // 
            this.computerGamesDBDataSet.DataSetName = "ComputerGamesDBDataSet";
            this.computerGamesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.computerGamesDBDataSet;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeveloperTableAdapter = null;
            this.tableAdapterManager.GameTableAdapter = this.gameTableAdapter;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.PlatformTableAdapter = null;
            this.tableAdapterManager.PublisherTableAdapter = null;
            this.tableAdapterManager.StylisticsTableAdapter = null;
            this.tableAdapterManager.SupportedPlatformTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComputerGames.ComputerGamesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "Name", true));
            this.newNameTextBox.Location = new System.Drawing.Point(122, 76);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.newNameTextBox.TabIndex = 1;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(122, 238);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(200, 20);
            this.ratingTextBox.TabIndex = 7;
            // 
            // multiplayerCheckBox
            // 
            this.multiplayerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gameBindingSource, "Multiplayer", true));
            this.multiplayerCheckBox.Location = new System.Drawing.Point(122, 290);
            this.multiplayerCheckBox.Name = "multiplayerCheckBox";
            this.multiplayerCheckBox.Size = new System.Drawing.Size(200, 24);
            this.multiplayerCheckBox.TabIndex = 9;
            this.multiplayerCheckBox.Text = "Yes / No";
            this.multiplayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // cybersportCheckBox
            // 
            this.cybersportCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gameBindingSource, "Cybersport", true));
            this.cybersportCheckBox.Location = new System.Drawing.Point(122, 320);
            this.cybersportCheckBox.Name = "cybersportCheckBox";
            this.cybersportCheckBox.Size = new System.Drawing.Size(200, 24);
            this.cybersportCheckBox.TabIndex = 10;
            this.cybersportCheckBox.Text = "Yes / No";
            this.cybersportCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(122, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 26;
            this.nameTextBox.TabStop = false;
            // 
            // yearMaskedTextBox
            // 
            this.yearMaskedTextBox.Location = new System.Drawing.Point(122, 212);
            this.yearMaskedTextBox.Mask = "00/00/0000";
            this.yearMaskedTextBox.Name = "yearMaskedTextBox";
            this.yearMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.yearMaskedTextBox.TabIndex = 6;
            this.yearMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // developerComboBox
            // 
            this.developerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.developerBindingSource, "Name", true));
            this.developerComboBox.DataSource = this.developerBindingSource;
            this.developerComboBox.DisplayMember = "Name";
            this.developerComboBox.FormattingEnabled = true;
            this.developerComboBox.Location = new System.Drawing.Point(122, 103);
            this.developerComboBox.Name = "developerComboBox";
            this.developerComboBox.Size = new System.Drawing.Size(200, 21);
            this.developerComboBox.TabIndex = 2;
            this.developerComboBox.ValueMember = "Name";
            // 
            // developerBindingSource
            // 
            this.developerBindingSource.DataMember = "Developer";
            this.developerBindingSource.DataSource = this.computerGamesDBDataSet;
            // 
            // publisherComboBox
            // 
            this.publisherComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.publisherBindingSource, "Name", true));
            this.publisherComboBox.DataSource = this.publisherBindingSource;
            this.publisherComboBox.DisplayMember = "Name";
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Location = new System.Drawing.Point(122, 131);
            this.publisherComboBox.Name = "publisherComboBox";
            this.publisherComboBox.Size = new System.Drawing.Size(200, 21);
            this.publisherComboBox.TabIndex = 3;
            this.publisherComboBox.ValueMember = "Name";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.computerGamesDBDataSet;
            // 
            // genreComboBox
            // 
            this.genreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genreBindingSource, "Name", true));
            this.genreComboBox.DataSource = this.genreBindingSource;
            this.genreComboBox.DisplayMember = "Name";
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(122, 158);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(200, 21);
            this.genreComboBox.TabIndex = 4;
            this.genreComboBox.ValueMember = "Name";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this.computerGamesDBDataSet;
            // 
            // stylisticsComboBox
            // 
            this.stylisticsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stylisticsBindingSource, "Name", true));
            this.stylisticsComboBox.DataSource = this.stylisticsBindingSource;
            this.stylisticsComboBox.DisplayMember = "Name";
            this.stylisticsComboBox.FormattingEnabled = true;
            this.stylisticsComboBox.Location = new System.Drawing.Point(122, 185);
            this.stylisticsComboBox.Name = "stylisticsComboBox";
            this.stylisticsComboBox.Size = new System.Drawing.Size(200, 21);
            this.stylisticsComboBox.TabIndex = 5;
            this.stylisticsComboBox.ValueMember = "Name";
            // 
            // stylisticsBindingSource
            // 
            this.stylisticsBindingSource.DataMember = "Stylistics";
            this.stylisticsBindingSource.DataSource = this.computerGamesDBDataSet;
            // 
            // developerTableAdapter
            // 
            this.developerTableAdapter.ClearBeforeFill = true;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // stylisticsTableAdapter
            // 
            this.stylisticsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Image = global::ComputerGames.Properties.Resources.Update_Button_2;
            this.button1.Location = new System.Drawing.Point(155, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 67);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "Rating", true));
            this.priceTextBox.Location = new System.Drawing.Point(122, 264);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // UpdateGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 455);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stylisticsComboBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.publisherComboBox);
            this.Controls.Add(this.developerComboBox);
            this.Controls.Add(this.yearMaskedTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(newNameLabel);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(multiplayerLabel);
            this.Controls.Add(this.multiplayerCheckBox);
            this.Controls.Add(cybersportLabel);
            this.Controls.Add(this.cybersportCheckBox);
            this.Controls.Add(developerIDLabel);
            this.Controls.Add(publisherLabel);
            this.Controls.Add(genreLabel);
            this.Controls.Add(stylisticsLabel);
            this.Name = "UpdateGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateGameForm";
            this.Load += new System.EventHandler(this.UpdateGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylisticsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComputerGamesDBDataSet computerGamesDBDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private ComputerGamesDBDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private ComputerGamesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.CheckBox multiplayerCheckBox;
        private System.Windows.Forms.CheckBox cybersportCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox yearMaskedTextBox;
        private System.Windows.Forms.ComboBox developerComboBox;
        private System.Windows.Forms.ComboBox publisherComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox stylisticsComboBox;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private ComputerGamesDBDataSetTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private ComputerGamesDBDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private ComputerGamesDBDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource stylisticsBindingSource;
        private ComputerGamesDBDataSetTableAdapters.StylisticsTableAdapter stylisticsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox priceTextBox;
        private ComputerGamesDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}