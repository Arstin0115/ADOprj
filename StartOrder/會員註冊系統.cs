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
    public partial class 會員註冊系統 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyDBconnectionString;

        public 會員註冊系統()
        {
            InitializeComponent();
        }

        private void 會員註冊系統_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Myproject";
            scsb.IntegratedSecurity = true;
            strMyDBconnectionString = scsb.ConnectionString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strMyDBconnectionString);
            con.Open();

            string SQLaccount = "select * from Personsdata where 帳號 = @New_account";
            string SQLphone = "select * from Personsdata where 電話 = @New_phone";
            string SQLemail = "select * from Personsdata where 信箱 = @New_email";

            SqlCommand cmdaccount = new SqlCommand(SQLaccount,con);
            SqlCommand cmdphone = new SqlCommand(SQLphone, con);
            SqlCommand cmdemail = new SqlCommand(SQLemail, con);

            cmdaccount.Parameters.AddWithValue("@New_account", txtAct.Text);
            cmdphone.Parameters.AddWithValue("@New_phone", txtPhone.Text);
            cmdemail.Parameters.AddWithValue("@New_email", txtEmail.Text);

            SqlDataReader reader_account = cmdaccount.ExecuteReader();

            if (reader_account.Read())
            {
                reader_account.Close();
                MessageBox.Show("註冊的帳號已有人使用");
            }
            else
            {
                reader_account.Close();

                SqlDataReader reader_phone = cmdphone.ExecuteReader();
                if (reader_phone.Read())
                {
                    reader_phone.Close();
                    MessageBox.Show("註冊的手機已有人使用");
                }
                else
                {
                    reader_phone.Close();

                    SqlDataReader reader_email = cmdemail.ExecuteReader();
                    if (reader_email.Read())
                    {
                        reader_email.Close();
                        MessageBox.Show("註冊的信箱已有人使用");
                    }
                    else
                    {
                        reader_email.Close();

                        if((txtAct.Text != "") && (txtAdrss.Text != "") && (txtEmail.Text != "") && (txtName.Text != "") && (txtPhone.Text != "") && (txtPsw.Text != ""))
                        {
                            string strSQL = "insert into Personsdata values (@name,@Newact,@pasw,@phone,@email,@address)";
                            SqlCommand cmd = new SqlCommand(strSQL,con);
                            cmd.Parameters.AddWithValue("@name",txtName.Text);
                            cmd.Parameters.AddWithValue("@Newact",txtAct.Text);
                            cmd.Parameters.AddWithValue("@pasw",txtPsw.Text);
                            cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
                            cmd.Parameters.AddWithValue("@email",txtEmail.Text);
                            cmd.Parameters.AddWithValue("@address",txtAdrss.Text);
                            int rows = cmd.ExecuteNonQuery();

                            MessageBox.Show("會員註冊成功");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("每格欄位必填");
                        }
                    }
                }
            }
            con.Close();
        }
    }
}
