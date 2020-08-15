using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WRD_Sploit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://bst.gg/ezttwb");
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            if (flatTextBox1.Text == "1234cap")
            {
                MessageBox.Show("Thanks for using this Exploit!");
                this.Hide();
                Form2 main = new Form2();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Key Try Again.");
            }
        }
    }
}
