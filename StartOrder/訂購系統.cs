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

using System.Data.SqlTypes;

namespace StartOrder
{
    public partial class 訂購系統 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyDBconnectionString = "";

        List<string> list餐盒品項名稱 = new List<string>();
        List<int> list餐盒價格 = new List<int>();
        List<int>list加肉單價 = new List<int>();

        List<string> list加肉 = new List<string>();
        List<string> list附餐飲料 = new List<string>();
        List<string> list所選加購 = new List<string>();
        List<string> list所選其他 = new List<string>();

        List<string> listPdname = new List<string>();
        List<int> listPdrice = new List<int>();
        List<int> listPdID = new List<int>();

        int 所選餐盒份數 = 0;
        int 所選餐盒單價 = 0;
        int 所選餐盒總價 = 0;
        int 所選加肉單價 = 0;
        string 所選餐盒品項 = "";
        string 所選餐盒的加肉 = "";
        string 所選附餐的飲料 = "";
        bool 購物袋 = false;
        bool 自備餐盒 = false;
        bool 綜合蔬菜盤 = false;
        bool 蔬菜湯 = false;
        bool 昆布湯 = false;
        bool 味噌湯 = false;
        string 訂購人姓名 = "";
        string 訂購人電話 = "";

        public 訂購系統()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Myproject";
            scsb.IntegratedSecurity = true;
            strMyDBconnectionString = scsb.ConnectionString;

            list加肉.Add("無");
            list加肉.Add("牛肉(60元)");
            list加肉.Add("豬肉(45元)");
            list加肉.Add("雞肉(40元)");
            list加肉.Add("魚肉(55元)");

            list加肉單價.Add(0);
            list加肉單價.Add(0);
            list加肉單價.Add(60);
            list加肉單價.Add(45);
            list加肉單價.Add(40);
            list加肉單價.Add(55);


            list附餐飲料.Add("無糖綠茶");
            list附餐飲料.Add("冷翠青茶");
            list附餐飲料.Add("炭焙烏龍");
            list附餐飲料.Add("蜜香紅茶");


            foreach (string i in list加肉)
            {
                cbxMent.Items.Add(i);
            }

            foreach (string i in list附餐飲料)
            {
                cbxDrink.Items.Add(i);
            }

            lblPrice.Text = "0元";
            txtHowMany.Text = "1";
            所選餐盒份數 = 1;
            cbxMent.SelectedIndex = 0;
            //所選餐盒的加肉 = cbxMent.SelectedIndex.ToString();
            cbxDrink.SelectedIndex = 0;
            //所選附餐的飲料 = cbxDrink.SelectedIndex.ToString();
            購物袋 = false;
            自備餐盒 = false;
            綜合蔬菜盤 = false;
            蔬菜湯 = false;
            昆布湯 = false;
            味噌湯 = false;

            菜單列表();
            品項總價();
            readdb();
            展示listView菜單圖片模式();

