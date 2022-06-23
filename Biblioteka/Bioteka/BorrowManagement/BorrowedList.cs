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
    public partial class BorrowedList : Form
    {
        User user;
        List<BorrowedBook> borrowed;
        public BorrowedList(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void BorrowedList_Load(object sender, EventArgs e)
        {
            fillLayout();
        }

        private void fillLayout()
        {
            layout.Controls.Clear();
            borrowed = LibraryDB.getBorrowedBooks(user);
            int width = layout.Width;


            foreach (BorrowedBook borrow in borrowed)
            {
                Label label = new Label();
                label.Text = borrow.Title;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(width / 5 - 15, 50);
                layout.Controls.Add(label);

                label = new Label();
                label.Text = "Borrow date:\n" + borrow.borrow;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(width / 5 - 15, 50);
                layout.Controls.Add(label);

                label = new Label();
                label.Text = "Return date:\n" + borrow.ret;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(width / 5 - 15, 50);
                layout.Controls.Add(label);

                Book book = LibraryDB.getBook(borrow.ID);

                BorrowButton button = new BorrowButton(book);
                button.Text = "Return";
                button.Size = new Size(width / 5 - 15, 50);
                button.Click += returnBook;
                layout.Controls.Add(button);

                button = new BorrowButton(book);
                button.Text = "Prolongate";
                button.Size = new Size(width / 5 - 15, 50);
                button.Click += prolongate;
                layout.Controls.Add(button);
            }
        }

        private void returnBook(object sender, EventArgs e)
        {
            BorrowButton button = (BorrowButton)sender;
            var bor = borrowed.Find(d => d.ID == button.book.ID);
            LibraryDB.returnBook(Login.currentUser, button.book, bor.borrow);
            fillLayout();
        }

        private void prolongate(object sender, EventArgs e)
        {
            BorrowButton button = (BorrowButton)sender;
            var bor = borrowed.Find(d => d.ID == button.book.ID);
            if(bor.ret.CompareTo(DateTime.Now.AddDays(7)) <= 0)
            {
                LibraryDB.prolongate(button.book);
                MessageBox.Show("prolongated");
            }
            else
            {
                MessageBox.Show("You can only prelongate when you have less than 7 days remaining.");
            }
            fillLayout();
        }
    }

    public class BorrowedBook
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime borrow { get; set; }
        public DateTime ret { get; set; }

        public BorrowedBook() {}

        public BorrowedBook(int iD, string title, DateTime borrow, DateTime ret)
        {
            ID = iD;
            Title = title;
            this.borrow = borrow;
            this.ret = ret;
        }
    }
}
