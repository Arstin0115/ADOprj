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
    public partial class 商品上下架 : Form
    {
        public int PDID = 0;
        string strMyDBconnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖檔 = false;


        public 商品上下架()
        {
            InitializeComponent();
        }

        private void 商品上下架_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Myproject";
            scsb.IntegratedSecurity = true;
            strMyDBconnectionString = scsb.ConnectionString;

            if (PDID > 0)
            {                               //修改
                groupBox新增.Visible = false;
                groupBox修改.Visible = true;
                ShowProductData();
            }
            else
            {                               //上下架
                groupBox新增.Visible = true;
                groupBox修改.Visible = false;
            }
        }

        void ShowProductData()
        {
            SqlConnection con = new SqlConnection(strMyDBconnectionString);
            con.Open();
            string strSQL = "select * from Menu where pdid = @SerachID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SerachID", PDID);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                lblID.Text = reader["pdid"].ToString();
                txtName.Text = reader["pdname"].ToString();
                txtPrice.Text = reader["pdprice"].ToString();
                txtProductsData.Text = reader["pddesc"].ToString();
                image_name = reader["pdimage"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);

                count++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"查詢{count}筆資料");
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog P = new OpenFileDialog();
            P.Filter = "檔案類型 (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            DialogResult R = P.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(P.FileName);
                string fileExtension = System.IO.Path.GetExtension(P.SafeFileName);
                Random Rand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + Rand.Next(1000, 10000).ToString() + fileExtension;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPrice.Text != "") && (txtProductsData.Text != "") && (pictureBox1.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(strMyDBconnectionString);
                con.Open();
                string strSQL = "update Menu set pdname = @NewName ,pdprice = @NewPrice ,pddesc = @NewDesc ,pdimage = @NewImage where pdid = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", PDID);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                int Price = 0;
                Int32.TryParse(txtPrice.Text, out Price);
                cmd.Parameters.AddWithValue("@NewPrice", txtPrice.Text);
                cmd.Parameters.AddWithValue("@NewDesc", txtProductsData.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_name);
                int rows = cmd.ExecuteNonQuery(); //新增修改一定要有這行!!

                con.Close();
                MessageBox.Show($"{rows}筆資料修改成功");
            }
            else
            {
                MessageBox.Show("所有欄位都必須填");
            }
        }


        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPrice.Text != "") && (txtProductsData.Text != "") && (pictureBox1.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(strMyDBconnectionString);
                con.Open();
                string strSQL = "Insert into Menu values(@NewName, @NewPrice, @NewDesc, @NewImage)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                int Price = 0;
                Int32.TryParse(txtPrice.Text, out Price);
                cmd.Parameters.AddWithValue("@NewPrice", txtPrice.Text);
                cmd.Parameters.AddWithValue("@NewDesc", txtProductsData.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_name);
                int rows = cmd.ExecuteNonQuery(); //新增修改一定要有這行!!

                con.Close();
                MessageBox.Show($"{rows}筆資料新增成功");

            }
            else
            {
                MessageBox.Show("所有欄位都必須填");
            }

        }
    }
}
