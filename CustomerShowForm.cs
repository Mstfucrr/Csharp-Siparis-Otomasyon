using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class CustomerShowForm : Form
    {
        public CustomerShowForm()
        {
            InitializeComponent();
        }

        private void CustomerShowForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'customerDataSet.Customers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.customersTableAdapter.Fill(this.customerDataSet.Customers);
            MessageBox.Show("Test");
        }
    }
}
