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

namespace StartOrder
{
    public partial class 會員資料管理 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        List<int> IDs = new List<int>();

        public 會員資料管理()
        {
            InitializeComponent();
        }

        private void 會員資料管理_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Myproject";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ConnectionString;

            cbxClum.Items.Add("姓名");
            cbxClum.Items.Add("電話");
            cbxClum.Items.Add("地址");
            cbxClum.Items.Add("信箱");
            cbxClum.SelectedIndex = 0;

            Memberdatashow();
        }

        void DelAll()
        {
            lblID.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txtEmail.Clear();
            txtAct.Clear();
            txtPasw.Clear();
            listboxSerach.Items.Clear();
        }

        void Memberdatashow()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select * from Personsdata;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dat = new DataTable();
                dat.Load(reader);
                dgvPersonsData.DataSource = dat;
            }
            reader.Close();
            con.Close();
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int IDD = 0;
            Int32.TryParse(lblID.Text, out IDD);

            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "update Personsdata set 姓名 = @NewName ,電話 = @NewPhone ,地址 = @NewAddress, 信箱 = @NewEmail, 帳號 = @NewAccountt, 密碼 = @NewPassword where 會員編號 = @NewID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewID", IDD);
            cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
            cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
            cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
            cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@NewAccountt", txtAct.Text);
            cmd.Parameters.AddWithValue("@NewPassword", txtPasw.Text);
            int rows = cmd.ExecuteNonQuery();
            MessageBox.Show("資料修改成功");
            Memberdatashow();
            con.Close();
        }

        //private void btn新增資料_Click(object sender, EventArgs e)
        //{
        //    if ((txt姓名.Text != "") && (txtAct.Text != "") && (txtPasw.Text != "") && (txt電話.Text != "") && (txtEmail.Text != "") && (txt地址.Text != ""))
        //    {
        //        SqlConnection con = new SqlConnection(strDBConnectString);
        //        con.Open();
        //        string strSQL = "insert into Personsdata values (@NewName, @NewAccount, @NewPassword, @NewPhone, @NewEmail, @NewAddress)";
        //        SqlCommand cmd = new SqlCommand(strSQL, con);
        //        cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
        //        cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
        //        cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
        //        cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
        //        cmd.Parameters.AddWithValue("@NewAccount", txtAct.Text);
        //        cmd.Parameters.AddWithValue("@NewPassword", txtPasw.Text);

        //        int rows = cmd.ExecuteNonQuery();

        //        con.Close();
        //        MessageBox.Show("資料新增成功");
        //        Memberdatashow();
        //        DelAll();
        //    }
        //}

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int IDD = 0;
            Int32.TryParse(lblID.Text, out IDD);

            if (IDD > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from Personsdata where 會員編號 = @NewID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewID", IDD);

                int rows = cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("資料刪除成功");
                DelAll();
                txt欄位關鍵字.Clear();
                listboxSerach.Items.Clear();

            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            DelAll();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            listboxSerach.Items.Clear();
            IDs.Clear();
            string cbxName = cbxClum.SelectedItem.ToString();

            if (txt欄位關鍵字.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from Personsdata where " + cbxName + " like @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt欄位關鍵字.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    IDs.Add((int)reader["會員編號"]);
                    listboxSerach.Items.Add($"{reader["姓名"].ToString()} {reader["電話"].ToString()}");

                    count++;
                }
                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }

                reader.Close();
                con.Close();
            }


        }

        private void listboxSerach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxSerach.Items.Count >= 0)
            {
                int selectIndexsID = IDs[listboxSerach.SelectedIndex];
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from Personsdata where 會員編號 = @NewID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewID", selectIndexsID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = reader["會員編號"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtEmail.Text = reader["信箱"].ToString();
                    txtAct.Text = reader["帳號"].ToString();
                    txtPasw.Text = reader["密碼"].ToString();
                }
                else
                {
                    DelAll();
                    MessageBox.Show("查無此人");

                }

                reader.Close();
                con.Close();
            }
        }

        private void dgvPersonsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectRowsID = Convert.ToInt32(dgvPersonsData.Rows[e.RowIndex].Cells[0].Value);

                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from Personsdata where 會員編號 = @NewID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewID", selectRowsID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = reader["會員編號"].ToString();
                    txt姓名.Text = reader["姓名"].ToString();
                    txt電話.Text = reader["電話"].ToString();
                    txt地址.Text = reader["地址"].ToString();
                    txtEmail.Text = reader["信箱"].ToString();
                    txtAct.Text = reader["帳號"].ToString();
                    txtPasw.Text = reader["密碼"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此人");
                    DelAll();
                }
                reader.Close();
                con.Close();
            }
        }

       
    }
}
