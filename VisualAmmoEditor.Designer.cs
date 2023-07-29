namespace csharpSCConfigBuilder
{
    partial class VisualAmmoEditor
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
            comboBox1 = new ComboBox();
            labelDirectory = new Label();
            button1 = new Button();
            labelCurrentMode = new Label();
            trackBar1 = new TrackBar();
            textBox1 = new TextBox();
            labelBaseDamage = new Label();
            button2 = new Button();
            labelMaxTrajectory = new Label();
            trackBar2 = new TrackBar();
            labelDesiredSpeed = new Label();
            trackBar3 = new TrackBar();
            labelMaxLifeTime = new Label();
            trackBar4 = new TrackBar();
            buttonHelp = new Button();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            labelRed = new Label();
            labelGreen = new Label();
            labelBlue = new Label();
            panelColor = new Panel();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(776, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // labelDirectory
            // 
            labelDirectory.AutoSize = true;
            labelDirectory.Location = new Point(12, 614);
            labelDirectory.Name = "labelDirectory";
            labelDirectory.Size = new Size(54, 21);
            labelDirectory.TabIndex = 2;
            labelDirectory.Text = "Directory";
            labelDirectory.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            button1.Location = new Point(353, 9);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 3;
            button1.Text = "Select Directory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelCurrentMode
            // 
            labelCurrentMode.AutoSize = true;
            labelCurrentMode.Location = new Point(12, 635);
            labelCurrentMode.Name = "labelCurrentMode";
            labelCurrentMode.Size = new Size(81, 15);
            labelCurrentMode.TabIndex = 4;
            labelCurrentMode.Text = "Current Mode";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(42, 117);
            trackBar1.Maximum = 10000;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.RightToLeft = RightToLeft.No;
            trackBar1.Size = new Size(163, 45);
            trackBar1.TabIndex = 5;
            trackBar1.Value = 1;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(12, 295);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(776, 316);
            textBox1.TabIndex = 6;
            // 
            // labelBaseDamage
            // 
            labelBaseDamage.AutoSize = true;
            labelBaseDamage.Location = new Point(77, 99);
            labelBaseDamage.Name = "labelBaseDamage";
            labelBaseDamage.Size = new Size(75, 15);
            labelBaseDamage.TabIndex = 7;
            labelBaseDamage.Text = "BaseDamage";
            labelBaseDamage.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(353, 252);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelMaxTrajectory
            // 
            labelMaxTrajectory.AutoSize = true;
            labelMaxTrajectory.Location = new Point(245, 99);
            labelMaxTrajectory.Name = "labelMaxTrajectory";
            labelMaxTrajectory.Size = new Size(81, 15);
            labelMaxTrajectory.TabIndex = 10;
            labelMaxTrajectory.Text = "MaxTrajectory";
            labelMaxTrajectory.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(210, 117);
            trackBar2.Maximum = 10000;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.RightToLeft = RightToLeft.No;
            trackBar2.Size = new Size(163, 45);
            trackBar2.TabIndex = 9;
            trackBar2.Value = 1;
            // 
            // labelDesiredSpeed
            // 
            labelDesiredSpeed.AutoSize = true;
            labelDesiredSpeed.Location = new Point(77, 165);
            labelDesiredSpeed.Name = "labelDesiredSpeed";
            labelDesiredSpeed.Size = new Size(78, 15);
            labelDesiredSpeed.TabIndex = 12;
            labelDesiredSpeed.Text = "DesiredSpeed";
            labelDesiredSpeed.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(42, 183);
            trackBar3.Maximum = 10000;
            trackBar3.Minimum = 1;
            trackBar3.Name = "trackBar3";
            trackBar3.RightToLeft = RightToLeft.No;
            trackBar3.Size = new Size(163, 45);
            trackBar3.TabIndex = 11;
            trackBar3.Value = 1;
            // 
            // labelMaxLifeTime
            // 
            labelMaxLifeTime.AutoSize = true;
            labelMaxLifeTime.Location = new Point(245, 165);
            labelMaxLifeTime.Name = "labelMaxLifeTime";
            labelMaxLifeTime.Size = new Size(75, 15);
            labelMaxLifeTime.TabIndex = 14;
            labelMaxLifeTime.Text = "MaxLifeTime";
            labelMaxLifeTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(211, 183);
            trackBar4.Maximum = 3600;
            trackBar4.Minimum = 1;
            trackBar4.Name = "trackBar4";
            trackBar4.RightToLeft = RightToLeft.No;
            trackBar4.Size = new Size(163, 45);
            trackBar4.TabIndex = 13;
            trackBar4.Value = 1;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(12, 9);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(47, 23);
            buttonHelp.TabIndex = 15;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(490, 230);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(104, 45);
            trackBarRed.TabIndex = 16;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(587, 230);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(104, 45);
            trackBarGreen.TabIndex = 17;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(684, 230);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(104, 45);
            trackBarBlue.TabIndex = 18;
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Location = new Point(524, 213);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(27, 15);
            labelRed.TabIndex = 21;
            labelRed.Text = "Red";
            labelRed.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Location = new Point(618, 213);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(38, 15);
            labelGreen.TabIndex = 22;
            labelGreen.Text = "Green";
            labelGreen.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelBlue
            // 
            labelBlue.AutoSize = true;
            labelBlue.Location = new Point(719, 213);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(30, 15);
            labelBlue.TabIndex = 23;
            labelBlue.Text = "Blue";
            labelBlue.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelColor
            // 
            panelColor.BackColor = SystemColors.Control;
            panelColor.Location = new Point(587, 108);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(104, 82);
            panelColor.TabIndex = 24;
            // 
            // VisualAmmoEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 659);
            Controls.Add(panelColor);
            Controls.Add(labelBlue);
            Controls.Add(labelGreen);
            Controls.Add(labelRed);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Controls.Add(buttonHelp);
            Controls.Add(labelMaxLifeTime);
            Controls.Add(trackBar4);
            Controls.Add(labelDesiredSpeed);
            Controls.Add(trackBar3);
            Controls.Add(labelMaxTrajectory);
            Controls.Add(trackBar2);
            Controls.Add(button2);
            Controls.Add(labelBaseDamage);
            Controls.Add(textBox1);
            Controls.Add(trackBar1);
            Controls.Add(labelCurrentMode);
            Controls.Add(button1);
            Controls.Add(labelDirectory);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VisualAmmoEditor";
            Text = "SCConfigBuilder";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label labelDirectory;
        private Button button1;
        private Label labelCurrentMode;
        private TrackBar trackBar1;
        private TextBox textBox1;
        private Label labelBaseDamage;
        private Button button2;
        private Label labelMaxTrajectory;
        private TrackBar trackBar2;
        private Label labelDesiredSpeed;
        private TrackBar trackBar3;
        private Label labelMaxLifeTime;
        private TrackBar trackBar4;
        private Button buttonHelp;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Label labelRed;
        private Label labelGreen;
        private Label labelBlue;
        private Panel panelColor;
    }
}