namespace Library.BorrowManagement
{
    partial class Catalogue
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
            this.filters = new System.Windows.Forms.Panel();
            this.currenciesList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.maxPages = new System.Windows.Forms.TextBox();
            this.minPages = new System.Windows.Forms.TextBox();
            this.maxVal = new System.Windows.Forms.TextBox();
            this.minVal = new System.Windows.Forms.TextBox();
            this.categoriesList = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNew = new System.Windows.Forms.Button();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filters:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filters
            // 
            this.filters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filters.Controls.Add(this.currenciesList);
            this.filters.Controls.Add(this.label7);
            this.filters.Controls.Add(this.apply);
            this.filters.Controls.Add(this.clear);
            this.filters.Controls.Add(this.maxPages);
            this.filters.Controls.Add(this.minPages);
            this.filters.Controls.Add(this.maxVal);
            this.filters.Controls.Add(this.minVal);
            this.filters.Controls.Add(this.categoriesList);
            this.filters.Controls.Add(this.label6);
            this.filters.Controls.Add(this.label5);
            this.filters.Controls.Add(this.label4);
            this.filters.Controls.Add(this.label3);
            this.filters.Controls.Add(this.label2);
            this.filters.Controls.Add(this.label1);
            this.filters.Location = new System.Drawing.Point(1038, 21);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(247, 574);
            this.filters.TabIndex = 2;
            // 
            // currenciesList
            // 
            this.currenciesList.FormattingEnabled = true;
            this.currenciesList.ItemHeight = 16;
            this.currenciesList.Location = new System.Drawing.Point(17, 411);
            this.currenciesList.Name = "currenciesList";
            this.currenciesList.Size = new System.Drawing.Size(215, 52);
            this.currenciesList.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Currency:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(17, 483);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(215, 29);
            this.apply.TabIndex = 13;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(17, 524);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(215, 31);
            this.clear.TabIndex = 12;
            this.clear.Text = "Clear filters";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // maxPages
            // 
            this.maxPages.Location = new System.Drawing.Point(17, 349);
            this.maxPages.Name = "maxPages";
            this.maxPages.Size = new System.Drawing.Size(215, 22);
            this.maxPages.TabIndex = 11;
            // 
            // minPages
            // 
            this.minPages.Location = new System.Drawing.Point(17, 289);
            this.minPages.Name = "minPages";
            this.minPages.Size = new System.Drawing.Size(215, 22);
            this.minPages.TabIndex = 10;
            // 
            // maxVal
            // 
            this.maxVal.Location = new System.Drawing.Point(17, 224);
            this.maxVal.Name = "maxVal";
            this.maxVal.Size = new System.Drawing.Size(215, 22);
            this.maxVal.TabIndex = 9;
            // 
            // minVal
            // 
            this.minVal.Location = new System.Drawing.Point(17, 163);
            this.minVal.Name = "minVal";
            this.minVal.Size = new System.Drawing.Size(215, 22);
            this.minVal.TabIndex = 8;
            // 
            // categoriesList
            // 
            this.categoriesList.CheckOnClick = true;
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Location = new System.Drawing.Point(17, 60);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(215, 72);
            this.categoriesList.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Max Pages:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Min Pages:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max value:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min value:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNew
            // 
            this.addNew.Location = new System.Drawing.Point(1056, 609);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(215, 53);
            this.addNew.TabIndex = 13;
            this.addNew.Text = "Add new book";
            this.addNew.UseVisualStyleBackColor = true;
            // 
            // layout
            // 
            this.layout.AutoScroll = true;
            this.layout.Location = new System.Drawing.Point(29, 21);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(988, 641);
            this.layout.TabIndex = 14;
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 684);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.filters);
            this.Name = "Catalogue";
            this.Text = "Catalogue";
            this.Load += new System.EventHandler(this.Catalogue_Load);
            this.filters.ResumeLayout(false);
            this.filters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel filters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox maxPages;
        private System.Windows.Forms.TextBox minPages;
        private System.Windows.Forms.TextBox maxVal;
        private System.Windows.Forms.TextBox minVal;
        private System.Windows.Forms.CheckedListBox categoriesList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.FlowLayoutPanel layout;
        private System.Windows.Forms.ListBox currenciesList;
    }
}