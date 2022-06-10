using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(name.Text != "" && password.Text != "")
            {
                String encrypted = Authentication.getPassword(name.Text);
                if (encrypted == "") MessageBox.Show("Wrong user name");
                if (encrypted.Equals(Authentication.hash(password.Text))) {
                    initializeUser(name.Text);

                    if(name.Text == "Admin")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                        admin.Closed += (s, args) => this.Close();
                    }
                    else
                    {
                        ViewCategories viewCategories = new ViewCategories();
                        viewCategories.Show();
                        this.Hide();
                        viewCategories.Closed += (s, args) => this.Close();
                    }
                }
                else MessageBox.Show("Wrong password");
            }
        }

        private void initializeUser(String userName)
        {
            CurrentUser.user = Authentication.getUserByName(userName);
            List<Permission> permissions = Authentication.getPermissionsByUserID(CurrentUser.user.ID);
            foreach (var item in permissions)
            {
                CurrentUser.permissions.Add(item.ID);
            }
        }
    }
}
