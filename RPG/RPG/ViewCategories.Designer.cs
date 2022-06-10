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
            this.categoriesBox = new System.Windows.Forms.ListBox();
            this.addCat = new System.Windows.Forms.Button();
            this.editCat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.newCat = new System.Windows.Forms.TextBox();
            this.deleteCat = new System.Windows.Forms.Button();
            this.attributesBox = new System.Windows.Forms.ListBox();
            this.artefactsBox = new System.Windows.Forms.ListBox();
            this.deleteArt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.newArt = new System.Windows.Forms.TextBox();
            this.addArt = new System.Windows.Forms.Button();
            this.editArt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(408, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attributes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(789, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artifacts:";
            // 
            // categoriesBox
            // 
            this.categoriesBox.FormattingEnabled = true;
            this.categoriesBox.ItemHeight = 16;
            this.categoriesBox.Location = new System.Drawing.Point(31, 147);
            this.categoriesBox.Name = "categoriesBox";
            this.categoriesBox.Size = new System.Drawing.Size(375, 132);
            this.categoriesBox.TabIndex = 3;
            this.categoriesBox.SelectedIndexChanged += new System.EventHandler(this.categoriesBox_SelectedIndexChanged);
            // 
            // addCat
            // 
            this.addCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addCat.Location = new System.Drawing.Point(3, 84);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(366, 86);
            this.addCat.TabIndex = 4;
            this.addCat.Text = "Add new Category";
            this.addCat.UseVisualStyleBackColor = true;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // editCat
            // 
            this.editCat.Location = new System.Drawing.Point(31, 285);
            this.editCat.Name = "editCat";
            this.editCat.Size = new System.Drawing.Size(183, 30);
            this.editCat.TabIndex = 5;
            this.editCat.Text = "Edit Category";
            this.editCat.UseVisualStyleBackColor = true;
            this.editCat.Click += new System.EventHandler(this.editCat_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.newCat);
            this.panel1.Controls.Add(this.addCat);
            this.panel1.Location = new System.Drawing.Point(31, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 175);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "New category\'s name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newCat
            // 
            this.newCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCat.Location = new System.Drawing.Point(3, 55);
            this.newCat.Name = "newCat";
            this.newCat.Size = new System.Drawing.Size(366, 22);
            this.newCat.TabIndex = 5;
            // 
            // deleteCat
            // 
            this.deleteCat.Location = new System.Drawing.Point(223, 285);
            this.deleteCat.Name = "deleteCat";
            this.deleteCat.Size = new System.Drawing.Size(183, 30);
            this.deleteCat.TabIndex = 7;
            this.deleteCat.Text = "Delete Category";
            this.deleteCat.UseVisualStyleBackColor = true;
            this.deleteCat.Click += new System.EventHandler(this.deleteCat_Click);
            // 
            // attributesBox
            // 
            this.attributesBox.FormattingEnabled = true;
            this.attributesBox.ItemHeight = 16;
            this.attributesBox.Location = new System.Drawing.Point(412, 147);
            this.attributesBox.Name = "attributesBox";
            this.attributesBox.Size = new System.Drawing.Size(375, 132);
            this.attributesBox.TabIndex = 8;
            // 
            // artefactsBox
            // 
            this.artefactsBox.FormattingEnabled = true;
            this.artefactsBox.ItemHeight = 16;
            this.artefactsBox.Location = new System.Drawing.Point(793, 147);
            this.artefactsBox.Name = "artefactsBox";
            this.artefactsBox.Size = new System.Drawing.Size(375, 132);
            this.artefactsBox.TabIndex = 9;
            // 
            // deleteArt
            // 
            this.deleteArt.Location = new System.Drawing.Point(985, 285);
            this.deleteArt.Name = "deleteArt";
            this.deleteArt.Size = new System.Drawing.Size(183, 30);
            this.deleteArt.TabIndex = 12;
            this.deleteArt.Text = "Delete Artifact";
            this.deleteArt.UseVisualStyleBackColor = true;
            this.deleteArt.Click += new System.EventHandler(this.deleteArt_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.newArt);
            this.panel2.Controls.Add(this.addArt);
            this.panel2.Location = new System.Drawing.Point(793, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 175);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "New Artefacts\'s name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newArt
            // 
            this.newArt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newArt.Location = new System.Drawing.Point(3, 55);
            this.newArt.Name = "newArt";
            this.newArt.Size = new System.Drawing.Size(366, 22);
            this.newArt.TabIndex = 5;
            // 
            // addArt
            // 
            this.addArt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addArt.Location = new System.Drawing.Point(3, 84);
            this.addArt.Name = "addArt";
            this.addArt.Size = new System.Drawing.Size(366, 86);
            this.addArt.TabIndex = 4;
            this.addArt.Text = "Add new Artefact";
            this.addArt.UseVisualStyleBackColor = true;
            this.addArt.Click += new System.EventHandler(this.addArt_Click);
            // 
            // editArt
            // 
            this.editArt.Location = new System.Drawing.Point(793, 285);
            this.editArt.Name = "editArt";
            this.editArt.Size = new System.Drawing.Size(183, 30);
            this.editArt.TabIndex = 10;
            this.editArt.Text = "Edit Artifact";
            this.editArt.UseVisualStyleBackColor = true;
            this.editArt.Click += new System.EventHandler(this.editArt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "User name:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(121, 25);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(39, 16);
            this.username.TabIndex = 14;
            this.username.Text = "User ";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(235, 18);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(71, 30);
            this.logout.TabIndex = 15;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // ViewCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 608);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteArt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editArt);
            this.Controls.Add(this.artefactsBox);
            this.Controls.Add(this.attributesBox);
            this.Controls.Add(this.deleteCat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editCat);
            this.Controls.Add(this.categoriesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewCategories";
            this.Text = "ViewCategories";
            this.Load += new System.EventHandler(this.ViewCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox categoriesBox;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.Button editCat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox newCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteCat;
        private System.Windows.Forms.ListBox attributesBox;
        private System.Windows.Forms.ListBox artefactsBox;
        private System.Windows.Forms.Button deleteArt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newArt;
        private System.Windows.Forms.Button addArt;
        private System.Windows.Forms.Button editArt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button logout;
    }
}