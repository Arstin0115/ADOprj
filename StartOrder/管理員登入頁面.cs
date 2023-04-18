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
    public partial class 管理員登入頁面 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyDBconnectionString;

        public 管理員登入頁面()
        {
            InitializeComponent();
        }

        private void 店長登入頁面_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Myproject";
            scsb.IntegratedSecurity = true;
            strMyDBconnectionString = scsb.ConnectionString;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strMyDBconnectionString);
            con.Open();
            string strSQL = "select * from Manage where 帳號 = @NewAct and 密碼 = @NewPas";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewAct", txtAct.Text);
            cmd.Parameters.AddWithValue("@NewPas", txtPsw.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("登入成功");

                this.Hide();

                管理選單 Manage_Menu = new 管理選單();
                Manage_Menu.ShowDialog();

            }
            else
            {
                MessageBox.Show("帳號or密碼輸入錯誤");
            }
        }
    }
}
