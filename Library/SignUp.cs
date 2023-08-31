using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class SignUp : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userFirstName = textBoxFirstName.Text;
            string userLastName = textBoxLastName.Text;
            string userEmail = textBoxEmail.Text;
            string userPassword = textBoxPassword.Text;

            if (userFirstName.Equals(""))
            {
                MessageBox.Show("Please enter your first name.");
            }
            else if (userLastName.Equals(""))
            {
                MessageBox.Show("Please enter your last name.");
            }
            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your password.");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users(FirstName,LastName,Email,Password) values(@userFirstName, @userLastName, @userEmail, @userPassword)");

                insertCommand.Parameters.AddWithValue("@userFirstName", userFirstName);
                insertCommand.Parameters.AddWithValue("@userLastName", userLastName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);

                int row = objDBAccess.executeQuery(insertCommand);

                if(row == 1)
                {
                    MessageBox.Show("Account Created Successfully.");

                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Error Occured. Try Again.");
                }
            }
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }
    }
}
