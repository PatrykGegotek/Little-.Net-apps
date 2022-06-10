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
    public partial class PermissionsView : UserControl
    {
        public User user;
        public List<Permission> permissions;
        public PermissionsView()
        {
            InitializeComponent();
        }

        public PermissionsView(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void PermissionsView_Load(object sender, EventArgs e)
        {
            loadPerms();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Permissions permissions = new Permissions(this);
            permissions.ShowDialog();
            loadPerms();
        }

        private void loadPerms()
        {
            listBox1.Items.Clear();
            permissions = Authentication.getPermissionsByUserID(user.ID);
            foreach (Permission permission in permissions)
            {
                listBox1.Items.Add(permission.Name);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Permission perm = permissions[listBox1.SelectedIndex];
            Authentication.deletePerm(user, perm);
            loadPerms();
        }
    }
}
