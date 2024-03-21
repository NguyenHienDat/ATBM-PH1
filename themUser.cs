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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class themUser : Form
    {
        public themUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             using (OracleConnection connection = new OracleConnection(ConnectionString.connectionString))
             {
                connection.Open();
                string username,password;
                username = textBox1.Text;
                password = textBox2.Text;
                using (OracleCommand cmd = new OracleCommand("p_create_user", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("par_username", OracleDbType.Varchar2).Value = username;
                    cmd.Parameters.Add("par_password", OracleDbType.Varchar2).Value = password;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm user thành công");
                    this.Hide();
                }
                connection.Close(); 
            }
            
        }
    }
}
