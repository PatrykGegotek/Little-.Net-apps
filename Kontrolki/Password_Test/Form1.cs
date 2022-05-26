using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordCheck.PasswordCheck check = new PasswordCheck.PasswordCheck(passBox);
            this.Controls.Add(check);
            check.Location = new System.Drawing.Point(passBox.Location.X - 140, passBox.Location.Y + 50);
            check.Enabled = true;
            check.Anchor = AnchorStyles.Top;
            MinimumSize = new System.Drawing.Size(check.MinimumSize.Width, check.MinimumSize.Height + 100);

            Height += check.Height;
            Width = (Width > check.Width ? Width : check.Height + Width);

            check.Show();
        }
    }

}

