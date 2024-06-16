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
    public partial class Form4 : Form
    {
        string connectionString = "Data Source=LAPTOP-0FV1AID2; Database=超市库存;User Id =sa;Password =12345";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 检查输入数据是否为空
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox7.Text) ||
               string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrEmpty(textBox11.Text) || string.IsNullOrEmpty(textBox13.Text) ||
               string.IsNullOrEmpty(textBox15.Text))
            {
                MessageBox.Show("输入数据不能存在空值，请重新输入！");
                return; // 停止执行插入操作
            }

            try
            {
                // 创建数据库连接对象
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 打开数据库连接
                    connection.Open();

                    // 创建SQL插入命令
                    string sql = "INSERT INTO employee (员工编号, 姓名, 性别, 年龄, 工龄, 手机号码, 家庭住址) " +
                                 "VALUES (@EmployeeID, @Name, @Gender, @Age, @YearsOfWork, @PhoneNumber, @Address)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // 设置参数值
                    command.Parameters.AddWithValue("@EmployeeID", textBox3.Text);
                    command.Parameters.AddWithValue("@Name", textBox5.Text);
                    command.Parameters.AddWithValue("@Gender", textBox7.Text);
                    command.Parameters.AddWithValue("@Age", textBox9.Text);
                    command.Parameters.AddWithValue("@YearsOfWork", textBox11.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", textBox13.Text);
                    command.Parameters.AddWithValue("@Address", textBox15.Text);

                    // 执行插入命令
                    int rowsAffected = command.ExecuteNonQuery();
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    textBox9.Text = "";
                    textBox11.Text = "";
                    textBox13.Text = "";
                    textBox15.Text = "";
                    // 提示用户添加成功
                    MessageBox.Show(rowsAffected + " 行记录已添加到数据库。");
                }
            }
            catch (Exception ex)
            {
                // 处理异常情况
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建数据库连接对象
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 打开数据库连接
                    connection.Open();
                    // 检查员工编号是否存在
                    string checkEmployeeQuery = "SELECT COUNT(*) FROM employee WHERE 员工编号 = @EmployeeID";
                    SqlCommand checkEmployeeCommand = new SqlCommand(checkEmployeeQuery, connection);
                    checkEmployeeCommand.Parameters.AddWithValue("@EmployeeID", textBox18.Text);
                    int employeeCount = (int)checkEmployeeCommand.ExecuteScalar();

                    // 如果员工编号不存在，则提示错误
                    if (employeeCount == 0)
                    {
                        MessageBox.Show("输入的员工编号不存在，请重新输入。");
                        return;
                    }
                    // 创建SQL删除命令
                    string sql = "DELETE FROM employee WHERE 员工编号 = @EmployeeID";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // 设置参数值
                    command.Parameters.AddWithValue("@EmployeeID", textBox18.Text);

                    // 执行删除命令
                    int rowsAffected = command.ExecuteNonQuery();
                    textBox18.Text = "";
                    // 提示用户删除成功
                    MessageBox.Show(rowsAffected + " 行记录已从数据库中删除。");
                }
            }
            catch (Exception ex)
            {
                // 处理异常情况
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建数据库连接对象
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 打开数据库连接
                    connection.Open();
                    // 检查员工编号是否存在
                    string checkEmployeeQuery = "SELECT COUNT(*) FROM employee WHERE 员工编号 = @EmployeeID";
                    SqlCommand checkEmployeeCommand = new SqlCommand(checkEmployeeQuery, connection);
                    checkEmployeeCommand.Parameters.AddWithValue("@EmployeeID", textBox21.Text);
                    int employeeCount = (int)checkEmployeeCommand.ExecuteScalar();

                    // 检查列名是否存在
                    string columnName = textBox23.Text;
                    string checkColumnQuery = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'employee' AND COLUMN_NAME = '{columnName}'";
                    SqlCommand checkColumnCommand = new SqlCommand(checkColumnQuery, connection);
                    int columnCount = (int)checkColumnCommand.ExecuteScalar();

                    // 如果员工编号或列名不存在，则提示错误
                    if (employeeCount == 0)
                    {
                        MessageBox.Show("输入的员工编号不存在，请重新输入。");
                        return;
                    }
                    else if (columnCount == 0)
                    {
                        MessageBox.Show("输入的列名不存在，请重新输入。");
                        return;
                    }
                    // 创建SQL修改命令
                    string sql = $"UPDATE employee SET {textBox23.Text} = @NewValue WHERE 员工编号 = @EmployeeID";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // 设置参数值
                    command.Parameters.AddWithValue("@EmployeeID", textBox21.Text);
                    command.Parameters.AddWithValue("@NewValue", textBox25.Text);

                    // 执行修改命令
                    int rowsAffected = command.ExecuteNonQuery();
                    textBox21.Text = "";
                    textBox23.Text = "";
                    textBox25.Text = "";
                    // 提示用户修改成功
                    MessageBox.Show(rowsAffected + " 行记录已修改。");
                }
            }
            catch (Exception ex)
            {
                // 处理异常情况
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 mainForm = new Form3();
            mainForm.Show();
            this.Hide();
        }
    }
}
