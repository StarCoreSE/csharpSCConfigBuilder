namespace csharpSCConfigBuilder
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            trackBar1 = new TrackBar();
            textBox1 = new TextBox();
            labelBaseDamage = new Label();
            button2 = new Button();
            labelMaxTrajectory = new Label();
            trackBar2 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 614);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 2;
            label1.Text = "Directory";
            label1.UseCompatibleTextRendering = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 635);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Current Mode";
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
            textBox1.Location = new Point(12, 295);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
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
            // 
            // button2
            // 
            button2.Location = new Point(378, 252);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 659);
            Controls.Add(labelMaxTrajectory);
            Controls.Add(trackBar2);
            Controls.Add(button2);
            Controls.Add(labelBaseDamage);
            Controls.Add(textBox1);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "SCConfigBuilder";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TrackBar trackBar1;
        private TextBox textBox1;
        private Label labelBaseDamage;
        private Button button2;
        private Label labelMaxTrajectory;
        private TrackBar trackBar2;
    }
}