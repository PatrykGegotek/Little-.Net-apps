using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RPG
{
    public class Authentication
    {
        static RPG_DB ctx = new RPG_DB();
        public static string hash(String text)
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

        public static String getPassword(String name)
        {
            var query = (from user in ctx.User
                         where user.Name == name
                         select user);
            if (query.Count() == 0) return "";
            return query.First().Password;
        }

        public static void createUser(String name, String password)
        {
            User user = new User()
            {
                Name = name,
                Password = hash(password),
                ID = getHighestUser()
            };

            ctx.User.Add(user);
            ctx.SaveChanges();
        }

        public static void removeUser(User user)
        {
            foreach (UserPermission perm in getUserPermissionsByUserID(user.ID))
            {
                ctx.UserPermission.Remove(perm);
            }
            ctx.User.Remove(user);
            ctx.SaveChanges();
        }

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

        public static List<Permission> getPermissionsByUserID(int ID)
        {
            return (from perm in ctx.Permission
                    join UP in ctx.UserPermission
                    on perm.ID equals UP.PermissionID
                    join user in ctx.User
                    on UP.UserID equals user.ID
                    where user.ID == ID
                    select perm).ToList();
        }

        public static List<UserPermission> getUserPermissionsByUserID(int ID)
        {
            return (from perm in ctx.UserPermission
                    where perm.UserID == ID
                    select perm).ToList();
        }

        public static List<Permission> getPermissions()
        {
            return (from permission in ctx.Permission select permission).ToList();
        }

        public static List<User> getUsers()
        {
            return (from user in ctx.User select user).ToList();
        }

        public static void addPermissionToUser(User user, Permission permission)
        {
            UserPermission userPermission = new UserPermission()
            {
                ID = getHighestUserPerm(),
                UserID = user.ID,
                PermissionID = permission.ID
            };

            ctx.UserPermission.Add(userPermission);
            ctx.SaveChanges();
        }

        public static void deletePerm(User user, Permission permission)
        {
            var query = (from perm in ctx.UserPermission
                         where perm.UserID == user.ID && perm.PermissionID == permission.ID
                         select perm).Single();

            ctx.UserPermission.Remove(query);
            ctx.SaveChanges();  
        }

        public static int getHighestUserPerm()
        {
            var a = (from up in ctx.UserPermission
                     orderby up.ID descending
                     select up);
            if (a.Count() != 0) return a.First().ID + 1;
            return 0;
        }

        public static int getHighestUser()
        {
            var a = (from up in ctx.User
                     orderby up.ID descending
                     select up);
            if (a.Count() != 0) return a.First().ID + 1;
            return 0;
        }
    }
}
