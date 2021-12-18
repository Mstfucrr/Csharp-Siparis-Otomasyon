
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
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.registerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerBtn.Location = new System.Drawing.Point(5, 5);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(5);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(175, 124);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Kayıt Ol";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCustomer.Location = new System.Drawing.Point(190, 5);
            this.BtnCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(176, 124);
            this.BtnCustomer.TabIndex = 1;
            this.BtnCustomer.Text = "Müşteri Giriş";
            this.BtnCustomer.UseVisualStyleBackColor = false;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomerLogin_Click);
            // 
            // BtnControl_Panel
            // 
            this.BtnControl_Panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnControl_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnControl_Panel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnControl_Panel.Location = new System.Drawing.Point(3, 137);
            this.BtnControl_Panel.Name = "BtnControl_Panel";
            this.BtnControl_Panel.Size = new System.Drawing.Size(179, 128);
            this.BtnControl_Panel.TabIndex = 2;
            this.BtnControl_Panel.Text = "Kontrol Paneli";
            this.BtnControl_Panel.UseVisualStyleBackColor = false;
            this.BtnControl_Panel.Click += new System.EventHandler(this.BtnControl_Panel_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.BackColor = System.Drawing.Color.Crimson;
            this.Btn_Quit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Quit.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Quit.Location = new System.Drawing.Point(188, 137);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(180, 128);
            this.Btn_Quit.TabIndex = 3;
            this.Btn_Quit.Text = "Çıkış";
            this.Btn_Quit.UseVisualStyleBackColor = false;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.registerBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Quit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnControl_Panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCustomer, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(505, 398);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Button BtnControl_Panel;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

