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
    public partial class 會員登入系統 : Form
    {

        SqlConnectionStringBuilder scsb;
        string strMyDBconnectionString;

        public 會員登入系統()
        {
            InitializeComponent();
        }

        private void 會員登入系統_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Myproject";
            scsb.IntegratedSecurity = true;
            strMyDBconnectionString = scsb.ConnectionString;
        }

        private void lbReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            會員註冊系統 regForm = new 會員註冊系統();
            regForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strMyDBconnectionString);
            con.Open();
            string strSQL = "select * from Personsdata where 帳號 = @Newact and 密碼 = @Newpsw;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Newact", txtAct.Text);
            cmd.Parameters.AddWithValue("@Newpsw", txtPsw.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                //string act = reader["帳號"].ToString();
                
                //this.Hide();
                GlobalVar.Name = reader["姓名"].ToString();
                GlobalVar.Phone = reader["電話"].ToString();
                MessageBox.Show($"登入成功,歡迎光臨 : {GlobalVar.Name}");
                txtAct.Clear();
                txtPsw.Clear();
                訂購系統 Buy_Form = new 訂購系統();
                Buy_Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("帳號or密碼輸入錯誤");
            }
        }

        private void lblSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            管理員登入頁面 ManagerLogin = new 管理員登入頁面();
            ManagerLogin.ShowDialog();
        }
    }
}
