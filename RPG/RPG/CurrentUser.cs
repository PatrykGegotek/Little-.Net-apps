using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class CurrentUser
    {
        static public User user;
        static public List<int> permissions = new List<int>();

        static public bool hasPerm(PermissionType permission)
        {
            return permissions.Contains((int)permission);
        }
    }

    public enum PermissionType
    {
        addCategory = 0,
        editCategory,
        deleteCategory,
        addArtifact,
        editArtifact,
        deleteArtifact,
        addAttribute
    }
}
