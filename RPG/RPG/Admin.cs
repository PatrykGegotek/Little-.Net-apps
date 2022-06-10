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
    public partial class Admin : Form
    {
        List<User> users;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            readUsers();
        }

        private void readUsers()
        {
            users = Authentication.getUsers();

            int columnCount = 3;
            int rowCount = users.Count;

            this.Controls.Remove(this.layout);
            this.layout = new TableLayoutPanel();
            this.layout.Enabled = true;
            this.layout.Visible = true;
            this.layout.Location = new Point(44, 12);
            this.Controls.Add(this.layout);
            this.layout.Size = new System.Drawing.Size(300, rowCount * 40);
            this.Size = 
                new Size(layout.Width + 2 * layout.Location.X + 120, layout.Height + layout.Location.X + 120);

            this.layout.ColumnCount = columnCount;
            this.layout.RowCount = rowCount;

            this.layout.ColumnStyles.Clear();
            this.layout.RowStyles.Clear();

            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                    (System.Windows.Forms.SizeType.Percent, 20));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                    (System.Windows.Forms.SizeType.Percent, 40));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                    (System.Windows.Forms.SizeType.Percent, 40));

            for (int i = 0; i < rowCount; i++)
            {
                this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle
                    (System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                Label label = new Label();
                label.AutoSize = false;
                label.Dock = DockStyle.Fill;
                label.Text = users[i].Name;
                label.TextAlign = ContentAlignment.MiddleCenter;
                layout.Controls.Add(label, 0, i);

                UserButton button = new UserButton(users[i]);
                button.Dock = DockStyle.Fill;
                button.Text = "Edit permissions";
                layout.Controls.Add(button, 1, i);
                button.Click += editUser;

                UserButton button2 = new UserButton(users[i]);
                button2.Dock = DockStyle.Fill;
                button2.Text = "Delete";
                layout.Controls.Add(button2, 2, i);
                button2.Click += removeUser;
            }
        }

        private void editUser(object sender, EventArgs e)
        {
            User user = ((UserButton)sender).user;
            EditUser editUser = new EditUser(user);
            editUser.ShowDialog();
        }

        private void removeUser(object sender, EventArgs e)
        {
            User user = ((UserButton)sender).user;
            foreach(Category cat in Essentials.getCategoryByCreatorID(user.ID))
            {
                Essentials.removeCategory(cat);
            }
            Authentication.removeUser(user);
            readUsers();
        }

        private void manager_Click(object sender, EventArgs e)
        {
            ViewCategories viewCategories = new ViewCategories();
            viewCategories.Show();
            this.Hide();
            viewCategories.Closed += (s, args) => this.Close();
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            CreateUser cu = new CreateUser();
            cu.ShowDialog();
            readUsers();
        }
    }

    class UserButton: Button
    {
        public User user;

        public UserButton(User user)
        {
            this.user = user;
        }
    }
}
