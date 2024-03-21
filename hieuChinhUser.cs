using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class hieuChinhUser : Form
    {
        public hieuChinhUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string username, password;
                username = textBox1.Text;
                password = textBox2.Text;
                using (OracleCommand cmd = new OracleCommand("p_alter_user", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("par_username", OracleDbType.Varchar2).Value = username;
                    cmd.Parameters.Add("par_password", OracleDbType.Varchar2).Value = password;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hiệu chỉnh user thành công");
                    this.Hide();
                }
                connection.Close();
            }

        }
    }
}
