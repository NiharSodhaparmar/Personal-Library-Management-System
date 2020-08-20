using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementClient
{
    public partial class Category : Form
    {
        LibraryManagementServiceReference.BooksServiceClient client = new LibraryManagementServiceReference.BooksServiceClient();
        int ID = 0;

        public Category()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;

            BindGridCategory();
        }

        public void BindGridCategory()
        {
            DataSet ds = new DataSet();
            ds = client.GetCategories();
            DataTable dt = ds.Tables[0];
            categoryDataGridView.DataSource = dt;
        }

        private void ClearCategory()
        {
            categoryName.Text = "";
            ID = 0;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoryDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.categoryDataSet.Category);

        }

        private void categoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in categoryDataGridView.SelectedRows) // foreach datagridview selected rows values  
                {
                    ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    categoryName.Text = row.Cells[1].Value.ToString();
                }
                addCategory_btn.Enabled = false;
            }
        }

        private void addCategory_btn_Click(object sender, EventArgs e)
        {
            if (categoryName.Text != "")
            {
                MessageBox.Show(client.addCategory(categoryName.Text));
                BindGridCategory();
                ClearCategory();
            }
            else
            {
                MessageBox.Show("Please Provide Category Name !");
            }
        }

        private void deleteCategory_btn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                string result = client.deleteCategory(ID);
                if (result == "Record Deleted Successfully!")
                {
                    BindGridCategory();
                    MessageBox.Show("Category Deleted Successfully!");
                    addCategory_btn.Enabled = true;
                    ClearCategory();
                }
                else
                {
                    MessageBox.Show("With This Category Book Is There !");
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void updateCategory_btn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                string result = client.updateCategory(ID, categoryName.Text.ToString());
                if (result == "Record Updated Successfully !")
                {
                    BindGridCategory();
                    MessageBox.Show("Category Updated Successfully!");
                    addCategory_btn.Enabled = true;
                    ClearCategory();
                }
                else
                {
                    MessageBox.Show("Category Not Updated!");
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        
    }
}
