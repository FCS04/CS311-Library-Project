using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class frmaccounts : Form
    {
        public frmaccounts()
        {
            InitializeComponent();
        }

        private void frmaccounts_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = accounts.GetData("SELECT * FROM tbl_accounts ORDER BY username");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["password"].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR on frmAccounts_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
