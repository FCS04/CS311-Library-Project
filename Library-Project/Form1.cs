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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int score;
        private string message;
        private void button1_Click(object sender, EventArgs e)
        {
            score = 100;
            message = "Hello, World!";
            MessageBox.Show(message + " Your score is: " + score);
        }
    }
}
