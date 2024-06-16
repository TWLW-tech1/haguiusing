using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 库存管理
{
    internal class SQL
    {
        public static DataTable GetTable(string sqltext)
        {
            SqlConnection connection = new SqlConnection(TConfig.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(sqltext, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
