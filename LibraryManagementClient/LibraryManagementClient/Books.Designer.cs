namespace LibraryManagementClient
{
    partial class Books
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
            this.manageBooks = new System.Windows.Forms.GroupBox();
            this.updateBook_btn = new System.Windows.Forms.Button();
            this.deleteBook_btn = new System.Windows.Forms.Button();
            this.addBook_btn = new System.Windows.Forms.Button();
            this.categoryList = new System.Windows.Forms.ListBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataSet = new LibraryManagementClient.CategoryDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.pages = new System.Windows.Forms.TextBox();
            this.edition = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.booksDataGridView1 = new System.Windows.Forms.DataGridView();
            this.bIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookdataset = new LibraryManagementClient.bookdataset();
            this.categoryTableAdapter = new LibraryManagementClient.CategoryDataSetTableAdapters.CategoryTableAdapter();
            this.booksTableAdapter = new LibraryManagementClient.bookdatasetTableAdapters.BooksTableAdapter();
            this.filter = new System.Windows.Forms.GroupBox();
            this.searchByCategory_btn = new System.Windows.Forms.Button();
            this.labelcat = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.ComboBox();
            this.manageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookdataset)).BeginInit();
            this.filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // manageBooks
            // 
            this.manageBooks.Controls.Add(this.updateBook_btn);
            this.manageBooks.Controls.Add(this.deleteBook_btn);
            this.manageBooks.Controls.Add(this.addBook_btn);
            this.manageBooks.Controls.Add(this.pages);
            this.manageBooks.Controls.Add(this.price);
            this.manageBooks.Controls.Add(this.categoryList);
            this.manageBooks.Controls.Add(this.label5);
            this.manageBooks.Controls.Add(this.edition);
            this.manageBooks.Controls.Add(this.author);
            this.manageBooks.Controls.Add(this.label4);
            this.manageBooks.Controls.Add(this.label3);
            this.manageBooks.Controls.Add(this.label2);
            this.manageBooks.Controls.Add(this.label1);
            this.manageBooks.Controls.Add(this.bookName);
            this.manageBooks.Controls.Add(this.label);
            this.manageBooks.Location = new System.Drawing.Point(198, 118);
            this.manageBooks.Name = "manageBooks";
            this.manageBooks.Size = new System.Drawing.Size(548, 780);
            this.manageBooks.TabIndex = 0;
            this.manageBooks.TabStop = false;
            this.manageBooks.Text = "Manage Books";
            // 
            // updateBook_btn
            // 
            this.updateBook_btn.Location = new System.Drawing.Point(197, 668);
            this.updateBook_btn.Name = "updateBook_btn";
            this.updateBook_btn.Size = new System.Drawing.Size(158, 44);
            this.updateBook_btn.TabIndex = 14;
            this.updateBook_btn.Text = "Update Book";
            this.updateBook_btn.UseVisualStyleBackColor = true;
            this.updateBook_btn.Click += new System.EventHandler(this.updateBook_btn_Click);
            // 
            // deleteBook_btn
            // 
            this.deleteBook_btn.Location = new System.Drawing.Point(327, 578);
            this.deleteBook_btn.Name = "deleteBook_btn";
            this.deleteBook_btn.Size = new System.Drawing.Size(158, 44);
            this.deleteBook_btn.TabIndex = 13;
            this.deleteBook_btn.Text = "Delete Book";
            this.deleteBook_btn.UseVisualStyleBackColor = true;
            this.deleteBook_btn.Click += new System.EventHandler(this.deleteBook_btn_Click);
            // 
            // addBook_btn
            // 
            this.addBook_btn.Location = new System.Drawing.Point(63, 578);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Size = new System.Drawing.Size(158, 44);
            this.addBook_btn.TabIndex = 12;
            this.addBook_btn.Text = "Add Book";
            this.addBook_btn.UseVisualStyleBackColor = true;
            this.addBook_btn.Click += new System.EventHandler(this.addBook_btn_Click);
            // 
            // categoryList
            // 
            this.categoryList.DataSource = this.categoryBindingSource;
            this.categoryList.DisplayMember = "Category";
            this.categoryList.FormattingEnabled = true;
            this.categoryList.ItemHeight = 16;
            this.categoryList.Location = new System.Drawing.Point(197, 411);
            this.categoryList.Name = "categoryList";
            this.categoryList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.categoryList.Size = new System.Drawing.Size(268, 84);
            this.categoryList.TabIndex = 11;
            this.categoryList.ValueMember = "CId";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Category :";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(197, 345);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(268, 22);
            this.price.TabIndex = 9;
            // 
            // pages
            // 
            this.pages.Location = new System.Drawing.Point(197, 286);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(268, 22);
            this.pages.TabIndex = 8;
            // 
            // edition
            // 
            this.edition.Location = new System.Drawing.Point(197, 223);
            this.edition.Name = "edition";
            this.edition.Size = new System.Drawing.Size(268, 22);
            this.edition.TabIndex = 7;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(197, 161);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(268, 22);
            this.author.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pages :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edition :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author :";
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(197, 93);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(268, 22);
            this.bookName.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(60, 93);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Book Name :";
            // 
            // booksDataGridView1
            // 
            this.booksDataGridView1.AllowUserToAddRows = false;
            this.booksDataGridView1.AllowUserToDeleteRows = false;
            this.booksDataGridView1.AutoGenerateColumns = false;
            this.booksDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.editionDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.booksDataGridView1.DataSource = this.booksBindingSource;
            this.booksDataGridView1.Location = new System.Drawing.Point(977, 276);
            this.booksDataGridView1.Name = "booksDataGridView1";
            this.booksDataGridView1.ReadOnly = true;
            this.booksDataGridView1.RowTemplate.Height = 24;
            this.booksDataGridView1.Size = new System.Drawing.Size(857, 622);
            this.booksDataGridView1.TabIndex = 1;
            this.booksDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView1_CellClick);
            // 
            // bIdDataGridViewTextBoxColumn
            // 
            this.bIdDataGridViewTextBoxColumn.DataPropertyName = "BId";
            this.bIdDataGridViewTextBoxColumn.HeaderText = "BId";
            this.bIdDataGridViewTextBoxColumn.Name = "bIdDataGridViewTextBoxColumn";
            this.bIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editionDataGridViewTextBoxColumn
            // 
            this.editionDataGridViewTextBoxColumn.DataPropertyName = "Edition";
            this.editionDataGridViewTextBoxColumn.HeaderText = "Edition";
            this.editionDataGridViewTextBoxColumn.Name = "editionDataGridViewTextBoxColumn";
            this.editionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            this.pagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bookdataset;
            // 
            // bookdataset
            // 
            this.bookdataset.DataSetName = "bookdataset";
            this.bookdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // filter
            // 
            this.filter.Controls.Add(this.categoryName);
            this.filter.Controls.Add(this.searchByCategory_btn);
            this.filter.Controls.Add(this.labelcat);
            this.filter.Location = new System.Drawing.Point(977, 118);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(857, 121);
            this.filter.TabIndex = 2;
            this.filter.TabStop = false;
            this.filter.Text = "Filter";
            // 
            // searchByCategory_btn
            // 
            this.searchByCategory_btn.Location = new System.Drawing.Point(613, 52);
            this.searchByCategory_btn.Name = "searchByCategory_btn";
            this.searchByCategory_btn.Size = new System.Drawing.Size(170, 34);
            this.searchByCategory_btn.TabIndex = 16;
            this.searchByCategory_btn.Text = "Search By Category";
            this.searchByCategory_btn.UseVisualStyleBackColor = true;
            this.searchByCategory_btn.Click += new System.EventHandler(this.searchByCategory_btn_Click);
            // 
            // labelcat
            // 
            this.labelcat.AutoSize = true;
            this.labelcat.Location = new System.Drawing.Point(101, 58);
            this.labelcat.Name = "labelcat";
            this.labelcat.Size = new System.Drawing.Size(114, 17);
            this.labelcat.TabIndex = 0;
            this.labelcat.Text = "Category Name :";
            // 
            // categoryName
            // 
            this.categoryName.FormattingEnabled = true;
            this.categoryName.Location = new System.Drawing.Point(258, 51);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(268, 24);
            this.categoryName.TabIndex = 17;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.booksDataGridView1);
            this.Controls.Add(this.manageBooks);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.manageBooks.ResumeLayout(false);
            this.manageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookdataset)).EndInit();
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox manageBooks;
        private System.Windows.Forms.ListBox categoryList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox pages;
        private System.Windows.Forms.TextBox edition;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button updateBook_btn;
        private System.Windows.Forms.Button deleteBook_btn;
        private System.Windows.Forms.Button addBook_btn;
        private System.Windows.Forms.DataGridView booksDataGridView1;
        private CategoryDataSet categoryDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private CategoryDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private bookdataset bookdataset;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private bookdatasetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox filter;
        private System.Windows.Forms.Button searchByCategory_btn;
        private System.Windows.Forms.Label labelcat;
        private System.Windows.Forms.ComboBox categoryName;
    }
}