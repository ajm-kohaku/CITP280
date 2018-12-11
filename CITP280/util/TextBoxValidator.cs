using System;
using System.Drawing;
using System.Windows.Forms;

namespace CITP280.util
{
    public class TextBoxValidator
    {
        public static void ValidateIntegerTextBox(TextBox textBox)
        {
            if (!IsValidInteger(textBox.Text))
            {
                textBox.Select(0, textBox.Text.Length);
                textBox.Font = new Font(textBox.Font, FontStyle.Bold);
                textBox.ForeColor = Color.Red;
                textBox.Focus();

                MessageBox.Show("Value entered is invalid.\n Please enter a valid Integer.");
            }
        }

        public static void ResetTextBoxFormat(TextBox textBox)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Regular);
            textBox.ForeColor = Color.Black;
        }

        public static bool IsValidInteger(string integerString)
        {
            return Int32.TryParse(integerString, out int ignore) || String.IsNullOrEmpty(integerString);
        }

        public static Int32 ConvertToInt(TextBox textBox)
        {
            Int32.TryParse(textBox.Text, out int integer);
            return integer;
        }

        public static Int32 ConvertToInt(Label label)
        {
            Int32.TryParse(label.Text, out int integer);
            return integer;
        }

        public static Int32 ConvertToInt(string val)
        {
            Int32.TryParse(val, out int integer);
            return integer;
        }
    }
}