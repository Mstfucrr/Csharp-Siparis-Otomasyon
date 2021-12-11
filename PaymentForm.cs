using System;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            FormPull(new PaymentCreditForm());
        }

        private Form activForm = null;

        private void FormPull(Form form)
        {
            if (activForm != null)
                activForm.Close();

            activForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Panel_Payment.Controls.Add(form);
            form.BringToFront();

            form.Show();
        }
        
        private void BtnCreditMenuItem(object sender, EventArgs e)
        {
            FormPull(new PaymentCreditForm());
            
        }

        private void BtnCheckMenuItem(object sender, EventArgs e)
        {
            FormPull(new PaymentCheckForm());

        }

        
    }
}
