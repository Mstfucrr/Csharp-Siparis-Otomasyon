using System;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class PaymentCheckForm : Form
    {
        public PaymentCheckForm()
        {
            InitializeComponent();
        }

        private void BtnBuy_Click(object sender, System.EventArgs e)
        {
            PaymentCheck check = new PaymentCheck();
            check.bankId = Convert.ToUInt64(TxtCreditNumber.Text);
            check.checkOwner = TxtCreditName.Text;
            MessageBox.Show(check.Authorized());
        }
    }
}
