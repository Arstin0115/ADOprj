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
    public partial class 餐點介紹 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyDBconnectionString = "";

        public int PDID = 0;
        string imagedir = @"images\";
        string imagename = "";
        public 餐點介紹()
        {
            InitializeComponent();
        }

        private void FormDesciption_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Myproject";
            scsb.IntegratedSecurity = true;
            strMyDBconnectionString = scsb.ConnectionString;

            showProducts();
        }

        void showProducts()
        {
            SqlConnection con = new SqlConnection(strMyDBconnectionString);
            con.Open();
            string strSQL = "select * from Menu where pdid = @NewID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewID", PDID);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lblName.Text = reader["pdname"].ToString();
                lblintroduce.Text = reader["pddesc"].ToString();
                imagename = reader["pdimage"].ToString();
                pictureBox1.Image = Image.FromFile(imagedir + imagename);
            }
            reader.Close();
            con.Close();

        }
    }
}
