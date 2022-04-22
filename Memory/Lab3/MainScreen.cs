using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Memory;


namespace Lab3
{
    public partial class MainScreen : Form
    {
        Memory memory;
        Settings setting;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void easy_Click(object sender, EventArgs e)
        {
            memory = new Memory(0);
            this.Hide();
            memory.Show();
        }

        private void medium_Click(object sender, EventArgs e)
        {
            memory = new Memory(1);
            this.Hide();
            memory.Show();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            memory = new Memory(2);
            this.Hide();
            memory.Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            setting = new Settings();
            setting.begginingVisibility.Value = Memory.startTime / 1000;
            setting.visible2tiles.Value = Memory.twoUncoverTime / 1000;
            setting.ShowDialog();
        }
    }
}
