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
    public partial class AddArtifact : Form
    {
        Category category;
        String name;
        List<Attribute> attributes;
        List<TextBox> textBoxes = new List<TextBox>();
        public AddArtifact(Category category, String name)
        {
            this.category = category;
            this.name = name;
            InitializeComponent();
        }

        private void AddArtifact_Load(object sender, EventArgs e)
        {
            catName.Text = category.Name;
            artName.Text = name;
            this.layout.Size = new Size(250, 150);
            attributes = Essentials.getAttributesOfCategoryByID(category.ID);
            foreach (Attribute attribute in attributes)
            {
                Label label = new Label();
                label.Text = attribute.Name.Trim() + ":";
                label.AutoSize = false;
                label.Size = new Size(100, 25);
                label.TextAlign = ContentAlignment.MiddleLeft;
                layout.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Size = new Size(200, 22);
                layout.Controls.Add(textBox);
                textBoxes.Add(textBox);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            List<String> values = new List<string>();
            foreach (TextBox textBox in textBoxes)
            {
                if(textBox.Text == "")
                {
                    MessageBox.Show("All fields must be filled in!");
                    values.Clear();
                    return;
                }
                values.Add(textBox.Text);
            }
            Essentials.addNewArtifact(attributes, values, name, category, CurrentUser.user.ID);
            this.Close();
        }
    }
}
