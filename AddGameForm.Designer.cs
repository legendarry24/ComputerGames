using System;

namespace ComputerGames
{
    partial class AddGameForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label multiplayerLabel;
            System.Windows.Forms.Label cybersportLabel;
            System.Windows.Forms.Label developerIDLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label stylisticsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGameForm));
            this.button1 = new System.Windows.Forms.Button();
            this.stylisticsComboBox = new System.Windows.Forms.ComboBox();
            this.stylisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerGamesDBDataSet = new ComputerGames.ComputerGamesDBDataSet();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherComboBox = new System.Windows.Forms.ComboBox();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.multiplayerCheckBox = new System.Windows.Forms.CheckBox();
            this.cybersportCheckBox = new System.Windows.Forms.CheckBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.queriesTableAdapter1 = new ComputerGames.ComputerGamesDBDataSetTableAdapters.QueriesTableAdapter();
            this.developerComboBox = new System.Windows.Forms.ComboBox();
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.DeveloperTableAdapter();
            this.publisherTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.PublisherTableAdapter();
            this.genreTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.GenreTableAdapter();
            this.stylisticsTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.StylisticsTableAdapter();
            this.supportedPlatformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supportedPlatformTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.SupportedPlatformTableAdapter();
            label1 = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            multiplayerLabel = new System.Windows.Forms.Label();
            cybersportLabel = new System.Windows.Forms.Label();
            developerIDLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            stylisticsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stylisticsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportedPlatformBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(49, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 49;
            label1.Text = "Name:";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(49, 206);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(75, 13);
            releaseDateLabel.TabIndex = 35;
            releaseDateLabel.Text = "Release Date:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(49, 231);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 36;
            ratingLabel.Text = "Rating:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(49, 257);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 38;
            priceLabel.Text = "Price:";
            // 
            // multiplayerLabel
            // 
            multiplayerLabel.AutoSize = true;
            multiplayerLabel.Location = new System.Drawing.Point(49, 285);
            multiplayerLabel.Name = "multiplayerLabel";
            multiplayerLabel.Size = new System.Drawing.Size(60, 13);
            multiplayerLabel.TabIndex = 39;
            multiplayerLabel.Text = "Multiplayer:";
            // 
            // cybersportLabel
            // 
            cybersportLabel.AutoSize = true;
            cybersportLabel.Location = new System.Drawing.Point(49, 315);
            cybersportLabel.Name = "cybersportLabel";
            cybersportLabel.Size = new System.Drawing.Size(60, 13);
            cybersportLabel.TabIndex = 41;
            cybersportLabel.Text = "Cybersport:";
            // 
            // developerIDLabel
            // 
            developerIDLabel.AutoSize = true;
            developerIDLabel.Location = new System.Drawing.Point(49, 95);
            developerIDLabel.Name = "developerIDLabel";
            developerIDLabel.Size = new System.Drawing.Size(62, 13);
            developerIDLabel.TabIndex = 45;
            developerIDLabel.Text = "Developer :";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(49, 121);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(56, 13);
            publisherLabel.TabIndex = 46;
            publisherLabel.Text = "Publisher :";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(49, 147);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(42, 13);
            genreLabel.TabIndex = 47;
            genreLabel.Text = "Genre :";
            // 
            // stylisticsLabel
            // 
            stylisticsLabel.AutoSize = true;
            stylisticsLabel.Location = new System.Drawing.Point(49, 173);
            stylisticsLabel.Name = "stylisticsLabel";
            stylisticsLabel.Size = new System.Drawing.Size(53, 13);
            stylisticsLabel.TabIndex = 48;
            stylisticsLabel.Text = "Stylistics :";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(163, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 58);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stylisticsComboBox
            // 
            this.stylisticsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stylisticsBindingSource, "Name", true));
            this.stylisticsComboBox.DataSource = this.stylisticsBindingSource;
            this.stylisticsComboBox.DisplayMember = "Name";
            this.stylisticsComboBox.FormattingEnabled = true;
            this.stylisticsComboBox.Location = new System.Drawing.Point(130, 175);
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
            // computerGamesDBDataSet
            // 
            this.computerGamesDBDataSet.DataSetName = "ComputerGamesDBDataSet";
            this.computerGamesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genreComboBox
            // 
            this.genreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genreBindingSource, "Name", true));
            this.genreComboBox.DataSource = this.genreBindingSource;
            this.genreComboBox.DisplayMember = "Name";
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(130, 148);
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
            // publisherComboBox
            // 
            this.publisherComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.publisherBindingSource, "Name", true));
            this.publisherComboBox.DataSource = this.publisherBindingSource;
            this.publisherComboBox.DisplayMember = "Name";
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Location = new System.Drawing.Point(130, 121);
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
            // yearMaskedTextBox
            // 
            this.yearMaskedTextBox.Location = new System.Drawing.Point(130, 202);
            this.yearMaskedTextBox.Mask = "00/00/0000";
            this.yearMaskedTextBox.Name = "yearMaskedTextBox";
            this.yearMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.yearMaskedTextBox.TabIndex = 6;
            this.yearMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.Location = new System.Drawing.Point(130, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(130, 228);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(200, 20);
            this.ratingTextBox.TabIndex = 7;
            // 
            // multiplayerCheckBox
            // 
            this.multiplayerCheckBox.Location = new System.Drawing.Point(130, 280);
            this.multiplayerCheckBox.Name = "multiplayerCheckBox";
            this.multiplayerCheckBox.Size = new System.Drawing.Size(200, 24);
            this.multiplayerCheckBox.TabIndex = 9;
            this.multiplayerCheckBox.Text = "Yes / No";
            this.multiplayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // cybersportCheckBox
            // 
            this.cybersportCheckBox.Location = new System.Drawing.Point(130, 310);
            this.cybersportCheckBox.Name = "cybersportCheckBox";
            this.cybersportCheckBox.Size = new System.Drawing.Size(200, 24);
            this.cybersportCheckBox.TabIndex = 10;
            this.cybersportCheckBox.Text = "Yes / No";
            this.cybersportCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(130, 254);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // developerComboBox
            // 
            this.developerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.developerBindingSource, "Name", true));
            this.developerComboBox.DataSource = this.developerBindingSource;
            this.developerComboBox.DisplayMember = "Name";
            this.developerComboBox.FormattingEnabled = true;
            this.developerComboBox.Location = new System.Drawing.Point(130, 95);
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
            // supportedPlatformBindingSource
            // 
            this.supportedPlatformBindingSource.DataMember = "SupportedPlatform";
            this.supportedPlatformBindingSource.DataSource = this.computerGamesDBDataSet;
            // 
            // supportedPlatformTableAdapter
            // 
            this.supportedPlatformTableAdapter.ClearBeforeFill = true;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 454);
            this.Controls.Add(this.developerComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.stylisticsComboBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.publisherComboBox);
            this.Controls.Add(this.yearMaskedTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.nameTextBox);
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
            this.Controls.Add(this.button1);
            this.Name = "AddGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGameForm";
            this.Load += new System.EventHandler(this.AddGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stylisticsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportedPlatformBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox stylisticsComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox publisherComboBox;
        private System.Windows.Forms.MaskedTextBox yearMaskedTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.CheckBox multiplayerCheckBox;
        private System.Windows.Forms.CheckBox cybersportCheckBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private ComputerGamesDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.ComboBox developerComboBox;
        private ComputerGamesDBDataSet computerGamesDBDataSet;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private ComputerGamesDBDataSetTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private ComputerGamesDBDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private ComputerGamesDBDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource stylisticsBindingSource;
        private ComputerGamesDBDataSetTableAdapters.StylisticsTableAdapter stylisticsTableAdapter;
        private System.Windows.Forms.BindingSource supportedPlatformBindingSource;
        private ComputerGamesDBDataSetTableAdapters.SupportedPlatformTableAdapter supportedPlatformTableAdapter;
    }
}