﻿
namespace PROJECT
{
    partial class OrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productDataSet = new PROJECT.ProductDataSet();
            this.productDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new PROJECT.ProductDataSetTableAdapters.ProductsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAdd_Basket = new System.Windows.Forms.Button();
            this.TxtTanim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAgirlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnConfirmBasket = new System.Windows.Forms.Button();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ListWeight = new System.Windows.Forms.ListBox();
            this.ListPrice = new System.Windows.Forms.ListBox();
            this.ListName = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectShowProductDetail);
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productDataSetBindingSource
            // 
            this.productDataSetBindingSource.DataSource = this.productDataSet;
            this.productDataSetBindingSource.Position = 0;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(641, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Bilgisi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BtnAdd_Basket);
            this.panel1.Controls.Add(this.TxtTanim);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtAgirlik);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtFiyat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(621, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 346);
            this.panel1.TabIndex = 4;
            // 
            // quantity
            // 
            this.quantity.FormattingEnabled = true;
            this.quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.quantity.Location = new System.Drawing.Point(101, 263);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(54, 24);
            this.quantity.TabIndex = 9;
            this.quantity.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Miktar";
            // 
            // BtnAdd_Basket
            // 
            this.BtnAdd_Basket.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnAdd_Basket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd_Basket.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd_Basket.Location = new System.Drawing.Point(71, 303);
            this.BtnAdd_Basket.Name = "BtnAdd_Basket";
            this.BtnAdd_Basket.Size = new System.Drawing.Size(125, 38);
            this.BtnAdd_Basket.TabIndex = 3;
            this.BtnAdd_Basket.Text = "Sepete Ekle";
            this.BtnAdd_Basket.UseVisualStyleBackColor = false;
            this.BtnAdd_Basket.Click += new System.EventHandler(this.Add_Basket_Click);
            // 
            // TxtTanim
            // 
            this.TxtTanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTanim.Location = new System.Drawing.Point(40, 169);
            this.TxtTanim.Multiline = true;
            this.TxtTanim.Name = "TxtTanim";
            this.TxtTanim.ReadOnly = true;
            this.TxtTanim.Size = new System.Drawing.Size(185, 76);
            this.TxtTanim.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanımı";
            // 
            // TxtAgirlik
            // 
            this.TxtAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAgirlik.Location = new System.Drawing.Point(40, 126);
            this.TxtAgirlik.Name = "TxtAgirlik";
            this.TxtAgirlik.ReadOnly = true;
            this.TxtAgirlik.Size = new System.Drawing.Size(185, 23);
            this.TxtAgirlik.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ağırlık (kg)";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFiyat.Location = new System.Drawing.Point(40, 83);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.ReadOnly = true;
            this.TxtFiyat.Size = new System.Drawing.Size(185, 23);
            this.TxtFiyat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim Fiyatı";
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(40, 40);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.ReadOnly = true;
            this.TxtAd.Size = new System.Drawing.Size(185, 23);
            this.TxtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.LblAmount);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.LblTax);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.BtnConfirmBasket);
            this.panel2.Controls.Add(this.LblPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ListWeight);
            this.panel2.Controls.Add(this.ListPrice);
            this.panel2.Controls.Add(this.ListName);
            this.panel2.Location = new System.Drawing.Point(31, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 209);
            this.panel2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Çek"});
            this.comboBox1.Location = new System.Drawing.Point(162, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Ödeme Yöntemi";
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAmount.Location = new System.Drawing.Point(462, 150);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(17, 17);
            this.LblAmount.TabIndex = 12;
            this.LblAmount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(445, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Ödenecek Tutar";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTax.Location = new System.Drawing.Point(462, 100);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(17, 17);
            this.LblTax.TabIndex = 10;
            this.LblTax.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(462, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Vergi Tutarı";
            // 
            // BtnConfirmBasket
            // 
            this.BtnConfirmBasket.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnConfirmBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmBasket.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnConfirmBasket.Location = new System.Drawing.Point(22, 159);
            this.BtnConfirmBasket.Name = "BtnConfirmBasket";
            this.BtnConfirmBasket.Size = new System.Drawing.Size(125, 38);
            this.BtnConfirmBasket.TabIndex = 8;
            this.BtnConfirmBasket.Text = "Sepeti Onayla";
            this.BtnConfirmBasket.UseVisualStyleBackColor = false;
            this.BtnConfirmBasket.Click += new System.EventHandler(this.BtnConfirmBasket_Click);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPrice.Location = new System.Drawing.Point(462, 49);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(17, 17);
            this.LblPrice.TabIndex = 4;
            this.LblPrice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(460, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Toplam Fiyat";
            // 
            // ListWeight
            // 
            this.ListWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListWeight.FormattingEnabled = true;
            this.ListWeight.ItemHeight = 18;
            this.ListWeight.Location = new System.Drawing.Point(301, 22);
            this.ListWeight.Name = "ListWeight";
            this.ListWeight.Size = new System.Drawing.Size(122, 128);
            this.ListWeight.TabIndex = 2;
            // 
            // ListPrice
            // 
            this.ListPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListPrice.FormattingEnabled = true;
            this.ListPrice.ItemHeight = 18;
            this.ListPrice.Location = new System.Drawing.Point(162, 22);
            this.ListPrice.Name = "ListPrice";
            this.ListPrice.Size = new System.Drawing.Size(122, 128);
            this.ListPrice.TabIndex = 1;
            // 
            // ListName
            // 
            this.ListName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListName.FormattingEnabled = true;
            this.ListName.ItemHeight = 18;
            this.ListName.Location = new System.Drawing.Point(22, 22);
            this.ListName.Name = "ListName";
            this.ListName.Size = new System.Drawing.Size(122, 128);
            this.ListName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SpringGreen;
            this.label6.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sepet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(334, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sepeti Kaldır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Btn_RemoveBasket_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 530);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderForm";
            this.Text = "Sipariş";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Click += new System.EventHandler(this.Btn_RemoveBasket_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource productDataSetBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProductDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAdd_Basket;
        private System.Windows.Forms.TextBox TxtTanim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAgirlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox ListWeight;
        private System.Windows.Forms.ListBox ListPrice;
        private System.Windows.Forms.ListBox ListName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnConfirmBasket;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}