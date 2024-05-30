using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RecordAncePrototype
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }


        NavigationPage navigationpage = new NavigationPage();
        public static string usernameDB = "usernameDB.txt";
        public static string passwordDB = "passwordDB.txt";
        public static string fullnameDB = "fullnameDB.txt";

        private void signupButton_Click(object sender, EventArgs e)
        {
            inputValidation();
        }

        public void proceedToNavigation()
        {
            this.Hide();
            navigationpage.ShowDialog();

            File.AppendAllText(usernameDB, usernameTextBox.Text + Environment.NewLine);
            File.AppendAllText(passwordDB, passwordTextBox.Text + Environment.NewLine);
            File.AppendAllText(fullnameDB, firstnameTextBox.Text + " " + lastnameTextBox.Text + Environment.NewLine);
        }

        public void inputValidation()
        {
            //Input Validation
            //Username validation
            //Empty Username
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your username."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
            }
            //Maximum length validation
            else if (usernameTextBox.Text.Length > 50)
            {
                MessageBox.Show("Username should be at least 6 to 50 characters only."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
            }
            //If the username has a white space
            else if (usernameTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Username should not contain a whitespace character."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();

            }
            //Input validation for unnecessary/prohibited characters
            else if(
                (usernameTextBox.Text.Contains("@"))
                || (usernameTextBox.Text.Contains("/"))
                || (usernameTextBox.Text.Contains("."))
                || (usernameTextBox.Text.Contains("&"))
                || (usernameTextBox.Text.Contains("*"))
                || (usernameTextBox.Text.Contains("!"))
                || (usernameTextBox.Text.Contains("#"))
                || (usernameTextBox.Text.Contains("$"))
                || (usernameTextBox.Text.Contains("%"))
                || (usernameTextBox.Text.Contains("^"))
                || (usernameTextBox.Text.Contains("("))
                || (usernameTextBox.Text.Contains(")"))
                || (usernameTextBox.Text.Contains("-"))
                || (usernameTextBox.Text.Contains("+"))
                || (usernameTextBox.Text.Contains("="))
                )
            {
                MessageBox.Show("Username should be a combination of alphanumeric" +
                    " characters and digits from 0 to 9."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
            }
            //First name validation
            //Empty first name
            else if (firstnameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your first name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstnameTextBox.Focus();
            }
            //Validate first name as a string
            else if (double.TryParse(firstnameTextBox.Text, out double firstnameParsed))
            {
                MessageBox.Show("First name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstnameTextBox.Text = "";
            }
            //Validate last name
            else if (lastnameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your last name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastnameTextBox.Focus();
            }
            //Validate last name as a string
            else if (double.TryParse(firstnameTextBox.Text, out double lastnameParsed))
            {
                MessageBox.Show("Last name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastnameTextBox.Text = "";
            }
            //Password Validation
            //Empty password
            else if(passwordTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your password."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
            }
            //Validate password length
            else if(usernameTextBox.Text.Length < 8)
            {
                MessageBox.Show("Password should be 8 characters long."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
                passwordTextBox.SelectAll();
            }
            //Validate white space character
            else if(usernameTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Password should not contain a whitespace character."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
                passwordTextBox.SelectAll();
            }
            else
            {
                proceedToNavigation();
            }
        }

    }
}
