
namespace Komis_samochodowy
{
    partial class Komis_samochodowy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Designer = new System.Windows.Forms.Button();
            this.Dodaj_samochód = new System.Windows.Forms.Button();
            this.RezerwacjaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Designer
            // 
            this.Designer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Designer.Location = new System.Drawing.Point(32, 38);
            this.Designer.MinimumSize = new System.Drawing.Size(150, 103);
            this.Designer.Name = "Designer";
            this.Designer.Size = new System.Drawing.Size(150, 103);
            this.Designer.TabIndex = 0;
            this.Designer.Text = "Designer";
            this.Designer.UseVisualStyleBackColor = true;
            this.Designer.Click += new System.EventHandler(this.Designer_Click);
            // 
            // Dodaj_samochód
            // 
            this.Dodaj_samochód.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dodaj_samochód.Location = new System.Drawing.Point(214, 38);
            this.Dodaj_samochód.Name = "Dodaj_samochód";
            this.Dodaj_samochód.Size = new System.Drawing.Size(150, 103);
            this.Dodaj_samochód.TabIndex = 1;
            this.Dodaj_samochód.Text = "Dodaj_samochód";
            this.Dodaj_samochód.UseVisualStyleBackColor = true;
            this.Dodaj_samochód.Click += new System.EventHandler(this.Dodaj_samochód_Click);
            // 
            // RezerwacjaButton
            // 
            this.RezerwacjaButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RezerwacjaButton.Location = new System.Drawing.Point(395, 38);
            this.RezerwacjaButton.Name = "RezerwacjaButton";
            this.RezerwacjaButton.Size = new System.Drawing.Size(150, 103);
            this.RezerwacjaButton.TabIndex = 2;
            this.RezerwacjaButton.Text = "Rezerwacja";
            this.RezerwacjaButton.UseVisualStyleBackColor = true;
            this.RezerwacjaButton.Click += new System.EventHandler(this.Rezerwacja_Click);
            // 
            // Komis_samochodowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 178);
            this.Controls.Add(this.RezerwacjaButton);
            this.Controls.Add(this.Dodaj_samochód);
            this.Controls.Add(this.Designer);
            this.Name = "Komis_samochodowy";
            this.Text = "Komis samochodowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Designer;
        private System.Windows.Forms.Button Dodaj_samochód;
        private System.Windows.Forms.Button RezerwacjaButton;
    }
}

