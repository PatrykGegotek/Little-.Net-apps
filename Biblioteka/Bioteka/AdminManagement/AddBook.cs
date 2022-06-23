using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BorrowManagement;

namespace Library.AdminManagement
{
    public partial class AddBook : Form
    {
        List<TextBox> textBoxes = new List<TextBox>();
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            fillLayout();
        }

        private void fillLayout()
        {
            String[] header = { "Title", "Author", "Category", "Cost", "Currency", "Pages"};
            int width = layout.Width;

            foreach(String text in header)
            {
                Label label = new Label();
                label.AutoSize = false;
                label.Text = text;
                label.Size = new System.Drawing.Size(width / 2 - 10, 30);
                label.TextAlign = ContentAlignment.MiddleLeft;
                layout.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Size = new System.Drawing.Size(width / 2 - 10, 30);
                textBoxes.Add(textBox);
                layout.Controls.Add(textBox);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            List<String> str = new List<String>();

            foreach(TextBox textBox in textBoxes)
            {
                if(textBox.Text.Trim() == "")
                {
                    MessageBox.Show("All fields must be filled in");
                    return;
                }
                str.Add(textBox.Text.Trim());
            }

            int catID = LibraryDB.getCategoryID(str[2]);

            Book book = new Book
            {
                Title = str[0],
                Author = str[1],
                Category = catID,
                Cost = Int16.Parse(str[3]),
                Currency = str[4],
                Pages = Int16.Parse(str[5]),
            };

            LibraryDB.addBook(book);
            this.Close();
        }
    }
}
