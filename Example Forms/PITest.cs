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
    public partial class PITest : Form
    {
        string userID;
        string password;

        public PITest(string u, string p)
        {
            InitializeComponent();
            userID = u;
            password = p;
        }

        private void PITest_Load(object sender, EventArgs e)
        {
            lblUserID.Text = "User ID: " + userID;
            lblPassword.Text = "Password: " + password;
        }
    }
}
