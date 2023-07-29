using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace csharpSCConfigBuilder
{
    public partial class VisualEditor : Form
    {
        private string lastSelectedAmmoFolder;
        private string lastSelectedWeaponFolder;
        private string selectedFilePath;

        public VisualEditor()
        {
            InitializeComponent();


            // Load the last selected folder from application settings.
            lastSelectedAmmoFolder = Properties.Settings.Default.LastSelectedAmmoFolder;
            lastSelectedWeaponFolder = Properties.Settings.Default.LastSelectedWeaponFolder;

            // Check and create the "coresysconfigs" folder if it doesn't exist.
            string folderPath = Path.Combine(Application.StartupPath, "coresysconfigs");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Initialize the ComboBox with the list of .cs files from the "coresysconfigs" folder.
            InitializeAmmoComboBox();



            // Initialize the color controls
            UpdateColorControls();
        }



        private void InitializeAmmoComboBox()
        {
            if (Directory.Exists(lastSelectedAmmoFolder))
            {
                string[] csFiles = Directory.GetFiles(lastSelectedAmmoFolder, "*.cs");
                comboBoxAmmoSelect.Items.Clear();
                comboBoxAmmoSelect.Items.AddRange(csFiles);

                // If a file was previously selected, set it as the selected item.
                if (comboBoxAmmoSelect.Items.Count > 0 && !string.IsNullOrEmpty(selectedFilePath))
                {
                    comboBoxAmmoSelect.SelectedItem = selectedFilePath;
                }
            }
            else
            {
                // Directory not found or empty, clear the ComboBox items.
                comboBoxAmmoSelect.Items.Clear();
            }
        }

        private void ComboBoxAmmoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected file path.
            selectedFilePath = comboBoxAmmoSelect.SelectedItem?.ToString();

            // Check if the selected file path is not null and the file exists.
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                // Read the contents of the selected file.
                string fileContent = File.ReadAllText(selectedFilePath);

                // Check if the file contains "new AmmoDef".
                if (fileContent.Contains("new AmmoDef"))
                {
                    // Display the file path in a label when it passes validation.
                    labelDisplayAmmoDir.Text = selectedFilePath;

                    // Set the file content as the text of the read-only TextBox.
                    textBoxAmmo.Text = fileContent;

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
                labelDisplayAmmoDir.Text = "";
                textBoxAmmo.Text = "";
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
            trackBarBaseDamage.Value = baseDamage;
            labelBaseDamage.Text = $"BaseDamage = {baseDamage}";
        }

        private void UpdateMaxTrajectory(string fileContent)
        {
            int maxTrajectory = GetConfigValueFromRegex(fileContent, @"MaxTrajectory = (\d+)");
            trackBarMaxTrajectory.Value = maxTrajectory;
            labelMaxTrajectory.Text = $"MaxTrajectory = {maxTrajectory}";
        }

        private void UpdateDesiredSpeed(string fileContent)
        {
            int desiredSpeed = GetConfigValueFromRegex(fileContent, @"DesiredSpeed = (\d+)");
            trackBarDesiredSpeed.Value = desiredSpeed;
            labelDesiredSpeed.Text = $"DesiredSpeed = {desiredSpeed}";
        }

        private void UpdateMaxLifetime(string fileContent)
        {
            int maxLifetime = GetConfigValueFromRegex(fileContent, @"MaxLifeTime = (\d+)");
            trackBarMaxLifetime.Value = maxLifetime;
            labelMaxLifeTime.Text = $"MaxLifeTime = {maxLifetime}";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the BaseDamage value.
            labelBaseDamage.Text = $"BaseDamage = {trackBarBaseDamage.Value}";
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the MaxTrajectory value.
            labelMaxTrajectory.Text = $"MaxTrajectory = {trackBarMaxTrajectory.Value}";
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the DesiredSpeed value.
            labelDesiredSpeed.Text = $"DesiredSpeed = {trackBarDesiredSpeed.Value}";
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the MaxLifetime value.
            labelMaxLifeTime.Text = $"MaxLifeTime = {trackBarMaxLifetime.Value}";
        }

        private void buttonAmmoSelectDir_Click(object sender, EventArgs e)
        {
            // Create a new instance of FolderBrowserDialog.
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Set the initial folder to the last selected folder path from the settings.
            folderBrowserDialog.SelectedPath = lastSelectedAmmoFolder;

            // Show the dialog and check if the user clicked OK.
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path and store it for the next time.
                lastSelectedAmmoFolder = folderBrowserDialog.SelectedPath;

                // Save the last selected folder path to application settings.
                Properties.Settings.Default.LastSelectedAmmoFolder = lastSelectedAmmoFolder;
                Properties.Settings.Default.Save();

                // Update the ComboBox based on the selected directory.
                InitializeAmmoComboBox();
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

        private void buttonAmmoSave_Click(object sender, EventArgs e)
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
            string newFileContent = Regex.Replace(fileContent, @"BaseDamage = \d+", $"BaseDamage = {trackBarBaseDamage.Value}");
            newFileContent = Regex.Replace(newFileContent, @"MaxTrajectory = \d+", $"MaxTrajectory = {trackBarMaxTrajectory.Value}");
            newFileContent = Regex.Replace(newFileContent, @"DesiredSpeed = \d+", $"DesiredSpeed = {trackBarDesiredSpeed.Value}");
            newFileContent = Regex.Replace(newFileContent, @"MaxLifeTime = \d+", $"MaxLifeTime = {trackBarMaxLifetime.Value}");

            // Replace the existing Color line with the updated RGB values from the track bars.
            newFileContent = Regex.Replace(newFileContent, @"Color\s*=\s*Color\s*\(red:\s*\d+,\s*green:\s*\d+,\s*blue:\s*\d+,\s*alpha:\s*[\d.]+f\s*\)",
                $"Color = Color(red: {trackBarRed.Value}, green: {trackBarGreen.Value}, blue: {trackBarBlue.Value}, alpha: 1f)");

            // Save the modified contents back to the file.
            File.WriteAllText(selectedFilePath, newFileContent);

            // Restore the scroll position.
            textBoxAmmo.Text = newFileContent;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Create and show the HelpForm as a dialog
            using (var helpForm = new HelpFormAmmo())
            {
                helpForm.ShowDialog();
            }
        }

        private void buttonHelpWeapon_Click(object sender, EventArgs e)
        {

            // Create and show the HelpForm as a dialog
            using (var helpForm = new HelpFormWeapon())
            {
                helpForm.ShowDialog();
            }

        }

        private void comboBoxWeaponSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected file path.
            selectedFilePath = comboBoxWeaponSelect.SelectedItem?.ToString();

            // Check if the selected file path is not null and the file exists.
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                // Read the contents of the selected file.
                string fileContent = File.ReadAllText(selectedFilePath);

                // Check if the file contains "new WeaponDefinition" (replace with the correct identifier for weapon definitions).
                if (fileContent.Contains("new WeaponDefinition"))
                {
                    // Display the file path in a label when it passes validation.
                    labelDisplayWeaponDir.Text = selectedFilePath;

                    // Set the file content as the text of the read-only TextBox.
                    textBoxWeapon.Text = fileContent;

                    // Parse and set the initial values for weapon-related parameters.
                    UpdateWeaponParameters(fileContent);

                }
                else
                {
                    // Display an error message if the selected file doesn't contain "new WeaponDefinition".
                    MessageBox.Show("The selected file does not contain 'new WeaponDefinition'. Please choose a different file.");
                }
            }
            else
            {
                // Handle the case when no file is selected or the selected file does not exist.
                // For example, you can clear the label displaying the file path and the TextBox.
                labelDisplayWeaponDir.Text = "";
                textBoxWeapon.Text = "";
            }
        }

        private void buttonWeaponSelectDir_Click(object sender, EventArgs e)
        {
            // Create a new instance of FolderBrowserDialog.
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Set the initial folder to the last selected folder path from the settings.
            folderBrowserDialog.SelectedPath = lastSelectedWeaponFolder;

            // Show the dialog and check if the user clicked OK.
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path and store it for the next time.
                lastSelectedWeaponFolder = folderBrowserDialog.SelectedPath;

                // Save the last selected folder path to application settings.
                Properties.Settings.Default.LastSelectedWeaponFolder = lastSelectedWeaponFolder;
                Properties.Settings.Default.Save(); // Save the settings

                // Update the ComboBox based on the selected directory.
                InitializeWeaponComboBox();
            }
        }


        private void InitializeWeaponComboBox()
        {
            if (Directory.Exists(lastSelectedWeaponFolder))
            {
                string[] csFiles = Directory.GetFiles(lastSelectedWeaponFolder, "*.cs");
                comboBoxWeaponSelect.Items.Clear();
                comboBoxWeaponSelect.Items.AddRange(csFiles);

                // If a file was previously selected, set it as the selected item.
                if (comboBoxWeaponSelect.Items.Count > 0 && !string.IsNullOrEmpty(selectedFilePath))
                {
                    comboBoxWeaponSelect.SelectedItem = selectedFilePath;
                }
            }
            else
            {
                // Directory not found or empty, clear the ComboBox items.
                comboBoxWeaponSelect.Items.Clear();
            }
        }


        private void UpdateWeaponParameters(string fileContent)
        {
            // Example: Get RateOfFire from the fileContent using regular expressions
            int rateOfFire = GetConfigValueFromRegex(fileContent, @"RateOfFire = (\d+)");
            int reloadTime = GetConfigValueFromRegex(fileContent, @"ReloadTime = (\d+)");

            // Update the slider or numeric up-down control for RateOfFire
            trackBarRateOfFire.Value = rateOfFire;
            labelRateOfFire.Text = $"Rate of Fire: {rateOfFire}";

            // Update the slider or numeric up-down control for ReloadTime
            trackBarReloadTime.Value = reloadTime;
            labelReloadTime.Text = $"Reload Time: {reloadTime} ms";

            // Set the file content as the text of the read-only TextBox.
            // This will ensure that the TextBox displays the latest values when the user selects a weapon file.
            textBoxWeapon.Text = fileContent;
        }



        private void buttonWeaponSave_Click(object sender, EventArgs e)
        {
            // Check if a file is selected
            if (string.IsNullOrEmpty(selectedFilePath) || !File.Exists(selectedFilePath))
            {
                MessageBox.Show("Please select a weapon config file before saving the values.");
                return;
            }

            // Read the contents of the selected file.
            string fileContent = File.ReadAllText(selectedFilePath);

            // Update the weapon-specific parameters in the file.
            string newFileContent = Regex.Replace(fileContent, @"RateOfFire = \d+", $"RateOfFire = {trackBarRateOfFire.Value}");
            newFileContent = Regex.Replace(newFileContent, @"ReloadTime = \d+", $"ReloadTime = {trackBarReloadTime.Value}");

            // If you have other sliders or numeric up-down controls for weapon stats, you can update them similarly here.

            // Save the modified contents back to the file.
            File.WriteAllText(selectedFilePath, newFileContent);

            // Restore the scroll position.
            textBoxWeapon.Text = newFileContent;
        }


        private void trackBarRateOfFire_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the Rate of Fire value in real-time.
            labelRateOfFire.Text = $"Rate of Fire = {trackBarRateOfFire.Value}";
        }

        private void trackBarReloadTime_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the Reload Time value in real-time.
            labelReloadTime.Text = $"Reload Time = {trackBarReloadTime.Value} ms";
        }



    }



}
