using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Library.BorrowManagement;
using Library.AdminManagement;

namespace Library.UserManagement
{
    public partial class Login : Form
    {
        static public User currentUser = null;
        public Login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            String Name = name.Text;
            User user = Auth.getUser(Name);
            if (user == null) MessageBox.Show("Wrong user name");
            else if (user.Password.Trim().Equals(Auth.hash(password.Text).Trim()))
            {
                currentUser = user;
                if(user.Type == 1)
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                    admin.Closed += (s, args) => this.Show();
                }
                else
                {
                    showMain();
                }
            }
            else MessageBox.Show("Wrong password");
            name.Text = "";
            password.Text = "";
        }

        private void signup_Click(object sender, EventArgs e)
        {
            CreateUser create = new CreateUser();
            create.ShowDialog();
        }

        static private User guest()
        {
            return new User
            {
                Name = "Guest",
                Password = "",
                Type = -1,
                Borrowed = 0
            };
        }

        private void logasguest_Click(object sender, EventArgs e)
        {
            currentUser = guest();
            showMain();
        }

        private void showMain()
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
            mainPage.Closed += (s, args) => this.Show();
        }
    }
}
