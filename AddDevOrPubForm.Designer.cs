namespace ComputerGames
{
    partial class AddDevOrPubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDevOrPubForm));
            this.computerGamesDBDataSet = new ComputerGames.ComputerGamesDBDataSet();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publisherTableAdapter = new ComputerGames.ComputerGamesDBDataSetTableAdapters.PublisherTableAdapter();
            this.tableAdapterManager = new ComputerGames.ComputerGamesDBDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new ComputerGames.ComputerGamesDBDataSetTableAdapters.QueriesTableAdapter();
            this.yearMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.officialSiteTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            officialSiteLabel = new System.Windows.Forms.Label();
            foundationYearLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerGamesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(37, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // officialSiteLabel
            // 
            officialSiteLabel.AutoSize = true;
            officialSiteLabel.Location = new System.Drawing.Point(37, 109);
            officialSiteLabel.Name = "officialSiteLabel";
            officialSiteLabel.Size = new System.Drawing.Size(63, 13);
            officialSiteLabel.TabIndex = 5;
            officialSiteLabel.Text = "Official Site:";
            // 
            // foundationYearLabel
            // 
            foundationYearLabel.AutoSize = true;
            foundationYearLabel.Location = new System.Drawing.Point(37, 136);
            foundationYearLabel.Name = "foundationYearLabel";
            foundationYearLabel.Size = new System.Drawing.Size(88, 13);
            foundationYearLabel.TabIndex = 7;
            foundationYearLabel.Text = "Foundation Year:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(37, 161);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 9;
            countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(37, 187);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(37, 213);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 13;
            stateLabel.Text = "State:";
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
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(131, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(131, 158);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(131, 184);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 5;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(131, 210);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(200, 20);
            this.stateTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(164, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 58);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yearMaskedTextBox
            // 
            this.yearMaskedTextBox.Location = new System.Drawing.Point(131, 132);
            this.yearMaskedTextBox.Mask = "00/00/0000";
            this.yearMaskedTextBox.Name = "yearMaskedTextBox";
            this.yearMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.yearMaskedTextBox.TabIndex = 3;
            this.yearMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // officialSiteTextBox
            // 
            this.officialSiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherBindingSource, "OfficialSite", true));
            this.officialSiteTextBox.Location = new System.Drawing.Point(131, 106);
            this.officialSiteTextBox.Name = "officialSiteTextBox";
            this.officialSiteTextBox.Size = new System.Drawing.Size(200, 20);
            this.officialSiteTextBox.TabIndex = 2;
            this.officialSiteTextBox.TextChanged += new System.EventHandler(this.officialSiteTextBox_TextChanged);
            // 
            // AddDevOrPubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 343);
            this.Controls.Add(this.officialSiteTextBox);
            this.Controls.Add(this.yearMaskedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(officialSiteLabel);
            this.Controls.Add(foundationYearLabel);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Name = "AddDevOrPubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Developer or Publisher";
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
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Button button1;
        private ComputerGamesDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.MaskedTextBox yearMaskedTextBox;
        private System.Windows.Forms.TextBox officialSiteTextBox;
    }
}