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
        public ViewCategories()
        {
            InitializeComponent();
        }

        private void ViewCategories_Load(object sender, EventArgs e)
        {
            var context = new RPG_DB();
            categories = (from cat in context.Category orderby cat.ID ascending select cat).ToList();
            foreach (Category category in categories)
            {
                categoriesList.Items.Add(category.Name);
            }
        }

        private void categoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void editCat_Click(object sender, EventArgs e)
        {
            Category category = categories[categoriesList.SelectedIndex];
            CategoryModification categoryModification = new CategoryModification(category);
            categoryModification.ShowDialog();
        }
    }
}
