
namespace Lab3
{
    partial class Memory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.timer = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.twoUncoveredTimer = new System.Windows.Forms.Timer(this.components);
            this.stoper = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.visible2tiles = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.freeze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.layout.ColumnCount = 6;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.Location = new System.Drawing.Point(70, 48);
            this.layout.Name = "layout";
            this.layout.RowCount = 7;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.layout.Size = new System.Drawing.Size(1717, 801);
            this.layout.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timer.AutoSize = true;
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timer.Location = new System.Drawing.Point(70, 918);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(51, 22);
            this.timer.TabIndex = 1;
            this.timer.Text = "Time: ";
            // 
            // startTimer
            // 
            this.startTimer.Interval = 5000;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // twoUncoveredTimer
            // 
            this.twoUncoveredTimer.Interval = 1000;
            this.twoUncoveredTimer.Tick += new System.EventHandler(this.twoUncoveredTimer_Tick);
            // 
            // stoper
            // 
            this.stoper.Interval = 1000;
            this.stoper.Tick += new System.EventHandler(this.stoper_Tick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1170, 920);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "10";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 920);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "1";
            // 
            // visible2tiles
            // 
            this.visible2tiles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.visible2tiles.LargeChange = 1;
            this.visible2tiles.Location = new System.Drawing.Point(885, 918);
            this.visible2tiles.Maximum = 10;
            this.visible2tiles.Minimum = 1;
            this.visible2tiles.Name = "visible2tiles";
            this.visible2tiles.Size = new System.Drawing.Size(267, 23);
            this.visible2tiles.TabIndex = 8;
            this.visible2tiles.Value = 1;
            this.visible2tiles.Scroll += new System.Windows.Forms.ScrollEventHandler(this.visible2tiles_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 920);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Visibilty of 2 last tiles:";
            // 
            // freeze
            // 
            this.freeze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.freeze.Location = new System.Drawing.Point(1627, 911);
            this.freeze.Name = "freeze";
            this.freeze.Size = new System.Drawing.Size(160, 30);
            this.freeze.TabIndex = 13;
            this.freeze.Text = "Freeze";
            this.freeze.UseVisualStyleBackColor = true;
            this.freeze.Click += new System.EventHandler(this.freeze_Click);
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 973);
            this.Controls.Add(this.freeze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.visible2tiles);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.layout);
            this.Name = "Memory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Memory_FormClosed);
            this.Load += new System.EventHandler(this.Memory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label timer;
        public System.Windows.Forms.Timer startTimer;
        public System.Windows.Forms.Timer twoUncoveredTimer;
        private System.Windows.Forms.Timer stoper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.HScrollBar visible2tiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button freeze;
    }
}

