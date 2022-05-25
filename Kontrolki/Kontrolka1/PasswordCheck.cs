using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrolka1
{
    public partial class PasswordCheck : UserControl
    {
        int minChar = 7;
        int minDigit = 1;
        int minBig = 1;
        int minSpecial = 1;
        TextBox textBox;

        public PasswordCheck()
        {
            InitializeComponent();
        }
        public PasswordCheck(TextBox textBox)
        {
            this.textBox = textBox;
            InitializeComponent();
            Load();
        }

        public PasswordCheck(int minChar, int minDigit, int minBig, int minSpecial, TextBox textBox)
        {
            this.minChar = minChar;
            this.minDigit = minDigit;
            this.minBig = minBig;
            this.minSpecial = minSpecial;
            textBox = textBox;
            InitializeComponent();
            Load();
        }

        public void AddBox(TextBox text)
        {
            textBox = text;
            Load();
        }

        private void Load()
        {
            textBox.TextChanged += textChanged;
            charNum.Text = $"at least {minChar} charactes required";
            big.Text = $"at least {minBig} capital letters required";
            special.Text = $"at least {minSpecial} special characters required";
            digit.Text = $"at least {minDigit} digits required";

            imChar.Image = Properties.Resources._false;
            imBig.Image = Properties.Resources._false;
            imDigit.Image = Properties.Resources._false;
            imSpecial.Image = Properties.Resources._false;
        }

        private void textChanged(object sender, EventArgs e)
        {
            int big = 0, special = 0, num = 0;
            foreach (Char c in textBox.Text)
            {
                if (c >= 'A' && c <= 'Z') big++;
                else if (c >= '0' && c <= '9') num++;
                else if(c < 'a' || c > 'z') special++;
            }

            if(textBox.Text.Length >= minChar) imChar.Image = Properties.Resources._true;
                else imChar.Image = Properties.Resources._false;
            if(big >= minBig) imBig.Image = Properties.Resources._true;
                else imBig.Image = Properties.Resources._false;
            if (special >= minSpecial) imSpecial.Image = Properties.Resources._true;
                else imSpecial.Image = Properties.Resources._false;
            if (num >= minDigit) imDigit.Image = Properties.Resources._true;
                else imDigit.Image = Properties.Resources._false;
        }
    }
}
