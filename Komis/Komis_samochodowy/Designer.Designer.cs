
namespace Komis_samochodowy
{
    partial class Designer
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
            this.marka = new System.Windows.Forms.ListBox();
            this.wybierz_marke = new System.Windows.Forms.Label();
            this.Wybierz_model = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.ListBox();
            this.wybierz_silnik = new System.Windows.Forms.Label();
            this.silnik = new System.Windows.Forms.ListBox();
            this.wybierz_kolor = new System.Windows.Forms.Label();
            this.kolor = new System.Windows.Forms.ListBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.wybierz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // marka
            // 
            this.marka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.marka.FormattingEnabled = true;
            this.marka.ItemHeight = 20;
            this.marka.Location = new System.Drawing.Point(33, 71);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(250, 124);
            this.marka.TabIndex = 0;
            this.marka.SelectedIndexChanged += new System.EventHandler(this.marka_SelectedIndexChanged);
            // 
            // wybierz_marke
            // 
            this.wybierz_marke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wybierz_marke.Location = new System.Drawing.Point(33, 33);
            this.wybierz_marke.Name = "wybierz_marke";
            this.wybierz_marke.Size = new System.Drawing.Size(250, 25);
            this.wybierz_marke.TabIndex = 1;
            this.wybierz_marke.Text = "Wybierz markę:";
            this.wybierz_marke.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Wybierz_model
            // 
            this.Wybierz_model.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Wybierz_model.Location = new System.Drawing.Point(390, 33);
            this.Wybierz_model.Name = "Wybierz_model";
            this.Wybierz_model.Size = new System.Drawing.Size(250, 25);
            this.Wybierz_model.TabIndex = 3;
            this.Wybierz_model.Text = "Wybierz model:";
            this.Wybierz_model.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // model
            // 
            this.model.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.model.FormattingEnabled = true;
            this.model.ItemHeight = 20;
            this.model.Location = new System.Drawing.Point(390, 71);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(250, 124);
            this.model.TabIndex = 2;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // wybierz_silnik
            // 
            this.wybierz_silnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wybierz_silnik.Location = new System.Drawing.Point(737, 33);
            this.wybierz_silnik.Name = "wybierz_silnik";
            this.wybierz_silnik.Size = new System.Drawing.Size(250, 25);
            this.wybierz_silnik.TabIndex = 5;
            this.wybierz_silnik.Text = "Wybierz silnik:";
            this.wybierz_silnik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // silnik
            // 
            this.silnik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.silnik.FormattingEnabled = true;
            this.silnik.ItemHeight = 20;
            this.silnik.Location = new System.Drawing.Point(737, 71);
            this.silnik.Name = "silnik";
            this.silnik.Size = new System.Drawing.Size(250, 124);
            this.silnik.TabIndex = 4;
            this.silnik.SelectedIndexChanged += new System.EventHandler(this.silnik_SelectedIndexChanged);
            // 
            // wybierz_kolor
            // 
            this.wybierz_kolor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wybierz_kolor.Location = new System.Drawing.Point(1083, 33);
            this.wybierz_kolor.Name = "wybierz_kolor";
            this.wybierz_kolor.Size = new System.Drawing.Size(250, 25);
            this.wybierz_kolor.TabIndex = 9;
            this.wybierz_kolor.Text = "Wybierz kolor:";
            this.wybierz_kolor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kolor
            // 
            this.kolor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kolor.FormattingEnabled = true;
            this.kolor.ItemHeight = 20;
            this.kolor.Location = new System.Drawing.Point(1083, 71);
            this.kolor.Name = "kolor";
            this.kolor.Size = new System.Drawing.Size(250, 124);
            this.kolor.TabIndex = 8;
            this.kolor.SelectedIndexChanged += new System.EventHandler(this.kolor_SelectedIndexChanged);
            // 
            // photo
            // 
            this.photo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photo.Location = new System.Drawing.Point(33, 260);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(1300, 485);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 10;
            this.photo.TabStop = false;
            // 
            // wybierz
            // 
            this.wybierz.Location = new System.Drawing.Point(572, 203);
            this.wybierz.Name = "wybierz";
            this.wybierz.Size = new System.Drawing.Size(240, 48);
            this.wybierz.TabIndex = 11;
            this.wybierz.Text = "Wybierz ten samochód";
            this.wybierz.UseVisualStyleBackColor = true;
            this.wybierz.Click += new System.EventHandler(this.wybierz_Click);
            // 
            // Designer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 757);
            this.Controls.Add(this.wybierz);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.wybierz_kolor);
            this.Controls.Add(this.kolor);
            this.Controls.Add(this.wybierz_silnik);
            this.Controls.Add(this.silnik);
            this.Controls.Add(this.Wybierz_model);
            this.Controls.Add(this.model);
            this.Controls.Add(this.wybierz_marke);
            this.Controls.Add(this.marka);
            this.Name = "Designer";
            this.Text = "Designer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Designer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox marka;
        private System.Windows.Forms.Label wybierz_marke;
        private System.Windows.Forms.Label Wybierz_model;
        private System.Windows.Forms.ListBox model;
        private System.Windows.Forms.Label wybierz_silnik;
        private System.Windows.Forms.ListBox silnik;
        private System.Windows.Forms.Label wybierz_kolor;
        private System.Windows.Forms.ListBox kolor;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Button wybierz;
    }
}