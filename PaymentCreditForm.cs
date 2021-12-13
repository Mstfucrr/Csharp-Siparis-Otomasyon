using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class PaymentCreditForm : Form
    {
        private int OrderId { get; set; }
        public PaymentCreditForm(int orderId)
        {
            InitializeComponent();
            this.OrderId = orderId;
        }

        private void TxtCardName_TextChanged(object sender, EventArgs e)
        {
            LblCardName.Text = TxtCardName.Text;
            if (TxtCardName.Text.Length == 0)
            {
                LblCardName.Text = "Kart sahibi";
            }
        }

        private void CboxCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboxCardType.Text == "Visa")
            {
                PicVisa_Logo.Visible = true;
                PicMaster_Logo.Visible = false;
            }
            else
            {
                PicVisa_Logo.Visible = false;
                PicMaster_Logo.Visible = true;
            }
        }

        private void TxtCardNumber_KeyUp(object sender, KeyEventArgs e)
        {
            LblCardNumber.Text = TxtCardNumber.Text;
            if (e.KeyCode == Keys.Back)
            {
                LblCardNumber.Text = TxtCardNumber.Text;

            }
            else
            {
                if (LblCardNumber.Text.Length == 4 || LblCardNumber.Text.Length == 9
                    || LblCardNumber.Text.Length == 14)
                {
                    LblCardNumber.Text += " ";
                    TxtCardNumber.Text += " ";
                    TxtCardNumber.SelectionStart = TxtCardNumber.Text.Length;
                }
                LblCardNumber.Text = TxtCardNumber.Text;

            }
        }

        private void CboxAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblDateAA.Text = Convert.ToInt32(CboxAA.Text) < 10 ? "0" + CboxAA.Text : CboxAA.Text;
        }

        private void CboxYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblDateYY.Text = CboxYY.Text;
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ödeme işlemini tamamlamak istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PaymentCredit credit = new PaymentCredit();
                DateTime expTime = new DateTime(Convert.ToInt32(LblDateYY.Text), Convert.ToInt32(LblDateAA.Text),1);
                credit.CartExpDateTime = expTime;
                credit.cartNumber = Convert.ToUInt64(LblCardNumber.Text.Replace(" ", ""));
                credit.cartType = CboxCardType.Text;
                credit.cartOwner = LblCardName.Text;
                MessageBox.Show(credit.Authorized());

                OrderDbStatusUpdate();

                this.Close();
            }
        }

        private void OrderDbStatusUpdate()
        {
            DB db = new DB();
            string update = "Update Orders set Status = 1 where id = @OrderId";
            SqlCommand cmd = new SqlCommand(update,db.baglanti());
            cmd.Parameters.AddWithValue("@OrderId", OrderId);
            cmd.ExecuteNonQuery();
            db.baglanti().Close();
        }
    }
}
