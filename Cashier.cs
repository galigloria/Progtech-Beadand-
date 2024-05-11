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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void Admin_Costumer_button_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_Close_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Biztosan ki szeretne lépni?","információ",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
           
            if(check==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Cashier_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Biztosan ki szeretne lépni?", "Információ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (check == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void cashierCostumer1_Load(object sender, EventArgs e)
        {

        }

        private void Cashier_Products_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_Dashboard_Click(object sender, EventArgs e)
        {
            adminDash1.Visible = true;
            
            adminAddProducts2.Visible = false;
          
            
        }
    }
}
