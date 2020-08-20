using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementClient
{
    public partial class Books : Form
    {
        string book_name, auth, edi, page, pri;
        LibraryManagementServiceReference.BooksServiceClient client = new LibraryManagementServiceReference.BooksServiceClient();
        int ID = 0;
        int i = 0;

        public Books()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;

            BindGridBooks();
            BindComboBox();
            
        }

        
        public void BindGridBooks()
        {
            DataSet ds = new DataSet();
            ds = client.getBooks();
            DataTable dt = ds.Tables[0];
            booksDataGridView1.DataSource = dt;
        }


        private void ClearBook()
        {
            bookName.Text = "";
            author.Text = "";
            price.Text = "";
            edition.Text = "";
            pages.Text = "";
            ID = 0;
        }

        public void BindComboBox()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            string Query = "SELECT * from Category";
            cmd = new SqlCommand(Query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                categoryName.Items.Add(reader["Category"]);
            }
            con.Close();
        }


        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookdataset.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.bookdataset.Books);
            // TODO: This line of code loads data into the 'categoryDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.categoryDataSet.Category);

        }


        private void booksDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (booksDataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in booksDataGridView1.SelectedRows) // foreach datagridview selected rows values  
                {
                    ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    bookName.Text = row.Cells[1].Value.ToString();
                    author.Text = row.Cells[2].Value.ToString();
                    edition.Text = row.Cells[3].Value.ToString();
                    pages.Text = row.Cells[4].Value.ToString();
                    price.Text = row.Cells[5].Value.ToString();
                }
                
                addBook_btn.Enabled = false;
            }
        }

        
        private void addBook_btn_Click(object sender, EventArgs e)
        {
            book_name = bookName.Text;
            auth = author.Text;
            edi = edition.Text;
            page = pages.Text;
            pri = price.Text;

            Dictionary<string, int> d = new Dictionary<string, int>();

            foreach (DataRowView item in categoryList.SelectedItems)
            {
                int tempId = Convert.ToInt32(item[0]);
                string tempName = item[1] as string;
                d.Add(tempName, tempId);

            }

            if (book_name != "" && auth != "" && edi != "" && page != "" && pri != "" && d.Count != 0)
            {
                MessageBox.Show(client.addBooks(book_name, auth, edi, page, pri, d));
                BindGridBooks();
                ClearBook();
            }
            else
            {
                MessageBox.Show("Please Provide All Details !");
            }
        }

        private void deleteBook_btn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                string result = client.deleteBook(ID);
                if (result == "Record Deleted Successfully!")
                {
                    BindGridBooks();
                    MessageBox.Show("Book Deleted Successfully!");
                    addBook_btn.Enabled = true;
                    ClearBook();
                }
                else
                {
                    MessageBox.Show("Book Not Deleted!");
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void updateBook_btn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                book_name = bookName.Text;
                auth = author.Text;
                edi = edition.Text;
                page = pages.Text;
                pri = price.Text;

                Dictionary<string, int> d = new Dictionary<string, int>();

                foreach (DataRowView item in categoryList.SelectedItems)
                {
                    int tempId = Convert.ToInt32(item[0]);
                    string tempName = item[1] as string;
                    d.Add(tempName, tempId);

                }

                string result = client.updateBook(ID, book_name, auth, edi, page, pri, d);
                if (result == "Record Updated Successfully !")
                {
                    BindGridBooks();
                    MessageBox.Show("Book Updated Successfully!");
                    addBook_btn.Enabled = true;
                    ClearBook();
                }
                else
                {
                    MessageBox.Show("Book Not Updated!");
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }

        }


        private void searchByCategory_btn_Click(object sender, EventArgs e)
        {
            string category = categoryName.Text;
            if(category != "")
            {
                DataSet ds = new DataSet();
                ds = client.getBooksByCategory(category);
                DataTable dt = ds.Tables["Books"];
                booksDataGridView1.DataSource = dt;
                //MessageBox.Show("Category Id " + client.getBooksByCategory(category));
            }
            else
            {
                MessageBox.Show("Please Provide Category Name For Search !");
            }
            
        }

    }
}
