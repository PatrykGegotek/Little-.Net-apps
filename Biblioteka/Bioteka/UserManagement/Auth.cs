using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Library.UserManagement
{
    public class Auth
    {
        static private LibraryEntity ctx = new LibraryEntity();
        static public string hash(String text)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));
                StringBuilder stringbuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringbuilder.Append(bytes[i].ToString("x2"));
                }
                return stringbuilder.ToString();
            }
        }

        

        static public User getUser(String name)
        {
            return (from user in ctx.User
                    where user.Name == name
                    select user).FirstOrDefault();
        }

        public static void createUser(String name, String password)
        {
            User user = new User()
            {
                Name = name,
                Password = hash(password),
            };

            ctx.User.Add(user);
            ctx.SaveChanges();
        }
        /*
        public static User getUserByName(String name)
        {
            return (from user in ctx.User
                    where user.Name == name
                    select user).FirstOrDefault();
        }

        public static User getUserByID(int ID)
        {
            return (from user in ctx.User
                    where user.ID == ID
                    select user).FirstOrDefault();
        }
        */
        public static List<User> getUsers()
        {
            return (from user in ctx.User select user).ToList();
        }
    }
}
