namespace LibraryManagementClient
{
    partial class Category
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
            this.manageCategories = new System.Windows.Forms.GroupBox();
            this.updateCategory_btn = new System.Windows.Forms.Button();
            this.deleteCategory_btn = new System.Windows.Forms.Button();
            this.addCategory_btn = new System.Windows.Forms.Button();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.cIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataSet = new LibraryManagementClient.CategoryDataSet();
            this.categoryTableAdapter = new LibraryManagementClient.CategoryDataSetTableAdapters.CategoryTableAdapter();
            this.categories = new System.Windows.Forms.GroupBox();
            this.manageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).BeginInit();
            this.categories.SuspendLayout();
            this.SuspendLayout();
            // 
            // manageCategories
            // 
            this.manageCategories.Controls.Add(this.updateCategory_btn);
            this.manageCategories.Controls.Add(this.deleteCategory_btn);
            this.manageCategories.Controls.Add(this.addCategory_btn);
            this.manageCategories.Controls.Add(this.categoryName);
            this.manageCategories.Controls.Add(this.label1);
            this.manageCategories.Location = new System.Drawing.Point(139, 110);
            this.manageCategories.Name = "manageCategories";
            this.manageCategories.Size = new System.Drawing.Size(471, 355);
            this.manageCategories.TabIndex = 0;
            this.manageCategories.TabStop = false;
            this.manageCategories.Text = "Manage Categories";
            // 
            // updateCategory_btn
            // 
            this.updateCategory_btn.Location = new System.Drawing.Point(164, 276);
            this.updateCategory_btn.Name = "updateCategory_btn";
            this.updateCategory_btn.Size = new System.Drawing.Size(129, 32);
            this.updateCategory_btn.TabIndex = 4;
            this.updateCategory_btn.Text = "Update Category";
            this.updateCategory_btn.UseVisualStyleBackColor = true;
            this.updateCategory_btn.Click += new System.EventHandler(this.updateCategory_btn_Click);
            // 
            // deleteCategory_btn
            // 
            this.deleteCategory_btn.Location = new System.Drawing.Point(268, 204);
            this.deleteCategory_btn.Name = "deleteCategory_btn";
            this.deleteCategory_btn.Size = new System.Drawing.Size(133, 32);
            this.deleteCategory_btn.TabIndex = 3;
            this.deleteCategory_btn.Text = "Delete Category";
            this.deleteCategory_btn.UseVisualStyleBackColor = true;
            this.deleteCategory_btn.Click += new System.EventHandler(this.deleteCategory_btn_Click);
            // 
            // addCategory_btn
            // 
            this.addCategory_btn.Location = new System.Drawing.Point(55, 204);
            this.addCategory_btn.Name = "addCategory_btn";
            this.addCategory_btn.Size = new System.Drawing.Size(133, 32);
            this.addCategory_btn.TabIndex = 2;
            this.addCategory_btn.Text = "Add Category";
            this.addCategory_btn.UseVisualStyleBackColor = true;
            this.addCategory_btn.Click += new System.EventHandler(this.addCategory_btn_Click);
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(164, 111);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(252, 22);
            this.categoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name :";
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.Location = new System.Drawing.Point(830, 110);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.RowTemplate.Height = 24;
            this.categoryDataGridView.Size = new System.Drawing.Size(324, 355);
            this.categoryDataGridView.TabIndex = 1;
            this.categoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellClick);
            // 
            // cIdDataGridViewTextBoxColumn
            // 
            this.cIdDataGridViewTextBoxColumn.DataPropertyName = "CId";
            this.cIdDataGridViewTextBoxColumn.HeaderText = "CId";
            this.cIdDataGridViewTextBoxColumn.Name = "cIdDataGridViewTextBoxColumn";
            this.cIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.categoryDataSet;
            // 
            // categoryDataSet
            // 
            this.categoryDataSet.DataSetName = "CategoryDataSet";
            this.categoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categories
            // 
            this.categories.Controls.Add(this.categoryDataGridView);
            this.categories.Controls.Add(this.manageCategories);
            this.categories.Location = new System.Drawing.Point(360, 202);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(1271, 578);
            this.categories.TabIndex = 2;
            this.categories.TabStop = false;
            this.categories.Text = "Categories";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1915, 931);
            this.Controls.Add(this.categories);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.manageCategories.ResumeLayout(false);
            this.manageCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
            this.categories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox manageCategories;
        private System.Windows.Forms.Button updateCategory_btn;
        private System.Windows.Forms.Button deleteCategory_btn;
        private System.Windows.Forms.Button addCategory_btn;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private CategoryDataSet categoryDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private CategoryDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox categories;
    }
}