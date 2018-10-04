namespace Library
{
    partial class confirm_coming_books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirm_coming_books));
            this.exitb = new System.Windows.Forms.Button();
            this.libraryDataSet8 = new Library.LibraryDataSet8();
            this.listComBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_Com_BooksTableAdapter = new Library.LibraryDataSet8TableAdapters.List_Com_BooksTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCPublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCPublishYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCConfirmDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listComBooksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet81 = new Library.LibraryDataSet8();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listComBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listComBooksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet81)).BeginInit();
            this.SuspendLayout();
            // 
            // exitb
            // 
            this.exitb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitb.BackgroundImage")));
            this.exitb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitb.Location = new System.Drawing.Point(161, 318);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(67, 68);
            this.exitb.TabIndex = 39;
            this.exitb.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // libraryDataSet8
            // 
            this.libraryDataSet8.DataSetName = "LibraryDataSet8";
            this.libraryDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listComBooksBindingSource
            // 
            this.listComBooksBindingSource.DataMember = "List_Com_Books";
            this.listComBooksBindingSource.DataSource = this.libraryDataSet8;
            // 
            // list_Com_BooksTableAdapter
            // 
            this.list_Com_BooksTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bCIDDataGridViewTextBoxColumn,
            this.bCNameDataGridViewTextBoxColumn,
            this.bCAuthorDataGridViewTextBoxColumn,
            this.bCLanguageDataGridViewTextBoxColumn,
            this.bCPublisherDataGridViewTextBoxColumn,
            this.bCPublishYearDataGridViewTextBoxColumn,
            this.bCPageDataGridViewTextBoxColumn,
            this.bCExpDataGridViewTextBoxColumn,
            this.bCNumberDataGridViewTextBoxColumn,
            this.bCDateDataGridViewTextBoxColumn,
            this.bCConfirmDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.listComBooksBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 287);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bCIDDataGridViewTextBoxColumn
            // 
            this.bCIDDataGridViewTextBoxColumn.DataPropertyName = "BCID";
            this.bCIDDataGridViewTextBoxColumn.HeaderText = "BCID";
            this.bCIDDataGridViewTextBoxColumn.Name = "bCIDDataGridViewTextBoxColumn";
            this.bCIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bCNameDataGridViewTextBoxColumn
            // 
            this.bCNameDataGridViewTextBoxColumn.DataPropertyName = "BCName";
            this.bCNameDataGridViewTextBoxColumn.HeaderText = "BCName";
            this.bCNameDataGridViewTextBoxColumn.Name = "bCNameDataGridViewTextBoxColumn";
            // 
            // bCAuthorDataGridViewTextBoxColumn
            // 
            this.bCAuthorDataGridViewTextBoxColumn.DataPropertyName = "BCAuthor";
            this.bCAuthorDataGridViewTextBoxColumn.HeaderText = "BCAuthor";
            this.bCAuthorDataGridViewTextBoxColumn.Name = "bCAuthorDataGridViewTextBoxColumn";
            // 
            // bCLanguageDataGridViewTextBoxColumn
            // 
            this.bCLanguageDataGridViewTextBoxColumn.DataPropertyName = "BCLanguage";
            this.bCLanguageDataGridViewTextBoxColumn.HeaderText = "BCLanguage";
            this.bCLanguageDataGridViewTextBoxColumn.Name = "bCLanguageDataGridViewTextBoxColumn";
            // 
            // bCPublisherDataGridViewTextBoxColumn
            // 
            this.bCPublisherDataGridViewTextBoxColumn.DataPropertyName = "BCPublisher";
            this.bCPublisherDataGridViewTextBoxColumn.HeaderText = "BCPublisher";
            this.bCPublisherDataGridViewTextBoxColumn.Name = "bCPublisherDataGridViewTextBoxColumn";
            // 
            // bCPublishYearDataGridViewTextBoxColumn
            // 
            this.bCPublishYearDataGridViewTextBoxColumn.DataPropertyName = "BCPublishYear";
            this.bCPublishYearDataGridViewTextBoxColumn.HeaderText = "BCPublishYear";
            this.bCPublishYearDataGridViewTextBoxColumn.Name = "bCPublishYearDataGridViewTextBoxColumn";
            // 
            // bCPageDataGridViewTextBoxColumn
            // 
            this.bCPageDataGridViewTextBoxColumn.DataPropertyName = "BCPage";
            this.bCPageDataGridViewTextBoxColumn.HeaderText = "BCPage";
            this.bCPageDataGridViewTextBoxColumn.Name = "bCPageDataGridViewTextBoxColumn";
            // 
            // bCExpDataGridViewTextBoxColumn
            // 
            this.bCExpDataGridViewTextBoxColumn.DataPropertyName = "BCExp";
            this.bCExpDataGridViewTextBoxColumn.HeaderText = "BCExp";
            this.bCExpDataGridViewTextBoxColumn.Name = "bCExpDataGridViewTextBoxColumn";
            // 
            // bCNumberDataGridViewTextBoxColumn
            // 
            this.bCNumberDataGridViewTextBoxColumn.DataPropertyName = "BCNumber";
            this.bCNumberDataGridViewTextBoxColumn.HeaderText = "BCNumber";
            this.bCNumberDataGridViewTextBoxColumn.Name = "bCNumberDataGridViewTextBoxColumn";
            // 
            // bCDateDataGridViewTextBoxColumn
            // 
            this.bCDateDataGridViewTextBoxColumn.DataPropertyName = "BCDate";
            this.bCDateDataGridViewTextBoxColumn.HeaderText = "BCDate";
            this.bCDateDataGridViewTextBoxColumn.Name = "bCDateDataGridViewTextBoxColumn";
            // 
            // bCConfirmDataGridViewCheckBoxColumn
            // 
            this.bCConfirmDataGridViewCheckBoxColumn.DataPropertyName = "BCConfirm";
            this.bCConfirmDataGridViewCheckBoxColumn.HeaderText = "BCConfirm";
            this.bCConfirmDataGridViewCheckBoxColumn.Name = "bCConfirmDataGridViewCheckBoxColumn";
            // 
            // listComBooksBindingSource1
            // 
            this.listComBooksBindingSource1.DataMember = "List_Com_Books";
            this.listComBooksBindingSource1.DataSource = this.libraryDataSet81;
            // 
            // libraryDataSet81
            // 
            this.libraryDataSet81.DataSetName = "LibraryDataSet8";
            this.libraryDataSet81.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // confirm_coming_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(386, 404);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "confirm_coming_books";
            this.Text = "Confirm Coming Books";
            this.Load += new System.EventHandler(this.confirm_coming_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listComBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listComBooksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet81)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitb;
        private LibraryDataSet8 libraryDataSet8;
        private System.Windows.Forms.BindingSource listComBooksBindingSource;
        private LibraryDataSet8TableAdapters.List_Com_BooksTableAdapter list_Com_BooksTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet8 libraryDataSet81;
        private System.Windows.Forms.BindingSource listComBooksBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCPublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCPublishYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bCConfirmDataGridViewCheckBoxColumn;
    }
}