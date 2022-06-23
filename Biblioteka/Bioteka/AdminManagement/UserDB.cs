using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AdminManagement
{
    internal class UserDB
    {
        static private LibraryEntity ctx = new LibraryEntity();
        static public List<User> getUsers()
        {
            return (from user in ctx.User
                    where user.Type == 0
                    select user).ToList();
        }
    }
}
