namespace TestKontrolka1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

        Kontrolka1.PasswordCheck check = new Kontrolka1.PasswordCheck(passBox);
        this.Controls.Add(check);
        check.Location = new System.Drawing.Point(passBox.Location.X- 140, passBox.Location.Y + 50);
        check.Enabled = true;
        check.Anchor = AnchorStyles.Top;
        MinimumSize = new System.Drawing.Size(check.MinimumSize.Width, check.MinimumSize.Height + 100);
        
        Height += check.Height;
        Width = (Width > check.Width ? Width : check.Height + Width);

        check.Show();
    }
}
