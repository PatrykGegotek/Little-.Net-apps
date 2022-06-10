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
    
    public partial class EditUser : Form
    {
        User user;
        public EditUser(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            PermissionsView view = new PermissionsView(user);
            this.Controls.Add(view);
            view.Location = new Point(10,10);
            view.Enabled = true;
            view.Visible = true;
        }
    }
}
