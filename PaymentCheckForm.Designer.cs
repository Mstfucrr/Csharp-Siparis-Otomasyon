
namespace PROJECT
{
    partial class PaymentCheckForm
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
            this.Panel_Check = new System.Windows.Forms.Panel();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.TxtCreditNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCreditName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Check.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Check
            // 
            this.Panel_Check.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel_Check.Controls.Add(this.BtnBuy);
            this.Panel_Check.Controls.Add(this.TxtCreditNumber);
            this.Panel_Check.Controls.Add(this.label2);
            this.Panel_Check.Controls.Add(this.TxtCreditName);
            this.Panel_Check.Controls.Add(this.label1);
            this.Panel_Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Panel_Check.Location = new System.Drawing.Point(0, 0);
            this.Panel_Check.Name = "Panel_Check";
            this.Panel_Check.Size = new System.Drawing.Size(460, 384);
            this.Panel_Check.TabIndex = 0;
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBuy.ForeColor = System.Drawing.Color.YellowGreen;
            this.BtnBuy.Location = new System.Drawing.Point(123, 236);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(222, 59);
            this.BtnBuy.TabIndex = 18;
            this.BtnBuy.Text = "Ödemeyi Tamamla";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // TxtCreditNumber
            // 
            this.TxtCreditNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCreditNumber.Location = new System.Drawing.Point(95, 156);
            this.TxtCreditNumber.MaxLength = 16;
            this.TxtCreditNumber.Name = "TxtCreditNumber";
            this.TxtCreditNumber.Size = new System.Drawing.Size(280, 27);
            this.TxtCreditNumber.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(91, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Banka ID";
            // 
            // TxtCreditName
            // 
            this.TxtCreditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCreditName.Location = new System.Drawing.Point(95, 93);
            this.TxtCreditName.Name = "TxtCreditName";
            this.TxtCreditName.Size = new System.Drawing.Size(280, 27);
            this.TxtCreditName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(91, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Çek sahibi";
            // 
            // PaymentCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 384);
            this.Controls.Add(this.Panel_Check);
            this.Name = "PaymentCheckForm";
            this.Text = "Çek ile öde";
            this.Panel_Check.ResumeLayout(false);
            this.Panel_Check.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Check;
        private System.Windows.Forms.TextBox TxtCreditNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCreditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuy;
    }
}