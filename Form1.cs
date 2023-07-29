using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace csharpSCConfigBuilder
{
    public partial class Form1 : Form
    {
        private string lastSelectedFolder;
        private string selectedFilePath;

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
            if (Directory.Exists(lastSelectedFolder))
            {
                string[] csFiles = Directory.GetFiles(lastSelectedFolder, "*.cs");
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(csFiles);

                // If a file was previously selected, set it as the selected item.
                if (comboBox1.Items.Count > 0 && !string.IsNullOrEmpty(lastSelectedFolder))
                {
                    comboBox1.SelectedItem = lastSelectedFolder;
                }
            }
            else
            {
                // Directory not found or empty, clear the ComboBox items.
                comboBox1.Items.Clear();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected file path.
            selectedFilePath = comboBox1.SelectedItem?.ToString();

            // Check if the selected file path is not null and the file exists.
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                // Read the contents of the selected file.
                string fileContent = File.ReadAllText(selectedFilePath);

                // Check if the file contains "new AmmoDef".
                if (fileContent.Contains("new AmmoDef"))
                {
                    // Display the file path in a label when it passes validation.
                    label1.Text = selectedFilePath;

                    // Set the file content as the text of the read-only TextBox.
                    textBox1.Text = fileContent;

                    // Parse and set the initial BaseDamage and MaxTrajectory values.
                    UpdateBaseDamage(fileContent);
                    UpdateMaxTrajectory(fileContent);
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
                // For example, you can clear the label displaying the file path and the TextBox.
                label1.Text = "";
                textBox1.Text = "";
            }
        }

        private int GetConfigValueFromRegex(string fileContent, string pattern)
        {
            // Use regular expression to find the specified value in the file.
            Match match = Regex.Match(fileContent, pattern);
            if (match.Success && match.Groups.Count >= 2)
            {
                int value;
                if (int.TryParse(match.Groups[1].Value, out value))
                {
                    return value;
                }
            }
            return 0; // Default value if the specified value is not found or parsing fails.
        }

        private void UpdateBaseDamage(string fileContent)
        {
            int baseDamage = GetConfigValueFromRegex(fileContent, @"BaseDamage = (\d+)");
            trackBar1.Value = baseDamage;
            labelBaseDamage.Text = $"BaseDamage = {baseDamage}";
        }

        private void UpdateMaxTrajectory(string fileContent)
        {
            int maxTrajectory = GetConfigValueFromRegex(fileContent, @"MaxTrajectory = (\d+)");
            trackBar2.Value = maxTrajectory;
            labelMaxTrajectory.Text = $"MaxTrajectory = {maxTrajectory}";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the BaseDamage value.
            labelBaseDamage.Text = $"BaseDamage = {trackBar1.Value}";
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the MaxTrajectory value.
            labelMaxTrajectory.Text = $"MaxTrajectory = {trackBar2.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of FolderBrowserDialog.
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Set the initial folder to the last selected folder path from the settings.
            folderBrowserDialog.SelectedPath = lastSelectedFolder;

            // Show the dialog and check if the user clicked OK.
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path and store it for the next time.
                lastSelectedFolder = folderBrowserDialog.SelectedPath;

                // Update the ComboBox based on the selected directory.
                InitializeComboBox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if a file is selected
            if (string.IsNullOrEmpty(selectedFilePath) || !File.Exists(selectedFilePath))
            {
                MessageBox.Show("Please select an ammo config file before saving the values.");
                return;
            }

            // Read the contents of the selected file.
            string fileContent = File.ReadAllText(selectedFilePath);

            // Update the BaseDamage and MaxTrajectory values in the file.
            string newFileContent = Regex.Replace(fileContent, @"BaseDamage = \d+", $"BaseDamage = {trackBar1.Value}");
            newFileContent = Regex.Replace(newFileContent, @"MaxTrajectory = \d+", $"MaxTrajectory = {trackBar2.Value}");

            // Save the modified contents back to the file.
            File.WriteAllText(selectedFilePath, newFileContent);

            // Update the TextBox with the new file content.
            textBox1.Text = newFileContent;
        }
    }
}
