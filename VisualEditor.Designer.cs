namespace csharpSCConfigBuilder
{
    partial class VisualEditor
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
            trackBarMaxLifetime = new TrackBar();
            labelDesiredSpeed = new Label();
            trackBarDesiredSpeed = new TrackBar();
            labelMaxTrajectory = new Label();
            trackBarMaxTrajectory = new TrackBar();
            buttonAmmoSave = new Button();
            labelBaseDamage = new Label();
            textBox1 = new TextBox();
            trackBarBaseDamage = new TrackBar();
            buttonAmmoSelectDir = new Button();
            labelDisplayAmmoDir = new Label();
            comboBoxAmmoSelect = new ComboBox();
            tabWeapon = new TabPage();
            labelDisplayWeaponDir = new Label();
            textBox2 = new TextBox();
            buttonHelpWeapon = new Button();
            button3 = new Button();
            comboBoxWeaponSelect = new ComboBox();
            tabControl1.SuspendLayout();
            tabAmmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarMaxLifetime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDesiredSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarMaxTrajectory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBaseDamage).BeginInit();
            tabWeapon.SuspendLayout();
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
            tabAmmo.Controls.Add(trackBarMaxLifetime);
            tabAmmo.Controls.Add(labelDesiredSpeed);
            tabAmmo.Controls.Add(trackBarDesiredSpeed);
            tabAmmo.Controls.Add(labelMaxTrajectory);
            tabAmmo.Controls.Add(trackBarMaxTrajectory);
            tabAmmo.Controls.Add(buttonAmmoSave);
            tabAmmo.Controls.Add(labelBaseDamage);
            tabAmmo.Controls.Add(textBox1);
            tabAmmo.Controls.Add(trackBarBaseDamage);
            tabAmmo.Controls.Add(buttonAmmoSelectDir);
            tabAmmo.Controls.Add(labelDisplayAmmoDir);
            tabAmmo.Controls.Add(comboBoxAmmoSelect);
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
            trackBarBlue.BackColor = SystemColors.ControlLightLight;
            trackBarBlue.Location = new Point(687, 241);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(104, 45);
            trackBarBlue.TabIndex = 42;
            trackBarBlue.ValueChanged += trackBarBlue_ValueChanged;
            // 
            // trackBarGreen
            // 
            trackBarGreen.BackColor = SystemColors.ControlLightLight;
            trackBarGreen.Location = new Point(590, 241);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(104, 45);
            trackBarGreen.TabIndex = 41;
            trackBarGreen.ValueChanged += trackBarGreen_ValueChanged;
            // 
            // trackBarRed
            // 
            trackBarRed.BackColor = SystemColors.ControlLightLight;
            trackBarRed.Location = new Point(493, 241);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(104, 45);
            trackBarRed.TabIndex = 40;
            trackBarRed.ValueChanged += trackBarRed_ValueChanged;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(6, 6);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(47, 23);
            buttonHelp.TabIndex = 39;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
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
            // trackBarMaxLifetime
            // 
            trackBarMaxLifetime.BackColor = SystemColors.ControlLightLight;
            trackBarMaxLifetime.Location = new Point(184, 241);
            trackBarMaxLifetime.Maximum = 3600;
            trackBarMaxLifetime.Minimum = 1;
            trackBarMaxLifetime.Name = "trackBarMaxLifetime";
            trackBarMaxLifetime.RightToLeft = RightToLeft.No;
            trackBarMaxLifetime.Size = new Size(163, 45);
            trackBarMaxLifetime.TabIndex = 37;
            trackBarMaxLifetime.Value = 1;
            trackBarMaxLifetime.ValueChanged += trackBar4_ValueChanged;
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
            // trackBarDesiredSpeed
            // 
            trackBarDesiredSpeed.BackColor = SystemColors.ControlLightLight;
            trackBarDesiredSpeed.Location = new Point(15, 241);
            trackBarDesiredSpeed.Maximum = 10000;
            trackBarDesiredSpeed.Minimum = 1;
            trackBarDesiredSpeed.Name = "trackBarDesiredSpeed";
            trackBarDesiredSpeed.RightToLeft = RightToLeft.No;
            trackBarDesiredSpeed.Size = new Size(163, 45);
            trackBarDesiredSpeed.TabIndex = 35;
            trackBarDesiredSpeed.Value = 1;
            trackBarDesiredSpeed.ValueChanged += trackBar3_ValueChanged;
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
            // trackBarMaxTrajectory
            // 
            trackBarMaxTrajectory.BackColor = SystemColors.ControlLightLight;
            trackBarMaxTrajectory.Location = new Point(183, 175);
            trackBarMaxTrajectory.Maximum = 10000;
            trackBarMaxTrajectory.Minimum = 1;
            trackBarMaxTrajectory.Name = "trackBarMaxTrajectory";
            trackBarMaxTrajectory.RightToLeft = RightToLeft.No;
            trackBarMaxTrajectory.Size = new Size(163, 45);
            trackBarMaxTrajectory.TabIndex = 33;
            trackBarMaxTrajectory.Value = 1;
            trackBarMaxTrajectory.ValueChanged += trackBar2_ValueChanged;
            // 
            // buttonAmmoSave
            // 
            buttonAmmoSave.Location = new Point(374, 282);
            buttonAmmoSave.Name = "buttonAmmoSave";
            buttonAmmoSave.Size = new Size(75, 23);
            buttonAmmoSave.TabIndex = 32;
            buttonAmmoSave.Text = "Save";
            buttonAmmoSave.UseVisualStyleBackColor = true;
            buttonAmmoSave.Click += buttonAmmoSave_Click;
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
            // trackBarBaseDamage
            // 
            trackBarBaseDamage.BackColor = SystemColors.ControlLightLight;
            trackBarBaseDamage.Location = new Point(15, 175);
            trackBarBaseDamage.Maximum = 10000;
            trackBarBaseDamage.Minimum = 1;
            trackBarBaseDamage.Name = "trackBarBaseDamage";
            trackBarBaseDamage.RightToLeft = RightToLeft.No;
            trackBarBaseDamage.Size = new Size(163, 45);
            trackBarBaseDamage.TabIndex = 29;
            trackBarBaseDamage.Value = 1;
            trackBarBaseDamage.ValueChanged += trackBar1_ValueChanged;
            // 
            // buttonAmmoSelectDir
            // 
            buttonAmmoSelectDir.Location = new Point(352, 6);
            buttonAmmoSelectDir.Name = "buttonAmmoSelectDir";
            buttonAmmoSelectDir.Size = new Size(118, 23);
            buttonAmmoSelectDir.TabIndex = 27;
            buttonAmmoSelectDir.Text = "Select Directory";
            buttonAmmoSelectDir.UseVisualStyleBackColor = true;
            buttonAmmoSelectDir.Click += buttonAmmoSelectDir_Click;
            // 
            // labelDisplayAmmoDir
            // 
            labelDisplayAmmoDir.AutoSize = true;
            labelDisplayAmmoDir.Location = new Point(14, 630);
            labelDisplayAmmoDir.Name = "labelDisplayAmmoDir";
            labelDisplayAmmoDir.Size = new Size(54, 21);
            labelDisplayAmmoDir.TabIndex = 26;
            labelDisplayAmmoDir.Text = "Directory";
            labelDisplayAmmoDir.UseCompatibleTextRendering = true;
            // 
            // comboBoxAmmoSelect
            // 
            comboBoxAmmoSelect.FormattingEnabled = true;
            comboBoxAmmoSelect.Location = new Point(6, 35);
            comboBoxAmmoSelect.Name = "comboBoxAmmoSelect";
            comboBoxAmmoSelect.Size = new Size(776, 23);
            comboBoxAmmoSelect.TabIndex = 25;
            comboBoxAmmoSelect.SelectedIndexChanged += ComboBoxAmmoSelect_SelectedIndexChanged;
            // 
            // tabWeapon
            // 
            tabWeapon.Controls.Add(labelDisplayWeaponDir);
            tabWeapon.Controls.Add(textBox2);
            tabWeapon.Controls.Add(buttonHelpWeapon);
            tabWeapon.Controls.Add(button3);
            tabWeapon.Controls.Add(comboBoxWeaponSelect);
            tabWeapon.Location = new Point(4, 24);
            tabWeapon.Name = "tabWeapon";
            tabWeapon.Padding = new Padding(3);
            tabWeapon.Size = new Size(825, 681);
            tabWeapon.TabIndex = 1;
            tabWeapon.Text = "Weapon";
            tabWeapon.UseVisualStyleBackColor = true;
            // 
            // labelDisplayWeaponDir
            // 
            labelDisplayWeaponDir.AutoSize = true;
            labelDisplayWeaponDir.Location = new Point(14, 630);
            labelDisplayWeaponDir.Name = "labelDisplayWeaponDir";
            labelDisplayWeaponDir.Size = new Size(54, 21);
            labelDisplayWeaponDir.TabIndex = 44;
            labelDisplayWeaponDir.Text = "Directory";
            labelDisplayWeaponDir.UseCompatibleTextRendering = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(14, 311);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(776, 316);
            textBox2.TabIndex = 43;
            // 
            // buttonHelpWeapon
            // 
            buttonHelpWeapon.Location = new Point(6, 6);
            buttonHelpWeapon.Name = "buttonHelpWeapon";
            buttonHelpWeapon.Size = new Size(47, 23);
            buttonHelpWeapon.TabIndex = 42;
            buttonHelpWeapon.Text = "?";
            buttonHelpWeapon.UseVisualStyleBackColor = true;
            buttonHelpWeapon.Click += buttonHelpWeapon_Click;
            // 
            // button3
            // 
            button3.Location = new Point(352, 6);
            button3.Name = "button3";
            button3.Size = new Size(118, 23);
            button3.TabIndex = 41;
            button3.Text = "Select Directory";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxWeaponSelect
            // 
            comboBoxWeaponSelect.FormattingEnabled = true;
            comboBoxWeaponSelect.Location = new Point(6, 35);
            comboBoxWeaponSelect.Name = "comboBoxWeaponSelect";
            comboBoxWeaponSelect.Size = new Size(776, 23);
            comboBoxWeaponSelect.TabIndex = 40;
            comboBoxWeaponSelect.SelectedIndexChanged += comboBoxWeaponSelect_SelectedIndexChanged;
            // 
            // VisualEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 735);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VisualEditor";
            Text = "SCConfigBuilder";
            tabControl1.ResumeLayout(false);
            tabAmmo.ResumeLayout(false);
            tabAmmo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarMaxLifetime).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDesiredSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarMaxTrajectory).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBaseDamage).EndInit();
            tabWeapon.ResumeLayout(false);
            tabWeapon.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelColor;
        private Label labelBlue;
        private Label labelGreen;
        private Label labelRed;
        private TrackBar trackBarBlue;
        private TrackBar trackBarGreen;
        private TrackBar trackBarRed;
        private Button buttonHelp;
        private Label labelMaxLifeTime;
        private TrackBar trackBarMaxLifetime;
        private Label labelDesiredSpeed;
        private TrackBar trackBarDesiredSpeed;
        private Label labelMaxTrajectory;
        private TrackBar trackBarMaxTrajectory;
        private Button buttonAmmoSave;
        private Label labelBaseDamage;
        private TextBox textBox1;
        private TrackBar trackBarBaseDamage;
        private Button buttonAmmoSelectDir;
        private Label labelDisplayAmmoDir;
        private ComboBox comboBoxAmmoSelect;
        private TabControl tabControl1;
        private TabPage tabAmmo;
        private TabPage tabWeapon;
        private Button buttonHelpWeapon;
        private Button button3;
        private ComboBox comboBoxWeaponSelect;
        private Label labelDisplayWeaponDir;
        private TextBox textBox2;
    }
}