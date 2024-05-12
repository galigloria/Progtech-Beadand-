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
    public partial class admin_Add_user : Form
    {
        public admin_Add_user()
        {
            InitializeComponent();
        }

        private void Admin_close_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Biztosan ki akar lépni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult logOut = MessageBox.Show("Biztosan ki akar jelentkezni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logOut == DialogResult.Yes)
            {
                Application.Exit();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           adminDash1.Visible = true;
            employeeAddUser1.Visible = false;
            adminAddProducts2.Visible = false;
            order1.Visible = false;
            AdminDash adminDash = adminDash1 as AdminDash;
            if(adminDash != null)
            {
                adminDash.RefershData();
            }

        }

        private void Admin_Employee_button_Click(object sender, EventArgs e)
        {
            adminDash1.Visible = false;
            employeeAddUser1.Visible = true;
            adminAddProducts2.Visible =false;
            order1.Visible = false;
           EmployeeAddUser employeeAddUser = employeeAddUser1 as EmployeeAddUser;
            
        }

        private void Admin_Products_button_Click(object sender, EventArgs e)
        {
            adminDash1.Visible =false;
            employeeAddUser1.Visible = false;
            adminAddProducts2.Visible =true;
            order1.Visible = false;
            AdminAddProducts adminAddProducts = adminAddProducts2 as AdminAddProducts;
            if (adminAddProducts != null)
            {
                adminAddProducts.RefershData();
            }
        }

        
        private void order_Click(object sender, EventArgs e)
        {

            adminDash1.Visible = false;
            employeeAddUser1.Visible = false;
            adminAddProducts2.Visible = false;
            order1.Visible = true;
            Order order = order1 as Order;
            if (order != null)
            {
                order.RefershData();
            }
        }

        private void order1_Load(object sender, EventArgs e)
        {

        }
    }
}
