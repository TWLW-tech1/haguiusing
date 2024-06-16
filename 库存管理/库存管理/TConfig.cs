using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 库存管理
{
    internal class TConfig
    {
        private static string _connection_string = string.Empty;
        public static string ConnectionString
        {
            get { return _connection_string; }
            set { _connection_string = value; }
        }
        public static void OpenDataGridViewDoubleBuffered(DataGridView dgv)
        {
            Type type = dgv.GetType();
            PropertyInfo pi = type.GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            pi.SetValue(dgv, true, null);
        }
    }
}
