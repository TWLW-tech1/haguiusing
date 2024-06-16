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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=LAPTOP-0FV1AID2; Database=超市库存;User Id =sa;Password =12345";
        private void button8_Click(object sender, EventArgs e)
        {
            // 检查输入数据是否为空
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) ||
               string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("输入数据不能存在空值，请重新输入！");
                return; // 停止执行插入操作
            }
            // 获取文本框中的输入值
            string productID = textBox1.Text;
            string employeeID = textBox2.Text;
            string brand = textBox3.Text;
            string productName = textBox4.Text;
            decimal price = Convert.ToDecimal(textBox5.Text);
            int quantity = Convert.ToInt32(textBox6.Text);

            // 创建连接对象和 SQL 命令对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // 插入到商品表
                    string insertProductQuery = "INSERT INTO 商品 (商品编号, 员工编号, 品牌, 商品名称, 价格, 库存) " +
                                                "VALUES (@ProductID, @EmployeeID, @Brand, @ProductName, @Price, @Quantity)";

                    using (SqlCommand command = new SqlCommand(insertProductQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@Brand", brand);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("成功添加 " + rowsAffected + " 行记录到商品表。");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }

                    // 插入到盘点表
                    string insertInventoryQuery = "INSERT INTO 盘点 (商品编号, 品牌, 商品名称, 库存) " +
                                                  "VALUES (@ProductID, @Brand, @ProductName, @Quantity)";

                    using (SqlCommand command = new SqlCommand(insertInventoryQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.Parameters.AddWithValue("@Brand", brand);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("成功添加 " + rowsAffected + " 行记录到盘点表。");
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("添加记录时出错：" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建数据库连接对象
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 打开数据库连接
                    connection.Open();

                    // 检查商品编号是否存在
                    string checkProductQuery = "SELECT COUNT(*) FROM 商品 WHERE 商品编号 = @ProductID";
                    SqlCommand checkProductCommand = new SqlCommand(checkProductQuery, connection);
                    checkProductCommand.Parameters.AddWithValue("@ProductID", textBox7.Text);
                    int productCount = (int)checkProductCommand.ExecuteScalar();

                    // 检查列名是否存在
                    string columnName = textBox8.Text;
                    string checkColumnQuery = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '商品' AND COLUMN_NAME = '{columnName}'";
                    SqlCommand checkColumnCommand = new SqlCommand(checkColumnQuery, connection);
                    int columnCount = (int)checkColumnCommand.ExecuteScalar();

                    // 如果商品编号或列名不存在，则提示错误
                    if (productCount == 0)
                    {
                        MessageBox.Show("输入的商品编号不存在，请重新输入。");
                        return;
                    }
                    else if (columnCount == 0)
                    {
                        MessageBox.Show("输入的列名不存在，请重新输入。");
                        return;
                    }

                    // 创建SQL修改命令
                    string sql = $"UPDATE 商品 SET {textBox8.Text} = @NewValue WHERE 商品编号 = @ProductID";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // 设置参数值
                    command.Parameters.AddWithValue("@ProductID", textBox7.Text);
                    command.Parameters.AddWithValue("@NewValue", textBox9.Text);

                    // 执行修改命令
                    int rowsAffected = command.ExecuteNonQuery();
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";

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

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建数据库连接对象
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 打开数据库连接
                    connection.Open();

                    // 检查商品编号是否存在
                    string checkProductQuery = "SELECT COUNT(*) FROM 商品 WHERE 商品编号 = @ProductID";
                    SqlCommand checkProductCommand = new SqlCommand(checkProductQuery, connection);
                    checkProductCommand.Parameters.AddWithValue("@ProductID", textBox10.Text);
                    int productCount = (int)checkProductCommand.ExecuteScalar();

                    // 如果商品编号不存在，则提示错误
                    if (productCount == 0)
                    {
                        MessageBox.Show("输入的商品编号不存在，请重新输入。");
                        return;
                    }

                    // 创建SQL删除命令
                    string sql = "DELETE FROM 商品 WHERE 商品编号 = @ProductID";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // 设置参数值
                    command.Parameters.AddWithValue("@ProductID", textBox10.Text);

                    // 执行删除命令
                    int rowsAffected = command.ExecuteNonQuery();

                    // 提示用户删除成功
                    MessageBox.Show(rowsAffected + " 行记录已删除。");
                }
            }
            catch (Exception ex)
            {
                // 处理异常情况
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form3 mainForm = new Form3();
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int 商品编号 = Convert.ToInt32(textBox11.Text);
            int 出库数量 = Convert.ToInt32(txtQuantity.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // 查询当前商品的库存
                    string 查询库存SQL = "SELECT 库存 FROM 商品表 WHERE 商品编号 = @商品编号";
                    SqlCommand 查询库存命令 = new SqlCommand(查询库存SQL, connection, transaction);
                    查询库存命令.Parameters.AddWithValue("@商品编号", 商品编号);
                    int 当前库存 = Convert.ToInt32(查询库存命令.ExecuteScalar());

                    // 检查出库数量是否有效
                    if (出库数量 > 当前库存)
                    {
                        throw new Exception("出库数量大于当前库存，无法完成出库操作。");
                    }

                    // 更新商品表中的库存
                    string 更新库存SQL = "UPDATE 商品表 SET 库存 = 库存 - @出库数量 WHERE 商品编号 = @商品编号";
                    SqlCommand 更新库存命令 = new SqlCommand(更新库存SQL, connection, transaction);
                    更新库存命令.Parameters.AddWithValue("@出库数量", 出库数量);
                    更新库存命令.Parameters.AddWithValue("@商品编号", 商品编号);
                    更新库存命令.ExecuteNonQuery();

                    // 向出库表插入记录
                    string 插入出库记录SQL = "INSERT INTO 出库表 (商品编号, 出库数量, 出库时间) VALUES (@商品编号, @出库数量, @出库时间)";
                    SqlCommand 插入出库记录命令 = new SqlCommand(插入出库记录SQL, connection, transaction);
                    插入出库记录命令.Parameters.AddWithValue("@商品编号", 商品编号);
                    插入出库记录命令.Parameters.AddWithValue("@出库数量", 出库数量);
                    插入出库记录命令.Parameters.AddWithValue("@出库时间", DateTime.Now);
                    插入出库记录命令.ExecuteNonQuery();

                    // 提交事务
                    transaction.Commit();

                    // 更新界面显示
                    更新库存显示();
                    更新出库记录显示();
                    MessageBox.Show("成功出库。");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("出库操作失败：" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void 更新库存显示()
        {
            int 商品编号 = Convert.ToInt32(textBox11.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string 查询库存SQL = "SELECT 库存 FROM 商品表 WHERE 商品编号 = @商品编号";
                SqlCommand 查询库存命令 = new SqlCommand(查询库存SQL, connection);
                查询库存命令.Parameters.AddWithValue("@商品编号", 商品编号);
                connection.Open();
                object 结果 = 查询库存命令.ExecuteScalar();
                connection.Close();

                if (结果 != null)
                {
                    textBox12.Text = "当前库存：" + 结果.ToString();
                }
                else
                {
                    textBox12.Text = "当前库存：0";
                }
            }
        }

        private void 更新出库记录显示()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string 查询出库记录SQL = "SELECT 商品编号, 出库数量, 出库时间 FROM 出库表";
                SqlDataAdapter adapter = new SqlDataAdapter(查询出库记录SQL, connection);
                DataTable 出库记录表 = new DataTable();
                adapter.Fill(出库记录表);
                dataGridViewCheckout.DataSource = 出库记录表;
            }
        }
    }
}
        }
    }
}