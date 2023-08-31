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
using System.Data.SqlClient;

namespace Library
{
    public partial class Book : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public Book()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.Show();
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string bookTitle = textBoxTitle.Text;
            string bookAuthor = textBoxAuthor.Text;
            string bookPYear = textBoxYear.Text;
            string bookCategory = comboBoxCategory.Text;
            string bookISBN = textBoxISBN.Text;
            string bookQuantity = textBoxQuantity.Text;

            if (bookTitle.Equals(""))
            {
                MessageBox.Show("Please enter book title.");
            }
            else if (bookAuthor.Equals(""))
            {
                MessageBox.Show("Please enter book author.");
            }
            else if (bookPYear.Equals(""))
            {
                MessageBox.Show("Please enter book publication year.");
            }
            else if (bookCategory.Equals(""))
            {
                MessageBox.Show("Please enter book category.");
            }
            else if (bookISBN.Equals(""))
            {
                MessageBox.Show("Please enter book ISBN number.");
            }
            else if (bookQuantity.Equals(""))
            {
                MessageBox.Show("Please enter quantity of books.");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Books(Title,Author,PublicationYear,Category,ISBN,Quantity) values(@bookTitle, @bookAuthor, @bookPYear, @bookCategory, @bookISBN, @bookQuantity)");

                insertCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                insertCommand.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                insertCommand.Parameters.AddWithValue("@bookPYear", bookPYear);
                insertCommand.Parameters.AddWithValue("@bookCategory", bookCategory);
                insertCommand.Parameters.AddWithValue("@bookISBN", bookISBN);
                insertCommand.Parameters.AddWithValue("@bookQuantity", bookQuantity);

                int row = objDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Book Added Successfully.");

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
    }
}
