namespace RPG
{
    partial class ViewCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoriesList = new System.Windows.Forms.ListBox();
            this.addCat = new System.Windows.Forms.Button();
            this.editCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attributes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(871, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artefacts:";
            // 
            // categoriesList
            // 
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.ItemHeight = 16;
            this.categoriesList.Location = new System.Drawing.Point(31, 66);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(375, 100);
            this.categoriesList.TabIndex = 3;
            this.categoriesList.SelectedIndexChanged += new System.EventHandler(this.categoriesList_SelectedIndexChanged);
            // 
            // addCat
            // 
            this.addCat.Location = new System.Drawing.Point(31, 334);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(75, 74);
            this.addCat.TabIndex = 4;
            this.addCat.Text = "Add Category";
            this.addCat.UseVisualStyleBackColor = true;
            // 
            // editCat
            // 
            this.editCat.Location = new System.Drawing.Point(127, 334);
            this.editCat.Name = "editCat";
            this.editCat.Size = new System.Drawing.Size(75, 74);
            this.editCat.TabIndex = 5;
            this.editCat.Text = "Edit Category";
            this.editCat.UseVisualStyleBackColor = true;
            this.editCat.Click += new System.EventHandler(this.editCat_Click);
            // 
            // ViewCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.editCat);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewCategories";
            this.Text = "ViewCategories";
            this.Load += new System.EventHandler(this.ViewCategories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox categoriesList;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.Button editCat;
    }
}