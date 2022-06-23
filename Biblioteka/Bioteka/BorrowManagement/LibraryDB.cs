using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library.BorrowManagement
{
    internal class LibraryDB
    {
        static private LibraryEntity ctx = new LibraryEntity();

        static public List<Book> getAllBooks()
        {
            ctx.Dispose();
            ctx = new LibraryEntity();
            return (from book in ctx.Book
            select book).ToList();
        }

        static public Book getBook(int ID)
        {
            return (from book in ctx.Book
                    where book.ID == ID
                    select book).FirstOrDefault();
        }

        static public List<Category> getAllCategories()
        {
            return (from cat in ctx.Category
                    select cat).ToList();
        }

        static public void borrowBook(User user, Book book)
        {
            user.Borrowed += 1;
            book.Isborrowed = 1;

            BorrowedBooks borrowed = new BorrowedBooks()
            {
                BookID = book.ID,
                UserID = user.ID,
                BorrowDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddMonths(1)
            };

            ctx.BorrowedBooks.Add(borrowed);
            ctx.SaveChanges();
        }

        static public void returnBook(User user, Book book, DateTime borrowTime)
        {
            book.Isborrowed = 0;
            user.Borrowed -= 1;

            BorrowedBooks borrowed = (from bor in ctx.BorrowedBooks
                                      where bor.BookID == book.ID
                                 select bor).SingleOrDefault();

            ctx.BorrowedBooks.Remove(borrowed);

            History history = new History()
            {
                UserID = user.ID,
                BookID = book.ID,
                BorrowDate = borrowTime,
                ReturnDate = DateTime.Now
            };

            ctx.History.Add(history);
            ctx.SaveChanges();
        }

        static public List<BorrowedBook> getBorrowedBooks(User user)
        {
            List<BorrowedBook> query = (from book in ctx.Book
                    join borrow in ctx.BorrowedBooks
                    on book.ID equals borrow.BookID
                    join user2 in ctx.User
                    on borrow.UserID equals user2.ID
                    where user2.ID == user.ID
                    select new BorrowedBook() 
                    {
                        ID = book.ID, 
                        Title = book.Title, 
                        borrow = borrow.BorrowDate, 
                        ret = borrow.ReturnDate 
                    }
                    ).ToList();
            return query;
        }

        

        static public void prolongate (Book book)
        {
            var borrowed = (from bor in ctx.BorrowedBooks
                            where bor.BookID == book.ID
                         select bor).SingleOrDefault();

            borrowed.ReturnDate = DateTime.Now.AddMonths(1);
            ctx.SaveChanges();
        }

        static public List<BorrowedBook> getHistory(User user)
        {
            return (from history in ctx.History
                    join book in ctx.Book
                    on history.BookID equals book.ID
                    where history.UserID == user.ID
                    select new BorrowedBook()
                    {
                        ID = book.ID,
                        Title = book.Title,
                        borrow = history.BorrowDate,
                        ret = history.ReturnDate

                    }).ToList();
        }

        static public int getCategoryID(String name)
        {
            var query = (from category in ctx.Category
                         where category.Name == name
                         select category).SingleOrDefault();

            if (query != null) return query.ID;
            else
            {
                Category category = new Category()
                {
                    Name = name
                };

                ctx.Category.Add(category);
                ctx.SaveChanges();
                return getCategoryID(name);
            }

        }

        static public void addBook(Book book)
        {
            ctx.Book.Add(book);
            ctx.SaveChanges();
        }

        static public void removeBook(Book book)
        {
            if(book.Isborrowed == 1)
            {
                BorrowedBooks borr = (from bor in ctx.BorrowedBooks
                                      where bor.BookID == book.ID
                                 select bor).SingleOrDefault();

                List<History> history = (from his in ctx.History
                                  where his.BookID == book.ID
                                  select his).ToList();

                int userID = borr.UserID;

                User user = (from us in ctx.User
                             where us.ID == userID
                             select us).SingleOrDefault();


                user.Borrowed -= 1;
                ctx.History.RemoveRange(history);
                ctx.BorrowedBooks.Remove(borr);
                ctx.SaveChanges();
            }
            ctx.Book.Remove(book);
            ctx.SaveChanges();
        }

        static public List<Book> getUsersBooks(User user)
        {
            return (from book in ctx.Book
                    join bor in ctx.BorrowedBooks
                    on book.ID equals bor.BookID
                    where bor.UserID == user.ID
                    select book).ToList();
        }

        static public List<Book> getUsersNotified(User user)
        {
            return (from book in ctx.Book
                    join notified in ctx.Notified
                    on book.ID equals notified.BookID
                    where notified.UserID == user.ID
                    select book).ToList();
        }

        static public void notifyBook(User user, Book book)
        {
            Notified notified = new Notified()
            {
                UserID = user.ID,
                BookID = book.ID,
            };

            ctx.Notified.Add(notified);
            ctx.SaveChanges();
        }

        static public void unNotifyBook(User user, Book book)
        {
            var not = (from notified in ctx.Notified
                       where notified.UserID == user.ID
                       && notified.BookID == book.ID
                       select notified).SingleOrDefault();

            ctx.Notified.Remove(not);
            ctx.SaveChanges();
        }
    }
}
