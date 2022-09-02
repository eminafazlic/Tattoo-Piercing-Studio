using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TattooStudio.WinUI
{
    class Validator
    {
        public const string poruka = "Obavezno polje!";
        public const string telefon = "Obavezno polje! Format: XXX/XXX-XXX ili XXX/XXX-XXXX";
        public const string email = "Obavezno polje! Format: example@mail.com";
        public const string lozinke = "Lozinke se ne podudaraju!";
        public const string intpolje = "Obavezan unos broja!";
        public const string minDuzina = "Minimalan broj karaktera je ";
        public const string maxDuzina = "Maksimalan broj karaktera je ";
        public const string samoSlova = "Dozvoljen unos samo slova!";

        public static bool ObaveznoPolje(TextBox textBox, ErrorProvider err, string poruka)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                err.SetError(textBox, poruka);
                return false;
            }
            err.Clear();
            return true;
        }

        public static bool LozinkePolje(TextBox textBox1, TextBox textBox2, ErrorProvider err, string poruka)
        {
            if (textBox1.Text != textBox2.Text)
            {
                err.SetError(textBox2, poruka);
                return false;
            }
            err.Clear();
            return true;
        }

        public static bool ObaveznoPolje(RichTextBox richTextBox, ErrorProvider err, string poruka)
        {
            if (string.IsNullOrEmpty(richTextBox.Text))
            {
                err.SetError(richTextBox, poruka);
                return false;
            }
            err.Clear();
            return true;
        }

        public static bool TelefonPolje(TextBox textBox, ErrorProvider err, string poruka)
        {
            string pattern = "\\d{3}\\/\\d{3}-\\d{3,4}";
            Regex rg = new Regex(pattern);
            if (rg.Match(textBox.Text).Success)
            {
                err.Clear();
                return true;
            }
            else
            {
                err.SetError(textBox, poruka);
                return false;
            }
        }

        public static bool EmailPolje(TextBox textBox, ErrorProvider err, string poruka)
        {
            bool isValid = false;
            try
            {
                MailAddress address = new MailAddress(textBox.Text);
                isValid = string.IsNullOrEmpty(address.DisplayName);
                if (isValid)
                {
                    err.Clear();
                    return true;
                }

            }
            catch(FormatException)
            {
                err.SetError(textBox, poruka);
                return false;
            }
            return false;
        }

        public static bool IntegerPolje(TextBox textBox, ErrorProvider err, string poruka)
        {
            if (!int.TryParse(textBox.Text, out int result))
            {
                err.SetError(textBox, poruka);
                return false;
            }
            err.Clear();
            return true;
        }

        public static bool MinDuzina(RichTextBox richTextBox, ErrorProvider err, int min, string poruka)
        {
            if ((richTextBox.Text).Length < min)
            {
                err.SetError(richTextBox, poruka + min);
                return false;
            }
            err.Clear();
            return true;
        }

        public static bool MinDuzina(TextBox textBox, ErrorProvider err, int min, string poruka)
        {
            if ((textBox.Text).Length < min)
            {
                err.SetError(textBox, poruka + min);
                return false;
            }
            err.Clear();
            return true;
        }

        public static bool MaxDuzina(RichTextBox richTextBox, ErrorProvider err, int max, string poruka)
        {
            if (richTextBox.Text.Length > max)
            {
                err.SetError(richTextBox, poruka + max);
                return false;
            }
            err.Clear();
            return true;
        }
        public static bool MaxDuzina(TextBox textBox, ErrorProvider err, int max, string poruka)
        {
            if (textBox.Text.Length > max)
            {
                err.SetError(textBox, poruka + max);
                return false;
            }
            err.Clear();
            return true;
        }
        public static bool SamoSlova(TextBox textBox, ErrorProvider err, string poruka)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (regex.IsMatch(textBox.Text))
            {
                err.SetError(textBox, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
