using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 库存管理
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private TabControl tabControl;
        private DataTable dtProduct;
        private DataTable dtEmployee;
        private void UpdataDateGridViewEmployee()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dtEmployee.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = i + 1;
                dataGridView1[1, i].Value = dtEmployee.Rows[i]["员工编号"];
                dataGridView1[2, i].Value = dtEmployee.Rows[i]["姓名"];
                dataGridView1[3, i].Value = dtEmployee.Rows[i]["性别"];
                dataGridView1[4, i].Value = dtEmployee.Rows[i]["年龄"];
                dataGridView1[5, i].Value = dtEmployee.Rows[i]["工龄"];
                dataGridView1[6, i].Value = dtEmployee.Rows[i]["手机号码"];
                dataGridView1[7, i].Value = dtEmployee.Rows[i]["家庭住址"];
            }
        }
        private void Form6_Load_1(object sender, EventArgs e)
        {
            TConfig.OpenDataGridViewDoubleBuffered(dataGridView1);//打开DataGridView1控件的双缓冲
            TConfig.ConnectionString = "Data Source=LAPTOP-0FV1AID2; Database=超市库存;User Id =sa;Password =12345";
            string sqltext = "select * from employee";
            dtEmployee = SQL.GetTable(sqltext);
            UpdataDateGridViewEmployee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 mainForm = new Form3();
            mainForm.Show();
            this.Hide();
        }
    }
}
