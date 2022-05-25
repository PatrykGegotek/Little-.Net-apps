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
        Dictionary<Label, MyLabel> myLabels = new Dictionary<Label, MyLabel>();
        Label[,] labels = new Label[7, 48];
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            int columnCount = 8;
            int rowCount = 49;
            this.layout.ColumnCount = columnCount;
            this.layout.RowCount = rowCount;
            this.layout.AutoScroll = true;

            this.layout.ColumnStyles.Clear();
            this.layout.RowStyles.Clear();
            this.layout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            for (int i = 0; i < columnCount; i++)
            {
                this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                    (System.Windows.Forms.SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle
                    (System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var label = new Label();
                    //label.BackColor = Color.White;
                    //label.MinimumSize = new System.Drawing.Size(15, 15);
                    //layout.Controls.Add(label, j, i);
                }

            }


            /*
            String[] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            
            int minutes = 0;

            Label lab = new Label();
            lab.Size = new Size(layout.Width / 9, 30);
            lab.BorderStyle = BorderStyle.FixedSingle;
            lab.Text = "Hour";
            lab.BackColor = Color.Beige;
            layout.Controls.Add(lab);

            for (int j = 0; j < 7; j++)
            {
                var label = new Label();
                label.Text = week[j];
                label.Size = new Size(layout.Width / 9, 30);
                label.BorderStyle = BorderStyle.FixedSingle;
                label.BackColor = Color.Aqua;
                layout.Controls.Add(label);
            }

            for (int i = 0; i < 48; i++)
            {
                Label l = new Label();
                l.Size = new Size(layout.Width / 9, 80);
                l.BorderStyle = BorderStyle.FixedSingle;
                l.Text = (minutes/60).ToString() + ':' + (minutes%60);
                l.BackColor = Color.Beige;
                minutes += 30;
                layout.Controls.Add(l);

                for (int j = 0; j < 7; j++)
                {
                    var label = new Label();
                    label.Text = i.ToString() + ',' + j.ToString();
                    label.Size = new Size(layout.Width / 9, 80);
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Click += labelClick;
                    layout.Controls.Add(label);
                    labels[j, i] = label;
                    myLabels.Add(label, new MyLabel(j, i));
                }
            }
            */
        }

        private void labelClick(object sender, EventArgs e)
        {
            Label l = ((Label)sender);
            MyLabel myLabel = myLabels[l];
            l.BackColor = Color.Red;
            l.Text = "efwefwefwefwefwefwefwefwe";
            //l.Size = new Size(layout.Width / 9, 160);?
            labels[myLabel.X, myLabel.Y+1].BackColor = Color.Red;
        }
    }
}
