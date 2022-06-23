namespace Library.BorrowManagement
{
    partial class MainPage
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
            this.cataloque = new System.Windows.Forms.Button();
            this.Borrowed = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cataloque
            // 
            this.cataloque.Location = new System.Drawing.Point(56, 93);
            this.cataloque.Name = "cataloque";
            this.cataloque.Size = new System.Drawing.Size(100, 100);
            this.cataloque.TabIndex = 0;
            this.cataloque.Text = "Catalogue";
            this.cataloque.UseVisualStyleBackColor = true;
            this.cataloque.Click += new System.EventHandler(this.cataloque_Click);
            // 
            // Borrowed
            // 
            this.Borrowed.Location = new System.Drawing.Point(201, 93);
            this.Borrowed.Name = "Borrowed";
            this.Borrowed.Size = new System.Drawing.Size(100, 100);
            this.Borrowed.TabIndex = 1;
            this.Borrowed.Text = "Borrowed books";
            this.Borrowed.UseVisualStyleBackColor = true;
            this.Borrowed.Click += new System.EventHandler(this.Borrowed_Click);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(344, 93);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(100, 100);
            this.history.TabIndex = 2;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(344, 34);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(100, 37);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logged as:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(142, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(159, 23);
            this.name.TabIndex = 5;
            this.name.Text = "name";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 217);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.history);
            this.Controls.Add(this.Borrowed);
            this.Controls.Add(this.cataloque);
            this.Name = "MainPage";
            this.Text = "mainPage";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cataloque;
        private System.Windows.Forms.Button Borrowed;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
    }
}