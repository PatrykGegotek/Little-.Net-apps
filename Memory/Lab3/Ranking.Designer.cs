﻿
namespace Memory
{
    partial class Ranking
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "difficulty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label label1;
    }
}