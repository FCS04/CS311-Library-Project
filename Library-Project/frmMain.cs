using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Project
{
    public partial class frmMain : Form
    {
        private string username, usertype;
        public frmMain()
        {
            InitializeComponent();
            this.username = username;
        }

        private void bookManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooksManagement bookmanagementform = new frmBooksManagement(username);
            bookmanagementform.MdiParent = this;
            bookmanagementform.Show();
        }
    }
}
