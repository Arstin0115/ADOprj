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
    public partial class 訂單管理 : Form
    {

        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";

        List<int> IDs = new List<int>();
        List<string> listMade = new List<string>();

        public 訂單管理()
        {
            InitializeComponent();
        }

        private void 訂單管理_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Myproject";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ConnectionString;            

            Ordersdatashow();
        }

        void Ordersdatashow()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select * from Orders;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable OrderTb = new DataTable();
                OrderTb.Load(reader);
                dgvOrderData.DataSource = OrderTb;
            }
            reader.Close();
            con.Close();
        }

        void ClearAll()
        {
            lblID.Text = "";
            lblName.Text = "";
            lblPrice.Text = "";
            lblState.Text = "";
        }

        void Readdb()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select * from Orders";
            SqlCommand cmd = new SqlCommand(strSQL, con);
        }

        private void dgvOrderData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectRowsID = Convert.ToInt32(dgvOrderData.Rows[e.RowIndex].Cells[0].Value);

                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from Orders where 訂單編號 = @NewID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewID", selectRowsID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = reader["訂單編號"].ToString();
                    lblName.Text = reader["訂購人"].ToString();
                    lblPrice.Text = reader["總價"].ToString();
                    lblState.Text = reader["訂單狀態"].ToString();
                }
            
                reader.Close();
                con.Close();
            }
        }

        private void ckCancel_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ckCancel.Checked)
            {
                lblPrice.Text = "0";
                lblState.Text = "訂單已取消";
                ckOK.Checked = false;
            }
            else
            {
                ClearAll();
            }
           
        }

        private void ckOK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckOK.Checked)
            {
                lblState.Text = "訂單已完成";
                ckCancel.Checked = false;
            }
            else
            {
                lblState.Text = "製做中";
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            int OrderID = 0;
            Int32.TryParse(lblID.Text, out OrderID);

            if(lblID.Text != "" && lblName.Text != "" && lblPrice.Text != "" && lblState.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update Orders set 總價 = @NewTotal ,訂單狀態 = @NewState where 訂單編號 = @NewID";  
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewID", OrderID);
                cmd.Parameters.AddWithValue("@NewTotal", lblPrice.Text);
                cmd.Parameters.AddWithValue("@NewState", lblState.Text);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("資料修改成功");
                Ordersdatashow();
                con.Close();
                ckCancel.Checked = false;
                ckOK.Checked = false;
            }
            else
            {
                MessageBox.Show("有欄位是空的");
                ckCancel.Checked = false;
                ckOK.Checked = false;
            }
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            int OrderID = 0;
            Int32.TryParse(lblID.Text, out OrderID);

            if (OrderID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from Orders where 訂單編號 = @NewID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewID", OrderID);
                int rows = cmd.ExecuteNonQuery();

                
                MessageBox.Show("資料刪除成功");
                Ordersdatashow();


                ClearAll();
                con.Close();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Readdb();
            Ordersdatashow();
        }

        private void btnDelAllclu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select sum(總價) as 今日營業額 from Orders";
            string strMade = "select * from Orders where 訂單狀態 like '%訂單已完成%'";
            string strCancel = "select * from Orders where 訂單狀態 like '%訂單已取消%'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlCommand cmdMade  = new SqlCommand(strMade, con);
            SqlCommand cmdCancel = new SqlCommand(strCancel, con);
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                lblTurnover.Text = reader["今日營業額"].ToString();
                string Dayprice = lblTurnover.Text;
                reader.Close();

                SqlDataReader readerMade = cmdMade.ExecuteReader();
                int Mcount = 0;
                while (readerMade.Read())
                {
                    Mcount++;
                }
                readerMade.Close();

                SqlDataReader readerCancel = cmdCancel.ExecuteReader();
                int Ccount = 0;
                while(readerCancel.Read())
                {
                    Ccount++;
                }
                readerCancel.Close();

                MessageBox.Show($"今日{DateTime.Now}總營業額為{Dayprice}元\n{Mcount}筆完成的訂單\n{Ccount}筆取消的訂單");
            }
            con.Close();
        }
    }
}
