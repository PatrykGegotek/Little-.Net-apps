using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Memory;
using System.IO;

namespace Lab3
{
    public partial class Memory : Form
    {
        static List<Button> buttons;
        static int uncoverdCount;
        static Button[] clickedButtons;
        static Color[] colors;
        static int[] values;
        public static int startTime = 5000;
        public static int twoUncoverTime = 1000;

        List<(string, int, string)> tupleList;
        Congrats congrats;
        string difficultyStr;
        int difficultyInt;
        int timeCount;
        int rowCount;
        int columnCount;
        int correctTilesCount;
        int clicksCount;

        public Memory(int difficulty)
        {
            InitializeComponent();

            //statics
            buttons = new List<Button>();
            uncoverdCount = 0;
            clickedButtons = new Button[2];

            //nonstatics
            tupleList = new List<(string, int, string)>();
            timeCount = 0;
            correctTilesCount = 0;
            clicksCount = 0;
            difficultyInt = difficulty;

            if (difficulty == 0)
            {
                rowCount = 4;
                columnCount = 5;
                difficultyStr = "easy";
            } else if (difficulty == 1)
            {
                rowCount = 6;
                columnCount = 10;
                difficultyStr = "medium";
            } else
            {
                rowCount = 10;
                columnCount = 12;
                difficultyStr = "hard";
            }
        }

