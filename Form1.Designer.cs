
namespace PROJECT
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerBtn = new System.Windows.Forms.Button();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.BtnControl_Panel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerBtn.Location = new System.Drawing.Point(244, 28);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(5);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(106, 43);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Kayıt Ol";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCustomer.Location = new System.Drawing.Point(49, 28);
            this.BtnCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(139, 43);
            this.BtnCustomer.TabIndex = 1;
            this.BtnCustomer.Text = "Müşteri Giriş";
            this.BtnCustomer.UseVisualStyleBackColor = true;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomerLogin_Click);
            // 
            // BtnControl_Panel
            // 
            this.BtnControl_Panel.Location = new System.Drawing.Point(35, 93);
            this.BtnControl_Panel.Name = "BtnControl_Panel";
            this.BtnControl_Panel.Size = new System.Drawing.Size(184, 35);
            this.BtnControl_Panel.TabIndex = 2;
            this.BtnControl_Panel.Text = "Kontrol Panali";
            this.BtnControl_Panel.UseVisualStyleBackColor = true;
            this.BtnControl_Panel.Click += new System.EventHandler(this.BtnControl_Panel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 398);
            this.Controls.Add(this.BtnControl_Panel);
            this.Controls.Add(this.BtnCustomer);
            this.Controls.Add(this.registerBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Button BtnControl_Panel;
    }
}

