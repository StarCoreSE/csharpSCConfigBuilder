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
            tabControl1 = new TabControl();
            tabAmmo = new TabPage();
            panelColor = new Panel();
            labelBlue = new Label();
            labelGreen = new Label();
            labelRed = new Label();
            trackBarBlue = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarRed = new TrackBar();
            buttonHelp = new Button();
            labelMaxLifeTime = new Label();
            trackBar4 = new TrackBar();
            labelDesiredSpeed = new Label();
            trackBar3 = new TrackBar();
            labelMaxTrajectory = new Label();
            trackBar2 = new TrackBar();
            button2 = new Button();
            labelBaseDamage = new Label();
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            labelCurrentMode = new Label();
            button1 = new Button();
            labelDirectory = new Label();
            comboBox1 = new ComboBox();
            tabWeapon = new TabPage();
            tabControl1.SuspendLayout();
            tabAmmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAmmo);
            tabControl1.Controls.Add(tabWeapon);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(833, 709);
            tabControl1.TabIndex = 25;
            // 
            // tabAmmo
            // 
            tabAmmo.Controls.Add(panelColor);
            tabAmmo.Controls.Add(labelBlue);
            tabAmmo.Controls.Add(labelGreen);
            tabAmmo.Controls.Add(labelRed);
            tabAmmo.Controls.Add(trackBarBlue);
            tabAmmo.Controls.Add(trackBarGreen);
            tabAmmo.Controls.Add(trackBarRed);
            tabAmmo.Controls.Add(buttonHelp);
            tabAmmo.Controls.Add(labelMaxLifeTime);
            tabAmmo.Controls.Add(trackBar4);
            tabAmmo.Controls.Add(labelDesiredSpeed);
            tabAmmo.Controls.Add(trackBar3);
            tabAmmo.Controls.Add(labelMaxTrajectory);
            tabAmmo.Controls.Add(trackBar2);
            tabAmmo.Controls.Add(button2);
            tabAmmo.Controls.Add(labelBaseDamage);
            tabAmmo.Controls.Add(textBox1);
            tabAmmo.Controls.Add(trackBar1);
            tabAmmo.Controls.Add(labelCurrentMode);
            tabAmmo.Controls.Add(button1);
            tabAmmo.Controls.Add(labelDirectory);
            tabAmmo.Controls.Add(comboBox1);
            tabAmmo.Location = new Point(4, 24);
            tabAmmo.Name = "tabAmmo";
            tabAmmo.Padding = new Padding(3);
            tabAmmo.Size = new Size(825, 681);
            tabAmmo.TabIndex = 0;
            tabAmmo.Text = "Ammo";
            tabAmmo.UseVisualStyleBackColor = true;
            // 
            // panelColor
            // 
            panelColor.BackColor = SystemColors.Control;
            panelColor.Location = new Point(590, 119);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(104, 82);
            panelColor.TabIndex = 46;
            // 
            // labelBlue
            // 
            labelBlue.AutoSize = true;
            labelBlue.Location = new Point(722, 224);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(30, 15);
            labelBlue.TabIndex = 45;
            labelBlue.Text = "Blue";
            labelBlue.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Location = new Point(621, 224);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(38, 15);
            labelGreen.TabIndex = 44;
            labelGreen.Text = "Green";
            labelGreen.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Location = new Point(527, 224);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(27, 15);
            labelRed.TabIndex = 43;
            labelRed.Text = "Red";
            labelRed.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(687, 241);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(104, 45);
            trackBarBlue.TabIndex = 42;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(590, 241);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(104, 45);
            trackBarGreen.TabIndex = 41;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(493, 241);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(104, 45);
            trackBarRed.TabIndex = 40;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(15, 20);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(47, 23);
            buttonHelp.TabIndex = 39;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // labelMaxLifeTime
            // 
            labelMaxLifeTime.AutoSize = true;
            labelMaxLifeTime.Location = new Point(218, 223);
            labelMaxLifeTime.Name = "labelMaxLifeTime";
            labelMaxLifeTime.Size = new Size(75, 15);
            labelMaxLifeTime.TabIndex = 38;
            labelMaxLifeTime.Text = "MaxLifeTime";
            labelMaxLifeTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(184, 241);
            trackBar4.Maximum = 3600;
            trackBar4.Minimum = 1;
            trackBar4.Name = "trackBar4";
            trackBar4.RightToLeft = RightToLeft.No;
            trackBar4.Size = new Size(163, 45);
            trackBar4.TabIndex = 37;
            trackBar4.Value = 1;
            // 
            // labelDesiredSpeed
            // 
            labelDesiredSpeed.AutoSize = true;
            labelDesiredSpeed.Location = new Point(50, 223);
            labelDesiredSpeed.Name = "labelDesiredSpeed";
            labelDesiredSpeed.Size = new Size(78, 15);
            labelDesiredSpeed.TabIndex = 36;
            labelDesiredSpeed.Text = "DesiredSpeed";
            labelDesiredSpeed.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(15, 241);
            trackBar3.Maximum = 10000;
            trackBar3.Minimum = 1;
            trackBar3.Name = "trackBar3";
            trackBar3.RightToLeft = RightToLeft.No;
            trackBar3.Size = new Size(163, 45);
            trackBar3.TabIndex = 35;
            trackBar3.Value = 1;
            // 
            // labelMaxTrajectory
            // 
            labelMaxTrajectory.AutoSize = true;
            labelMaxTrajectory.Location = new Point(218, 157);
            labelMaxTrajectory.Name = "labelMaxTrajectory";
            labelMaxTrajectory.Size = new Size(81, 15);
            labelMaxTrajectory.TabIndex = 34;
            labelMaxTrajectory.Text = "MaxTrajectory";
            labelMaxTrajectory.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(183, 175);
            trackBar2.Maximum = 10000;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.RightToLeft = RightToLeft.No;
            trackBar2.Size = new Size(163, 45);
            trackBar2.TabIndex = 33;
            trackBar2.Value = 1;
            // 
            // button2
            // 
            button2.Location = new Point(399, 263);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 32;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // labelBaseDamage
            // 
            labelBaseDamage.AutoSize = true;
            labelBaseDamage.Location = new Point(50, 157);
            labelBaseDamage.Name = "labelBaseDamage";
            labelBaseDamage.Size = new Size(75, 15);
            labelBaseDamage.TabIndex = 31;
            labelBaseDamage.Text = "BaseDamage";
            labelBaseDamage.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(14, 311);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(776, 316);
            textBox1.TabIndex = 30;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(15, 175);
            trackBar1.Maximum = 10000;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.RightToLeft = RightToLeft.No;
            trackBar1.Size = new Size(163, 45);
            trackBar1.TabIndex = 29;
            trackBar1.Value = 1;
            // 
            // labelCurrentMode
            // 
            labelCurrentMode.AutoSize = true;
            labelCurrentMode.Location = new Point(14, 651);
            labelCurrentMode.Name = "labelCurrentMode";
            labelCurrentMode.Size = new Size(81, 15);
            labelCurrentMode.TabIndex = 28;
            labelCurrentMode.Text = "Current Mode";
            // 
            // button1
            // 
            button1.Location = new Point(356, 20);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 27;
            button1.Text = "Select Directory";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelDirectory
            // 
            labelDirectory.AutoSize = true;
            labelDirectory.Location = new Point(14, 630);
            labelDirectory.Name = "labelDirectory";
            labelDirectory.Size = new Size(54, 21);
            labelDirectory.TabIndex = 26;
            labelDirectory.Text = "Directory";
            labelDirectory.UseCompatibleTextRendering = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(776, 23);
            comboBox1.TabIndex = 25;
            // 
            // tabWeapon
            // 
            tabWeapon.Location = new Point(4, 24);
            tabWeapon.Name = "tabWeapon";
            tabWeapon.Padding = new Padding(3);
            tabWeapon.Size = new Size(1069, 720);
            tabWeapon.TabIndex = 1;
            tabWeapon.Text = "Weapon";
            tabWeapon.UseVisualStyleBackColor = true;
            // 
            // VisualAmmoEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 735);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VisualAmmoEditor";
            Text = "SCConfigBuilder";
            tabControl1.ResumeLayout(false);
            tabAmmo.ResumeLayout(false);
            tabAmmo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabAmmo;
        private TabPage tabWeapon;
        private Panel panelColor;
        private Label labelBlue;
        private Label labelGreen;
        private Label labelRed;
        private TrackBar trackBarBlue;
        private TrackBar trackBarGreen;
        private TrackBar trackBarRed;
        private Button buttonHelp;
        private Label labelMaxLifeTime;
        private TrackBar trackBar4;
        private Label labelDesiredSpeed;
        private TrackBar trackBar3;
        private Label labelMaxTrajectory;
        private TrackBar trackBar2;
        private Button button2;
        private Label labelBaseDamage;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private Label labelCurrentMode;
        private Button button1;
        private Label labelDirectory;
        private ComboBox comboBox1;
    }
}