
namespace Komis_samochodowy
{
    partial class Dodaj
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
            this.marka = new System.Windows.Forms.Label();
            this.markaT = new System.Windows.Forms.TextBox();
            this.modelT = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.Label();
            this.silnikT = new System.Windows.Forms.TextBox();
            this.silnik = new System.Windows.Forms.Label();
            this.kolorT = new System.Windows.Forms.TextBox();
            this.kolor = new System.Windows.Forms.Label();
            this.zdjecie = new System.Windows.Forms.Label();
            this.wyczysc = new System.Windows.Forms.Button();
            this.zapisz = new System.Windows.Forms.Button();
            this.wyjdz = new System.Windows.Forms.Button();
            this.wybierzZdjecie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(25, 35);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(136, 24);
            this.marka.TabIndex = 0;
            this.marka.Text = "marka:";
            // 
            // markaT
            // 
            this.markaT.Location = new System.Drawing.Point(167, 32);
            this.markaT.Name = "markaT";
            this.markaT.Size = new System.Drawing.Size(243, 27);
            this.markaT.TabIndex = 1;
            // 
            // modelT
            // 
            this.modelT.Location = new System.Drawing.Point(167, 78);
            this.modelT.Name = "modelT";
            this.modelT.Size = new System.Drawing.Size(243, 27);
            this.modelT.TabIndex = 3;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(25, 81);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(136, 24);
            this.model.TabIndex = 2;
            this.model.Text = "model:";
            // 
            // silnikT
            // 
            this.silnikT.Location = new System.Drawing.Point(167, 130);
            this.silnikT.Name = "silnikT";
            this.silnikT.Size = new System.Drawing.Size(243, 27);
            this.silnikT.TabIndex = 5;
            // 
            // silnik
            // 
            this.silnik.Location = new System.Drawing.Point(25, 133);
            this.silnik.Name = "silnik";
            this.silnik.Size = new System.Drawing.Size(136, 24);
            this.silnik.TabIndex = 4;
            this.silnik.Text = "silnik:";
            // 
            // kolorT
            // 
            this.kolorT.Location = new System.Drawing.Point(167, 182);
            this.kolorT.Name = "kolorT";
            this.kolorT.Size = new System.Drawing.Size(243, 27);
            this.kolorT.TabIndex = 7;
            // 
            // kolor
            // 
            this.kolor.Location = new System.Drawing.Point(25, 185);
            this.kolor.Name = "kolor";
            this.kolor.Size = new System.Drawing.Size(136, 24);
            this.kolor.TabIndex = 6;
            this.kolor.Text = "kolor:";
            // 
            // zdjecie
            // 
            this.zdjecie.Location = new System.Drawing.Point(25, 237);
            this.zdjecie.Name = "zdjecie";
            this.zdjecie.Size = new System.Drawing.Size(136, 24);
            this.zdjecie.TabIndex = 8;
            this.zdjecie.Text = "zdjęcie:";
            // 
            // wyczysc
            // 
            this.wyczysc.Location = new System.Drawing.Point(498, 44);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(143, 28);
            this.wyczysc.TabIndex = 9;
            this.wyczysc.Text = "Wyczyść";
            this.wyczysc.UseVisualStyleBackColor = true;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click);
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(498, 142);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(143, 28);
            this.zapisz.TabIndex = 10;
            this.zapisz.Text = "Zapisz";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // wyjdz
            // 
            this.wyjdz.Location = new System.Drawing.Point(498, 233);
            this.wyjdz.Name = "wyjdz";
            this.wyjdz.Size = new System.Drawing.Size(143, 28);
            this.wyjdz.TabIndex = 11;
            this.wyjdz.Text = "Wyjdź";
            this.wyjdz.UseVisualStyleBackColor = true;
            this.wyjdz.Click += new System.EventHandler(this.wyjdz_Click);
            // 
            // wybierzZdjecie
            // 
            this.wybierzZdjecie.Location = new System.Drawing.Point(167, 233);
            this.wybierzZdjecie.Name = "wybierzZdjecie";
            this.wybierzZdjecie.Size = new System.Drawing.Size(243, 27);
            this.wybierzZdjecie.TabIndex = 12;
            this.wybierzZdjecie.Text = "Wybierz zdjęcie";
            this.wybierzZdjecie.UseVisualStyleBackColor = true;
            this.wybierzZdjecie.Click += new System.EventHandler(this.wybierzZdjecie_Click);
            // 
            // Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 307);
            this.Controls.Add(this.wybierzZdjecie);
            this.Controls.Add(this.wyjdz);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.zdjecie);
            this.Controls.Add(this.kolorT);
            this.Controls.Add(this.kolor);
            this.Controls.Add(this.silnikT);
            this.Controls.Add(this.silnik);
            this.Controls.Add(this.modelT);
            this.Controls.Add(this.model);
            this.Controls.Add(this.markaT);
            this.Controls.Add(this.marka);
            this.Name = "Dodaj";
            this.Text = "Dodaj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dodaj_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label marka;
        private System.Windows.Forms.TextBox markaT;
        private System.Windows.Forms.TextBox modelT;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.TextBox silnikT;
        private System.Windows.Forms.Label silnik;
        private System.Windows.Forms.TextBox kolorT;
        private System.Windows.Forms.Label kolor;
        private System.Windows.Forms.Label zdjecie;
        private System.Windows.Forms.Button wyczysc;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Button wyjdz;
        private System.Windows.Forms.Button wybierzZdjecie;
    }
}