        //cretes layout of tiles
        private void createLayout()
        {
            this.layout.ColumnCount = columnCount;
            this.layout.RowCount = rowCount;

            this.layout.ColumnStyles.Clear();
            this.layout.RowStyles.Clear();

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

            Font font = new Font("Webdings", 25);
            //adds buttons 
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var button = new Button();
                    button.Text = string.Format("");
                    button.Name = string.Format("button_{0}_{1}", i, j);
                    button.Dock = DockStyle.Fill;
                    button.Font = font;
                    this.layout.Controls.Add(button, j, i);
                    buttons.Add(button);
                }

            }
        }

        private void Memory_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int howMany = rowCount * columnCount;
            colors = new Color[howMany];
            values = new int[howMany];

            createLayout();

            //create labels on buttons
            float f = 0;
            for (int i = 0; i < howMany; i++)
            {
                values[i] = (int)f;
                f += 0.5f;
            }

            //create colors
            for (int i = 0; i < howMany / 2; i++)
            {
                colors[i] = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            }

            //shuffle labels
            for (int i = 0; i < howMany; i++)
            {
                int rand = rnd.Next(0, howMany);
                int swap = values[rand];
                values[rand] = values[i];
                values[i] = swap;
            }

            //assign colors and labels to buttons
            int k = 0;
            foreach (var button in buttons)
            {
                button.Click += button_Click;
                button.Text = ((char)(values[k] + 60)).ToString();
                button.BackColor = colors[values[k]];
                k++;
                button.ForeColor = Color.Black;
            }

            startTimer.Interval = startTime;
            startTimer.Enabled = true;
            twoUncoveredTimer.Interval = twoUncoverTime;
            visible2tiles.Value = twoUncoveredTimer.Interval / 1000;
        }

        private void Memory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainScreen.Show();
        }

        private void button_Click(object sender, EventArgs eventArgs)
        {
            //do nothing while showing the tiles
            if (this.startTimer.Enabled == true || this.twoUncoveredTimer.Enabled == true 
                || this.stoper.Enabled == false) return;

            clicksCount++;

            //clear array of clicked tiles
            if (uncoverdCount == 2)
            {
                uncoverdCount = 0;
                for(int i = 0; i < 2; i++)
                {
                    clickedButtons[i].ForeColor = clickedButtons[i].BackColor = Color.White;
                    clickedButtons[i] = null;
                }
                
            } 

            var button = (Button)sender;

            //if clicked on already clicked tile do nothing
            if(uncoverdCount == 1 && button == clickedButtons[0])
                uncoverdCount--;

            //add tile to array of clicked tiles, change color of background and label
            clickedButtons[uncoverdCount++] = button;
            String str = button.Text;
            char[] t = str.ToCharArray();
            char a = t[0];
            int index = (int)a - 60;
            
            button.ForeColor = Color.Black;
            button.BackColor = colors[index];

            //wait some time after oncovering two tiles
            if (uncoverdCount == 2)
            {
                this.twoUncoveredTimer.Enabled = true;
            }
               
            //check if tiles match
            if (uncoverdCount == 2 && clickedButtons[0].Text == clickedButtons[1].Text)
            {
                //clickedButtons[0].Hide();
                clickedButtons[0].Enabled = false;
                //clickedButtons[1].Hide();
                clickedButtons[1].Enabled = false;
                correctTilesCount += 2;
                this.twoUncoveredTimer.Enabled = false;
            }
             
            //check if game has been finished
            if (correctTilesCount == columnCount * rowCount)
            {
                stoper.Enabled = false;
                float score = (float)(clicksCount * 4 * timeCount/10);
                score = 1000000f / score * (difficultyInt + 2)*(difficultyInt + 2);
                showWinningMessage((int)score);
                
                Program.mainScreen.Show();
                this.Close();
            }
        }

        //shows winning dialog
        private void showWinningMessage(int score)
        {
            String message = $"ConDRAGulations! You've finished {difficultyStr} difficulty within " +
                    $"{timeCount / 60} minutes and {timeCount % 60} second and scored {score}";
            congrats = new Congrats();
            congrats.label1.Text = message;
            congrats.ShowDialog();
            //MessageBox.Show(message);
            addToRanking(congrats.str, score);
        }

        private void addToRanking(String name, int score)
        {
            string fileName = ".\\Ranking.txt";
            fileName = AppDomain.CurrentDomain.BaseDirectory + fileName;
            checkExistance(fileName);

            StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(difficultyStr + '\n' + score + '\n' + name);
            writer.Close();
            showRanking(fileName);
        }

        private void checkExistance(string fileName)
        {
            if(!File.Exists(fileName))
            {
                var f = File.CreateText(fileName);
                f.Close();
            }
        }

        private void showRanking(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string line = reader.ReadLine();
            string name = "";
            int score = 0;
            string diffic = "";
            int i = 0;
            (string, int, string) tuple;
            while (line != null)
            {
                if(i == 0)
                {
                    diffic = line;
                } else if (i == 1)
                {
                    score = Int32.Parse(line);
                } else
                {
                    name = line;
                }
                if (i == 2 && diffic == difficultyStr)
                {
                    tuple = (diffic, score, name);
                    tupleList.Add(tuple);
                }
                if (i == 2) i = -1;
                i++;
                line = reader.ReadLine();
            }
            reader.Close();
            tupleList.Sort((x, y) => y.Item2.CompareTo(x.Item2));
            createRanking();
        }

        void createRanking()
        {
            Ranking ranking = new Ranking();
            ranking.listView1.Columns.Add("Player", 250);
            ranking.listView1.Columns.Add("Score", 250);
            ranking.listView1.View = View.Details;
            ranking.listView1.GridLines = true;
            ranking.listView1.FullRowSelect = true;
            ranking.label1.Text = "Difficulty: " + difficultyStr;
            foreach (var game in tupleList) {
                String[] str = new String[2];
                str[0] = game.Item3;
                str[1] = game.Item2.ToString();
                ranking.listView1.Items.Add(new ListViewItem(str));
            }
            ranking.ShowDialog();
        }

        //set how long tiles are visible
        private void startTimer_Tick(object sender, EventArgs e)
        {
            foreach (var button in buttons)
            {
                button.ForeColor = button.BackColor = Color.White;
            }
            ((Timer)sender).Enabled = false;
            stoper.Enabled = true;
        }

        //set how long 2 uncovered tiles remain visible
        private void twoUncoveredTimer_Tick(object sender, EventArgs e)
        {
            uncoverdCount = 0;
            for (int i = 0; i < 2; i++)
            {
                clickedButtons[i].ForeColor = clickedButtons[i].BackColor = Color.White;
                clickedButtons[i] = null;
            }
            ((Timer)sender).Enabled = false;
        }

        //count time
        private void stoper_Tick(object sender, EventArgs e)
        {
            timeCount++;
            timer.Text = "Time: " + $"{timeCount / 60}:{timeCount % 60}";
        }

        //open main windows after closing
        

        private void visible2tiles_Scroll(object sender, ScrollEventArgs e)
        {
            twoUncoveredTimer.Interval = visible2tiles.Value * 1000;
        }

        private void freeze_Click(object sender, EventArgs e)
        {
            if(this.stoper.Enabled == true && uncoverdCount == 0)
            {
                this.stoper.Enabled = false;
                this.timer.Text = "FROZEN";
            }
            else
            {
                this.stoper.Enabled = true;
            }
        }

        static Predicate<Button> ByName(string name)
        {
            return delegate (Button button)
            {
                return button.Name == name;
            };
        }
    }
}
