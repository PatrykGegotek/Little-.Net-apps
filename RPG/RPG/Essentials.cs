using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Essentials
    {
        static public RPG_DB ctx = new RPG_DB();

        public static int getHighestAttributeOfCategory()
        {
            var a = (from attCat in ctx.AttributeOfCategory
                     orderby attCat.ID descending
                     select attCat);
            if (a != null) return a.First().ID + 1;
            return 0;
        }

        public static int getHighestCategory()
        {
            var a = (from cat in ctx.Category
                     orderby cat.ID descending
                     select cat);
            if (a.Count() != 0) return a.First().ID + 1;
            return 0;
        }

        public static int getHighestArtifact()
        {
            var a = (from art in ctx.Artifact
                     orderby art.ID descending
                     select art);
            if (a.Count() != 0) return a.First().ID + 1;
            return 0;
        }

        public static int getHighestAttributeOfArtifact()
        {
            var a = (from attArt in ctx.AttributeOfArtifact
                     orderby attArt.ID descending
                     select attArt);
            if (a.Count() != 0) return a.First().ID + 1;
            return 0;
        }

        public static List<Attribute> getAllAttributes()
        {
            return (from att in ctx.Attribute orderby att.ID select att).ToList();
        }
        public static Category getCategoryByName(String name)
        {
            var query = from cat in ctx.Category
                        where cat.Name == name
                        select cat;
            return query.Single();
        }

        public static Category getCategoryByID(int ID)
        {
            var query = from cat in ctx.Category
                        where cat.ID == ID
                        select cat;
            return query.Single();
        }

        public static List<Category> getCategoryByCreatorID(int ID)
        {
            var query = from cat in ctx.Category
                        where cat.CreatorID == ID
                        select cat;
            return query.ToList();
        }


        public static List<Attribute> getAttributesOfCategoryByID(int ID)
        {
            return (from att in ctx.Attribute
                    join catAtt in ctx.AttributeOfCategory
                    on att.ID equals catAtt.AttributeID
                    join cat in ctx.Category
                    on catAtt.CategoryID equals ID
                    select att).Distinct().ToList();
        }

        public static List<ValueOfArtifact> getAttributesAndValuesOfArtifact(Artifact artifact)
        {
            var query = (from attArt in ctx.AttributeOfArtifact
                         where attArt.ArtifactID == artifact.ID
                         select attArt).ToList();

            List<ValueOfArtifact> values = new List<ValueOfArtifact>();
            foreach(AttributeOfArtifact attArt in query)
            {
                ValueOfArtifact v = new ValueOfArtifact(getAttributeByID(attArt.AttributeID), attArt);
                values.Add(v);
            }

            return values;
        }

        public static List<AttributeOfArtifact> getAttributesOfArtifact (Artifact artifact)
        {
            return (from attrArt in ctx.AttributeOfArtifact
                    where attrArt.ArtifactID == artifact.ID
                    select attrArt).ToList();
        }

        public static Attribute getAttributeByID(int ID)
        {
            return (from att in ctx.Attribute
                   where att.ID == ID
                   select att).First();
        }

        public static void setValueOfAttributeofArtifact(AttributeOfArtifact attArt, String val)
        {
            (from att in ctx.AttributeOfArtifact
                    where att == attArt
                    select att).Single().Value = val;
            ctx.SaveChanges();
        }

        public static List<Artifact> getArtifactsofCategoryByID(int ID)
        {
            return (from art in ctx.Artifact
                    where art.CategoryID == ID
                    select art).Distinct().ToList();
        }


        public static void DeleteAttributeOfCategory(int catID, int attID)
        {
            var query = from attcat in ctx.AttributeOfCategory
                        where attcat.CategoryID == catID && attcat.AttributeID == attID
                        select attcat;
            

            ctx.AttributeOfCategory.Remove(query.Single());
            
            ctx.SaveChanges();
        }

        public static void removeCategory(Category category)
        {
            var attrOfCat = from attCat in ctx.AttributeOfCategory
                        where attCat.CategoryID == category.ID
                        select attCat;
            var artifacts = getArtifactsofCategoryByID(category.ID);
            List<AttributeOfArtifact> attrOfArt = new List<AttributeOfArtifact>();

            foreach (var artifact in artifacts)
            {
                removeArtifact(artifact);
            }

            ctx.AttributeOfCategory.RemoveRange(attrOfCat);
            ctx.Category.Remove(Essentials.getCategoryByName(category.Name));
            ctx.SaveChanges();
        }

        static public void removeArtifact(Artifact artifact)
        {
            ctx.AttributeOfArtifact.RemoveRange(getAttributesOfArtifact(artifact));
            ctx.Artifact.Remove(artifact);
            ctx.SaveChanges();
        }

        public static void addNewArtifact(List<Attribute> attributes, List<String> strings, String name, Category category, int creatorID)
        {
            int ID = getHighestArtifact();
            Artifact artifact = new Artifact()
            {
                ID = ID,
                Name = name,
                CategoryID = category.ID,
                CreatorID = creatorID
            };
            ctx.Artifact.Add(artifact);

            int artID = getHighestAttributeOfArtifact();
            for (int i = 0; i < attributes.Count; i++, artID++)
            {
                AttributeOfArtifact attributeOf = new AttributeOfArtifact()
                {
                    ID = artID,
                    AttributeID = attributes[i].ID,
                    ArtifactID = ID,
                    Value = strings[i]
                };
                ctx.AttributeOfArtifact.Add(attributeOf);
            }
            ctx.SaveChanges();
        }

        
    }

    public class ValueOfArtifact
    {
        public Attribute attribute;
        public AttributeOfArtifact attArt;

        public ValueOfArtifact(Attribute attribute, AttributeOfArtifact attArt)
        {
            this.attribute = attribute;
            this.attArt = attArt;
        }
    }

}
