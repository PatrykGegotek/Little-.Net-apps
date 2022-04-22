
namespace Komis_samochodowy
{
    partial class Rezerwacja
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
            this.label = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.Button();
            this.choose = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.Location = new System.Drawing.Point(195, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(528, 28);
            this.label.TabIndex = 0;
            this.label.Text = "Wybierz samochód:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Location = new System.Drawing.Point(154, 68);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(610, 405);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // right
            // 
            this.right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.right.Font = new System.Drawing.Font("Webdings", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.right.Location = new System.Drawing.Point(798, 240);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(81, 78);
            this.right.TabIndex = 3;
            this.right.Text = "4";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // choose
            // 
            this.choose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.choose.Location = new System.Drawing.Point(413, 522);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(94, 29);
            this.choose.TabIndex = 4;
            this.choose.Text = "Wybierz";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // left
            // 
            this.left.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left.Font = new System.Drawing.Font("Webdings", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.left.Location = new System.Drawing.Point(32, 240);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(81, 78);
            this.left.TabIndex = 5;
            this.left.Text = "3";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(154, 479);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(610, 28);
            this.rez.TabIndex = 6;
            this.rez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rezerwacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 563);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.left);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.right);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label);
            this.Name = "Rezerwacja";
            this.Text = "Rezerwacja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rezerwacja_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Label rez;
    }
}