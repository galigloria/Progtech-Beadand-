namespace LegoStoreManagementSystem
{
    partial class Order
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.Order_Panel = new System.Windows.Forms.Panel();
            this.Order_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Order_ProductsPrice = new System.Windows.Forms.TextBox();
            this.Order_ProductsName = new System.Windows.Forms.TextBox();
            this.Order_Clear = new System.Windows.Forms.Button();
            this.Order_Remove = new System.Windows.Forms.Button();
            this.Order_Add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Order_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Order_ID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Order_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Order_Receipt = new System.Windows.Forms.Button();
            this.Order_Pay = new System.Windows.Forms.Button();
            this.Order_Change = new System.Windows.Forms.Label();
            this.Order_Amount = new System.Windows.Forms.TextBox();
            this.Order_Price = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderData = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productsDataGridView1 = new LegoStoreManagementSystem.ProductsDataGridView();
            this.Order_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Quantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_Panel
            // 
            this.Order_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.Order_Panel.Controls.Add(this.productsDataGridView1);
            this.Order_Panel.Location = new System.Drawing.Point(302, 22);
            this.Order_Panel.Name = "Order_Panel";
            this.Order_Panel.Size = new System.Drawing.Size(656, 352);
            this.Order_Panel.TabIndex = 0;
            // 
            // Order_lbl
            // 
            this.Order_lbl.AutoSize = true;
            this.Order_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Order_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.Order_lbl.Location = new System.Drawing.Point(36, 20);
            this.Order_lbl.Name = "Order_lbl";
            this.Order_lbl.Size = new System.Drawing.Size(173, 38);
            this.Order_lbl.TabIndex = 38;
            this.Order_lbl.Text = "Rendelés ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.Order_ProductsPrice);
            this.panel2.Controls.Add(this.Order_ProductsName);
            this.panel2.Controls.Add(this.Order_Clear);
            this.panel2.Controls.Add(this.Order_Remove);
            this.panel2.Controls.Add(this.Order_Add);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Order_Quantity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Order_ID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Order_Type);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(302, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 434);
            this.panel2.TabIndex = 1;
            // 
            // Order_ProductsPrice
            // 
            this.Order_ProductsPrice.Location = new System.Drawing.Point(488, 30);
            this.Order_ProductsPrice.Name = "Order_ProductsPrice";
            this.Order_ProductsPrice.Size = new System.Drawing.Size(100, 22);
            this.Order_ProductsPrice.TabIndex = 60;
            // 
            // Order_ProductsName
            // 
            this.Order_ProductsName.Location = new System.Drawing.Point(228, 30);
            this.Order_ProductsName.Name = "Order_ProductsName";
            this.Order_ProductsName.Size = new System.Drawing.Size(100, 22);
            this.Order_ProductsName.TabIndex = 59;
            // 
            // Order_Clear
            // 
            this.Order_Clear.BackColor = System.Drawing.Color.Gold;
            this.Order_Clear.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Order_Clear.Location = new System.Drawing.Point(472, 335);
            this.Order_Clear.Name = "Order_Clear";
            this.Order_Clear.Size = new System.Drawing.Size(136, 69);
            this.Order_Clear.TabIndex = 58;
            this.Order_Clear.Text = "Eltávolítás";
            this.Order_Clear.UseVisualStyleBackColor = false;
            // 
            // Order_Remove
            // 
            this.Order_Remove.BackColor = System.Drawing.Color.Gold;
            this.Order_Remove.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Order_Remove.Location = new System.Drawing.Point(76, 335);
            this.Order_Remove.Name = "Order_Remove";
            this.Order_Remove.Size = new System.Drawing.Size(136, 69);
            this.Order_Remove.TabIndex = 57;
            this.Order_Remove.Text = "Törlés ";
            this.Order_Remove.UseVisualStyleBackColor = false;
            // 
            // Order_Add
            // 
            this.Order_Add.BackColor = System.Drawing.Color.Gold;
            this.Order_Add.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Order_Add.Location = new System.Drawing.Point(275, 335);
            this.Order_Add.Name = "Order_Add";
            this.Order_Add.Size = new System.Drawing.Size(136, 69);
            this.Order_Add.TabIndex = 56;
            this.Order_Add.Text = "Hozzáadás";
            this.Order_Add.UseVisualStyleBackColor = false;
            this.Order_Add.Click += new System.EventHandler(this.Order_Add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(391, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Ár (Ft)";
            // 
            // Order_Quantity
            // 
            this.Order_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.Order_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Order_Quantity.Location = new System.Drawing.Point(395, 263);
            this.Order_Quantity.Name = "Order_Quantity";
            this.Order_Quantity.Size = new System.Drawing.Size(159, 22);
            this.Order_Quantity.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(230, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Mennyiség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(171, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Név";
            // 
            // Order_ID
            // 
            this.Order_ID.BackColor = System.Drawing.Color.Gold;
            this.Order_ID.FormattingEnabled = true;
            this.Order_ID.Items.AddRange(new object[] {
            "Aktív ",
            "Felfüggesztett"});
            this.Order_ID.Location = new System.Drawing.Point(395, 217);
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.Size = new System.Drawing.Size(159, 24);
            this.Order_ID.TabIndex = 46;
            this.Order_ID.SelectedIndexChanged += new System.EventHandler(this.Order_ID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(230, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Azonosító";
            // 
            // Order_Type
            // 
            this.Order_Type.BackColor = System.Drawing.Color.Gold;
            this.Order_Type.FormattingEnabled = true;
            this.Order_Type.Items.AddRange(new object[] {
            "LEGO Alkatrész",
            "LEGO Duplo",
            "LEGO Starwars",
            "LEGO Kiegészítők",
            "LEGO Figurák "});
            this.Order_Type.Location = new System.Drawing.Point(395, 157);
            this.Order_Type.Name = "Order_Type";
            this.Order_Type.Size = new System.Drawing.Size(159, 24);
            this.Order_Type.TabIndex = 44;
            this.Order_Type.SelectedIndexChanged += new System.EventHandler(this.Order_Type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(230, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Típus";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.Order_Receipt);
            this.panel3.Controls.Add(this.Order_lbl);
            this.panel3.Controls.Add(this.Order_Pay);
            this.panel3.Controls.Add(this.Order_Change);
            this.panel3.Controls.Add(this.Order_Amount);
            this.panel3.Controls.Add(this.Order_Price);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.OrderData);
            this.panel3.Location = new System.Drawing.Point(14, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 811);
            this.panel3.TabIndex = 2;
            // 
            // Order_Receipt
            // 
            this.Order_Receipt.BackColor = System.Drawing.Color.Gold;
            this.Order_Receipt.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_Receipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Order_Receipt.Location = new System.Drawing.Point(144, 682);
            this.Order_Receipt.Name = "Order_Receipt";
            this.Order_Receipt.Size = new System.Drawing.Size(106, 54);
            this.Order_Receipt.TabIndex = 64;
            this.Order_Receipt.Text = "Számla ";
            this.Order_Receipt.UseVisualStyleBackColor = false;
            this.Order_Receipt.Click += new System.EventHandler(this.Order_Receipt_Click);
            // 
            // Order_Pay
            // 
            this.Order_Pay.BackColor = System.Drawing.Color.Gold;
            this.Order_Pay.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_Pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Order_Pay.Location = new System.Drawing.Point(15, 682);
            this.Order_Pay.Name = "Order_Pay";
            this.Order_Pay.Size = new System.Drawing.Size(106, 54);
            this.Order_Pay.TabIndex = 63;
            this.Order_Pay.Text = "Fizetés";
            this.Order_Pay.UseVisualStyleBackColor = false;
            this.Order_Pay.Click += new System.EventHandler(this.Order_Pay_Click);
            // 
            // Order_Change
            // 
            this.Order_Change.AutoSize = true;
            this.Order_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Order_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.Order_Change.Location = new System.Drawing.Point(190, 640);
            this.Order_Change.Name = "Order_Change";
            this.Order_Change.Size = new System.Drawing.Size(19, 20);
            this.Order_Change.TabIndex = 62;
            this.Order_Change.Text = "0";
            // 
            // Order_Amount
            // 
            this.Order_Amount.Location = new System.Drawing.Point(165, 579);
            this.Order_Amount.Name = "Order_Amount";
            this.Order_Amount.Size = new System.Drawing.Size(68, 22);
            this.Order_Amount.TabIndex = 61;
            this.Order_Amount.TextChanged += new System.EventHandler(this.Order_Amount_TextChanged);
            this.Order_Amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Order_Amount_KeyDown);
            // 
            // Order_Price
            // 
            this.Order_Price.AutoSize = true;
            this.Order_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.Order_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Order_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.Order_Price.Location = new System.Drawing.Point(174, 538);
            this.Order_Price.Name = "Order_Price";
            this.Order_Price.Size = new System.Drawing.Size(59, 20);
            this.Order_Price.TabIndex = 59;
            this.Order_Price.Text = "30000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(22, 639);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Visszajár (Ft)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(22, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Ár (Ft)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(22, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Összeg (Ft)";
            // 
            // OrderData
            // 
            this.OrderData.AllowUserToAddRows = false;
            this.OrderData.AllowUserToDeleteRows = false;
            this.OrderData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderData.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderData.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderData.EnableHeadersVisualStyles = false;
            this.OrderData.Location = new System.Drawing.Point(15, 74);
            this.OrderData.Name = "OrderData";
            this.OrderData.ReadOnly = true;
            this.OrderData.RowHeadersVisible = false;
            this.OrderData.RowHeadersWidth = 51;
            this.OrderData.RowTemplate.Height = 24;
            this.OrderData.Size = new System.Drawing.Size(235, 264);
            this.OrderData.TabIndex = 38;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // productsDataGridView1
            // 
            this.productsDataGridView1.AllowUserToAddRows = false;
            this.productsDataGridView1.AllowUserToDeleteRows = false;
            this.productsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.productsDataGridView1.Name = "productsDataGridView1";
            this.productsDataGridView1.ReadOnly = true;
            this.productsDataGridView1.RowHeadersWidth = 51;
            this.productsDataGridView1.RowTemplate.Height = 24;
            this.productsDataGridView1.Size = new System.Drawing.Size(656, 352);
            this.productsDataGridView1.TabIndex = 42;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Order_Panel);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1000, 900);
            this.Order_Panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Order_Panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Order_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Order_Type;
        private System.Windows.Forms.NumericUpDown Order_Quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Order_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Order_Add;
        private System.Windows.Forms.Button Order_Clear;
        private System.Windows.Forms.Button Order_Remove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView OrderData;
        private System.Windows.Forms.Button Order_Receipt;
        private System.Windows.Forms.Button Order_Pay;
        private System.Windows.Forms.Label Order_Change;
        private System.Windows.Forms.TextBox Order_Amount;
        private System.Windows.Forms.Label Order_Price;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox Order_ProductsPrice;
        private System.Windows.Forms.TextBox Order_ProductsName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ProductsDataGridView productsDataGridView1;
    }
}
