using System;
using System.Windows.Forms;
using UniversalSerialGenerator.Properties;

namespace UniversalSerialGenerator
{
    public partial class FormMain : Form
    {
        char[] uppercase = Resources.uppercase.ToCharArray();
        char[] lowercase = Resources.lowercase.ToCharArray();
        char[] numbers = Resources.numbers.ToCharArray();
        Random rand = new Random();

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show();
            btnGen.Focus();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            tbGeneratedSerial.Text = GenerateSerial();
        }

        private string GenerateSerial()
        {
            string tmp = "";

            if (chkSpecificStart.Checked && tbSpecificStart.Text != "")
                tmp += tbSpecificStart.Text;
            
            // Section
            for (int sections = 0; sections < numSections.Value; sections++)
            {
                // Char in section
                for (int cps = 0; cps < numCharsPerSections.Value; cps++)
                {
                    if (optLettersAndNumbers.Checked)
                        if (rand.Next(0, 3) == 0)
                            tmp += GenerateLetter();
                        else
                            tmp += GenerateNumber();
                    else if (optOnlyLetters.Checked)
                        tmp += GenerateLetter();
                    else if (optOnlyNumbers.Checked)
                        tmp += GenerateNumber();
                    else
                        MessageBox.Show("GenerateSerial(): weird error :/");
                }
                if(sections < numSections.Value - 1)
                tmp += tbSeperator.Text;
            }

            if (chkSpecificEnd.Checked && tbSpecificEnd.Text != "")
                tmp += tbSpecificEnd.Text;

            return tmp;
        }

        private char GenerateNumber()
        {
            return numbers[rand.Next(0, 10)];
        }

        private char GenerateLetter()
        {
            if (optUpperAndLowerCase.Checked)
            {
                if (rand.Next(0, 2) == 0)
                    return uppercase[rand.Next(0, 26)];
                else
                    return lowercase[rand.Next(0, 26)];
            }
            else if (optOnlyUpperCase.Checked)
                return uppercase[rand.Next(0, 26)];
            else
                return lowercase[rand.Next(0, 26)];
        }

        private void chkSpecificStart_CheckedChanged(object sender, EventArgs e)
        {
            tbSpecificStart.Enabled = chkSpecificStart.Checked;
        }

        private void chkSpecificEnd_CheckedChanged(object sender, EventArgs e)
        {
            tbSpecificEnd.Enabled = chkSpecificEnd.Checked;
        }

        private void optOnlyNumbers_CheckedChanged(object sender, EventArgs e)
        {
            optOnlyUpperCase.Enabled = !optOnlyNumbers.Checked;
            optOnlyLowerCase.Enabled = !optOnlyNumbers.Checked;
            optUpperAndLowerCase.Enabled = !optOnlyNumbers.Checked;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbGeneratedSerial.Text);
        }
    }
}
