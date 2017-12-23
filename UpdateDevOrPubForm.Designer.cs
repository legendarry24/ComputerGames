namespace ComputerGames
{
    partial class UpdateDevOrPubForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label officialSiteLabel;
            System.Windows.Forms.Label foundationYearLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label label1;
            this.computerGamesDBDataSet = new ComputerGames.ComputerGamesDBDataSet();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.PublisherTableAdapter();
            this.tableAdapterManager = new ComputerGames.ComputerGamesDBDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.officialSiteTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.yearMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new ComputerGames.ComputerGamesDBDataSetTableAdapters.QueriesTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            officialSiteLabel = new System.Windows.Forms.Label();
            foundationYearLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(41, 62);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // officialSiteLabel
            // 
            officialSiteLabel.AutoSize = true;
            officialSiteLabel.Location = new System.Drawing.Point(41, 114);
            officialSiteLabel.Name = "officialSiteLabel";
            officialSiteLabel.Size = new System.Drawing.Size(63, 13);
            officialSiteLabel.TabIndex = 5;
            officialSiteLabel.Text = "Official Site:";
            // 
            // foundationYearLabel
            // 
            foundationYearLabel.AutoSize = true;
            foundationYearLabel.Location = new System.Drawing.Point(41, 141);
            foundationYearLabel.Name = "foundationYearLabel";
            foundationYearLabel.Size = new System.Drawing.Size(88, 13);
            foundationYearLabel.TabIndex = 7;
            foundationYearLabel.Text = "Foundation Year:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(41, 166);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 9;
            countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(41, 192);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(41, 218);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 13;
            stateLabel.Text = "State:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(41, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 15;
            label1.Text = "New Name:";
            // 
            // computerGamesDBDataSet
            // 
            this.computerGamesDBDataSet.DataSetName = "ComputerGamesDBDataSet";
            this.computerGamesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataMember = "Publisher";
            this.publisherBindingSource.DataSource = this.computerGamesDBDataSet;
            // 
            // publisherTableAdapter
            // 
            this.publisherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeveloperTableAdapter = null;
            this.tableAdapterManager.GameTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.PlatformTableAdapter = null;
            this.tableAdapterManager.PublisherTableAdapter = this.publisherTableAdapter;
            this.tableAdapterManager.StylisticsTableAdapter = null;
            this.tableAdapterManager.SupportedPlatformTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComputerGames.ComputerGamesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nameTextBox.CausesValidation = false;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(135, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TabStop = false;
            // 
            // officialSiteTextBox
            // 
            this.officialSiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "OfficialSite", true));
            this.officialSiteTextBox.Location = new System.Drawing.Point(135, 111);
            this.officialSiteTextBox.Name = "officialSiteTextBox";
            this.officialSiteTextBox.Size = new System.Drawing.Size(200, 20);
            this.officialSiteTextBox.TabIndex = 2;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(135, 163);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(135, 189);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 5;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(135, 215);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(200, 20);
            this.stateTextBox.TabIndex = 6;
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(135, 85);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.newNameTextBox.TabIndex = 1;
            // 
            // yearMaskedTextBox
            // 
            this.yearMaskedTextBox.Location = new System.Drawing.Point(135, 138);
            this.yearMaskedTextBox.Mask = "00/00/0000";
            this.yearMaskedTextBox.Name = "yearMaskedTextBox";
            this.yearMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.yearMaskedTextBox.TabIndex = 3;
            this.yearMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Image = global::ComputerGames.Properties.Resources.Update_Button_2;
            this.button1.Location = new System.Drawing.Point(168, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 67);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateDevOrPubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yearMaskedTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(officialSiteLabel);
            this.Controls.Add(this.officialSiteTextBox);
            this.Controls.Add(foundationYearLabel);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Name = "UpdateDevOrPubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDevOrPubForm";
            this.Load += new System.EventHandler(this.UpdateDevOrPubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComputerGamesDBDataSet computerGamesDBDataSet;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private ComputerGamesDBDataSetTableAdapters.PublisherTableAdapter publisherTableAdapter;
        private ComputerGamesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox officialSiteTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.MaskedTextBox yearMaskedTextBox;
        private System.Windows.Forms.Button button1;
        private ComputerGamesDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}