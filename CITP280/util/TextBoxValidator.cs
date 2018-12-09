using System;
using System.Drawing;
using System.Windows.Forms;

namespace CITP280.util
{
    public class TextBoxValidator
    {
        public static void InvalidIntegerTextBox(TextBox textBox)
        {
            textBox.Select(0, textBox.Text.Length);
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
            textBox.ForeColor = Color.Red;
            textBox.Focus();

            MessageBox.Show("Value entered is invalid.\n Please enter a valid Integer.");
        }

       public static void ResetTextBoxFormat(TextBox textBox)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Regular);
            textBox.ForeColor = Color.Black;
        }

        public static bool IsValidInteger(string integerString)
        {
            return Int32.TryParse(integerString, out int ignore) || IsNullOrEmpty(integerString) ;
        }

        //for some reason the normal IsNullOrEmpty is not accessible in this class.
        public static bool IsNullOrEmpty(string val)
        {
            return val == "" || val.Length == 0;
        }
    }
}
