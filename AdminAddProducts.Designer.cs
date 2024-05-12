namespace LegoStoreManagementSystem
{
    partial class AdminAddProducts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.legoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.legoDataSet = new LegoStoreManagementSystem.legoDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminAddProducts_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminAddProducts_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminAddProducts_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminAddProducts_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AdminAddProducts_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AdminAddProducts_condition = new System.Windows.Forms.ComboBox();
            this.AdminAddProducts_imageView = new System.Windows.Forms.PictureBox();
            this.AdminAddProducts_import = new System.Windows.Forms.Button();
            this.AdminAddProducts_deletebtn = new System.Windows.Forms.Button();
            this.AdminAddProducts_addBtn = new System.Windows.Forms.Button();
            this.AdminAddProducts_clearBtn = new System.Windows.Forms.Button();
            this.AdminAddProducts_updatebtn = new System.Windows.Forms.Button();
            this.ProductsdataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminAddProducts_imageView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.ProductsdataGridView1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 350);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // legoDataSetBindingSource
            // 
            this.legoDataSetBindingSource.DataSource = this.legoDataSet;
            this.legoDataSetBindingSource.Position = 0;
            // 
            // legoDataSet
            // 
            this.legoDataSet.DataSetName = "legoDataSet";
            this.legoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LegoStoreManagementSystem.Properties.Resources.add_product_1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 68);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(268, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Termék adatok";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_id);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_name);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_type);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_stock);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_price);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_condition);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_imageView);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_import);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_deletebtn);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_addBtn);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_clearBtn);
            this.flowLayoutPanel1.Controls.Add(this.AdminAddProducts_updatebtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 378);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 358);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Termék ID";
            // 
            // AdminAddProducts_id
            // 
            this.AdminAddProducts_id.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_id.Location = new System.Drawing.Point(105, 3);
            this.AdminAddProducts_id.Name = "AdminAddProducts_id";
            this.AdminAddProducts_id.Size = new System.Drawing.Size(69, 22);
            this.AdminAddProducts_id.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(180, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Termék neve";
            // 
            // AdminAddProducts_name
            // 
            this.AdminAddProducts_name.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_name.Location = new System.Drawing.Point(302, 3);
            this.AdminAddProducts_name.Name = "AdminAddProducts_name";
            this.AdminAddProducts_name.Size = new System.Drawing.Size(137, 22);
            this.AdminAddProducts_name.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(445, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Típus";
            // 
            // AdminAddProducts_type
            // 
            this.AdminAddProducts_type.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_type.FormattingEnabled = true;
            this.AdminAddProducts_type.Items.AddRange(new object[] {
            "LEGO Alkatrész",
            "LEGO Duplo",
            "LEGO Starwars",
            "LEGO Kiegészítők",
            "LEGO Figurák "});
            this.AdminAddProducts_type.Location = new System.Drawing.Point(506, 3);
            this.AdminAddProducts_type.Name = "AdminAddProducts_type";
            this.AdminAddProducts_type.Size = new System.Drawing.Size(137, 24);
            this.AdminAddProducts_type.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(649, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Készlet";
            // 
            // AdminAddProducts_stock
            // 
            this.AdminAddProducts_stock.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_stock.Location = new System.Drawing.Point(727, 3);
            this.AdminAddProducts_stock.Name = "AdminAddProducts_stock";
            this.AdminAddProducts_stock.Size = new System.Drawing.Size(137, 22);
            this.AdminAddProducts_stock.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ár(Ft)";
            // 
            // AdminAddProducts_price
            // 
            this.AdminAddProducts_price.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_price.Location = new System.Drawing.Point(68, 33);
            this.AdminAddProducts_price.Name = "AdminAddProducts_price";
            this.AdminAddProducts_price.Size = new System.Drawing.Size(137, 22);
            this.AdminAddProducts_price.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(211, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Állapot";
            // 
            // AdminAddProducts_condition
            // 
            this.AdminAddProducts_condition.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_condition.FormattingEnabled = true;
            this.AdminAddProducts_condition.Items.AddRange(new object[] {
            "Jelenleg elérhető ",
            "Jelenleg nincs készleten "});
            this.AdminAddProducts_condition.Location = new System.Drawing.Point(284, 33);
            this.AdminAddProducts_condition.Name = "AdminAddProducts_condition";
            this.AdminAddProducts_condition.Size = new System.Drawing.Size(137, 24);
            this.AdminAddProducts_condition.TabIndex = 50;
            // 
            // AdminAddProducts_imageView
            // 
            this.AdminAddProducts_imageView.Location = new System.Drawing.Point(427, 33);
            this.AdminAddProducts_imageView.Name = "AdminAddProducts_imageView";
            this.AdminAddProducts_imageView.Size = new System.Drawing.Size(100, 50);
            this.AdminAddProducts_imageView.TabIndex = 60;
            this.AdminAddProducts_imageView.TabStop = false;
            // 
            // AdminAddProducts_import
            // 
            this.AdminAddProducts_import.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_import.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminAddProducts_import.Location = new System.Drawing.Point(533, 33);
            this.AdminAddProducts_import.Name = "AdminAddProducts_import";
            this.AdminAddProducts_import.Size = new System.Drawing.Size(87, 38);
            this.AdminAddProducts_import.TabIndex = 53;
            this.AdminAddProducts_import.Text = "Importálás";
            this.AdminAddProducts_import.UseVisualStyleBackColor = false;
            this.AdminAddProducts_import.Click += new System.EventHandler(this.AdminAddProducts_import_Click);
            // 
            // AdminAddProducts_deletebtn
            // 
            this.AdminAddProducts_deletebtn.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_deletebtn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminAddProducts_deletebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.AdminAddProducts_deletebtn.Location = new System.Drawing.Point(626, 33);
            this.AdminAddProducts_deletebtn.Name = "AdminAddProducts_deletebtn";
            this.AdminAddProducts_deletebtn.Size = new System.Drawing.Size(95, 69);
            this.AdminAddProducts_deletebtn.TabIndex = 55;
            this.AdminAddProducts_deletebtn.Text = "Törlés ";
            this.AdminAddProducts_deletebtn.UseVisualStyleBackColor = false;
            this.AdminAddProducts_deletebtn.Click += new System.EventHandler(this.AdminAddProducts_deletebtn_Click);
            // 
            // AdminAddProducts_addBtn
            // 
            this.AdminAddProducts_addBtn.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_addBtn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminAddProducts_addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.AdminAddProducts_addBtn.Location = new System.Drawing.Point(727, 33);
            this.AdminAddProducts_addBtn.Name = "AdminAddProducts_addBtn";
            this.AdminAddProducts_addBtn.Size = new System.Drawing.Size(95, 69);
            this.AdminAddProducts_addBtn.TabIndex = 58;
            this.AdminAddProducts_addBtn.Text = "Hozzáadás";
            this.AdminAddProducts_addBtn.UseVisualStyleBackColor = false;
            this.AdminAddProducts_addBtn.Click += new System.EventHandler(this.AdminAddProducts_addBtn_Click_1);
            // 
            // AdminAddProducts_clearBtn
            // 
            this.AdminAddProducts_clearBtn.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_clearBtn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminAddProducts_clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.AdminAddProducts_clearBtn.Location = new System.Drawing.Point(3, 108);
            this.AdminAddProducts_clearBtn.Name = "AdminAddProducts_clearBtn";
            this.AdminAddProducts_clearBtn.Size = new System.Drawing.Size(95, 69);
            this.AdminAddProducts_clearBtn.TabIndex = 59;
            this.AdminAddProducts_clearBtn.Text = "Eltávolítás ";
            this.AdminAddProducts_clearBtn.UseVisualStyleBackColor = false;
            this.AdminAddProducts_clearBtn.Click += new System.EventHandler(this.AdminAddProducts_clearBtn_Click_1);
            // 
            // AdminAddProducts_updatebtn
            // 
            this.AdminAddProducts_updatebtn.BackColor = System.Drawing.Color.Gold;
            this.AdminAddProducts_updatebtn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdminAddProducts_updatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.AdminAddProducts_updatebtn.Location = new System.Drawing.Point(104, 108);
            this.AdminAddProducts_updatebtn.Name = "AdminAddProducts_updatebtn";
            this.AdminAddProducts_updatebtn.Size = new System.Drawing.Size(95, 69);
            this.AdminAddProducts_updatebtn.TabIndex = 57;
            this.AdminAddProducts_updatebtn.Text = "Módosítás ";
            this.AdminAddProducts_updatebtn.UseVisualStyleBackColor = false;
            this.AdminAddProducts_updatebtn.Click += new System.EventHandler(this.AdminAddProducts_updatebtn_Click);
            // 
            // ProductsdataGridView1
            // 
            this.ProductsdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsdataGridView1.Location = new System.Drawing.Point(3, 130);
            this.ProductsdataGridView1.Name = "ProductsdataGridView1";
            this.ProductsdataGridView1.RowHeadersWidth = 51;
            this.ProductsdataGridView1.RowTemplate.Height = 24;
            this.ProductsdataGridView1.Size = new System.Drawing.Size(897, 150);
            this.ProductsdataGridView1.TabIndex = 40;
            this.ProductsdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsdataGridView1_CellClick_1);
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(1000, 900);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminAddProducts_imageView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminAddProducts_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminAddProducts_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AdminAddProducts_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdminAddProducts_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AdminAddProducts_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AdminAddProducts_condition;
        private System.Windows.Forms.Button AdminAddProducts_import;
        private System.Windows.Forms.Button AdminAddProducts_deletebtn;
        private System.Windows.Forms.Button AdminAddProducts_updatebtn;
        private System.Windows.Forms.Button AdminAddProducts_addBtn;
        private System.Windows.Forms.Button AdminAddProducts_clearBtn;
        private System.Windows.Forms.PictureBox AdminAddProducts_imageView;
        private System.Windows.Forms.BindingSource legoDataSetBindingSource;
        private legoDataSet legoDataSet;
        private System.Windows.Forms.DataGridView ProductsdataGridView1;
    }
}
