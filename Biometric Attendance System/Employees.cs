using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Biometric_Attendance_System.Model;
using System.Security.Cryptography;
using System.Drawing.Imaging;

namespace Biometric_Attendance_System
{
    public partial class Employees : UserControl
    {
        Dictionary<string, string> templates = new Dictionary<string, string>();

        public Employees()
        {
            InitializeComponent();
            Program.biometrics.engine.OnEnroll += Engine_OnEnroll;
            Program.biometrics.engine.OnImageReceived += Engine_OnImageReceived;
            Program.biometrics.engine.OnCapture += Engine_OnCapture;
            templates.Add("thumb", "mspZFprRjU5ogQkaUWdBDR5NNkENJs07gQ4jTkIBCyCZH0EJdhwZwQVumjlBDYqdQEEIhbAnAQ5pMy3BEWtLTcENjUxUAQuUzlYBDhzOTwEJHFkwQQYfWSqBCSBXLgEKnlcpAQ6ZWTuBCxdZNsEKGVZGAQ+WVz8BDplXOkEOnlc1gQyeIDbBBA40ZgEKkzJXwQceTG1BCpTObkEOE8lcAQ6aTF1BEZKySsELjsk8wRuOSTRBF43MFwFLtzwcgQ9H0TMBECZOGEExLKc7gQmFJ0vBBIurNkEIfVALwQ01HA2BBeYaKQEEB6oMQQTXxTCBNp2uDMEIXZElQQaADjTBBYjZRMEGGFlNwQwTJWRPDQANYmNnbXQCBwwSFhgZGRkADl9fYmZwdwULEhcaGxobGwANZGZrcXYFCQ8RFRcYGBgADltbXWBpcwQLFBocHBoaGQANaGpvcwEGCg8RFBYWFxcADlVWV1lgbQMOGB0fIB0dGwANam1wdAIHCg4QEhQUFhgADlRUUlNVXwEVHCEiIyEhHwAMbnBzdgMHCg4QExMVFQAPT05MS0tMMR0hJCUmJCMiIgAMcHJ1AgUICw8REhQVGAAPSklGREREMiUlJSYmJSMjJAALc3UCBQcJDQ8RExQWAA9DQkFAPjcnJiYlJCMiIiEiAAt2AQUICgwODxESFBYAD0FAQD43Ix0iJCIgHx8dHSAACgIFCAoOEBISEBARAA8+PTk1LSokIyEfHRwcHBsdAQkHCg0PEhMTERAADjk3Mi4pKCUjIR0dHBsYFwIICw4RFBUUEAENNjEuKiknJSIgHx8dGw==");
            templates.Add("index", "mspZ1nh+mS5QQQaSsUpBBY8/JcEHusEowQm/PzHBDEnCN8EaRTguAQtGSiVBFsesMUEeXLIagRDHujfBEjdNM0Eb5jVYQQcgx2lBD5RFG8ELxEgswRLMrCjBDds5PgEmKrNWQQSUzCnBHtakHIEN2TRAAR15siUBCU++bsEJmZVFgQmDIl2BBY2HQUEJiE5RgSWDMhDBBUtIPcE7g5BBAQWCJoTtDrDgcQ4ADUxOUVRZYXMJEhgcHyAhAA1LSk1QVlxrCBQaHyAhIQANUVNWWV9rAQoRFhkcHyEADklHSUtQVF0HFhwfISEjIgEMVlldYXACCQ8TFRkbAA5HRUZGSktLLx8gISMjJCIBDFhcX2RyAwgNEBMWGQAORkZGRkZFQTUlIyMjIyQkAQxdYGRtdQQHDA8RFBgADkZGRkZFQz80KSQkJSQjIQEMYGNqcncDBgsPEhUYAA5HSEpKSkdANCgkIyIhISECC2RwdQIEBwwPExQBDkhJS01OSzEgHyEhIR8gAgtocwEEBwkMDhETAg5MTVNWXAQUGBwdHx0iAwp3BQgKDA8PEAIOVFRWW2d1BxAYHyEfJwQKCQ0ODw8QEQIOXllbXmtzAxEfJichKwUJDg8REhMDDVxZXmtr/////zMt");
            templates.Add("middle", "mspZVm96nspIQSKVzUgBIpQzJwEFPUsjwRbdLEgBDCo+WoEKmjE4AR4vzUFBGIgwMYEVPEQpAT8aQCqBHiFLHgESzcY1AQeVSi8BI3alKMEW1SQXQQjGpTrBHoEoOIE1ZqkfQQfEry8BFc+xHUEDQCRHQQuSnUTBDYwWPAEMgRdOgQeRoyMBDkxFY8ETkENTwQ+WL2HBCKC6ZYEGly5ESw6w0DEKAA1HR0dHSFFYGCMpKywsLAANRkZFRURHPy8oLCwrKSkADUhISUtPW3cRICYrLC0tAA1ERURCQUA6Mi0uLCknKAANSEhLUFdlAg8cJCksLjIADUREQ0E+OzYxLi0rJyUkAQxITldeawIPGiImKS0ADUJDQkA9ODMuLCooJCQjAgxTXGNtAg0YHyQnKwANQkNDQTs0LCgnJiQgHxwCDFJeZnEEDhYcIiUpAQ1GRkQ7MCQiISEfHRwcAgtSYGpzBQ0VGR8iAg1LS0MoHR0fIBsZFxkDC2RwAQgMERYbHwINTlNcBRMXGBcYGhsaBQoECAsQFBoCDU9ZZHQKERIUG/8dGwcJCg8SAwleaHEDCAcLAAD/BAhmcAMKBw==");
            templates.Add("TART KO <3", "mspZFnmBlz00wVoevjLBSiW9IYERRL4ngRhAvywBIjaRH8ELAxMhwQcHkBzBFXCSHMEZbrgxQSgFvFnBCRofIIEIAq5OwQaIsElBBhK0WEEDjDlKQQsbzFUBC463MQEkYjcUAQ3RRkpBCZgqCcEI2J8wQQeAoSUBC3VCMwEUJjMewQ1YKR1BC2REL8EOqbUOwQxNjxRBEHAVSUEKiJcfARBzSyaBCygfNC8MAA1dXmJobnUFCg8RERAQEAANV1leY2pyBAoOERMSEhIADV9hZWxydwYMDxAQDw4OAA1TVFleZW8DCw8SExMUFAANYmVpcHQDBwwPDw8ODg0ADktNUVdfagIPExUVFBQUFgAMZWdrcXcGCg0PDw8NDQAORkdITFRfCBYYGRgWFRQVAAxmaW5zAwkNDw8PDw4PAA5CQkNERDshHBwdGxkWFRQAC2prbnQFCw8REg8QDwAOPj4+PTkwJSAfHx0bGBYWAAtub3IBBwwPEhUSExAADTs6OTcyKyQgHRwcGhkXAApyc3UCBQkPEhQSFAANODc1Mi0mIR0aGBYWFhYBCHYCBQcJDxATAA02NDAtJyIfGxcTERETFQMFBQgJAQ0xLSkkIBwZFBANDQ8UAAD/AgwoJiIdGxgTDwwLDQ==");
        }