            lblPersonsName.Text = $"{GlobalVar.Name}";
            lblPersonsPhone.Text = $"{GlobalVar.Phone}";
            

        }
        //方法區=================================================================================
        void readdb()
        {
            SqlConnection con = new SqlConnection(strMyDBconnectionString);
            con.Open();
            string strSQL = "select * from Menu;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            int i = 0;

            while (reader.Read())
            {
                listPdID.Add((int)reader["pdid"]);
                listPdname.Add(reader["pdname"].ToString());
                listPdrice.Add((int)reader["pdprice"]);
                image_name = reader["pdimage"].ToString();
                Image myProductImage = Image.FromFile(image_dir + image_name);
                imageList產品圖檔.Images.Add(myProductImage);
                i++;
            }
            Console.WriteLine($"讀取了{i}筆資料");
            reader.Close();
            con.Close();
        }
        //=======================================================================================
        void 展示listView菜單圖片模式()
        {
            listViewShowPd.Clear();
            listViewShowPd.View = View.LargeIcon;
            imageList產品圖檔.ImageSize = new Size(120, 120);
            listViewShowPd.LargeImageList = imageList產品圖檔;
            listViewShowPd.SmallImageList = imageList產品圖檔;


            for (int i = 0; i < imageList產品圖檔.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listPdname[i] + " " + listPdrice[i] +"元";                
                item.Tag = listPdID[i];
                listViewShowPd.Items.Add(item);
            }
        }
        //=======================================================================================
        void 品項總價()
        {
            所選加肉單價 = list加肉單價[cbxMent.SelectedIndex + 1]; //這裡有問題

            if (所選餐盒份數 > 0)
            {
                所選餐盒總價 = 所選餐盒單價 * 所選餐盒份數;

                if (list加肉.Count > 0)
                {
                    所選餐盒總價 = 所選餐盒總價 + (所選加肉單價 * 所選餐盒份數);
                }

                if (購物袋)
                {
                    所選餐盒總價 += 2;
                }

                if (自備餐盒)
                {
                    所選餐盒總價 -= 5 * 所選餐盒份數;
                }

                if (綜合蔬菜盤)
                {
                    所選餐盒總價 += 90 * 所選餐盒份數;
                }

                if (蔬菜湯)
                {
                    所選餐盒總價 += 40 * 所選餐盒份數;
                }

                if (昆布湯)
                {
                    所選餐盒總價 += 50 * 所選餐盒份數;
                }

                if (味噌湯)
                {
                    所選餐盒總價 += 45 * 所選餐盒份數;
                }



                lblAllPrice.Text = 所選餐盒總價.ToString();
            }
        }
        //=======================================================================================
        void 菜單列表()
        {
            SqlConnection con = new SqlConnection(strMyDBconnectionString);
            con.Open();
            string strSQL = "select pdid as '餐點編號', pdname as '餐點名稱' , pdprice as '餐點價格' from Menu;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dtable = new DataTable();
                dtable.Load(reader);
                dgvData.DataSource = dtable;
                
            }
            reader.Close();
            con.Close();
        }

        private void txtHowMany_TextChanged(object sender, EventArgs e)
        {
            if (txtHowMany.Text.Length > 0)
            {
                bool intmath = Int32.TryParse(txtHowMany.Text, out 所選餐盒份數);
                if (intmath)
                {
                    品項總價();
                }
                else
                {
                    MessageBox.Show("份數輸入錯誤");
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string SelectID = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectID = 0;
                bool MenuID = Int32.TryParse(SelectID, out intSelectID);

                if (MenuID == true)
                {
                    SqlConnection con = new SqlConnection(strMyDBconnectionString);
                    con.Open();
                    string strSQL = "select * from Menu where pdid = @NewID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewID", intSelectID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblOrdersName.Text = reader["pdname"].ToString();
                        lblPrice.Text = reader["pdprice"].ToString();
                        所選餐盒單價 = Convert.ToInt32(lblPrice.Text);
                        
                    }
                    reader.Close();
                    con.Close();
                }
                品項總價();
            }
        }

        private void cbxMent_SelectedIndexChanged(object sender, EventArgs e)
        {
            品項總價();
        }

        private void listViewShowPd_ItemActivate(object sender, EventArgs e)
        {
            餐點介紹 showProducts = new 餐點介紹();
            showProducts.PDID = (int)listViewShowPd.SelectedItems[0].Tag;
            showProducts.ShowDialog();
        }

        private void ckBag_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBag.Checked == true)
            {
                list所選其他.Add("要購物袋");
            }
            else
            {
                list所選其他.Remove("要購物袋");
            }

            購物袋 = ckBag.Checked;
            品項總價();
        }

        private void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox.Checked == true)
            {
                list所選其他.Add("有自備餐盒");
            }
            else
            {
                list所選其他.Remove("有自備餐盒");
            }

            自備餐盒 = ckBox.Checked;
            品項總價();
        }

        private void ckVag_CheckedChanged(object sender, EventArgs e)
        {
            if (ckVag.Checked == true)
            {
                list所選加購.Add("綜合蔬菜盤");
            }
            else
            {
                list所選加購.Remove("綜合蔬菜盤");
            }

            綜合蔬菜盤 = ckVag.Checked;
            品項總價();
        }

        private void ckVagSoup_CheckedChanged(object sender, EventArgs e)
        {
            if (ckVagSoup.Checked == true)
            {
                list所選加購.Add("蔬菜湯");
            }
            else
            {
                list所選加購.Remove("蔬菜湯");
            }

            蔬菜湯 = ckVagSoup.Checked;
            品項總價();
        }

        private void ckQbSoup_CheckedChanged(object sender, EventArgs e)
        {
            if (ckQbSoup.Checked == true)
            {
                list所選加購.Add("昆布湯");
            }
            else
            {
                list所選加購.Remove("昆布湯");
            }

            昆布湯 = ckQbSoup.Checked;
            品項總價();
        }

        private void ckMisoSoup_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMisoSoup.Checked == true)
            {
                list所選加購.Add("味噌湯");
            }
            else
            {
                list所選加購.Remove("味噌湯");
            }

            味噌湯 = ckMisoSoup.Checked;
            品項總價();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if((lblPersonsName.Text != "") && (lblPersonsPhone.Text != "") && (lblOrdersName.Text != "") && (cbxMent.SelectedIndex >= 0) && (cbxDrink.SelectedIndex >= 0) && (txtHowMany.Text != "0"))
            {
                訂購人姓名 = lblPersonsName.Text;
                訂購人電話 = lblPersonsPhone.Text;


                SqlConnection con = new SqlConnection(strMyDBconnectionString);
                con.Open();
                string strSQL = "insert into Orders values (@NewPersonName , @NewPhone , @NewOrderProduct , @NewMeat , @NewDrink , @NewAddpurchase , @NewBag , @NewBox , @NewShare , @NewTotal , @NewOrdersState , @NewTime)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPersonName",lblPersonsName.Text);
                cmd.Parameters.AddWithValue("@NewPhone",lblPersonsPhone.Text);
                cmd.Parameters.AddWithValue("@NewOrderProduct",lblOrdersName.Text);
                cmd.Parameters.AddWithValue("@NewMeat",cbxMent.Text);
                cmd.Parameters.AddWithValue("@NewDrink",cbxDrink.Text);
                string 加購集合 = "";
                foreach(string item in list所選加購)
                {
                    加購集合 += item + ", ";
                }
                cmd.Parameters.AddWithValue("@NewAddpurchase",加購集合);
                cmd.Parameters.AddWithValue("@NewBag",購物袋);
                cmd.Parameters.AddWithValue("@NewBox",自備餐盒);
                cmd.Parameters.AddWithValue("@NewShare",txtHowMany.Text);
                int Total = 0;
                Int32.TryParse(lblAllPrice.Text, out Total);
                cmd.Parameters.AddWithValue("@NewTotal", Total);
                cmd.Parameters.AddWithValue("@NewOrdersState", lblState.Text);
                cmd.Parameters.AddWithValue("@NewTime", new SqlDateTime(DateTime.Now));
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("訂購成功");

            }
            else
            {
                MessageBox.Show("至少須購買一份");
            }
        }

        
    }

}
