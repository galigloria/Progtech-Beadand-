using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoStoreManagementSystem
{
    public class ProductsDataGridView : DataGridView
    {
        public ProductsDataGridView()
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

            // LegoID oszlop
            DataGridViewTextBoxColumn legoIDColumn = new DataGridViewTextBoxColumn();
            legoIDColumn.DataPropertyName = "lego_id";
            legoIDColumn.HeaderText = "Lego Azonosítója";
            legoIDColumn.Name = "lego_id";
            dataGridView.Columns.Add(legoIDColumn);

            // Name oszlop
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "lego_name";
            nameColumn.HeaderText = "Lego neve";
            nameColumn.Name = "lego_name";
            dataGridView.Columns.Add(nameColumn);

            // LegoType oszlop
            DataGridViewTextBoxColumn legoTypeColumn = new DataGridViewTextBoxColumn();
            legoTypeColumn.DataPropertyName = "lego_type";
            legoTypeColumn.HeaderText = "Leg Típusa";
            legoTypeColumn.Name = "lego_type";
            dataGridView.Columns.Add(legoTypeColumn);

            // LegoStock oszlop
            DataGridViewTextBoxColumn legoStockColumn = new DataGridViewTextBoxColumn();
            legoStockColumn.DataPropertyName = "lego_stock";
            legoStockColumn.HeaderText = "Készleten lévő mennyiség";
            legoStockColumn.Name = "lego_stock";
            dataGridView.Columns.Add(legoStockColumn);

            // LegoPrice oszlop
            DataGridViewTextBoxColumn legoPriceColumn = new DataGridViewTextBoxColumn();
            legoPriceColumn.DataPropertyName = "lego_price";
            legoPriceColumn.HeaderText = "Leg ára";
            legoPriceColumn.Name = "lego_price";
            dataGridView.Columns.Add(legoPriceColumn);

            // LegoStatus oszlop
            DataGridViewTextBoxColumn legoStatusColumn = new DataGridViewTextBoxColumn();
            legoStatusColumn.DataPropertyName = "lego_status";
            legoStatusColumn.HeaderText = "Lego státusza";
            legoStatusColumn.Name = "lego_status";
            dataGridView.Columns.Add(legoStatusColumn);

            // LegoImage oszlop
            DataGridViewTextBoxColumn legoImageColumn = new DataGridViewTextBoxColumn();
            legoImageColumn.DataPropertyName = "lego_image";
            legoImageColumn.HeaderText = "Betöltött kép";
            legoImageColumn.Name = "lego_image";
            dataGridView.Columns.Add(legoImageColumn);

            // DateInsert oszlop
            DataGridViewTextBoxColumn dateInsertColumn = new DataGridViewTextBoxColumn();
            dateInsertColumn.DataPropertyName = "date_insert";
            dateInsertColumn.HeaderText = "Beszúrás időpontja";
            dateInsertColumn.Name = "date_insert";
            dataGridView.Columns.Add(dateInsertColumn);

            // DateUpdate oszlop
            DataGridViewTextBoxColumn dateUpdateColumn = new DataGridViewTextBoxColumn();
            dateUpdateColumn.DataPropertyName = "date_update";
            dateUpdateColumn.HeaderText = "Módosítás időpontja";
            dateUpdateColumn.Name = "date_update";
            dataGridView.Columns.Add(dateUpdateColumn);

            // DateDelete oszlop
            DataGridViewTextBoxColumn dateDeleteColumn = new DataGridViewTextBoxColumn();
            dateDeleteColumn.DataPropertyName = "date_delete";
            dateDeleteColumn.HeaderText = "Törlés időpontja";
            dateDeleteColumn.Name = "date_delete";
            dataGridView.Columns.Add(dateDeleteColumn);
            LegoData legoData = new LegoData();
            dataGridView.DataSource = legoData.LegoDataList();

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
        }
    }
}
