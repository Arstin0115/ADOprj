using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartOrder
{
    public partial class 管理選單 : Form
    {
        public 管理選單()
        {
            InitializeComponent();
        }

        private void 管理選單_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonsData_Click(object sender, EventArgs e)
        {
            會員資料管理 Personsdatamanager = new 會員資料管理();
            Personsdatamanager.ShowDialog();
        }

        private void btnProductData_Click(object sender, EventArgs e)
        {
            商品管理表單 Productsdatamanager = new 商品管理表單();
            Productsdatamanager.ShowDialog();
        }

        private void btnOrderData_Click(object sender, EventArgs e)
        {
            訂單管理 Ordersdatamanager = new 訂單管理();
            Ordersdatamanager.ShowDialog();
        }
    }
}
