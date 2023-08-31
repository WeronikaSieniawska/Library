using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Library : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtBooks = new DataTable();

        public Library()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.Show();
        }

        private void Library_Load(object sender, EventArgs e)
        {
            string query = "SELECT * from Books";

            objDBAccess.readDatathroughAdapter(query, dtBooks);

            dataGridView2.DataSource = dtBooks;
            objDBAccess.closeConn();
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from Books";

            int changes = objDBAccess.executeDataAdapter(dtBooks, query);

            MessageBox.Show("count = " + changes);
        }
    }
}
