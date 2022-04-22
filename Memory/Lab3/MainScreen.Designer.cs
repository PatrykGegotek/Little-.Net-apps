
namespace Lab3
{
    partial class MainScreen
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
            this.medium = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medium
            // 
            this.medium.Location = new System.Drawing.Point(74, 125);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(197, 35);
            this.medium.TabIndex = 1;
            this.medium.Text = "medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // easy
            // 
            this.easy.Location = new System.Drawing.Point(74, 55);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(197, 35);
            this.easy.TabIndex = 2;
            this.easy.Text = "easy";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // hard
            // 
            this.hard.Location = new System.Drawing.Point(74, 199);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(197, 35);
            this.hard.TabIndex = 3;
            this.hard.Text = "hard";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(459, 55);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(167, 74);
            this.settings.TabIndex = 4;
            this.settings.Text = "settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 337);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.medium);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button settings;
    }
}