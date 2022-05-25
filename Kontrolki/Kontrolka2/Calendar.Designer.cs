namespace Kontrolka2
{
    partial class Calendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.scrollLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.scrollLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(29, 60);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 75);
            this.add.TabIndex = 3;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(29, 153);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 75);
            this.delete.TabIndex = 4;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // scrollLayout
            // 
            this.scrollLayout.AutoScroll = true;
            this.scrollLayout.Controls.Add(this.layout);
            this.scrollLayout.Location = new System.Drawing.Point(577, 43);
            this.scrollLayout.Name = "scrollLayout";
            this.scrollLayout.Size = new System.Drawing.Size(682, 523);
            this.scrollLayout.TabIndex = 5;
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Location = new System.Drawing.Point(3, 3);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Size = new System.Drawing.Size(616, 866);
            this.layout.TabIndex = 0;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scrollLayout);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(1292, 594);
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.scrollLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button add;
        private Button delete;
        private FlowLayoutPanel scrollLayout;
        private TableLayoutPanel layout;
    }
}
