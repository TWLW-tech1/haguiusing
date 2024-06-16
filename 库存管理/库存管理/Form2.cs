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
using 库存管理;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 库存管理
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox5.Text;
            string confirmPassword = textBox7.Text;
            // 检查用户名、密码和确认密码是否为空
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("用户名、密码和确认密码不能为空，请重新输入！");
                return;
            }
            // 检查密码和确认密码是否一致
            if (password != confirmPassword)
            {
                MessageBox.Show("确认密码与密码不匹配，请重新输入！");
                textBox5.Clear(); // 清空密码字段，让用户重新输入
                textBox7.Clear();
                return;
            }

            // 连接数据库
            string connectionString = "Data Source=LAPTOP-0FV1AID2; Database=超市库存;User Id =sa;Password =12345";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // 插入数据
            string query = "INSERT INTO 账户 (账号, 密码) VALUES (@Username, @Password)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("注册成功！");

                // 关闭连接
                connection.Close();

                // 跳转到登录界面，关闭注册窗口
                this.Close();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("注册失败：" + ex.Message);
                // 可能的错误处理代码
            }
        }
    }
}
