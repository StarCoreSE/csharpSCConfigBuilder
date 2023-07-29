using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

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

            // Load the last selected folder from application settings for both ammo and weapon.
            lastSelectedAmmoFolder = Properties.Settings.Default.LastSelectedFolder;
            lastSelectedWeaponFolder = Properties.Settings.Default.LastSelectedFolder;

            // Check and create the "coresysconfigs" folder if it doesn't exist.
            string folderPath = Path.Combine(Application.StartupPath, "coresysconfigs");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Initialize the ComboBoxes with the list of .cs files from the "coresysconfigs" folder.
            InitializeAmmoComboBox();
            InitializeWeaponComboBox();

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
            labelMaxTrajectory.Text = $"MaxTrajectory = {maxTrajectory} m";
        }

        private void UpdateDesiredSpeed(string fileContent)
        {
            int desiredSpeed = GetConfigValueFromRegex(fileContent, @"DesiredSpeed = (\d+)");
            trackBarDesiredSpeed.Value = desiredSpeed;
            labelDesiredSpeed.Text = $"DesiredSpeed = {desiredSpeed} m/s";
        }

        private void UpdateMaxLifetime(string fileContent)
        {
            int maxLifetime = GetConfigValueFromRegex(fileContent, @"MaxLifeTime = (\d+)");
            trackBarMaxLifetime.Value = maxLifetime;
            labelMaxLifeTime.Text = $"MaxLifeTime = {maxLifetime} ms";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the BaseDamage value.
            labelBaseDamage.Text = $"BaseDamage = {trackBarBaseDamage.Value}";
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the MaxTrajectory value.
            labelMaxTrajectory.Text = $"MaxTrajectory = {trackBarMaxTrajectory.Value} m";
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the DesiredSpeed value.
            labelDesiredSpeed.Text = $"DesiredSpeed = {trackBarDesiredSpeed.Value} m/s";
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the MaxLifetime value.
            labelMaxLifeTime.Text = $"MaxLifeTime = {trackBarMaxLifetime.Value} ms";
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
                // Get the selected folder path and store it for the next time (for both ammo and weapon).
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                lastSelectedAmmoFolder = selectedFolderPath;
                lastSelectedWeaponFolder = selectedFolderPath;

                // Save the last selected folder path to application settings.
                Properties.Settings.Default.LastSelectedFolder = selectedFolderPath;
                Properties.Settings.Default.Save();

                // Update the ComboBoxes based on the selected directory.
                InitializeAmmoComboBox();
                InitializeWeaponComboBox();
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


        private void ComboBoxWeaponSelect_SelectedIndexChanged(object sender, EventArgs e)
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

                    // Enable/Disable the RotateRate and ElevateRate controls based on their presence in the config.
                    bool rotateRateExists = CheckIfConfigValueExists(fileContent, @"RotateRate = \d+(\.\d+)?");
                    bool elevateRateExists = CheckIfConfigValueExists(fileContent, @"ElevateRate = \d+(\.\d+)?");
                    numericUpDownRotateRate.Enabled = rotateRateExists;
                    numericUpDownElevateRate.Enabled = elevateRateExists;
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

                // Disable the RotateRate and ElevateRate controls when no file is selected.
                numericUpDownRotateRate.Enabled = false;
                numericUpDownElevateRate.Enabled = false;
            }
        }

        private bool CheckIfConfigValueExists(string fileContent, string pattern)
        {
            // Use regular expression to find the specified value in the file.
            Match match = Regex.Match(fileContent, pattern);
            return match.Success;
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
            // Get the weapon-specific parameters from the fileContent using regular expressions
            int rateOfFire = GetConfigValueFromRegex(fileContent, @"RateOfFire = (\d+)");
            int reloadTime = GetConfigValueFromRegex(fileContent, @"ReloadTime = (\d+)");

            // Example: Get RotateRate and ElevateRate from the fileContent using regular expressions
            float rotateRate = GetFloatConfigValueFromRegex(fileContent, @"RotateRate = (\d+(\.\d+)?)");
            float elevateRate = GetFloatConfigValueFromRegex(fileContent, @"ElevateRate = (\d+(\.\d+)?)");

            // Update the sliders and labels for RateOfFire and ReloadTime
            trackBarRateOfFire.Value = rateOfFire;
            labelRateOfFire.Text = $"Rate of Fire: {rateOfFire} rpm";

            trackBarReloadTime.Value = reloadTime;
            labelReloadTime.Text = $"Reload Time: {reloadTime} ms";

            // Check if RotateRate exists in the file and enable/disable the NumericUpDown control accordingly
            if (rotateRate >= 0)
            {
                numericUpDownRotateRate.Enabled = true;
                numericUpDownRotateRate.Value = (decimal)rotateRate;
                labelRotateRate.Text = $"Rotate Rate: {rotateRate:F3} rad/t";
            }
            else
            {
                numericUpDownRotateRate.Enabled = false;
                labelRotateRate.Text = "Rotate Rate: N/A";
            }

            // Check if ElevateRate exists in the file and enable/disable the NumericUpDown control accordingly
            if (elevateRate >= 0)
            {
                numericUpDownElevateRate.Enabled = true;
                numericUpDownElevateRate.Value = (decimal)elevateRate;
                labelElevateRate.Text = $"Elevate Rate: {elevateRate:F3} rad/t";
            }
            else
            {
                numericUpDownElevateRate.Enabled = false;
                labelElevateRate.Text = "Elevate Rate: N/A";
            }

            // Set the file content as the text of the read-only TextBox.
            // This will ensure that the TextBox displays the latest values when the user selects a weapon file.
            textBoxWeapon.Text = fileContent;
        }

        private float GetFloatConfigValueFromRegex(string fileContent, string pattern)
        {
            // Use regular expression to find the specified float value in the file.
            Match match = Regex.Match(fileContent, pattern);
            if (match.Success && match.Groups.Count >= 2)
            {
                float value;
                if (float.TryParse(match.Groups[1].Value, out value))
                {
                    return value;
                }
            }
            return 0.0f; // Default value if the specified value is not found or parsing fails.
        }

        private void numericUpDownRotateRate_ValueChanged(object sender, EventArgs e)
        {
            // Get the float value from the NumericUpDown control for RotateRate
            float rotateRate = (float)numericUpDownRotateRate.Value;

            // Update the label displaying the RotateRate value in radians per second
            labelRotateRate.Text = $"Rotate Rate: {rotateRate:F3} rad/t";
        }

        private void numericUpDownElevateRate_ValueChanged(object sender, EventArgs e)
        {
            // Get the float value from the NumericUpDown control for ElevateRate
            float elevateRate = (float)numericUpDownElevateRate.Value;

            // Update the label displaying the ElevateRate value in radians per second
            labelElevateRate.Text = $"Elevate Rate: {elevateRate:F3} rad/t";
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

            // Check if the RotateRate control is enabled (i.e., RotateRate exists in the file) before updating it
            if (numericUpDownRotateRate.Enabled)
            {
                newFileContent = Regex.Replace(newFileContent, @"RotateRate = [0-9]*\.?[0-9]+", $"RotateRate = {numericUpDownRotateRate.Value:F3}");
            }

            // Check if the ElevateRate control is enabled (i.e., ElevateRate exists in the file) before updating it
            if (numericUpDownElevateRate.Enabled)
            {
                newFileContent = Regex.Replace(newFileContent, @"ElevateRate = [0-9]*\.?[0-9]+", $"ElevateRate = {numericUpDownElevateRate.Value:F3}");
            }

            // Save the modified contents back to the file.
            File.WriteAllText(selectedFilePath, newFileContent);

            // Restore the scroll position.
            textBoxWeapon.Text = newFileContent;
        }

        private void trackBarRateOfFire_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the Rate of Fire value in real-time.
            labelRateOfFire.Text = $"Rate of Fire = {trackBarRateOfFire.Value} rpm";
        }

        private void trackBarReloadTime_ValueChanged(object sender, EventArgs e)
        {
            // Update the label displaying the Reload Time value in real-time.
            labelReloadTime.Text = $"Reload Time = {trackBarReloadTime.Value} ms";
        }

        private float rotationAngle = 0.0f; // Current rotation angle in degrees.
        private float elevationAngle = 0.0f; // Current elevation angle in degrees.

        private void pictureBoxRotateRate_Paint(object sender, PaintEventArgs e)
        {
            // Create a Graphics object from the PaintEventArgs.
            Graphics g = e.Graphics;

            // Get the center of the PictureBox.
            int centerX = pictureBoxRotateRate.Width / 2;
            int centerY = pictureBoxRotateRate.Height / 2;

            // Calculate the radius of the circle.
            int radius = 20;

            // Create a pen to define the color and thickness of the circle's outline.
            Pen penCircle = new Pen(Color.Blue, 2);

            // Draw the circle on the PictureBox with its center at (centerX, centerY).
            g.DrawEllipse(penCircle, centerX - radius, centerY - radius, radius * 2, radius * 2);

            // Dispose of the penCircle to release resources.
            penCircle.Dispose();

            // Create a pen for drawing the line.
            Pen penLine = new Pen(Color.Red, 2);

            // Define the starting point of the line (center of the circle).
            Point startPoint = new Point(centerX, centerY);

            // Define the length of the line.
            int lineLength = 50;

            // Calculate the ending point of the line based on the current rotation angle.
            double angleInRadians = rotationAngle * Math.PI / 180.0;
            int lineEndX = centerX + (int)(lineLength * Math.Cos(angleInRadians));
            int lineEndY = centerY - (int)(lineLength * Math.Sin(angleInRadians)); // Negative sign because Y-axis is inverted.
            Point endPoint = new Point(lineEndX, lineEndY);

            // Draw the line from the center of the circle towards the top.
            g.DrawLine(penLine, startPoint, endPoint);

            // Dispose of the penLine to release resources.
            penLine.Dispose();
        }

        private void timerRotation_Tick(object sender, EventArgs e)
        {
            // Get the current RotateRate from the number box.
            float rotateRate = (float)numericUpDownRotateRate.Value; // Convert to radians per game tick.

            // Calculate the change in rotation angle based on the elapsed time and RotateRate.
            float elapsedTimeInSeconds = timerRotation.Interval * 4f; // Convert interval to seconds.
            float rotationChange = rotateRate * elapsedTimeInSeconds;

            // Update the rotation angle.
            rotationAngle += rotationChange;

            // Trigger an immediate redraw of the picture box.
            pictureBoxRotateRate.Refresh();
        }

        private void pictureBoxElevateRate_Paint(object sender, PaintEventArgs e)
        {
            // Create a Graphics object from the PaintEventArgs.
            Graphics g = e.Graphics;

            // Get the center of the PictureBox.
            int centerX = pictureBoxElevateRate.Width / 2;
            int centerY = pictureBoxElevateRate.Height / 2;

            // Calculate the radius of the circle.
            int radius = 20;

            // Create a pen to define the color and thickness of the circle's outline.
            Pen penCircle = new Pen(Color.Blue, 2);

            // Draw the circle on the PictureBox with its center at (centerX, centerY).
            g.DrawEllipse(penCircle, centerX - radius, centerY - radius, radius * 2, radius * 2);

            // Dispose of the penCircle to release resources.
            penCircle.Dispose();

            // Create a pen for drawing the line (use a different color, e.g., Color.Green).
            Pen penLine = new Pen(Color.Green, 2);

            // Define the starting point of the line (center of the circle).
            Point startPoint = new Point(centerX, centerY);

            // Define the length of the line.
            int lineLength = 50;

            // Calculate the ending point of the line based on the current elevation angle.
            double angleInRadians = elevationAngle * Math.PI / 180.0;
            int lineEndX = centerX + (int)(lineLength * Math.Cos(angleInRadians));
            int lineEndY = centerY - (int)(lineLength * Math.Sin(angleInRadians)); // Negative sign because Y-axis is inverted.
            Point endPoint = new Point(lineEndX, lineEndY);

            // Draw the line from the center of the circle towards the top (elevation direction).
            g.DrawLine(penLine, startPoint, endPoint);

            // Dispose of the penLine to release resources.
            penLine.Dispose();
        }

        private void timerElevation_Tick(object sender, EventArgs e)
        {
            // Get the current ElevateRate from the number box.
            float elevateRate = (float)numericUpDownElevateRate.Value; // Convert to radians per game tick.

            // Calculate the change in elevation angle based on the elapsed time and ElevateRate.
            float elapsedTimeInSeconds = timerElevation.Interval * 4f; // Convert interval to seconds.
            float elevationChange = elevateRate * elapsedTimeInSeconds;

            // Update the elevation angle.
            elevationAngle += elevationChange;

            // Trigger an immediate redraw of the picture box for elevation.
            pictureBoxElevateRate.Refresh();
        }

        private void VisualEditor_Load(object sender, EventArgs e)
        {
            // ...

            // Subscribe to the Timer.Tick event and start the timer.
            timerRotation.Tick += timerRotation_Tick;
            timerRotation.Start();
            timerElevation.Tick += timerElevation_Tick;
            timerElevation.Start();

            // ...
        }


    }


}
