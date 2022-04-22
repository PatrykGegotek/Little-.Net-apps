using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memory
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void begginingVisibility_Scroll(object sender, ScrollEventArgs e)
        {
            int tick = ((HScrollBar)sender).Value * 1000;

            Lab3.Memory.startTime = tick == 0 ? 1 : tick;
        }

        private void visible2tiles_Scroll(object sender, ScrollEventArgs e)
        {
            Lab3.Memory.twoUncoverTime = ((HScrollBar)sender).Value * 1000;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
