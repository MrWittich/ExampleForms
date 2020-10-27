using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            if(textBox1.Text == "cwittich" && textBox2.Text == "12345")
            {
                this.Hide();
                LoggedIn l = new LoggedIn();
                l.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID and Password.");
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
}