        private void Engine_OnCapture(bool ActionResult, object ATemplate)
        {
            bool output;
            foreach (var pair in templates)
            {
                var key = pair.Key;
                object template = null;
                Program.biometrics.engine.DecodeTemplate(pair.Value, ref template);
                output = Program.biometrics.Verify(ref template, ATemplate);
                if (output)
                {
                    MessageBox.Show(key);
                    break;
                }
            }            
        }

        private void Engine_OnImageReceived(ref bool AImageValid)
        {
            pictureBoxFingerprint.Image = Program.biometrics.GetImage();
            //Program.biometrics.Beep();
            Program.biometrics.Success();
            
        }

        private void RegisterFingerprint(object sender, EventArgs e)
        {
            Program.biometrics.BeginEroll();
        }

        private void Engine_OnEnroll(bool ActionResult, object ATemplate)
        {
            if (ActionResult)
            {
                if (Program.biometrics.engine.LastQuality >= 60) //to ensure the fingerprint quality
                {
                    string regTemplate = Program.biometrics.engine.GetTemplateAsStringEx("9");                    
                    MessageBox.Show(regTemplate);
                    Clipboard.SetText(regTemplate);
                    //File.WriteAllText(Application.StartupPath + "\\fingerprint.txt", regTemplate);
                    MessageBox.Show("registered");
                }
                else
                {
                    MessageBox.Show("quality low");
                }
            }
            else
            {
                MessageBox.Show("register fail");
            }
        }

        private void buttonClearFinger_Click(object sender, EventArgs e)
        {
            pictureBoxFingerprint.Image = Properties.Resources.fingerprint;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var template = Program.biometrics.engine.GetTemplateAsStringEx("9");
            var templateHash = GetSha1Hash(template);
            MessageBox.Show(Application.StartupPath);
            pictureBoxFingerprint.Image.Save(@"fingerprints\" +templateHash + ".jpg", ImageFormat.Jpeg);
            //Employee employee = new Employee(
            //    int.Parse(txtId.Text),
            //    txtFirstName.Text,
            //    txtMiddleName.Text,
            //    txtLastName.Text,
            //    cbxDepartment.SelectedIndex,
            //    txtPosition.Text,
            //    txtAddress.Text,
            //    cbxSex.Text,
            //    new Date(dtpBirthDate.Value),
            //    new Date(dtpDateEmployed.Value),
            //    txtTIN.Text,
            //    txtSSN.Text,
            //    txtPhilHealth.Text,
            //    txtPagibig.Text,
            //    txtContact.Text,
            //    decimal.Parse(txtRate.Text),
            //    ,
            //);
        }

        static string GetSha1Hash(string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = Program.sha1.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
