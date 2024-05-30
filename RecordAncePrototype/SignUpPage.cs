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

        private void signupButton_Click(object sender, EventArgs e)
        {
            File.AppendAllText(usernameDB, usernameTextBox.Text);
            File.AppendAllText(passwordDB, passwordTextBox.Text);
            this.Hide();
            navigationpage.ShowDialog();
        }
    }
}
