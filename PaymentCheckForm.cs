using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class PaymentCheckForm : Form
    {
        public int OrderId { get; set; }
        private int CustomerId { get; set; }

        public PaymentCheckForm(int orderid,int customerId)
        {
            InitializeComponent();
            this.OrderId = orderid;
            this.CustomerId = customerId;
        }

        private void BtnBuy_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ödeme işlemini tamamlamak istediğinize emin misiniz ?", "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PaymentCheck check = new PaymentCheck();
                check.bankId = Convert.ToUInt64(TxtCreditNumber.Text);
                check.checkOwner = TxtCreditName.Text;
                MessageBox.Show(check.Authorized());
                OrderDbStatusUpdate();
                this.Close();
                OrderForm orderForm = new OrderForm(CustomerId);
                orderForm.Show();
            }
        }

        private void OrderDbStatusUpdate()
        {
            DB db = new DB();
            string update = "Update Orders set Status = 1 where id = @OrderId";
            SqlCommand cmd = new SqlCommand(update, db.baglanti());
            cmd.Parameters.AddWithValue("@OrderId", OrderId);
            cmd.ExecuteNonQuery();
            db.baglanti().Close();
        }
    }
}
