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

        SignUpPage signuppage= new SignUpPage();
        NavigationPage navigationpage = new NavigationPage();
        public static string usernameDB = "usernameDB.txt";
        public static string passwordDB = "passwordDB.txt";

        private void signinButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            navigationpage.ShowDialog();

            File.AppendAllText(usernameDB, usernameTextBox.Text);
            File.AppendAllText(passwordDB, usernameTextBox.Text);
        }

        private void signupLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            signuppage.ShowDialog();
        }
    }
}