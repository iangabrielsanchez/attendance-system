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
            
            
            Program.biometrics.Beep();
            Program.biometrics.Success();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.biometrics.BeginEroll();
            MessageBox.Show("Test");
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
    }
}
