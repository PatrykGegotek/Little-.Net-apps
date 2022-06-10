namespace RPG
{
    partial class Admin
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
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.addnew = new System.Windows.Forms.Button();
            this.manager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.Location = new System.Drawing.Point(44, 12);
            this.layout.Name = "layout";
            this.layout.RowCount = 1;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Size = new System.Drawing.Size(446, 159);
            this.layout.TabIndex = 0;
            // 
            // addnew
            // 
            this.addnew.Location = new System.Drawing.Point(543, 12);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(75, 67);
            this.addnew.TabIndex = 1;
            this.addnew.Text = "Add user";
            this.addnew.UseVisualStyleBackColor = true;
            this.addnew.Click += new System.EventHandler(this.addnew_Click);
            // 
            // manager
            // 
            this.manager.Location = new System.Drawing.Point(543, 104);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(75, 67);
            this.manager.TabIndex = 2;
            this.manager.Text = "Go to artifacts manager";
            this.manager.UseVisualStyleBackColor = true;
            this.manager.Click += new System.EventHandler(this.manager_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 209);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.addnew);
            this.Controls.Add(this.layout);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.Button manager;
    }
}