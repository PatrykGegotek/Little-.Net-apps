namespace Kontrolki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordCheck check = new PasswordCheck(textBox1);
            this.Controls.Add(check);
            check.Location = new System.Drawing.Point(textBox1.Location.X + 50, textBox1.Location.Y + 50);
            check.Enabled = true;
            check.Show();
        }
    }
}