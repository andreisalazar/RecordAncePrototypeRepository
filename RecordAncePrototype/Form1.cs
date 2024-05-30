using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecordAncePrototype
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        SignUpPage signuppage = new SignUpPage();
        NavigationPage navigationpage = new NavigationPage();
        public static string usernameDB = "usernameDB.txt";
        public static string passwordDB = "passwordDB.txt";

        private void signinButton_Click(object sender, EventArgs e)
        {
            //Validate if the account exists
            //String to read all the usernames inside the text file 
            string[] usernameList = File.ReadAllLines(usernameDB);
            string[] passwordList = File.ReadAllLines(passwordDB);

            
            int usernameIndex = Array.IndexOf(usernameList, usernameTextBox.Text);
            if (!usernameList.Contains(usernameTextBox.Text) 
                || usernameIndex == -1)
            {
                MessageBox.Show("Account not found.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
                passwordTextBox.Text = "";
            }
            if (passwordList[usernameIndex] == passwordTextBox.Text)
            {
                proceedToNavigation();
            }
            else
            {
                MessageBox.Show("Incorrect password." + passwordList[usernameIndex].ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
                passwordTextBox.SelectAll();
            }

        }

        private void signupLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            signuppage.ShowDialog();
        }

        public void proceedToNavigation()
        {
            this.Hide();
            navigationpage.ShowDialog();
        }

        private void forgotpasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}