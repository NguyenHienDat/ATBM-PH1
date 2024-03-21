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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class themRole : Form
    {
        public themRole()
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
                using (OracleCommand cmd = new OracleCommand("p_create_role", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("par_role", OracleDbType.Varchar2).Value = Role;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm role thành công");
                    this.Hide();
                }
                connection.Close();
            }

        }
    }
}
