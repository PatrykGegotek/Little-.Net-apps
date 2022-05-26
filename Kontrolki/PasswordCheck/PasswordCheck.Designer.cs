namespace PasswordCheck
{
    partial class PasswordCheck
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
            this.title = new System.Windows.Forms.Label();
            this.charNum = new System.Windows.Forms.Label();
            this.big = new System.Windows.Forms.Label();
            this.special = new System.Windows.Forms.Label();
            this.digit = new System.Windows.Forms.Label();
            this.imChar = new System.Windows.Forms.PictureBox();
            this.imBig = new System.Windows.Forms.PictureBox();
            this.imSpecial = new System.Windows.Forms.PictureBox();
            this.imDigit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imSpecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imDigit)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(0, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(590, 34);
            this.title.TabIndex = 0;
            this.title.Text = "Password Requirements";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charNum
            // 
            this.charNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charNum.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.charNum.Location = new System.Drawing.Point(80, 78);
            this.charNum.Name = "charNum";
            this.charNum.Size = new System.Drawing.Size(510, 22);
            this.charNum.TabIndex = 1;
            this.charNum.Text = "label2";
            // 
            // big
            // 
            this.big.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.big.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.big.Location = new System.Drawing.Point(80, 115);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(510, 22);
            this.big.TabIndex = 2;
            this.big.Text = "label1";
            // 
            // special
            // 
            this.special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.special.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.special.Location = new System.Drawing.Point(80, 155);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(510, 22);
            this.special.TabIndex = 3;
            this.special.Text = "label3";
            // 
            // digit
            // 
            this.digit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold);
            this.digit.Location = new System.Drawing.Point(80, 194);
            this.digit.Name = "digit";
            this.digit.Size = new System.Drawing.Size(510, 22);
            this.digit.TabIndex = 4;
            this.digit.Text = "label4";
            // 
            // imChar
            // 
            this.imChar.ErrorImage = global::PasswordCheck.Properties.Resources._false;
            this.imChar.Location = new System.Drawing.Point(14, 67);
            this.imChar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imChar.Name = "imChar";
            this.imChar.Size = new System.Drawing.Size(45, 34);
            this.imChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imChar.TabIndex = 5;
            this.imChar.TabStop = false;
            // 
            // imBig
            // 
            this.imBig.ErrorImage = global::PasswordCheck.Properties.Resources._false;
            this.imBig.Location = new System.Drawing.Point(14, 106);
            this.imBig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imBig.Name = "imBig";
            this.imBig.Size = new System.Drawing.Size(45, 34);
            this.imBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imBig.TabIndex = 6;
            this.imBig.TabStop = false;
            // 
            // imSpecial
            // 
            this.imSpecial.ErrorImage = global::PasswordCheck.Properties.Resources._false;
            this.imSpecial.Location = new System.Drawing.Point(14, 144);
            this.imSpecial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imSpecial.Name = "imSpecial";
            this.imSpecial.Size = new System.Drawing.Size(45, 34);
            this.imSpecial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imSpecial.TabIndex = 7;
            this.imSpecial.TabStop = false;
            // 
            // imDigit
            // 
            this.imDigit.ErrorImage = global::PasswordCheck.Properties.Resources._false;
            this.imDigit.Location = new System.Drawing.Point(14, 182);
            this.imDigit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imDigit.Name = "imDigit";
            this.imDigit.Size = new System.Drawing.Size(45, 34);
            this.imDigit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imDigit.TabIndex = 8;
            this.imDigit.TabStop = false;
            // 
            // PasswordCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imDigit);
            this.Controls.Add(this.imSpecial);
            this.Controls.Add(this.imBig);
            this.Controls.Add(this.imChar);
            this.Controls.Add(this.digit);
            this.Controls.Add(this.special);
            this.Controls.Add(this.big);
            this.Controls.Add(this.charNum);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PasswordCheck";
            this.Size = new System.Drawing.Size(590, 245);
            ((System.ComponentModel.ISupportInitialize)(this.imChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imSpecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imDigit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label charNum;
        private System.Windows.Forms.Label big;
        private System.Windows.Forms.Label special;
        private System.Windows.Forms.Label digit;
        private System.Windows.Forms.PictureBox imChar;
        private System.Windows.Forms.PictureBox imBig;
        private System.Windows.Forms.PictureBox imSpecial;
        private System.Windows.Forms.PictureBox imDigit;
    }
}
