using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using Library.BorrowManagement;
using Library.UserManagement;

namespace Library.AdminManagement
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            fillLayout();
        }

        private void fillLayout()
        {
            List<User> users = UserDB.getUsers();
            int width = layout.Width;

            foreach(User user in users)
            {
                Label label = new Label();
                label.Text = user.Name;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(width / 3 - 15, 50);
                layout.Controls.Add(label);

                UserButton button = new UserButton(user);
                button.Text = "Borrowed books";
                button.Size = new Size(width / 3 - 15, 50);
                button.Click += borrowedBooks;
                layout.Controls.Add(button);

                button = new UserButton(user);
                button.Text = "History";
                button.Size = new Size(width / 3 - 15, 50);
                button.Click += history;
                layout.Controls.Add(button);
            }
        }

        private void borrowedBooks(object sender, EventArgs e)
        {
            User user = ((UserButton)sender).user;
            BorrowedList borrowedList = new BorrowedList(user);
            borrowedList.Show();
            this.Hide();
            borrowedList.Closed += (s, args) => this.Show();
        }

        private void history(object sender, EventArgs e)
        {
            User user = ((UserButton)sender).user;
            HistoryList historyList = new HistoryList(user);
            historyList.Show();
            this.Hide();
            historyList.Closed += (s, args) => this.Show();
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            Catalogue catalogue = new Catalogue(Login.currentUser);
            catalogue.Show();
            this.Hide();
            catalogue.Closed += (s, args) => this.Show();
        }
    }

    class UserButton : Button
    {
        public User user;
        public UserButton(User user)
        {
            this.user = user;
        }
    }
}
