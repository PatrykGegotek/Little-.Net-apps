using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class ViewCategories : Form
    {
        List<Category> categories;
        List<Attribute> attributes;
        List<Artifact> artifacts;
        public ViewCategories()
        {
            InitializeComponent();
        }

        private void ViewCategories_Load(object sender, EventArgs e)
        {
            username.Text = CurrentUser.user.Name;
            populateCatBox();
            loadUser();
        }

        //****************************************CATEGORIES****************************************//
        private void addCat_Click(object sender, EventArgs e)
        {
            String name = newCat.Text;
            if (name.Equals(""))
            {
                MessageBox.Show("Must choose name!");
                return;
            }
            var ctx = new RPG_DB();
            Category category = new Category()
            {
                ID = Essentials.getHighestCategory(),
                Name = name,
                CreatorID = CurrentUser.user.ID
            };
            ctx.Category.Add(category);
            ctx.SaveChanges();
            CategoryModification categoryModification = new CategoryModification(category);
            categoryModification.ShowDialog();
            populateCatBox();
        }

        private void editCat_Click(object sender, EventArgs e)
        {
            if (categoriesBox.SelectedItem == null) return;
            if (artifacts.Count > 0)
            {
                MessageBox.Show("Cannot edit category when it has artifacts!");
                return;
            }
            Category category = chosenCat();
            CategoryModification categoryModification = new CategoryModification(category);
            categoryModification.ShowDialog();
        }

        private void deleteCat_Click(object sender, EventArgs e)
        {
            if (categoriesBox.SelectedItem == null) return;
            Category category = chosenCat();
            Essentials.removeCategory(category);
            populateCatBox();
        }

        //****************************************ARTIFACTS****************************************//
        private void addArt_Click(object sender, EventArgs e)
        {
            String name = newArt.Text;
            if(name.Equals("") || categoriesBox.SelectedItem == null)
            {
                MessageBox.Show("Must choose category and name!");
                return;
            }
            Category category = chosenCat();

            using (AddArtifact add = new AddArtifact(category, name))
            {
                add.ShowDialog();
            }
            populateArtBox();
        }

        private void editArt_Click(object sender, EventArgs e)
        {
            if (artefactsBox.SelectedItem == null || artefactsBox.SelectedItem.Equals("<None>")) return;
            Artifact artifact = chosenArt();
            EditArtifact editArtifact = new EditArtifact(artifact);
            editArtifact.ShowDialog();
        }

        private void deleteArt_Click(object sender, EventArgs e)
        {
            Artifact art = chosenArt();
            Essentials.removeArtifact(art);
            populateArtBox();
        }

        //****************************************POPULATE****************************************//
        private void populateCatBox()
        {
            categoriesBox.Items.Clear();
            var ctx = new RPG_DB();
            categories = (from cat in ctx.Category orderby cat.ID ascending select cat).ToList();
            foreach (Category category in categories)
            {
                categoriesBox.Items.Add(category.Name);
            }
            if (categoriesBox.SelectedItem != null)
            {
                populateAttBox();
                populateArtBox();
            }
            if (categories.Count == 0) categoriesBox.Items.Add("<None>");
        }

        private void populateAttBox()
        {
            attributesBox.Items.Clear();
            attributes = Essentials.getAttributesOfCategoryByID(chosenCat().ID);
            foreach (Attribute attribute in attributes)
            {
                attributesBox.Items.Add(attribute.Name);
            }
            if (attributes.Count == 0) attributesBox.Items.Add("<None>");
        }

        private void populateArtBox()
        {
            artefactsBox.Items.Clear();
            artifacts = Essentials.getArtifactsofCategoryByID(chosenCat().ID);
            foreach (Artifact artifact in artifacts)
            {
                artefactsBox.Items.Add(artifact.Name);
            }
            if (artifacts.Count == 0) artefactsBox.Items.Add("<None>");
        }


        //****************************************ADDITIONAL****************************************//
        private Category chosenCat()
        {
            return categories[categoriesBox.SelectedIndex];
        }

        private Artifact chosenArt()
        {
            return artifacts[artefactsBox.SelectedIndex];
        }

        private void categoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateAttBox();
            populateArtBox();
        }

        

        private void loadUser()
        {
            if (!CurrentUser.hasPerm(PermissionType.addArtifact)) 
            {
                addArt.Enabled = false;
                newArt.Enabled = false;
            }
            if(!CurrentUser.hasPerm(PermissionType.addCategory))
            {
                addCat.Enabled = false;
                newCat.Enabled = false;
            }

            if (!CurrentUser.hasPerm(PermissionType.deleteArtifact)) deleteArt.Enabled = false;
            if (!CurrentUser.hasPerm(PermissionType.deleteCategory)) deleteCat.Enabled = false;

            if (!CurrentUser.hasPerm(PermissionType.editArtifact)) editArt.Enabled = false;
            if (!CurrentUser.hasPerm(PermissionType.editCategory)) editCat.Enabled = false;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
            this.Hide();
        }
    }
}
