using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 库存管理;

namespace 库存管理
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private DataTable dtgoods;
        private void UpdataDateGridView()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dtgoods.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = i + 1;
                dataGridView1[1, i].Value = dtgoods.Rows[i]["商品编号"];
                dataGridView1[2, i].Value = dtgoods.Rows[i]["品牌"];
                dataGridView1[3, i].Value = dtgoods.Rows[i]["商品名称"];
                dataGridView1[4, i].Value = dtgoods.Rows[i]["库存"];
            }
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            TConfig.OpenDataGridViewDoubleBuffered(dataGridView1);//打开DataGridView1控件的双缓冲
            TConfig.ConnectionString = "Data Source=LAPTOP-0FV1AID2; Database=超市库存;User Id =sa;Password =12345";
            string sqltext = "select * from 盘点";
            dtgoods = SQL.GetTable(sqltext);
            UpdataDateGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 mainForm = new Form3();
            mainForm.Show();
            this.Hide();
        }
    }
}