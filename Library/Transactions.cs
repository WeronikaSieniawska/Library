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
    public partial class Transactions : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtTransactions = new DataTable();

        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            string query = "SELECT * from Transactions";

            objDBAccess.readDatathroughAdapter(query, dtTransactions);

            dataGridView1.DataSource = dtTransactions;
            objDBAccess.closeConn();
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from Transactions";

            int changes = objDBAccess.executeDataAdapter(dtTransactions, query);

            MessageBox.Show("count = " + changes);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.Show();
        }
    }
}
