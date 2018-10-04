namespace Library
{
    partial class confirm_donations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirm_donations));
            this.seeConfirmDonationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet7 = new Library.LibraryDataSet7();
            this.exitb = new System.Windows.Forms.Button();
            this.see_Confirm_DonationsTableAdapter = new Library.LibraryDataSet7TableAdapters.See_Confirm_DonationsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seeConfirmDonationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet71 = new Library.LibraryDataSet7();
            ((System.ComponentModel.ISupportInitialize)(this.seeConfirmDonationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeConfirmDonationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet71)).BeginInit();
            this.SuspendLayout();
            // 
            // seeConfirmDonationsBindingSource
            // 
            this.seeConfirmDonationsBindingSource.DataMember = "See_Confirm_Donations";
            this.seeConfirmDonationsBindingSource.DataSource = this.libraryDataSet7;
            // 
            // libraryDataSet7
            // 
            this.libraryDataSet7.DataSetName = "LibraryDataSet7";
            this.libraryDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exitb
            // 
            this.exitb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitb.BackgroundImage")));
            this.exitb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitb.Location = new System.Drawing.Point(172, 339);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(77, 79);
            this.exitb.TabIndex = 21;
            this.exitb.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // see_Confirm_DonationsTableAdapter
            // 
            this.see_Confirm_DonationsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bDIDDataGridViewTextBoxColumn,
            this.bMIDDataGridViewTextBoxColumn,
            this.bNameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publishYearDataGridViewTextBoxColumn,
            this.bPageDataGridViewTextBoxColumn,
            this.bLanguageDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.explanationDataGridViewTextBoxColumn,
            this.conDataGridViewCheckBoxColumn,
            this.recDataGridViewCheckBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seeConfirmDonationsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 306);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bDIDDataGridViewTextBoxColumn
            // 
            this.bDIDDataGridViewTextBoxColumn.DataPropertyName = "BDID";
            this.bDIDDataGridViewTextBoxColumn.HeaderText = "BDID";
            this.bDIDDataGridViewTextBoxColumn.Name = "bDIDDataGridViewTextBoxColumn";
            this.bDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bMIDDataGridViewTextBoxColumn
            // 
            this.bMIDDataGridViewTextBoxColumn.DataPropertyName = "BMID";
            this.bMIDDataGridViewTextBoxColumn.HeaderText = "BMID";
            this.bMIDDataGridViewTextBoxColumn.Name = "bMIDDataGridViewTextBoxColumn";
            // 
            // bNameDataGridViewTextBoxColumn
            // 
            this.bNameDataGridViewTextBoxColumn.DataPropertyName = "BName";
            this.bNameDataGridViewTextBoxColumn.HeaderText = "BName";
            this.bNameDataGridViewTextBoxColumn.Name = "bNameDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // publishYearDataGridViewTextBoxColumn
            // 
            this.publishYearDataGridViewTextBoxColumn.DataPropertyName = "PublishYear";
            this.publishYearDataGridViewTextBoxColumn.HeaderText = "PublishYear";
            this.publishYearDataGridViewTextBoxColumn.Name = "publishYearDataGridViewTextBoxColumn";
            // 
            // bPageDataGridViewTextBoxColumn
            // 
            this.bPageDataGridViewTextBoxColumn.DataPropertyName = "BPage";
            this.bPageDataGridViewTextBoxColumn.HeaderText = "BPage";
            this.bPageDataGridViewTextBoxColumn.Name = "bPageDataGridViewTextBoxColumn";
            // 
            // bLanguageDataGridViewTextBoxColumn
            // 
            this.bLanguageDataGridViewTextBoxColumn.DataPropertyName = "BLanguage";
            this.bLanguageDataGridViewTextBoxColumn.HeaderText = "BLanguage";
            this.bLanguageDataGridViewTextBoxColumn.Name = "bLanguageDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // explanationDataGridViewTextBoxColumn
            // 
            this.explanationDataGridViewTextBoxColumn.DataPropertyName = "Explanation";
            this.explanationDataGridViewTextBoxColumn.HeaderText = "Explanation";
            this.explanationDataGridViewTextBoxColumn.Name = "explanationDataGridViewTextBoxColumn";
            // 
            // conDataGridViewCheckBoxColumn
            // 
            this.conDataGridViewCheckBoxColumn.DataPropertyName = "Con";
            this.conDataGridViewCheckBoxColumn.HeaderText = "Con";
            this.conDataGridViewCheckBoxColumn.Name = "conDataGridViewCheckBoxColumn";
            // 
            // recDataGridViewCheckBoxColumn
            // 
            this.recDataGridViewCheckBoxColumn.DataPropertyName = "Rec";
            this.recDataGridViewCheckBoxColumn.HeaderText = "Rec";
            this.recDataGridViewCheckBoxColumn.Name = "recDataGridViewCheckBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // seeConfirmDonationsBindingSource1
            // 
            this.seeConfirmDonationsBindingSource1.DataMember = "See_Confirm_Donations";
            this.seeConfirmDonationsBindingSource1.DataSource = this.libraryDataSet71;
            // 
            // libraryDataSet71
            // 
            this.libraryDataSet71.DataSetName = "LibraryDataSet7";
            this.libraryDataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // confirm_donations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(435, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "confirm_donations";
            this.Text = "Confirm Donations";
            this.Load += new System.EventHandler(this.confirm_donations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seeConfirmDonationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeConfirmDonationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet71)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitb;
        private LibraryDataSet7 libraryDataSet7;
        private System.Windows.Forms.BindingSource seeConfirmDonationsBindingSource;
        private LibraryDataSet7TableAdapters.See_Confirm_DonationsTableAdapter see_Confirm_DonationsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet7 libraryDataSet71;
        private System.Windows.Forms.BindingSource seeConfirmDonationsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
    }
}