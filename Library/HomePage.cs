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
    public partial class HomePage : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            welcome.Text = "Welcome: " + SignIn.firstName + " " + SignIn.lastName;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are ypu sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                string query = ("DELETE from Users WHERE UserID = '" + SignIn.userID + "'");

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objDBAccess.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Deleted Successfully.");

                    this.Hide();
                    SignUp sign = new SignUp();
                    sign.Show();
                }
                else
                {
                    MessageBox.Show("Error Occured. Try Again.");
                }
            }
        }

        private void updateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update update = new Update();
            update.Show();
        }

        private void usersList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book add = new Book();
            add.Show();
        }

        private void booksList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Library books = new Library();
            books.Show();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Logged Out Successfully.");

            this.Hide();
            SignIn sign = new SignIn();
            sign.Show();
        }

        private void transactionsList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions transactions = new Transactions();
            transactions.Show();
        }
    }
}
