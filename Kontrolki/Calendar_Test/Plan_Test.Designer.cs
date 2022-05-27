namespace Calendar_Test
{
    partial class Plan_Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.planner1 = new Planner.Planner();
            this.SuspendLayout();
            // 
            // planner1
            // 
            this.planner1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planner1.Location = new System.Drawing.Point(13, 25);
            this.planner1.Name = "planner1";
            this.planner1.Size = new System.Drawing.Size(931, 471);
            this.planner1.TabIndex = 0;
            // 
            // Cal_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 513);
            this.Controls.Add(this.planner1);
            this.Name = "Cal_Test";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Planner.Planner planner1;
    }
}