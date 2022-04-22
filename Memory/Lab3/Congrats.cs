using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memory
{
    public partial class Congrats : Form
    {
        public String str;
        public Congrats()
        {
            str = "";
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = this.textBox1.Text;
            this.Close();
        }
    }
}
