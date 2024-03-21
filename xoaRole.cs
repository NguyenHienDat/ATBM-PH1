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
    public partial class xoaRole : Form
    {
        public xoaRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string Role;
                Role = textBox1.Text;
                using (OracleCommand cmd = new OracleCommand("p_delete_role", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("par_role", OracleDbType.Varchar2).Value = Role;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa role thành công");
                    this.Hide();
                }
                connection.Close();
            }
        }
    }
}
