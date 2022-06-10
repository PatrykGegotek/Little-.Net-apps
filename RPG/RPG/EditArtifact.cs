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
    public partial class EditArtifact : Form
    {
        Artifact artifact;
        List<ValueOfArtifact> vals;
        List<TextBox> textBoxes = new List<TextBox>();
        public EditArtifact(Artifact artifact)
        {
            this.artifact = artifact;
            InitializeComponent();
        }

        private void EditArtifact_Load(object sender, EventArgs e)
        {
            catName.Text = Essentials.getCategoryByID(artifact.CategoryID).Name;
            artName.Text = artifact.Name;
            this.author.Text = Authentication.getUserByID(
                Essentials.getCategoryByID(artifact.CategoryID).CreatorID).Name;
            this.layout.Size = new Size(250, 150);

            vals = Essentials.getAttributesAndValuesOfArtifact(artifact);

            if (vals == null) MessageBox.Show(":(");

            foreach(ValueOfArtifact val in vals)
            {
                Label label = new Label();
                label.Text = val.attribute.Name.Trim() + ":";
                label.AutoSize = false;
                label.Size = new Size(100, 25);
                label.TextAlign = ContentAlignment.MiddleLeft;
                layout.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Text = val.attArt.Value;
                textBox.Size = new Size(200, 22);
                layout.Controls.Add(textBox);
                textBoxes.Add(textBox);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            foreach(TextBox textBox in textBoxes)
            {
                if (textBox.Text.Trim() == "")
                {
                    MessageBox.Show("All values must be filled in!");
                    return;
                }
            }

            for(int i = 0; i < vals.Count; i++)
            {
                //Essentials.setValueOfAttributeofArtifact(vals[i].attArt, textBoxes[i].Text);
                vals[i].attArt.Value = textBoxes[i].Text;
            }
            Essentials.ctx.SaveChanges();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
