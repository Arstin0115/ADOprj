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
    public partial class 商品管理表單 : Form
    {
        string strMyDBconnectionString = "";
        List<string> listPddname = new List<string>();
        List<int> listPdprice = new List<int>();
        List<int> listPdID = new List<int>();
        List<string> listPddesc = new List<string>();
        

        public 商品管理表單()
        {
            InitializeComponent();
        }

        private void 商品管理表單_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Myproject";
            scsb.IntegratedSecurity = true;
            strMyDBconnectionString = scsb.ConnectionString;

            Readdb();
            ShowProductList();
        }

        void Readdb() //讀取資料庫
        {
            SqlConnection con = new SqlConnection(strMyDBconnectionString);
            con.Open();
            string strSQL = "select * from Menu";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\"; //圖檔的位置
            string image_Name = ""; //圖檔的名字

            int count = 0;

            while (reader.Read())
            {
                listPdID.Add((int)reader["pdid"]);
                listPddname.Add(reader["pdname"].ToString());
                listPdprice.Add((int)reader["pdprice"]);
                listPddesc.Add(reader["pddesc"].ToString());                
                image_Name = reader["pdimage"].ToString();
                Image MenuImage = Image.FromFile(image_dir + image_Name);
                imageList產品圖檔.Images.Add(MenuImage);

                count++;
            }
            Console.WriteLine($"讀取了{count}筆資料");
            reader.Close();
            con.Close();

        }

        void ShowProductList()
        {
            listViewShowPd.Clear();
            listViewShowPd.LargeImageList = null;
            listViewShowPd.SmallImageList = null;
            listViewShowPd.View = View.Details;
            listViewShowPd.Columns.Add("ID", 50);
            listViewShowPd.Columns.Add("商品名稱", 150);
            listViewShowPd.Columns.Add("商品價格", 100);
            listViewShowPd.Columns.Add("商品介紹", 400);
            listViewShowPd.FullRowSelect = true;
            listViewShowPd.GridLines = true;


            for (int i = 0; i < listPdID.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                listViewShowPd.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                item.Text = listPdID[i].ToString();
                item.SubItems.Add(listPddname[i]);
                item.SubItems.Add(listPdprice[i].ToString());
                item.SubItems.Add(listPddesc[i]);
                
                item.Tag = listPdID[i];

                listViewShowPd.Items.Add(item);

            }

        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            商品上下架 SetProduct = new 商品上下架();
            SetProduct.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            listPdID.Clear();
            listPddname.Clear();
            listPdprice.Clear();
            listPddesc.Clear();            
            imageList產品圖檔.Images.Clear();
            Readdb();
            ShowProductList();
        }

        private void listViewShowPd_ItemActivate(object sender, EventArgs e)
        {
            商品上下架 SetProduct = new 商品上下架();
            SetProduct.PDID = (int)listViewShowPd.SelectedItems[0].Tag;
            SetProduct.ShowDialog();
        }
    }
}
