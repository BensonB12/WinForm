namespace WinFormsPractice
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.NumberOfHorses = new System.Windows.Forms.NumericUpDown();
            this.HorseNumLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WildButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfHorses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(299, 359);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberOfHorses
            // 
            this.NumberOfHorses.Location = new System.Drawing.Point(120, 35);
            this.NumberOfHorses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfHorses.Name = "NumberOfHorses";
            this.NumberOfHorses.Size = new System.Drawing.Size(120, 23);
            this.NumberOfHorses.TabIndex = 1;
            this.NumberOfHorses.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumberOfHorses.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // HorseNumLabel
            // 
            this.HorseNumLabel.AutoSize = true;
            this.HorseNumLabel.Location = new System.Drawing.Point(10, 37);
            this.HorseNumLabel.Name = "HorseNumLabel";
            this.HorseNumLabel.Size = new System.Drawing.Size(104, 15);
            this.HorseNumLabel.TabIndex = 2;
            this.HorseNumLabel.Text = "Number of Horses";
            this.HorseNumLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumberOfHorses);
            this.groupBox1.Controls.Add(this.HorseNumLabel);
            this.groupBox1.Location = new System.Drawing.Point(428, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // WildButton
            // 
            this.WildButton.Location = new System.Drawing.Point(289, 81);
            this.WildButton.Name = "WildButton";
            this.WildButton.Size = new System.Drawing.Size(169, 23);
            this.WildButton.TabIndex = 4;
            this.WildButton.Text = "Can\'t Click me twice";
            this.WildButton.UseVisualStyleBackColor = true;
            this.WildButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 449);
            this.Controls.Add(this.WildButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfHorses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartButton;
        private NumericUpDown NumberOfHorses;
        private Label HorseNumLabel;
        private GroupBox groupBox1;
        private Button WildButton;
    }
}