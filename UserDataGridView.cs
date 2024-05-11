using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoStoreManagementSystem
{
    public class UserDataGridView: DataGridView
    {
        public UserDataGridView()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name = "DataGridView1";
            this.ReadOnly = true;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        private void InitializeDataGridView()
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            Controls.Add(dataGridView);

            // DataGridView oszlopainak beállítása
            dataGridView.AutoGenerateColumns = false;

            // ID oszlop
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "id";
            idColumn.HeaderText = "ID";
            idColumn.Name = "id";
            dataGridView.Columns.Add(idColumn);

           
            // Name oszlop
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "username";
            nameColumn.HeaderText = "Felhasználónév";
            nameColumn.Name = "username";
            dataGridView.Columns.Add(nameColumn);

            // LegoType oszlop
            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
           passwordColumn.DataPropertyName = "password";
            passwordColumn.HeaderText = "Jelszó";
            passwordColumn.Name = "password";
            dataGridView.Columns.Add(passwordColumn);

            // LegoStock oszlop
            DataGridViewTextBoxColumn profImageColumn = new DataGridViewTextBoxColumn();
            profImageColumn.DataPropertyName = "prof_image";
            profImageColumn.HeaderText = "Profilkép";
            profImageColumn.Name = "pro_image";
            dataGridView.Columns.Add(profImageColumn);

            // LegoPrice oszlop
            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.DataPropertyName = "role";
            roleColumn.HeaderText = "Munkakör";
            roleColumn.Name = "role";
            dataGridView.Columns.Add(roleColumn);

            // LegoStatus oszlop
            DataGridViewTextBoxColumn userStatusColumn = new DataGridViewTextBoxColumn();
            userStatusColumn.DataPropertyName = "status";
            userStatusColumn.HeaderText = "Státusz";
            userStatusColumn.Name = "status";
            dataGridView.Columns.Add(userStatusColumn);

            // LegoImage oszlop
            DataGridViewTextBoxColumn regDateColumn = new DataGridViewTextBoxColumn();
            regDateColumn.DataPropertyName = "reg_date";
            regDateColumn.HeaderText = "Regisztárlás időpontja";
            regDateColumn.Name = "reg_date";
            dataGridView.Columns.Add(regDateColumn);

            
           
            UserData userData = new UserData();
            dataGridView.DataSource = userData.usersDatas();

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
        }
    }
}
