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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text == "" || TxtAgirlik.Text == "" || TxtFiyat.Text == "" || TxtTanim.Text == "") 
            {
                MessageBox.Show("Lütfne tüm boşlukları doldurduğunuzdan emin olun");   
            }
            else
            {
                Product product = new Product();
                product.Ad = TxtAd.Text;
                product.Agirlik = Convert.ToSingle(TxtAgirlik.Text);
                product.BirimFiyat = Convert.ToSingle(TxtFiyat.Text);
                product.Tanim = TxtTanim.Text;
                if (product.AddProduct())
                {
                    MessageBox.Show("Ürün başarıyla eklendi");
                    TxtAd.Text = "";
                    TxtAgirlik.Text = "";
                    TxtFiyat.Text = "";
                    TxtTanim.Text = "";
                }

            }
        }
    }
}
