using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ConnectionString
    {
        public static string connectionString = @"DATA SOURCE=localhost:1521;DBA PRIVILEGE = SYSDBA;TNS_ADMIN=C:\Users\Win10\Oracle\network\admin;PERSIST SECURITY INFO=True;USER ID = SYS;PASSWORD=123456";
    }
}
