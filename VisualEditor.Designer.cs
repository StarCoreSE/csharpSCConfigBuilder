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
            textBoxAmmo = new TextBox();
            trackBarBaseDamage = new TrackBar();
            buttonAmmoSelectDir = new Button();
            labelDisplayAmmoDir = new Label();
            comboBoxAmmoSelect = new ComboBox();
            tabWeapon = new TabPage();
            numericUpDownElevateRate = new NumericUpDown();
            numericUpDownRotateRate = new NumericUpDown();
            labelElevateRate = new Label();
            labelRotateRate = new Label();
            labelReloadTime = new Label();
            trackBarReloadTime = new TrackBar();
            buttonWeaponSave = new Button();
            labelRateOfFire = new Label();
            trackBarRateOfFire = new TrackBar();
            labelDisplayWeaponDir = new Label();
            textBoxWeapon = new TextBox();
            buttonHelpWeapon = new Button();
            buttonWeaponSelectDir = new Button();
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownElevateRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRotateRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarReloadTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRateOfFire).BeginInit();
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
            tabAmmo.Controls.Add(textBoxAmmo);
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
            // textBoxAmmo
            // 
            textBoxAmmo.BackColor = SystemColors.ButtonHighlight;
            textBoxAmmo.Location = new Point(14, 311);
            textBoxAmmo.Multiline = true;
            textBoxAmmo.Name = "textBoxAmmo";
            textBoxAmmo.ReadOnly = true;
            textBoxAmmo.ScrollBars = ScrollBars.Both;
            textBoxAmmo.Size = new Size(776, 316);
            textBoxAmmo.TabIndex = 30;
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
            tabWeapon.Controls.Add(numericUpDownElevateRate);
            tabWeapon.Controls.Add(numericUpDownRotateRate);
            tabWeapon.Controls.Add(labelElevateRate);
            tabWeapon.Controls.Add(labelRotateRate);
            tabWeapon.Controls.Add(labelReloadTime);
            tabWeapon.Controls.Add(trackBarReloadTime);
            tabWeapon.Controls.Add(buttonWeaponSave);
            tabWeapon.Controls.Add(labelRateOfFire);
            tabWeapon.Controls.Add(trackBarRateOfFire);
            tabWeapon.Controls.Add(labelDisplayWeaponDir);
            tabWeapon.Controls.Add(textBoxWeapon);
            tabWeapon.Controls.Add(buttonHelpWeapon);
            tabWeapon.Controls.Add(buttonWeaponSelectDir);
            tabWeapon.Controls.Add(comboBoxWeaponSelect);
            tabWeapon.Location = new Point(4, 24);
            tabWeapon.Name = "tabWeapon";
            tabWeapon.Padding = new Padding(3);
            tabWeapon.Size = new Size(825, 681);
            tabWeapon.TabIndex = 1;
            tabWeapon.Text = "Weapon";
            tabWeapon.UseVisualStyleBackColor = true;
            // 
            // numericUpDownElevateRate
            // 
            numericUpDownElevateRate.DecimalPlaces = 3;
            numericUpDownElevateRate.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownElevateRate.Location = new Point(200, 259);
            numericUpDownElevateRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownElevateRate.Name = "numericUpDownElevateRate";
            numericUpDownElevateRate.Size = new Size(120, 23);
            numericUpDownElevateRate.TabIndex = 55;
            numericUpDownElevateRate.ValueChanged += numericUpDownElevateRate_ValueChanged;
            // 
            // numericUpDownRotateRate
            // 
            numericUpDownRotateRate.DecimalPlaces = 3;
            numericUpDownRotateRate.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownRotateRate.Location = new Point(200, 226);
            numericUpDownRotateRate.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRotateRate.Name = "numericUpDownRotateRate";
            numericUpDownRotateRate.Size = new Size(120, 23);
            numericUpDownRotateRate.TabIndex = 54;
            numericUpDownRotateRate.ValueChanged += numericUpDownRotateRate_ValueChanged;
            // 
            // labelElevateRate
            // 
            labelElevateRate.AutoSize = true;
            labelElevateRate.Location = new Point(56, 261);
            labelElevateRate.Name = "labelElevateRate";
            labelElevateRate.Size = new Size(67, 15);
            labelElevateRate.TabIndex = 53;
            labelElevateRate.Text = "ElevateRate";
            labelElevateRate.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelRotateRate
            // 
            labelRotateRate.AutoSize = true;
            labelRotateRate.Location = new Point(56, 228);
            labelRotateRate.Name = "labelRotateRate";
            labelRotateRate.Size = new Size(64, 15);
            labelRotateRate.TabIndex = 51;
            labelRotateRate.Text = "RotateRate";
            labelRotateRate.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelReloadTime
            // 
            labelReloadTime.AutoSize = true;
            labelReloadTime.Location = new Point(225, 157);
            labelReloadTime.Name = "labelReloadTime";
            labelReloadTime.Size = new Size(67, 15);
            labelReloadTime.TabIndex = 49;
            labelReloadTime.Text = "Reloadtime";
            labelReloadTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBarReloadTime
            // 
            trackBarReloadTime.BackColor = SystemColors.ControlLightLight;
            trackBarReloadTime.Location = new Point(183, 175);
            trackBarReloadTime.Maximum = 3600;
            trackBarReloadTime.Minimum = 1;
            trackBarReloadTime.Name = "trackBarReloadTime";
            trackBarReloadTime.RightToLeft = RightToLeft.No;
            trackBarReloadTime.Size = new Size(163, 45);
            trackBarReloadTime.TabIndex = 48;
            trackBarReloadTime.Value = 1;
            trackBarReloadTime.ValueChanged += trackBarReloadTime_ValueChanged;
            // 
            // buttonWeaponSave
            // 
            buttonWeaponSave.Location = new Point(374, 282);
            buttonWeaponSave.Name = "buttonWeaponSave";
            buttonWeaponSave.Size = new Size(75, 23);
            buttonWeaponSave.TabIndex = 47;
            buttonWeaponSave.Text = "Save";
            buttonWeaponSave.UseVisualStyleBackColor = true;
            buttonWeaponSave.Click += buttonWeaponSave_Click;
            // 
            // labelRateOfFire
            // 
            labelRateOfFire.AutoSize = true;
            labelRateOfFire.Location = new Point(56, 157);
            labelRateOfFire.Name = "labelRateOfFire";
            labelRateOfFire.Size = new Size(62, 15);
            labelRateOfFire.TabIndex = 46;
            labelRateOfFire.Text = "RateOfFire";
            labelRateOfFire.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBarRateOfFire
            // 
            trackBarRateOfFire.BackColor = SystemColors.ControlLightLight;
            trackBarRateOfFire.Location = new Point(14, 175);
            trackBarRateOfFire.Maximum = 3600;
            trackBarRateOfFire.Minimum = 1;
            trackBarRateOfFire.Name = "trackBarRateOfFire";
            trackBarRateOfFire.RightToLeft = RightToLeft.No;
            trackBarRateOfFire.Size = new Size(163, 45);
            trackBarRateOfFire.TabIndex = 45;
            trackBarRateOfFire.Value = 1;
            trackBarRateOfFire.ValueChanged += trackBarRateOfFire_ValueChanged;
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
            // textBoxWeapon
            // 
            textBoxWeapon.BackColor = SystemColors.ButtonHighlight;
            textBoxWeapon.Location = new Point(14, 311);
            textBoxWeapon.Multiline = true;
            textBoxWeapon.Name = "textBoxWeapon";
            textBoxWeapon.ReadOnly = true;
            textBoxWeapon.ScrollBars = ScrollBars.Both;
            textBoxWeapon.Size = new Size(776, 316);
            textBoxWeapon.TabIndex = 43;
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
            // buttonWeaponSelectDir
            // 
            buttonWeaponSelectDir.Location = new Point(352, 6);
            buttonWeaponSelectDir.Name = "buttonWeaponSelectDir";
            buttonWeaponSelectDir.Size = new Size(118, 23);
            buttonWeaponSelectDir.TabIndex = 41;
            buttonWeaponSelectDir.Text = "Select Directory";
            buttonWeaponSelectDir.UseVisualStyleBackColor = true;
            buttonWeaponSelectDir.Click += buttonWeaponSelectDir_Click;
            // 
            // comboBoxWeaponSelect
            // 
            comboBoxWeaponSelect.FormattingEnabled = true;
            comboBoxWeaponSelect.Location = new Point(6, 35);
            comboBoxWeaponSelect.Name = "comboBoxWeaponSelect";
            comboBoxWeaponSelect.Size = new Size(776, 23);
            comboBoxWeaponSelect.TabIndex = 40;
            comboBoxWeaponSelect.SelectedIndexChanged += ComboBoxWeaponSelect_SelectedIndexChanged;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownElevateRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRotateRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarReloadTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRateOfFire).EndInit();
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
        private TextBox textBoxAmmo;
        private TrackBar trackBarBaseDamage;
        private Button buttonAmmoSelectDir;
        private Label labelDisplayAmmoDir;
        private ComboBox comboBoxAmmoSelect;
        private TabControl tabControl1;
        private TabPage tabAmmo;
        private TabPage tabWeapon;
        private Button buttonHelpWeapon;
        private Button buttonWeaponSelectDir;
        private ComboBox comboBoxWeaponSelect;
        private Label labelDisplayWeaponDir;
        private TextBox textBoxWeapon;
        private Label labelRateOfFire;
        private TrackBar trackBarRateOfFire;
        private Button buttonWeaponSave;
        private Label labelReloadTime;
        private TrackBar trackBarReloadTime;
        private NumericUpDown numericUpDownElevateRate;
        private NumericUpDown numericUpDownRotateRate;
        private Label labelElevateRate;
        private Label labelRotateRate;
    }
}