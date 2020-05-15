using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProPApplication
{
    public partial class ShopPanel : UserControl
    {
        public ShopPanel()
        {
            InitializeComponent();
            mainForm = Form.ActiveForm;
            this.comboBoxShop = cbShopNo;
            this.comboBoxEmployee = cbEmployee;
            shopList = new List<Shop>();
            employeeList = new List<Staff>();
        }

        public List<Shop> shopList;
        Form mainForm;
        public Staff myStaff;
        public ComboBox comboBoxShop;
        public ComboBox comboBoxEmployee;
        public List<Staff> employeeList;

        private void btnAllShops_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();
            foreach (Shop search in shopList)
            {
                lbShow.Items.Add(search);
            }
        }

        private void btnMostProfitShop_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();
            decimal highestAmount = 0;
            List<Shop> tempList = new List<Shop>();
            highestAmount = shopList[0].Profit;
            foreach(Shop search in shopList)
            {
                if(search.Profit > highestAmount)
                {
                    highestAmount = search.Profit;
                }
            }
            foreach(Shop search in shopList)
            {
                if(search.Profit == highestAmount)
                {
                    lbShow.Items.Add(search);
                }
            }
        }

        private void btnShowAllEmployee_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();
            int shopNo = Convert.ToInt32(cbShopNo.SelectedItem);
            foreach(Staff search in this.employeeList)
            {
                if(search.ShopNo == shopNo)
                {
                    lbShow.Items.Add(search);
                }
            }
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();
            int employeeNo = Convert.ToInt32(cbEmployee.SelectedItem);
            foreach(Staff search in this.employeeList)
            {
                if(search.EmployeeNo == employeeNo)
                {
                    lbShow.Items.Add(search);
                }
            }
        }
    }
}
