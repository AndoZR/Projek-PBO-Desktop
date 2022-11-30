using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Pencatatan_Transaksi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="" && txtPassword.Text == "")
            {
                new DashBoard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Passwrod salah!");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
