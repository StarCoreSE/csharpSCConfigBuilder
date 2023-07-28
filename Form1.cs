using System;
using System.IO;
using System.Windows.Forms;

namespace csharpSCConfigBuilder
{
    public partial class Form1 : Form
    {
        private string lastSelectedFile;

        public Form1()
        {
            InitializeComponent();

            // Check and create the "coresysconfigs" folder if it doesn't exist.
            string folderPath = Path.Combine(Application.StartupPath, "coresysconfigs");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Initialize the ComboBox with the list of .cs files from the "coresysconfigs" folder.
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            string folderPath = Path.Combine(Application.StartupPath, "coresysconfigs");

            if (Directory.Exists(folderPath))
            {
                string[] csFiles = Directory.GetFiles(folderPath, "*.cs");
                comboBox1.Items.AddRange(csFiles);

                // If a file was previously selected, set it as the selected item.
                if (!string.IsNullOrEmpty(lastSelectedFile) && File.Exists(lastSelectedFile))
                {
                    comboBox1.SelectedItem = lastSelectedFile;
                }
            }
            else
            {
                // Directory not found, handle the case when the folder doesn't exist.
                MessageBox.Show("The 'coresysconfigs' folder does not exist in the application directory.");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected file path.
            string selectedFilePath = comboBox1.SelectedItem?.ToString();

            // Check if the selected file path is not null and the file exists.
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                // Read the contents of the selected file.
                string fileContent = File.ReadAllText(selectedFilePath);

                // Check if the file contains "new AmmoDef".
                if (fileContent.Contains("new AmmoDef"))
                {
                    // Here, you can do something with the selected file, now that it has been validated.
                    // For example, you can display the file path in a label:
                    label1.Text = selectedFilePath;
                }
                else
                {
                    // Display an error message if the selected file doesn't contain "new AmmoDef".
                    MessageBox.Show("The selected file does not contain 'new AmmoDef'. Please choose a different file.");
                }
            }
            else
            {
                // Handle the case when no file is selected or the selected file does not exist.
                // For example, you can clear the label displaying the file path.
                label1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
