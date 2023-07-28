using System;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace csharpSCConfigBuilder
{
    public partial class Form1 : Form
    {
        // Store the path of the last selected file.
        private string lastSelectedFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of OpenFileDialog.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set initial directory and file filter.
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "C# Files (*.cs)|*.cs|All Files (*.*)|*.*";

            // If a file was previously selected, use it as the initial file.
            if (!string.IsNullOrEmpty(lastSelectedFile) && File.Exists(lastSelectedFile))
            {
                openFileDialog.FileName = lastSelectedFile;
            }

            // Show the dialog and check if the user clicked OK.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the contents of the selected file.
                string fileContent = File.ReadAllText(openFileDialog.FileName);

                // Check if the file contains "new AmmoDef".
                if (fileContent.Contains("new AmmoDef"))
                {
                    // Get the selected file path and store it for the next time.
                    lastSelectedFile = openFileDialog.FileName;

                }
                else
                {
                    // Display an error message if the selected file doesn't contain "new AmmoDef".
                    MessageBox.Show("The selected file does not contain 'new AmmoDef'. Please choose a different file.");
                }
            }
        }

    }
}
