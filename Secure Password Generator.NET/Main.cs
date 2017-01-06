using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Password_Generator
{
    public partial class Main : Form
    {
        Password password;
        Letters letters;

        public Main()
        {
            InitializeComponent();
            this.FormClosing += customFormClosing;
            this.passwordLength.SelectedIndex = 0;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitApplication();
        }

        private void checkIncLetters_CheckedChanged(object sender, EventArgs e)
        {

            checkIncLetterSelected();

            if (checkIncLetters.Checked == true)
            {
                setRadioEnabled(true);
            }
            else
            {
                setRadioEnabled(false);
            }
        }

        private void checkIncNums_CheckedChanged(object sender, EventArgs e)
        {
            checkIncLetterSelected();
        }

        private void checkIncSyms_CheckedChanged(object sender, EventArgs e)
        {
            checkIncLetterSelected();
        }

        private void checkIncLetterSelected()
        {
            if (checkIncNums.Checked == false && checkIncSyms.Checked == false)
            {
                checkIncLetters.Checked = true;
            }
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtPassword.TextLength > 3)
            {
                System.Windows.Forms.Clipboard.SetText(txtPassword.Text);
            }
        }

        private void exitApplication()
        {
            if ((System.Windows.Forms.Clipboard.GetText() != txtPassword.Text) || (txtPassword.Text.Length == 0))
            {
                Application.Exit();
            }
            else
            {
                DialogResult message = MessageBox.Show("Your clipboard seems to contain your generated password. Would you like to clear it before you exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    try
                    {
                        System.Windows.Forms.Clipboard.Clear();
                    }
                    catch (System.Runtime.InteropServices.ExternalException ee)
                    {
                        MessageBox.Show("Unable to clear your clipboard: " + ee.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Application.Exit();
            }
        }

        public void setRadioEnabled(Boolean value)
        {
            radioLower.Enabled = value;
            radioUpper.Enabled = value;
            radioMix.Enabled = value;
        }

        private void customFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                exitApplication();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = int.Parse(passwordLength.SelectedItem.ToString());

            letters = new Letters(checkIncLetters.Checked, radioUpper.Checked, radioLower.Checked);
            password = new Password(length, letters, checkIncNums.Checked, checkIncSyms.Checked);

            txtPassword.Text = password.generate();
        }

        private void helpSymbols_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The following characters are considered symbols: \n\n" + "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~", "Symbols", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void openWebPage(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openWebPage("https://github.com/yazin-yousif/Secure-Password-Generator.NET");
        }

        private void lblLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openWebPage("https://www.linkedin.com/in/yazin-yousif");
        }
    }
}