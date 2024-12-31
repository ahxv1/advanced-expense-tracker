using System;
using System.Windows.Forms;

namespace advanced_expense_tracker
{
    public static class ThemeManager
    {
        // Static property to track the current theme
        // Made the setter public to allow modification from outside
        public static bool IsDarkMode { get; set; } = false;

        // Apply the current theme to a form
        public static void ApplyTheme(Form form)
        {
            if (IsDarkMode)
            {
                form.BackColor = System.Drawing.Color.FromArgb(45, 45, 48); // Dark background
                form.ForeColor = System.Drawing.Color.White;

                foreach (Control control in form.Controls)
                {
                    if (control is Button)
                    {
                        // Apply dark theme to buttons
                        control.BackColor = System.Drawing.Color.FromArgb(28, 28, 28); // Darker button color
                        control.ForeColor = System.Drawing.Color.White; // White text for buttons
                    }
                    else if (control is Label || control is ComboBox)
                    {
                        // Darker color for labels and combo boxes
                        control.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
                        control.ForeColor = System.Drawing.Color.White;
                    }
                    else if (control is Panel)
                    {
                        // Dark color for panels
                        control.BackColor = System.Drawing.Color.FromArgb(28, 28, 28); // Darker panel color
                    }
                }
            }
            else
            {
                form.BackColor = System.Drawing.Color.White; // Light background
                form.ForeColor = System.Drawing.Color.Black;

                foreach (Control control in form.Controls)
                {
                    if (control is Button)
                    {
                        // Apply light theme to buttons
                        control.BackColor = System.Drawing.Color.LightGray; // Light gray for buttons
                        control.ForeColor = System.Drawing.Color.Black; // Black text for buttons
                    }
                    else if (control is Label || control is ComboBox)
                    {
                        control.BackColor = System.Drawing.Color.LightGray; // Light gray for labels and combo boxes
                        control.ForeColor = System.Drawing.Color.Black; // Black text
                    }
                    else if (control is Panel)
                    {
                        // Light color for panels
                        control.BackColor = System.Drawing.Color.White; // Light panel color
                    }
                }
            }
        }

        // Toggle between dark and light themes
        public static void ToggleTheme()
        {
            IsDarkMode = !IsDarkMode;
        }
    }
}
