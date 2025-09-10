using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticket_management;

namespace Library_Project
{
    public partial class frmLibraryManage : Form
    {
        public frmLibraryManage()
        {
            InitializeComponent();
        }

        Class1 logs = new Class1("127.0.0.1", "cs311_library_proj", "benidigs", "aquino");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
