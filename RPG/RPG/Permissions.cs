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
    public partial class Permissions : Form
    {
        List<Permission> permissions;
        PermissionsView perView;
        public Permissions()
        {
            InitializeComponent();
        }

        public Permissions(PermissionsView perView)
        {
            this.perView = perView;
            InitializeComponent();
        }

        private void Permissions_Load(object sender, EventArgs e)
        {
            permissions = Authentication.getPermissions();
            foreach (Permission permission in permissions)
            {
                list.Items.Add(permission.Name);
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Permission permission = permissions[list.SelectedIndex];
            if(!perView.permissions.Contains(permission))
                Authentication.addPermissionToUser(perView.user, permission);
            this.Close();
        }

        
    }
}
