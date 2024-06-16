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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 库存管理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox5.Text;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();
            registerForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 连接数据库
            string connectionString = "Data Source=LAPTOP-0FV1AID2; Database=超市库存;User Id =sa;Password =12345";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // 查询数据库
            string query = "SELECT COUNT(*) FROM 账户 WHERE 账号 = @Username AND 密码 = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", textBox3.Text);
            command.Parameters.AddWithValue("@Password", textBox5.Text);
            int count = (int)command.ExecuteScalar();

            // 检查是否匹配成功
            if (count > 0)
            {
                // 密码匹配成功，进入主界面
                MessageBox.Show("登录成功！");
                this.Hide();
                Form3 mainForm = new Form3();
                mainForm.Show();// 进入主界面的代码
            }
            else
            {
                // 密码不匹配，提示用户重新输入
                MessageBox.Show("用户名或密码不正确，请重新输入！");
            }

            // 关闭连接
            connection.Close();
        }
    }
}
