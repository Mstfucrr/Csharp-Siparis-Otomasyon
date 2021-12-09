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
    public partial class ProductUpdateAndDeleteForm : Form
    {
        public ProductUpdateAndDeleteForm()
        {
            InitializeComponent();
        }

        private void ProductUpdateAndDeleteForm_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            dataGridView1.DataSource = product.GetProducts();
            // TODO: Bu kod satırı 'productDataSet.Products' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.productsTableAdapter.Fill(this.productDataSet.Products);

        }

        int id;
        private void SelectProduct(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                string Ad = row.Cells[1].Value.ToString();
                float BirimFiyati = Convert.ToSingle(row.Cells[2].Value);
                string Tanim = row.Cells[3].Value.ToString();
                float Agirlik= Convert.ToSingle(row.Cells[4].Value);
                TxtAd.Text = Ad;
                TxtAgirlik.Text = Agirlik.ToString();
                TxtFiyat.Text = BirimFiyati.ToString();
                TxtTanim.Text = Tanim;

            }

        }

        private void BtnUpdate_Product_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (TxtAd.Text == "" || TxtAgirlik.Text == "" || TxtFiyat.Text == "" || TxtTanim.Text == "")
            {
                MessageBox.Show("Lütfen bütün boşlukları doldurunuz.");
            }
            else
            {
                
                if (product.UpdateProduct(id,TxtAd.Text,Convert.ToSingle(TxtFiyat.Text),
                    TxtTanim.Text,Convert.ToSingle(TxtAgirlik.Text)))
                {
                    MessageBox.Show("Ürün başarıyla güncellendi");
                    dataGridView1.DataSource = product.GetProducts();


                }
                else
                {
                    MessageBox.Show("Ürün güncellenirken bir hata oluştu ! ");
                }
            }
        }

        private void BtnDelete_Product_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (product.DeleteProduct(id))
            {
                MessageBox.Show("Ürün başarıyla silindi"); 
                dataGridView1.DataSource = product.GetProducts();
                TxtAd.Text = "";
                TxtAgirlik.Text = "";
                TxtFiyat.Text = "";
                TxtTanim.Text = "";
            }
            else
            {
                MessageBox.Show("Ürün silinirken bir hata oluştu !");
            }
        }
    }
}
