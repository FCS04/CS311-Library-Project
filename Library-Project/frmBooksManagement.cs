using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticket_management;

namespace Library_Project
{
    public partial class frmBooksManagement : Form
    {
        private string username;
        public frmBooksManagement(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        Class1 books = new Class1("127.0.0.1", "cs311_library_proj", "benidigs", "aquino");
        private void frmBooksManagement_Load_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = books.GetData("SELECT * FROM tbl_books ORDER BY BookID");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["password"].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR on frmLibraryManage_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBooks addBooksForm = new frmAddBooks();
            addBooksForm.FormClosed += (s, args) =>
            {
                frmBooksManagement_Load(sender, e);
            };
            addBooksForm.Show();
        }

        private int row;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR on datagridview1_cellclick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR on btnUpdateBook_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
