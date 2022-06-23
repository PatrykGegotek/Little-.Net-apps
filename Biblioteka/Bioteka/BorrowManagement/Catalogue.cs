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
using Library.AdminManagement;

namespace Library.BorrowManagement
{
    public partial class Catalogue : Form
    {
        List<Book> books;
        List<Book> borrowedBooks;
        List<Book> notifiedBooks = new List<Book>();
        List<Category> categories;
        Dictionary<string, int> categoriesDict;
        static List<BorrowButton> borrowButtonList = new List<BorrowButton>();
        User user;
        public Catalogue(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Catalogue_Load(object sender, EventArgs e)
        {
            books = LibraryDB.getAllBooks();
            loadCategories();
            loadLayout();
            loadFilters();
            if (user.Type == 1)
            {
                filters.Visible = false;
                addNew.Click += addBook;
            }
            else addNew.Visible = false;
        }

        private void loadCategories()
        {
            categories = LibraryDB.getAllCategories();
            categoriesDict = new Dictionary<string, int>();
            foreach (Category category in categories)
            {
                categoriesDict.Add(category.Name, category.ID);
            }
        }

        private void loadLayout()
        {
            String[] header = {"Title", "Author", "Category", "Cost", "Currency", "Pages", " "};
            borrowedBooks = LibraryDB.getUsersBooks(user);
            notifiedBooks = LibraryDB.getUsersNotified(user);
            int width = layout.Width;

            this.layout.Controls.Clear();

            foreach(String label in header)
            {
                Label lbl = new Label();
                lbl.Text = label;
                lbl.AutoSize = false;
                lbl.Size = new System.Drawing.Size(width / 7 - 10, 40);
                this.layout.Controls.Add(lbl);
            }
            listBooks(width);
        }

        private void loadFilters()
        {
            //categories
            foreach(Category category in categories)
            {
                categoriesList.Items.Add(category.Name);
            }

            //currencies
            currenciesList.Items.Add("PLN");
            currenciesList.Items.Add("Euro");
            currenciesList.SelectedIndex = 0;
        }

        private void borrowBook(object sender, EventArgs e)
        {
            if(borrowedBooks.Count() >= 3)
            {
                MessageBox.Show("Cannot borrow more than 3 books at a time");
                return;
            }
            BorrowButton button = (BorrowButton)sender;
            Book book = button.book;
            LibraryDB.borrowBook(user, book);
            loadLayout();
        }

        private void notifyBook(object sender, EventArgs e)
        {
            BorrowButton button = (BorrowButton)sender;
            Book book = button.book;
            LibraryDB.notifyBook(user, book);
            loadLayout();
        }

        private void unNotifyBook(object sender, EventArgs e)
        {
            BorrowButton button = (BorrowButton)sender;
            Book book = button.book;
            LibraryDB.unNotifyBook(user, book);
            loadLayout();
        }

        private void removeBook(object sender, EventArgs e)
        {
            BorrowButton button = (BorrowButton)sender;
            LibraryDB.removeBook(books.Find(d => d.ID == button.book.ID));
            books = LibraryDB.getAllBooks();
            loadLayout();
        }

        private void loadBooks()
        {
            books = LibraryDB.getAllBooks();
        }

        private void addBook(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Hide();
            addBook.Closed += (s, args) => this.Show();
            addBook.Closed += (s, args) => this.loadCategories();
            addBook.Closed += (s, args) => this.loadBooks();
            addBook.Closed += (s, args) => this.loadLayout();
        }

        private void listBooks(int width)
        {
            foreach (Book book in books)
            {
                Label lbl = new Label();
                lbl.Text = book.Title;
                lbl.AutoSize = false;
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lbl.Size = new System.Drawing.Size(width / 7 - 10, 40);
                this.layout.Controls.Add(lbl);

                lbl = new Label();
                lbl.Text = book.Author;
                lbl.AutoSize = false;
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lbl.Size = new System.Drawing.Size(width / 7 - 10, 40);
                this.layout.Controls.Add(lbl);

                lbl = new Label();
                lbl.Text = categories.Find(d => d.ID == book.Category).Name;
                lbl.AutoSize = false;
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lbl.Size = new System.Drawing.Size(width / 7 - 10, 40);
                this.layout.Controls.Add(lbl);

                lbl = new Label();
                lbl.Text = book.Cost.ToString();
                lbl.AutoSize = false;
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lbl.Size = new System.Drawing.Size(width / 7 - 10, 40);
                this.layout.Controls.Add(lbl);

                lbl = new Label();
                lbl.Text = book.Currency;
                lbl.AutoSize = false;
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lbl.Size = new System.Drawing.Size(width / 7 - 10, 40);
                this.layout.Controls.Add(lbl);

                lbl = new Label();
                lbl.Text = book.Pages.ToString();
                lbl.AutoSize = false;
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lbl.Size = new System.Drawing.Size(width / 8 - 10, 40);
                this.layout.Controls.Add(lbl);

                BorrowButton button = new BorrowButton(book);
                button.Size = new System.Drawing.Size(width / 8 - 10, 40);
                if (user.Type == 1 && book.Isborrowed == 1)
                {
                    button.Text = "Remove (borrowed)";
                    button.Click += removeBook;
                }
                else if(user.Type == 1)
                {
                    button.Text = "Remove";
                    button.Click += removeBook;
                }
                else if (notifiedBooks.Contains(book))
                {
                    button.Text = "Un-notify";
                    button.Click += unNotifyBook;
                }
                else if (book.Isborrowed == 1)
                {
                    button.Text = "Notify";
                    button.Click += notifyBook;
                    if (borrowedBooks.Contains(book)) button.Enabled = false;
                }
                else
                {
                    button.Text = "Borrow";
                    button.Click += borrowBook;
                }
                this.layout.Controls.Add(button);
                if(Login.currentUser.Type == -1) button.Enabled = false;
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            books = LibraryDB.getAllBooks();
            HashSet<int> categories = new HashSet<int>();

            foreach(var item in categoriesList.CheckedItems) categories.Add(categoriesDict[item.ToString()]);

            int minVal, maxVal, minPages, maxPages;
            try
            {
                minVal = this.minVal.Text.Trim() == "" ? 0 : Int16.Parse(this.minVal.Text);
                maxVal = this.maxVal.Text.Trim() == "" ? 10000 : Int16.Parse(this.maxVal.Text);
                minPages = this.minPages.Text.Trim() == "" ? 0 : Int16.Parse(this.minPages.Text);
                maxPages = this.maxPages.Text.Trim() == "" ? 10000 : Int16.Parse(this.maxPages.Text);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Wrong input!");
                return;
            }

            books = books.FindAll(x => categories.Contains(x.Category));
            books = books.FindAll(x => x.Pages >= minPages && x.Pages <= maxPages);

            String curr;
            try
            {
                curr = currenciesList.SelectedItem.ToString();
                
            }
            catch (NullReferenceException ex) 
            {
                MessageBox.Show("Must choose currency!");
                return;
            }

            double multiplier = curr.Trim() == "PLN" ? 4.65 : 0.22;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Currency.Trim() != curr)
                {
                    books[i].Currency = curr;
                    books[i].Cost *= multiplier;
                }
            }

            books = books.FindAll(x => x.Cost >= minVal && x.Cost <= maxVal);

            loadLayout();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            books = LibraryDB.getAllBooks();
            loadLayout();
        }
    }
}
