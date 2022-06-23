using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Library.BorrowManagement
{
    internal class BorrowButton: Button
    {
        public Book book;
        public BorrowButton(Book book)
        {
            this.book = book;
        }
    }
}
