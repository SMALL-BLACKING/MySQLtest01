using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MySQLtest01
{
    public partial class Form1 : Form
    {
        
        private string MySqlConn = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NAMEinsert.Text = "";

            IDdelete.Text = "";
            NAMEdelete.Text = "";

            ID.Text = "";   
            NAME.Text = "";
            IDupdate.Text = "";
            NAMEupdate.Text = "";

        }

        public void AddRecord_Click()
        {

            string NAMEinsertText = NAMEinsert.Text.Trim();

            if (NAMEinsertText == "")
            {
                MessageBox.Show("名称不能为空！");
                return;
            }

            int p = 1;
            string qSQL = "SELECT id FROM test_records ORDER BY id ASC";

            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            using (MySqlCommand qCMD = new MySqlCommand(qSQL, conn))
            {
                conn.Open();
                using (MySqlDataReader reader = qCMD.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int DateId = reader.GetInt32("id");
                        if (DateId == p)
                        {
                            p++; 
                        }
                        else if (DateId > p)
                        {
                            break;
                        }
                    }
                }
            }
            


            string sql = "INSERT INTO test_records (id, test_name, result, test_time) VALUES (@id, @name, @result, NOW())";

            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", p);
                    cmd.Parameters.AddWithValue("@name", NAMEinsertText);
                    cmd.Parameters.AddWithValue("@result", "PASS");

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("数据插入成功！");
                            situationtext.Text = "PASS";
                            NAMEinsert.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("数据库插入失败：" + ex.Message);
                    }
                }
            }
        }

        public void DeleteRecord()
        {
            string IDdeleteText = IDdelete.Text.Trim();

            string NAMEdeleteText = NAMEdelete.Text.Trim();

            string sql = null;

            if(IDdeleteText != "")
            {
                sql = "DELETE FROM test_records WHERE id = @id";
            }
            else if(NAMEdeleteText != "")
            {
                sql = "DELETE FROM test_records WHERE test_name = @name";
            }
            else
            {
                MessageBox.Show("请输入要删除的记录的ID或测试名！");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (IDdeleteText != "")
                    {
                        cmd.Parameters.AddWithValue("@id", IDdeleteText);
                    }
                    else if (NAMEdeleteText != "")
                    {
                        cmd.Parameters.AddWithValue("@name", NAMEdeleteText);
                    }
                    
                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        situationtext.Text = "PASS";
                        if (rows > 0)
                            MessageBox.Show($"删除成功！");
                        else
                            MessageBox.Show("未找到该记录。");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败：" + ex.Message);
                    }
                }
            }
        }

        public void UpdateNAMERecord()
        {
            string IDText = ID.Text.Trim();

            string NAMEupdateText = NAMEupdate.Text.Trim();

            if (NAMEupdateText == "" || IDText == "")
            {
                MessageBox.Show("名称和ID都不能为空！");
                return;
            }

            string sql = "UPDATE test_records SET test_name = @test_name WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@test_name", NAMEupdateText);
                    cmd.Parameters.AddWithValue("@id", IDText);

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        situationtext.Text = "PASS";
                        MessageBox.Show($"成功更新了 {rows} 条记录！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("更新失败：" + ex.Message);
                    }
                }
            }
        }

        public void UpdateIDRecord()
        {
            string IDupdateText = IDupdate.Text.Trim();

            string NAMEText = NAME.Text.Trim();

            if (NAMEText == "" || IDupdateText == "")
            {
                MessageBox.Show("名称和ID都不能为空！");
                return;
            }

            string sql = "UPDATE test_records SET id = @id WHERE test_name = @test_name";

            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@test_name", NAMEText);
                    cmd.Parameters.AddWithValue("@id", IDupdateText);

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        situationtext.Text = "PASS";
                        MessageBox.Show($"成功更新了 {rows} 条记录！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("更新失败：" + ex.Message);
                    }
                }
            }
        }

        

        public DataTable GetAllRecords()
        {
            string sql = "SELECT * FROM test_records ORDER BY id DESC"; // 按 ID 倒序，最新的在最上面
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            situationtext.Text = "PASS";
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("查询失败：" + ex.Message);
                    }
                }
            }
            return dt;
        }

        private void insertbt_Click(object sender, EventArgs e)
        {
            AddRecord_Click();
        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void namechangebt_Click(object sender, EventArgs e)
        {
            UpdateNAMERecord();
        }

        private void IDchangebt_Click(object sender, EventArgs e)
        {
            UpdateIDRecord();
        }

        private void selectbt_Click(object sender, EventArgs e)
        {
            DataTable dt = GetAllRecords();

            dataGridView1.DataSource = dt;
        }
        
        private DataTable IDcheck()
        {
            string IDText = checkIDtext.Text.Trim();
            if (IDText == "")
            {
                MessageBox.Show("请输入要查询的ID！");
                return new DataTable();
            }
            string sql = "SELECT * FROM test_records WHERE id = @id";
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", IDText);
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            situationtext.Text = "PASS";
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("查询失败：" + ex.Message);
                    }
                }
            }
            return dt;
        }

        private DataTable NAMEcheck()
        {
            string NAMEText = checkNAMEtext.Text.Trim();
            if (NAMEText == "")
            {
                MessageBox.Show("请输入要查询的名称！");
                return new DataTable();
            }
            string sql = "SELECT * FROM test_records WHERE test_name LIKE @test_name";
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(MySqlConn))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@test_name", "%" + NAMEText + "%");
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            situationtext.Text = "PASS";
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("查询失败：" + ex.Message);
                    }
                }
            }
            return dt;
        }

        private void checkID_Click(object sender, EventArgs e)
        {
            DataTable dt = IDcheck();

            dataGridView2.DataSource = dt;

        }

        private void checkNAME_Click(object sender, EventArgs e)
        {
            DataTable dt = NAMEcheck();

            dataGridView2.DataSource = dt;
        }
    }
}
