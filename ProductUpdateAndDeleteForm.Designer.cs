﻿
namespace PROJECT
{
    partial class ProductUpdateAndDeleteForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productDataSet = new PROJECT.ProductDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new PROJECT.ProductDataSetTableAdapters.ProductsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agirlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAgirlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTanim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnUpdate_Product = new System.Windows.Forms.Button();
            this.BtnDelete_Product = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn,
            this.tanimDataGridViewTextBoxColumn,
            this.agirlikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(268, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectProduct);
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "Birim Fiyatı";
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            // 
            // tanimDataGridViewTextBoxColumn
            // 
            this.tanimDataGridViewTextBoxColumn.DataPropertyName = "Tanim";
            this.tanimDataGridViewTextBoxColumn.HeaderText = "Tanım";
            this.tanimDataGridViewTextBoxColumn.Name = "tanimDataGridViewTextBoxColumn";
            this.tanimDataGridViewTextBoxColumn.Width = 150;
            // 
            // agirlikDataGridViewTextBoxColumn
            // 
            this.agirlikDataGridViewTextBoxColumn.DataPropertyName = "Agirlik";
            this.agirlikDataGridViewTextBoxColumn.HeaderText = "Ağırlık (kg)";
            this.agirlikDataGridViewTextBoxColumn.Name = "agirlikDataGridViewTextBoxColumn";
            this.agirlikDataGridViewTextBoxColumn.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Bilgisi";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnDelete_Product);
            this.panel1.Controls.Add(this.BtnUpdate_Product);
            this.panel1.Controls.Add(this.TxtTanim);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtAgirlik);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtFiyat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 350);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAd.Location = new System.Drawing.Point(49, 45);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(185, 27);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiyat.Location = new System.Drawing.Point(49, 106);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(185, 27);
            this.TxtFiyat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim Fiyatı";
            // 
            // TxtAgirlik
            // 
            this.TxtAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAgirlik.Location = new System.Drawing.Point(49, 164);
            this.TxtAgirlik.Name = "TxtAgirlik";
            this.TxtAgirlik.Size = new System.Drawing.Size(185, 27);
            this.TxtAgirlik.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ağırlık (kg)";
            // 
            // TxtTanim
            // 
            this.TxtTanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTanim.Location = new System.Drawing.Point(49, 225);
            this.TxtTanim.Multiline = true;
            this.TxtTanim.Name = "TxtTanim";
            this.TxtTanim.Size = new System.Drawing.Size(185, 76);
            this.TxtTanim.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanımı";
            // 
            // BtnUpdate_Product
            // 
            this.BtnUpdate_Product.BackColor = System.Drawing.Color.Orange;
            this.BtnUpdate_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate_Product.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate_Product.Location = new System.Drawing.Point(25, 322);
            this.BtnUpdate_Product.Name = "BtnUpdate_Product";
            this.BtnUpdate_Product.Size = new System.Drawing.Size(85, 23);
            this.BtnUpdate_Product.TabIndex = 3;
            this.BtnUpdate_Product.Text = "Güncelle";
            this.BtnUpdate_Product.UseVisualStyleBackColor = false;
            this.BtnUpdate_Product.Click += new System.EventHandler(this.BtnUpdate_Product_Click);
            // 
            // BtnDelete_Product
            // 
            this.BtnDelete_Product.BackColor = System.Drawing.Color.Red;
            this.BtnDelete_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete_Product.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete_Product.Location = new System.Drawing.Point(149, 322);
            this.BtnDelete_Product.Name = "BtnDelete_Product";
            this.BtnDelete_Product.Size = new System.Drawing.Size(85, 23);
            this.BtnDelete_Product.TabIndex = 8;
            this.BtnDelete_Product.Text = "Sil";
            this.BtnDelete_Product.UseVisualStyleBackColor = false;
            this.BtnDelete_Product.Click += new System.EventHandler(this.BtnDelete_Product_Click);
            // 
            // ProductUpdateAndDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(801, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductUpdateAndDeleteForm";
            this.Text = "Ürün Güncelleme Ve Silme";
            this.Load += new System.EventHandler(this.ProductUpdateAndDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProductDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agirlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDelete_Product;
        private System.Windows.Forms.Button BtnUpdate_Product;
        private System.Windows.Forms.TextBox TxtTanim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAgirlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
    }
}