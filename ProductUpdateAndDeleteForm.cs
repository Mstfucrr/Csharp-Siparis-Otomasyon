using System;
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
            dataGridView1.DataSource = product.GetProducts("*");
            // TODO: Bu kod satırı 'productDataSet.Products' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.productsTableAdapter.Fill(this.productDataSet.Products);
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[5].HeaderText = "Eklenme Tarihi";
            BtnDelete_Product.Enabled = false;
            BtnUpdate_Product.Enabled = false;

        }

        int id;
        private void SelectProduct(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!BtnDelete_Product.Enabled && !BtnUpdate_Product.Enabled)
                {
                    BtnUpdate_Product.Enabled = true;
                    BtnDelete_Product.Enabled = true;
                }
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                TxtAd.Text = row.Cells[1].Value.ToString();
                TxtAgirlik.Text = Convert.ToSingle(row.Cells[4].Value).ToString();
                TxtFiyat.Text = Convert.ToSingle(row.Cells[2].Value).ToString();
                TxtTanim.Text = row.Cells[3].Value.ToString();

            }
            catch (Exception)
            { }

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
                    dataGridView1.DataSource = product.GetProducts("*");
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
            
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz? ", "Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (product.DeleteProduct(id))
                {
                    MessageBox.Show("Ürün başarıyla silindi");
                    dataGridView1.DataSource = product.GetProducts("*");
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
}
