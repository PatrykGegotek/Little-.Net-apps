namespace RPG
{
    partial class AddArtifact
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
            this.catName = new System.Windows.Forms.Label();
            this.artName = new System.Windows.Forms.Label();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(2, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artfiact name:";
            // 
            // catName
            // 
            this.catName.AutoSize = true;
            this.catName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.catName.Location = new System.Drawing.Point(168, 2);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(76, 20);
            this.catName.TabIndex = 2;
            this.catName.Text = "catName";
            // 
            // artName
            // 
            this.artName.AutoSize = true;
            this.artName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.artName.Location = new System.Drawing.Point(168, 41);
            this.artName.Name = "artName";
            this.artName.Size = new System.Drawing.Size(73, 20);
            this.artName.TabIndex = 3;
            this.artName.Text = "artName";
            // 
            // layout
            // 
            this.layout.AutoScroll = true;
            this.layout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.layout.Location = new System.Drawing.Point(32, 33);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(420, 172);
            this.layout.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.catName);
            this.panel1.Controls.Add(this.artName);
            this.panel1.Location = new System.Drawing.Point(31, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 77);
            this.panel1.TabIndex = 7;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(882, 62);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(87, 63);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(882, 171);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(87, 63);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.layout);
            this.panel2.Location = new System.Drawing.Point(354, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 228);
            this.panel2.TabIndex = 10;
            // 
            // AddArtifact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 285);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel1);
            this.Name = "AddArtifact";
            this.Text = "AddArtifact";
            this.Load += new System.EventHandler(this.AddArtifact_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label catName;
        private System.Windows.Forms.Label artName;
        private System.Windows.Forms.FlowLayoutPanel layout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Panel panel2;
    }
}