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
    public partial class Update : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            updateFirstName.Text = SignIn.firstName;
            updateLastName.Text = SignIn.lastName;
            updateEmail.Text = SignIn.eemail;
            updatePassword.Text = SignIn.ppassword;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string newUserFirstName = updateFirstName.Text;
            string newUserLastName = updateLastName.Text;
            string newUserEmail = updateEmail.Text;
            string newUserPassword = updatePassword.Text;

            if (newUserFirstName.Equals(""))
            {
                MessageBox.Show("please write your first name");
            }
            else if (newUserLastName.Equals(""))
            {
                MessageBox.Show("please write your last name");
            }
            else if (newUserEmail.Equals(""))
            {
                MessageBox.Show("please write your email");
            }
            else if (newUserPassword.Equals(""))
            {
                MessageBox.Show("please write your password");
            }
            else
            {
                string query = "Update Users SET FirstName = '" + @newUserFirstName + "', LastName = '" + @newUserLastName + "', Email = '" + @newUserEmail + "', Password = '" + @newUserPassword + "' WHERE UserID = '" + SignIn.userID + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@userFirstName", @newUserFirstName);
                updateCommand.Parameters.AddWithValue("@userLastName", @newUserLastName);
                updateCommand.Parameters.AddWithValue("@userEmail", @newUserEmail);
                updateCommand.Parameters.AddWithValue("@userPassword", @newUserPassword);

                int row = objDBAccess.executeQuery(updateCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Information Updated Successfully.");

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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.Show();
        }
    }
}
