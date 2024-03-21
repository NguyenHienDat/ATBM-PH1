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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class xoaUser : Form
    {
        public xoaUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string username;
                username = textBox1.Text;
                using (OracleCommand cmd = new OracleCommand("p_delete_user", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("par_username", OracleDbType.Varchar2).Value = username;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa user thành công");
                    this.Hide();
                }
                connection.Close();
            }

        }
    }
}
