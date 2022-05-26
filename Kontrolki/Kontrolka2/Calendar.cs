using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrolka2
{
    public partial class Calendar : UserControl
    {
        Label[,] labels = new Label[7, 48];
        List<MyLabel> chosenLabels = new List<MyLabel>();
        List<MyLabel> savedEvents = new List<MyLabel>();
        List<MyEvent> events = new List<MyEvent>();
        int currentNumber = -1;
        Color chosenColor = Color.Red;
        String text = "";

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            color.BackColor = chosenColor;
            int columnCount = 8;
            int rowCount = 49;
            layout.ColumnCount = columnCount;
            layout.RowCount = rowCount;
            layout.AutoScroll = true;
            layout.Size = new System.Drawing.Size(1092, 2500);

            layout.ColumnStyles.Clear();
            layout.RowStyles.Clear();
            layout.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

            for (int i = 0; i < columnCount; i++)
            {
                layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                    (System.Windows.Forms.SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                layout.RowStyles.Add(new System.Windows.Forms.RowStyle
                    (System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }


            String[] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            
            int minutes = 0;

            Label lab = new Label();
            lab.Dock = DockStyle.Fill;
            lab.Margin = new System.Windows.Forms.Padding(0);
            lab.Font = new Font(lab.Font.FontFamily, 12);
            lab.TextAlign = ContentAlignment.MiddleCenter;
            lab.BorderStyle = BorderStyle.FixedSingle;
            lab.Text = "Hour";
            lab.BackColor = Color.Beige;
            layout.Controls.Add(lab);

            for (int j = 0; j < 7; j++)
            {
                var label = new Label();
                label.Text = week[j];
                label.Font = new Font(label.Font.FontFamily, 12);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;
                label.Margin = new System.Windows.Forms.Padding(0);
                label.BorderStyle = BorderStyle.FixedSingle;
                label.BackColor = Color.Aqua;
                layout.Controls.Add(label);
            }

            int k = 0;
            for (int i = 0; i < 48; i++)
            {
                Label l = new Label();
                l.Dock = DockStyle.Fill;
                l.Font = new Font(l.Font.FontFamily, 12);
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Margin = new System.Windows.Forms.Padding(0);
                l.BorderStyle = BorderStyle.FixedSingle;
                l.Text = (minutes/60).ToString() + ':' + (minutes%60);
                l.BackColor = Color.Beige;
                minutes += 30;
                layout.Controls.Add(l);

                for (int j = 0; j < 7; j++)
                {
                    MyLabel label = new MyLabel();
                    label.pos = k++;
                    label.BackColor = Color.Bisque;
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Margin = new System.Windows.Forms.Padding(0);
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Click += labelClick;
                    layout.Controls.Add(label);
                    labels[j, i] = label;
                }
            }
        }

        private void labelClick(object sender, EventArgs e)
        {
            MyLabel label = ((MyLabel)sender);
            if (savedEvents.Contains(label)) return;
            int num = label.pos;

            if(label.BackColor == chosenColor && currentNumber == num)
            {
                chosenLabels.Remove(label);
                label.BackColor = Color.Bisque;
                currentNumber -= 7;
                if (chosenLabels.Count == 0) currentNumber = -1;
            }
            else
            {
                if (currentNumber == -1) currentNumber = num;
                else if (currentNumber + 7 != num) return;
                currentNumber = num;
                chosenLabels.Add(label);
                label.BackColor = chosenColor;
            }
            
        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                chosenColor = MyDialog.Color;
                ((Button)sender).BackColor = chosenColor;
                foreach(MyLabel label in chosenLabels)
                {
                    label.BackColor = chosenColor;
                }
            }
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
            text = message.Text;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (text.Equals("")) return;
            MyLabel start = chosenLabels[0];
            MyLabel end = chosenLabels[chosenLabels.Count - 1];
            MyEvent myEvent = new MyEvent(start.pos / 7 * 30, end.pos / 7 * 30 + 30, text);
            events.Add(myEvent);
            savedEvents.Add(start);

            for(int i = 1; i < chosenLabels.Count; i++)
            {
                layout.Controls.Remove(chosenLabels[i]);
            }
            layout.SetRowSpan(start, chosenLabels.Count);
            start.Text = text;
            currentNumber = -1;
            chosenLabels.Clear();
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            layout.Size = new Size(flowLayoutPanel1.Width - 40, layout.Height);
        }
    }
}
