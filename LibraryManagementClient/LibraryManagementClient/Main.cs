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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void manageBooks_btn_Click(object sender, EventArgs e)
        {
            Books booksForm = new Books();
            booksForm.Show();
        }

        private void manageCategories_btn_Click(object sender, EventArgs e)
        {
            Category categoryForm = new Category();
            categoryForm.Show();
        }
    }
}
