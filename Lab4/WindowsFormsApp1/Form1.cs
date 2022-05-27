using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addressBookDataSet.tblContacts' table. You can move, or remove it, as needed.
            //var a = this.tblContactsTableAdapter.Adapter;
            //var b = addressBookDataSet.tblContacts;


            this.tblContactsTableAdapter.Fill(this.addressBookDataSet.tblContacts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baza.Position += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baza.Position -= 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            test.ReadOnly = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Baza.CancelEdit();

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            test.ReadOnly = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Baza.EndEdit();
            var curr = Baza.Position;
            if(this.addressBookDataSet.HasChanges())
            {
                this.tblContactsTableAdapter.Update(addressBookDataSet);
                this.tblContactsTableAdapter.Fill(this.addressBookDataSet.tblContacts);
            }
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            test.ReadOnly = true;
            button1.Enabled = true;
            button2.Enabled = true;
            Baza.Position = curr;
        }

        private void add_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            test.ReadOnly = false;
            textBox1.Focus();

            Baza.AddNew();
            

        }

        private void delete_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("You sure?", "Yeah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Baza.RemoveAt(Baza.Position);
            }
        }
    }
}
