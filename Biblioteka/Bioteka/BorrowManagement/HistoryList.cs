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
using Library.UserManagement;

namespace Library.BorrowManagement
{
    public partial class HistoryList : Form
    {
        User user;
        public HistoryList(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void HistoryList_Load(object sender, EventArgs e)
        {
            fillLayout();
        }
        private void fillLayout()
        {
            int width = layout.Width;
            List<BorrowedBook> history = LibraryDB.getHistory(user);

            foreach(BorrowedBook borrow in history)
            {
                Label label = new Label();
                label.Text = borrow.Title;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(width / 3 - 15, 50);
                layout.Controls.Add(label);

                label = new Label();
                label.Text = "Borrow date:\n" + borrow.borrow;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(width / 3 - 15, 50);
                layout.Controls.Add(label);

                label = new Label();
                label.Text = "Return date:\n" + borrow.ret;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(width / 3 - 15, 50);
                layout.Controls.Add(label);
            }
        }
    }
}
