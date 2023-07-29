using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace csharpSCConfigBuilder
{
    public partial class VisualAmmoEditor : Form
    {
        private string lastSelectedFolder;
        private string selectedFilePath;

        public VisualAmmoEditor()
        {
            InitializeComponent();


            buttonHelp.Click += buttonHelp_Click;

            // Load the last selected folder from application settings.
            lastSelectedFolder = Properties.Settings.Default.LastSelectedFolder;

            // Check and create the "coresysconfigs" folder if it doesn't exist.
            string folderPath = Path.Combine(Application.StartupPath, "coresysconfigs");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Initialize the ComboBox with the list of .cs files from the "coresysconfigs" folder.
            InitializeComboBox();

            // Wire up the ValueChanged event of trackBar1, trackBar2, trackBar3, and trackBar4 to their respective event handlers.
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            trackBar3.ValueChanged += trackBar3_ValueChanged;
            trackBar4.ValueChanged += trackBar4_ValueChanged;

            // Set the event handlers for the track bars' ValueChanged events
            trackBarRed.ValueChanged += trackBarRed_ValueChanged;
            trackBarGreen.ValueChanged += trackBarGreen_ValueChanged;
            trackBarBlue.ValueChanged += trackBarBlue_ValueChanged;

            // Initialize the color controls
            UpdateColorControls();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Create and show the HelpForm as a dialog
            using (var helpForm = new HelpFormAmmo())
            {
                helpForm.ShowDialog();
            }
        }

        private void InitializeComboBox()
        {
            if (Directory.Exists(lastSelectedFolder))
            {
                string[] csFiles = Directory.GetFiles(lastSelectedFolder, "*.cs");
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(csFiles);

                // If a file was previously selected, set it as the selected item.
                if (comboBox1.Items.Count > 0 && !string.IsNullOrEmpty(selectedFilePath))
                {
                    comboBox1.SelectedItem = selectedFilePath;
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
                    labelDirectory.Text = selectedFilePath;

                    // Set the file content as the text of the read-only TextBox.
                    textBox1.Text = fileContent;

                    // Parse and set the initial BaseDamage, MaxTrajectory, DesiredSpeed, and MaxLifetime values.
                    UpdateBaseDamage(fileContent);
                    UpdateMaxTrajectory(fileContent);
                    UpdateDesiredSpeed(fileContent);
                    UpdateMaxLifetime(fileContent);

                    // Update the RGB values.
                    UpdateColorControls();
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
                labelDirectory.Text = "";
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

        private void UpdateDesiredSpeed(string fileContent)
        {
            int desiredSpeed = GetConfigValueFromRegex(fileContent, @"DesiredSpeed = (\d+)");
            trackBar3.Value = desiredSpeed;
            labelDesiredSpeed.Text = $"DesiredSpeed = {desiredSpeed}";
        }

        private void UpdateMaxLifetime(string fileContent)
        {
            int maxLifetime = GetConfigValueFromRegex(fileContent, @"MaxLifeTime = (\d+)");
            trackBar4.Value = maxLifetime;
            labelMaxLifeTime.Text = $"MaxLifeTime = {maxLifetime}";
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

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the DesiredSpeed value.
            labelDesiredSpeed.Text = $"DesiredSpeed = {trackBar3.Value}";
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the MaxLifetime value.
            labelMaxLifeTime.Text = $"MaxLifeTime = {trackBar4.Value}";
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

                // Save the last selected folder path to application settings.
                Properties.Settings.Default.LastSelectedFolder = lastSelectedFolder;
                Properties.Settings.Default.Save();

                // Update the ComboBox based on the selected directory.
                InitializeComboBox();
            }
        }

        private void UpdateColorControls()
        {
            // Check if selectedFilePath is null or empty.
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                return;
            }

            // Read the contents of the selected file.
            string fileContent = File.ReadAllText(selectedFilePath);

            // Use regular expression to find the existing Color line in the file.
            Match matchColor = Regex.Match(fileContent, @"Color\s*=\s*Color\s*\(red:\s*(\d+),\s*green:\s*(\d+),\s*blue:\s*(\d+),\s*alpha:\s*[\d.]+f\s*\)");
            if (matchColor.Success && matchColor.Groups.Count >= 4)
            {
                int red, green, blue;
                if (int.TryParse(matchColor.Groups[1].Value, out red) &&
                    int.TryParse(matchColor.Groups[2].Value, out green) &&
                    int.TryParse(matchColor.Groups[3].Value, out blue))
                {
                    // Update the track bars and labels with the parsed RGB values
                    trackBarRed.Value = red;
                    trackBarGreen.Value = green;
                    trackBarBlue.Value = blue;

                    labelRed.Text = $"Red = {red}";
                    labelGreen.Text = $"Green = {green}";
                    labelBlue.Text = $"Blue = {blue}";
                }
            }
        }

        // Assuming you have already added a Panel control named "panelColor" to your form.

        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            // Check if selectedFilePath is null or empty.
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                return;
            }

            labelRed.Text = $"Red = {trackBarRed.Value}";
            UpdateColorInConfig();

            // Update the color of the panelColor using the current RGB values.
            panelColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            // Check if selectedFilePath is null or empty.
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                return;
            }

            labelGreen.Text = $"Green = {trackBarGreen.Value}";
            UpdateColorInConfig();

            // Update the color of the panelColor using the current RGB values.
            panelColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            // Check if selectedFilePath is null or empty.
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                return;
            }

            labelBlue.Text = $"Blue = {trackBarBlue.Value}";
            UpdateColorInConfig();

            // Update the color of the panelColor using the current RGB values.
            panelColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void UpdateColorInConfig()
        {
            // Read the contents of the selected file.
            string fileContent = File.ReadAllText(selectedFilePath);

            // Replace the existing Color line with the updated RGB values from the track bars.
            string newFileContent = Regex.Replace(fileContent, @"Color\s*=\s*Color\s*\(red:\s*\d+,\s*green:\s*\d+,\s*blue:\s*\d+,\s*alpha:\s*[\d.]+f\s*\)",
                $"Color = Color(red: {trackBarRed.Value}, green: {trackBarGreen.Value}, blue: {trackBarBlue.Value}, alpha: 1f)");

            // Save the modified contents back to the file.
            File.WriteAllText(selectedFilePath, newFileContent);
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

            // Update the BaseDamage, MaxTrajectory, DesiredSpeed, and MaxLifetime values in the file.
            string newFileContent = Regex.Replace(fileContent, @"BaseDamage = \d+", $"BaseDamage = {trackBar1.Value}");
            newFileContent = Regex.Replace(newFileContent, @"MaxTrajectory = \d+", $"MaxTrajectory = {trackBar2.Value}");
            newFileContent = Regex.Replace(newFileContent, @"DesiredSpeed = \d+", $"DesiredSpeed = {trackBar3.Value}");
            newFileContent = Regex.Replace(newFileContent, @"MaxLifeTime = \d+", $"MaxLifeTime = {trackBar4.Value}");

            // Replace the existing Color line with the updated RGB values from the track bars.
            newFileContent = Regex.Replace(newFileContent, @"Color\s*=\s*Color\s*\(red:\s*\d+,\s*green:\s*\d+,\s*blue:\s*\d+,\s*alpha:\s*[\d.]+f\s*\)",
                $"Color = Color(red: {trackBarRed.Value}, green: {trackBarGreen.Value}, blue: {trackBarBlue.Value}, alpha: 1f)");

            // Save the modified contents back to the file.
            File.WriteAllText(selectedFilePath, newFileContent);

            // Restore the scroll position.
            textBox1.Text = newFileContent;
        }


    }



}
