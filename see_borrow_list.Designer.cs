namespace Library
{
    partial class see_borrow_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(see_borrow_list));
            this.exitb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryDataSet3 = new Library.LibraryDataSet3();
            this.seeBorrowListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.see_Borrow_ListTableAdapter = new Library.LibraryDataSet3TableAdapters.See_Borrow_ListTableAdapter();
            this.borrowIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeBorrowListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitb
            // 
            this.exitb.BackColor = System.Drawing.Color.Honeydew;
            this.exitb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitb.BackgroundImage")));
            this.exitb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitb.Location = new System.Drawing.Point(199, 359);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(77, 79);
            this.exitb.TabIndex = 21;
            this.exitb.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitb.UseVisualStyleBackColor = false;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.borrowStartDateDataGridViewTextBoxColumn,
            this.borrowEndDateDataGridViewTextBoxColumn,
            this.borrowNoteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seeBorrowListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(455, 329);
            this.dataGridView1.TabIndex = 22;
            // 
            // libraryDataSet3
            // 
            this.libraryDataSet3.DataSetName = "LibraryDataSet3";
            this.libraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seeBorrowListBindingSource
            // 
            this.seeBorrowListBindingSource.DataMember = "See_Borrow_List";
            this.seeBorrowListBindingSource.DataSource = this.libraryDataSet3;
            // 
            // see_Borrow_ListTableAdapter
            // 
            this.see_Borrow_ListTableAdapter.ClearBeforeFill = true;
            // 
            // borrowIDDataGridViewTextBoxColumn
            // 
            this.borrowIDDataGridViewTextBoxColumn.DataPropertyName = "BorrowID";
            this.borrowIDDataGridViewTextBoxColumn.HeaderText = "BorrowID";
            this.borrowIDDataGridViewTextBoxColumn.Name = "borrowIDDataGridViewTextBoxColumn";
            this.borrowIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowStartDateDataGridViewTextBoxColumn
            // 
            this.borrowStartDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowStartDate";
            this.borrowStartDateDataGridViewTextBoxColumn.HeaderText = "BorrowStartDate";
            this.borrowStartDateDataGridViewTextBoxColumn.Name = "borrowStartDateDataGridViewTextBoxColumn";
            this.borrowStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowEndDateDataGridViewTextBoxColumn
            // 
            this.borrowEndDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowEndDate";
            this.borrowEndDateDataGridViewTextBoxColumn.HeaderText = "BorrowEndDate";
            this.borrowEndDateDataGridViewTextBoxColumn.Name = "borrowEndDateDataGridViewTextBoxColumn";
            this.borrowEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowNoteDataGridViewTextBoxColumn
            // 
            this.borrowNoteDataGridViewTextBoxColumn.DataPropertyName = "BorrowNote";
            this.borrowNoteDataGridViewTextBoxColumn.HeaderText = "BorrowNote";
            this.borrowNoteDataGridViewTextBoxColumn.Name = "borrowNoteDataGridViewTextBoxColumn";
            this.borrowNoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // see_borrow_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "see_borrow_list";
            this.Text = "seeborrowlist_page";
            this.Load += new System.EventHandler(this.see_borrow_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seeBorrowListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet3 libraryDataSet3;
        private System.Windows.Forms.BindingSource seeBorrowListBindingSource;
        private LibraryDataSet3TableAdapters.See_Borrow_ListTableAdapter see_Borrow_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowNoteDataGridViewTextBoxColumn;
    }
}