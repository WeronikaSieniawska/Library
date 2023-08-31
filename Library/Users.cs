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
    public partial class Users : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Users()
        {
            InitializeComponent();
        }

        private void CommandBuilderForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * from Users";

            objDBAccess.readDatathroughAdapter(query, dtUsers);

            dataGridView1.DataSource = dtUsers;
            objDBAccess.closeConn();
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from Users";

            int changes = objDBAccess.executeDataAdapter(dtUsers, query);

            MessageBox.Show("count = " + changes);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.Show();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.Show();
        }
    }
}
