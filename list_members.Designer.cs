namespace Library
{
    partial class list_members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_members));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryDataSet6 = new Library.LibraryDataSet6();
            this.listMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_MembersTableAdapter = new Library.LibraryDataSet6TableAdapters.List_MembersTableAdapter();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberCellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMembersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.memberEmailDataGridViewTextBoxColumn,
            this.memberCellPhoneDataGridViewTextBoxColumn,
            this.membershipTypeDataGridViewTextBoxColumn,
            this.membershipStartDateDataGridViewTextBoxColumn,
            this.membershipEndDateDataGridViewTextBoxColumn,
            this.memberUsernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listMembersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(394, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // libraryDataSet6
            // 
            this.libraryDataSet6.DataSetName = "LibraryDataSet6";
            this.libraryDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listMembersBindingSource
            // 
            this.listMembersBindingSource.DataMember = "List_Members";
            this.listMembersBindingSource.DataSource = this.libraryDataSet6;
            // 
            // list_MembersTableAdapter
            // 
            this.list_MembersTableAdapter.ClearBeforeFill = true;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberEmailDataGridViewTextBoxColumn
            // 
            this.memberEmailDataGridViewTextBoxColumn.DataPropertyName = "MemberEmail";
            this.memberEmailDataGridViewTextBoxColumn.HeaderText = "MemberEmail";
            this.memberEmailDataGridViewTextBoxColumn.Name = "memberEmailDataGridViewTextBoxColumn";
            this.memberEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberCellPhoneDataGridViewTextBoxColumn
            // 
            this.memberCellPhoneDataGridViewTextBoxColumn.DataPropertyName = "MemberCellPhone";
            this.memberCellPhoneDataGridViewTextBoxColumn.HeaderText = "MemberCellPhone";
            this.memberCellPhoneDataGridViewTextBoxColumn.Name = "memberCellPhoneDataGridViewTextBoxColumn";
            this.memberCellPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membershipTypeDataGridViewTextBoxColumn
            // 
            this.membershipTypeDataGridViewTextBoxColumn.DataPropertyName = "MembershipType";
            this.membershipTypeDataGridViewTextBoxColumn.HeaderText = "MembershipType";
            this.membershipTypeDataGridViewTextBoxColumn.Name = "membershipTypeDataGridViewTextBoxColumn";
            this.membershipTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membershipStartDateDataGridViewTextBoxColumn
            // 
            this.membershipStartDateDataGridViewTextBoxColumn.DataPropertyName = "MembershipStartDate";
            this.membershipStartDateDataGridViewTextBoxColumn.HeaderText = "MembershipStartDate";
            this.membershipStartDateDataGridViewTextBoxColumn.Name = "membershipStartDateDataGridViewTextBoxColumn";
            this.membershipStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membershipEndDateDataGridViewTextBoxColumn
            // 
            this.membershipEndDateDataGridViewTextBoxColumn.DataPropertyName = "MembershipEndDate";
            this.membershipEndDateDataGridViewTextBoxColumn.HeaderText = "MembershipEndDate";
            this.membershipEndDateDataGridViewTextBoxColumn.Name = "membershipEndDateDataGridViewTextBoxColumn";
            this.membershipEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberUsernameDataGridViewTextBoxColumn
            // 
            this.memberUsernameDataGridViewTextBoxColumn.DataPropertyName = "MemberUsername";
            this.memberUsernameDataGridViewTextBoxColumn.HeaderText = "MemberUsername";
            this.memberUsernameDataGridViewTextBoxColumn.Name = "memberUsernameDataGridViewTextBoxColumn";
            this.memberUsernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exitb
            // 
            this.exitb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitb.BackgroundImage")));
            this.exitb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitb.Location = new System.Drawing.Point(177, 387);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(77, 79);
            this.exitb.TabIndex = 21;
            this.exitb.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // list_members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(445, 478);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "list_members";
            this.Text = "list_members";
            this.Load += new System.EventHandler(this.list_members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMembersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet6 libraryDataSet6;
        private System.Windows.Forms.BindingSource listMembersBindingSource;
        private LibraryDataSet6TableAdapters.List_MembersTableAdapter list_MembersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberCellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exitb;
    }
}