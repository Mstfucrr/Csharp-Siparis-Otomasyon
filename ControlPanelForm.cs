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
    public partial class ControlPanelForm : Form
    {
        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void BtnCustomers_Show_Click(object sender, EventArgs e)
        {
            CustomerShowForm customerShow = new CustomerShowForm();
            customerShow.Show();
        }

        private void BtnAdd_Product_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void BtnUpdate_Product_Click(object sender, EventArgs e)
        {
            ProductUpdateAndDeleteForm productUpdateAndDeleteForm = new ProductUpdateAndDeleteForm();
            productUpdateAndDeleteForm.Show();
        }
    }
}
