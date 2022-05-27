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
    public partial class AddAttributeToCategory : Form
    {
        Category category;
        List<Attribute> attributes;
        List<Attribute> currentAttributes;
        public AddAttributeToCategory(Category category, List<Attribute> attributes)
        {
            this.category = category;
            this.currentAttributes = attributes;
            InitializeComponent();
        }

        private void AddAttributeToCategory_Load(object sender, EventArgs e)
        {
            attributes = Essentials.getAllAttributes();
            foreach(Attribute attribute in attributes)
            {
                attributesList.Items.Add(attribute.Name);
            }
        }

        private void attributesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Attribute chosenAttribute = attributes[attributesList.SelectedIndex];
            if (currentAttributes.Contains(chosenAttribute)) return;

            var ctx = new RPG_DB();
            AttributeOfCategory attributeOfCategory = new AttributeOfCategory
            {
                ID = ctx.AttributeOfCategory.Count(),
                CategoryID = category.ID,
                AttributeID = chosenAttribute.ID
            };
            ctx.AttributeOfCategory.Add(attributeOfCategory);
            ctx.SaveChanges();
            this.Close();
        }
    }
}
