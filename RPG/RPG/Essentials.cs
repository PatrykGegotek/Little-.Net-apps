using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Essentials
    {
        static RPG_DB ctx = new RPG_DB();

        public static List<Attribute> getAllAttributes()
        {
            return (from att in ctx.Attribute orderby att.ID select att).ToList();
        }
        public static Category FindCategoriesID(String name)
        {
            var query = from cat in ctx.Category
                        where cat.Name == name
                        select cat;
            return query.Single();
        }

        public static int howManyElements_Attribute()
        {
            return (from cat in ctx.Attribute select cat).Count();
        }

        public static List<Attribute> getCategoryAttributes(int ID)
        {
            return (from att in ctx.Attribute
                    join catAtt in ctx.AttributeOfCategory
                    on att.ID equals catAtt.AttributeID
                    join cat in ctx.Category
                    on catAtt.CategoryID equals ID
                    orderby att.ID ascending
                    select att).Distinct().ToList();
        }

        public static void DeleteAttributeFromCategory(int catID, int attID)
        {
            var query = from attcat in ctx.AttributeOfCategory
                        where attcat.CategoryID == catID && attcat.AttributeID == attID
                        select attcat;

            ctx.AttributeOfCategory.Remove(query.Single());
            ctx.SaveChanges();
        }
    }
}
