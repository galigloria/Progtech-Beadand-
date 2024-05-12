using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LegoStoreManagementSystem
{
    public partial class CashierCostumer : UserControl
    {
        public CashierCostumer()
        {
            InitializeComponent();
            DisplayCustomerData();
        }
        public void RefershData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefershData);
                return;
            }
            DisplayCustomerData();

        }
        public void DisplayCustomerData()
        {
            CustomerData customerData = new CustomerData();
            List<CustomerData> listData = customerData.allCustomersData();
            Cash_Cust_DataTable.DataSource = listData;

        }
       
    }
}
