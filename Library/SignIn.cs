using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class SignIn : Form
    {
        public static string userID, firstName, lastName, eemail, ppassword;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public SignIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string userEmail = loginEmail.Text;
            string userPassword = loginPassword.Text;

            if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your password.");
            }
            else
            {
                string query = "Select * from Users WHERE Email= '" + userEmail + "' AND Password = '" + userPassword + "'";

                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if(dtUsers.Rows.Count == 1)
                {
                    userID = dtUsers.Rows[0]["userID"].ToString();
                    firstName = dtUsers.Rows[0]["FirstName"].ToString();
                    lastName = dtUsers.Rows[0]["LastName"].ToString();
                    eemail = dtUsers.Rows[0]["Email"].ToString();
                    ppassword = dtUsers.Rows[0]["Password"].ToString();

                    MessageBox.Show("You loged successfuly");
                    objDBAccess.closeConn();

                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid authentication data. Provide correct email and password.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
