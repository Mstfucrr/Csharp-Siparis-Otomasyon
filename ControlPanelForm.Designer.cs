
namespace PROJECT
{
    partial class ControlPanelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUpdate_Product = new System.Windows.Forms.Button();
            this.BtnAdd_Product = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCustomers_Show = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(236, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KONTROL PANELİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnUpdate_Product);
            this.panel1.Controls.Add(this.BtnAdd_Product);
            this.panel1.Location = new System.Drawing.Point(437, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 248);
            this.panel1.TabIndex = 1;
            // 
            // BtnUpdate_Product
            // 
            this.BtnUpdate_Product.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdate_Product.Font = new System.Drawing.Font("Bookman Old Style", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate_Product.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnUpdate_Product.Location = new System.Drawing.Point(49, 112);
            this.BtnUpdate_Product.Name = "BtnUpdate_Product";
            this.BtnUpdate_Product.Size = new System.Drawing.Size(137, 70);
            this.BtnUpdate_Product.TabIndex = 1;
            this.BtnUpdate_Product.Text = "Güncelle Ve Sil";
            this.BtnUpdate_Product.UseVisualStyleBackColor = false;
            this.BtnUpdate_Product.Click += new System.EventHandler(this.BtnUpdate_Product_Click);
            // 
            // BtnAdd_Product
            // 
            this.BtnAdd_Product.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdd_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd_Product.Font = new System.Drawing.Font("Bookman Old Style", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd_Product.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAdd_Product.Location = new System.Drawing.Point(60, 25);
            this.BtnAdd_Product.Name = "BtnAdd_Product";
            this.BtnAdd_Product.Size = new System.Drawing.Size(111, 43);
            this.BtnAdd_Product.TabIndex = 0;
            this.BtnAdd_Product.Text = "Ekle";
            this.BtnAdd_Product.UseVisualStyleBackColor = false;
            this.BtnAdd_Product.Click += new System.EventHandler(this.BtnAdd_Product_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(442, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürünler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteriler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BtnCustomers_Show);
            this.panel2.Location = new System.Drawing.Point(47, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 248);
            this.panel2.TabIndex = 3;
            // 
            // BtnCustomers_Show
            // 
            this.BtnCustomers_Show.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCustomers_Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCustomers_Show.Font = new System.Drawing.Font("Bookman Old Style", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCustomers_Show.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCustomers_Show.Location = new System.Drawing.Point(26, 80);
            this.BtnCustomers_Show.Name = "BtnCustomers_Show";
            this.BtnCustomers_Show.Size = new System.Drawing.Size(163, 53);
            this.BtnCustomers_Show.TabIndex = 0;
            this.BtnCustomers_Show.Text = "Görüntüle";
            this.BtnCustomers_Show.UseVisualStyleBackColor = false;
            this.BtnCustomers_Show.Click += new System.EventHandler(this.BtnCustomers_Show_Click);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(724, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "ControlPanelForm";
            this.Text = "Kontrol Paneli";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnUpdate_Product;
        private System.Windows.Forms.Button BtnAdd_Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCustomers_Show;
    }
}