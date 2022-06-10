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
    public partial class CategoryModification : Form
    {
        Category category;
        List<Attribute> attributes;
        public CategoryModification(Category category)
        {
            this.category = category;
            InitializeComponent();
        }

        private void CategoryModification_Load(object sender, EventArgs e)
        {
            this.name.Text = category.Name;
            this.author.Text = Authentication.getUserByID(category.CreatorID).Name;
            populateList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            using(var choser = new AddAttributeToCategory(category, attributes))
            {
                choser.ShowDialog();
                populateList();
            }
        }

        private void populateList()
        {
            attributes = Essentials.getAttributesOfCategoryByID(category.ID);
            this.attributesBox.Items.Clear();
            foreach (Attribute attribute in attributes)
            {
                this.attributesBox.Items.Add(attribute.Name);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var attribute = attributes[attributesBox.SelectedIndex];
            Essentials.DeleteAttributeOfCategory(category.ID, attribute.ID);
            populateList();
        }

        private void index_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
