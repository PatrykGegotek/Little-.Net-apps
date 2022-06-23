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
    public partial class MainPage : Form
    {
        User user;
        List<Book> booksTonotify;
        public MainPage()
        {
            user = Login.currentUser;
            InitializeComponent();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            name.Text = user.Name;
            if (name.Text == "Guest")
            {
                history.Enabled = false;
                Borrowed.Enabled = false;
            }
            loadBook();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.currentUser = null;
        }

        private void cataloque_Click(object sender, EventArgs e)
        {
            Catalogue catalogue = new Catalogue(user);
            catalogue.Show();
            this.Hide();
            catalogue.Closed += (s, args) => this.Show();
        }

        private void Borrowed_Click(object sender, EventArgs e)
        {
            BorrowedList borrowedList = new BorrowedList(user);
            borrowedList.Show();
            this.Hide();
            borrowedList.Closed += (s, args) => this.Show();
        }

        private void history_Click(object sender, EventArgs e)
        {
            HistoryList historyList = new HistoryList(user);
            historyList.Show();
            this.Hide();
            historyList.Closed += (s, args) => this.Show();
        }
        private void loadBook()
        {
            booksTonotify = LibraryDB.getUsersNotified(user);
            List<Book> books = LibraryDB.getAllBooks();
            books = books.FindAll(d => d.Isborrowed == 0);

            foreach(Book book in booksTonotify)
            {
                if(books.Contains(book))
                {
                    LibraryDB.unNotifyBook(user, book);
                    MessageBox.Show("Book '" + book.Title.Trim() + "' is now available.");
                }
            }
        }
    }
}
