namespace RPG
{
    partial class AddAttributeToCategory
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
            this.attributesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose from available attributes:";
            // 
            // attributesList
            // 
            this.attributesList.FormattingEnabled = true;
            this.attributesList.ItemHeight = 16;
            this.attributesList.Location = new System.Drawing.Point(13, 33);
            this.attributesList.Name = "attributesList";
            this.attributesList.Size = new System.Drawing.Size(202, 116);
            this.attributesList.TabIndex = 1;
            this.attributesList.SelectedIndexChanged += new System.EventHandler(this.attributesList_SelectedIndexChanged);
            // 
            // AddAttributeToCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 157);
            this.Controls.Add(this.attributesList);
            this.Controls.Add(this.label1);
            this.Name = "AddAttributeToCategory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddAttributeToCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox attributesList;
    }
}