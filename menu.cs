using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getAllUser().Tables[0];
        }
        DataSet getAllUser()
        {
            DataSet data = new DataSet();
            String query = "select * from DBA_USERS";
            using (OracleConnection connection = new OracleConnection(ConnectionString.connectionString))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query,connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getAllRoles().Tables[0];
        }
        DataSet getAllRoles()
        {
            DataSet data = new DataSet();
            String query = "select GRANTEE, GRANTOR, PRIVILEGE, TABLE_NAME from DBA_TAB_PRIVS";
            using (OracleConnection connection = new OracleConnection(ConnectionString.connectionString))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            themUser form = new themUser();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xoaUser form = new xoaUser();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hieuChinhUser form = new hieuChinhUser();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            themRole form = new themRole(); 
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            xoaRole form = new xoaRole();
            form.Show();
        }
    }
}
