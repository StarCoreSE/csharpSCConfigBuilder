namespace csharpSCConfigBuilder
{
    partial class HelpFormAmmo
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
            labelHelp = new Label();
            SuspendLayout();
            // 
            // labelHelp
            // 
            labelHelp.AutoSize = true;
            labelHelp.Location = new Point(12, 9);
            labelHelp.Name = "labelHelp";
            labelHelp.Size = new Size(27, 15);
            labelHelp.TabIndex = 0;
            labelHelp.Text = "Test";
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 444);
            Controls.Add(labelHelp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterParent;
            Tag = "Form1";
            Text = "HelpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHelp;
    }
}