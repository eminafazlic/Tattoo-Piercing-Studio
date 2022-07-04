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

    }
}
