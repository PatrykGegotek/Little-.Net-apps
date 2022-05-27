using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Basics
    {
        public static void addCategories()
        {
            var context = new RPG_DB();
            int count = context.Category.Count();
            Category[] cats = new Category[10];
            cats[0] = new Category()
            {
                ID = count++,
                Name = "Dragon"
            };
            cats[1] = new Category()
            {
                ID = count++,
                Name = "Spider"
            };
            cats[2] = new Category()
            {
                ID = count++,
                Name = "Warrior"
            };
            cats[3] = new Category()
            {
                ID = count++,
                Name = "Feral Dog"
            };
            cats[4] = new Category()
            {
                ID = count++,
                Name = "Zombie"
            };
            cats[5] = new Category()
            {
                ID = count++,
                Name = "Player"
            };
            cats[6] = new Category()
            {
                ID = count++,
                Name = "Cave"
            };
            cats[7] = new Category()
            {
                ID = count++,
                Name = "Tree"
            };
            cats[8] = new Category()
            {
                ID = count++,
                Name = "Spear"
            };
            cats[9] = new Category()
            {
                ID = count++,
                Name = "Axe"
            };
            foreach (Category c in cats)
            {
                context.Category.Add(c);
            }
            context.SaveChanges();
        }

        public static void addArtifacts()
        {
            /*
            var context = new RPG_Database();
            Artifact[] artifacts = new Artifact[6];
            artifacts[0] = new Artifact()
            {
                Id = 0,
                Name = "Spider",
                CategoryID = Essentials.FindCategoriesID("Enemy").Id 
            };
            artifacts[1] = new Artifact()
            {
                Id = 1,
                Name = "Dragon",
                CategoryID = Essentials.FindCategoriesID("Enemy").Id
            };
            artifacts[2] = new Artifact()
            {
                Id = 2,
                Name = "Rat",
                CategoryID = Essentials.FindCategoriesID("Enemy").Id
            };
            artifacts[3] = new Artifact()
            {
                Id = 3,
                Name = "Boar",
                CategoryID = Essentials.FindCategoriesID("Enemy").Id
            };
            artifacts[4] = new Artifact()
            {
                Id = 4,
                Name = "Feral Dog",
                CategoryID = Essentials.FindCategoriesID("Enemy").Id
            };
            artifacts[5] = new Artifact()
            {
                Id = 5,
                Name = "Thief",
                CategoryID = Essentials.FindCategoriesID("Enemy").Id
            };
            foreach(Artifact artifact in artifacts)
            {
                context.Artifact.Add(artifact);
            }
            context.SaveChanges();
            */
        }

        public static void addAttributes()
        {
            var context = new RPG_DB();
            Attribute[] att = new Attribute[5];
            int count = context.Attribute.Count();
            att[0] = new Attribute() { Name = "Strength", ID = count++ };
            att[1] = new Attribute() { Name = "Speed", ID = count++ };
            att[2] = new Attribute() { Name = "Height", ID = count++ };
            att[3] = new Attribute() { Name = "HP", ID = count++ };
            att[4] = new Attribute() { Name = "Lvl", ID = count++ };
            foreach (Attribute att2 in att)
            {
                context.Attribute.Add(att2);
            }
            context.SaveChanges();

            count = context.Attribute.Count();
            att[0] = new Attribute() { Name = "Armor", ID = count++ };
            att[1] = new Attribute() { Name = "Durability", ID = count++ };
            att[2] = new Attribute() { Name = "Attack", ID = count++ };
            att[3] = new Attribute() { Name = "Width", ID = count++ };
            att[4] = new Attribute() { Name = "Area", ID = count++ };
            foreach (Attribute att2 in att)
            {
                context.Attribute.Add(att2);
            }
            context.SaveChanges();
        }
    }
}
