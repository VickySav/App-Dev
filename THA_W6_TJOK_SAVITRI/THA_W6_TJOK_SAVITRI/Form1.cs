using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace THA_W6_TJOK_SAVITRI
{
    public partial class Form1 : Form
    {
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        List<string> idCategory = new List<string>();
        List<string> idproduct = new List<string>();
        List<Product> listProduct = new List<Product>();
        List<Category> listCategory = new List<Category>();
        public Form1()
        {
            InitializeComponent();
            listProduct = new List<Product> // add product
            {
                new Product("J001","Jas Hitam", 100000, 10, "C1","Jas"),
                new Product("T001","T-Shirt Black Pink", 70000, 20, "C2","T-Shirt"),
                new Product("T002","T-Shirt Obsessive", 75000, 16, "C2","T-Shirt"),
                new Product("R001","Rok Mini", 82000, 26, "C3","Rok"),
                new Product("J002", "Jeans Biru", 90000, 5, "C4","Celana"),
                new Product("C001","Celana Pendek Coklat", 60000, 11, "C4","Celana"),
                new Product("C002","Cawat Blink-blink", 1000000, 1, "C5","Cawat"),
                new Product("R002","Rocca Shirt", 50000, 8, "C2","T-Shirt")
            };
            listCategory = new List<Category> // add category
            {
                new Category("C1","Jas"),
                new Category("C2","T-Shirt"),
                new Category("C3","Rok"),
                new Category("C4","Celana"),
                new Category("C5","Cawat")
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            dgvProduct.DataSource = dtProdukSimpan;

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            dgvCategory.DataSource = dtCategory;

            dgvProduct.ForeColor = Color.Sienna;
            dgvCategory.ForeColor = Color.Sienna;

            foreach (Product product in listProduct) // print category
            {
                dtProdukSimpan.Rows.Add(product.idProduct, product.namaProduct, product.harga, product.stock, product.idCategory);

                if (!comboBoxCategory.Items.Contains(product.category))
                {
                    comboBoxCategory.Items.Add(product.category);
                }
            }
            updateCategory();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilter.Items.Clear();
            comboBoxFilter.Enabled = true;
            updateCategory();
        }

        private void comboBoxFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtProdukTampil.Clear();
            foreach (Product product in listProduct)
            {
                if (comboBoxFilter.Text == product.category)
                {
                    dtProdukTampil.Rows.Add(product.idProduct, product.namaProduct, product.harga, product.stock, product.idCategory);
                    dgvProduct.DataSource = dtProdukTampil;
                }
            }
            comboBoxCategory.SelectedItem = null;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = dtProdukSimpan;
            comboBoxFilter.Enabled = false;
            comboBoxFilter.SelectedItem = null; comboBoxCategory.SelectedItem = null;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string namaBarang = textBoxNama.Text;
            namaBarang = namaBarang.ToUpper();
            bool ada = true;
            bool found = false;
            if (textBoxNama.Text == "" || textBoxHarga.Text == "" || textBoxStock.Text == "" || comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("INPUT YANG LENGKAP");
            }

            if (textBoxNama.Text != "" && textBoxHarga.Text != "" && textBoxStock.Text != "" && comboBoxCategory.SelectedItem != null)
            {
                char a = namaBarang[0];
                string idData = "";
                string idBaru = "";
                foreach (Product product in listProduct)
                {
                    idData = product.idProduct;
                    char simpan = idData[0];
                    if (a == simpan)
                    {
                        idBaru = idData;
                        found = true;         
                    }
                }
                if (found == false)
                {
                    idBaru = a + "000";
                }
                string num = idBaru[1].ToString() + idBaru[2].ToString() + idBaru[3].ToString();
                int number = Convert.ToInt32(num);
                number++;
                if (ada == true)
                {
                    if (number <= 9)
                        idBaru = a + "00" + number.ToString();
                    else if (number <= 99)
                        idBaru = a + "0" + number.ToString();
                    else
                        idBaru = a + number.ToString();
                }
                string idCatgor = "";
                foreach (Category category in listCategory)
                {
                    if (comboBoxCategory.Text == category.category)
                    {
                        idCatgor = category.idCategory;
                    }
                }
                Product productz = new Product(idBaru, textBoxNama.Text, Convert.ToInt32(textBoxHarga.Text), Convert.ToInt32(textBoxStock.Text), idCatgor, comboBoxCategory.SelectedItem.ToString());
                listProduct.Add(productz);
                buttonAll.PerformClick();
                updateList();
                textBoxNama.Clear(); textBoxHarga.Clear(); textBoxStock.Clear(); comboBoxCategory.SelectedItem = null;
            }
        }

        public void updateList()
        {
            dtProdukSimpan.Clear();
            foreach (Product product in listProduct)
            {
                dtProdukSimpan.Rows.Add(product.idProduct, product.namaProduct, product.harga, product.stock, product.idCategory);
            }
        }

        public void updateCategory()
        {
            dtCategory.Clear(); comboBoxCategory.Items.Clear(); comboBoxFilter.Items.Clear();
            foreach (Category category in listCategory)
            {
                dtCategory.Rows.Add(category.idCategory, category.category);
                comboBoxCategory.Items.Add(category.category);
                comboBoxFilter.Items.Add(category.category);
            }
        }

        private void textBoxHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNama.Text = dgvProduct.CurrentRow.Cells["Nama Product"].Value.ToString();
            foreach (Category category in listCategory)
            {
                if (dgvProduct.CurrentRow.Cells["ID Category"].Value.ToString() == category.idCategory)
                {
                    comboBoxCategory.Text = category.category;
                }
            }
            textBoxHarga.Text = dgvProduct.CurrentRow.Cells["Harga"].Value.ToString();
            textBoxStock.Text = dgvProduct.CurrentRow.Cells["Stock"].Value.ToString();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCategory.Text = dgvCategory.CurrentRow.Cells["Nama Category"].Value.ToString();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            int index = dgvProduct.CurrentCell.RowIndex;
            if (dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih produk yang mau diedit dulu");
            }
            else if (Convert.ToInt32(textBoxStock.Text) > 0)
            {
                string idCatgor = "";
                foreach (Product product in listProduct)
                {
                    if (comboBoxCategory.Text == product.category)
                    {
                        idCatgor = product.idCategory;
                    }
                }

                listProduct[index].namaProduct = textBoxNama.Text;
                listProduct[index].category = comboBoxCategory.SelectedItem.ToString();
                listProduct[index].idCategory = idCatgor;
                listProduct[index].harga = Convert.ToInt32(textBoxHarga.Text);
                listProduct[index].stock = Convert.ToInt32(textBoxStock.Text);
            }
            else
            {
                listProduct.RemoveAt(index);
            }
            buttonAll.PerformClick();  updateList();
            textBoxNama.Clear(); textBoxHarga.Clear(); textBoxStock.Clear(); comboBoxCategory.SelectedItem = null;
        }
        private void dgvProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProduct.ClearSelection(); dgvCategory.ClearSelection();
            textBoxNama.Text = ""; textBoxHarga.Text = ""; textBoxStock.Text = "";
        }
        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count != 0)
            {
                int index = dgvProduct.CurrentCell.RowIndex;
                listProduct.RemoveAt(index);
                buttonAll.PerformClick(); updateList();
                textBoxNama.Clear(); textBoxHarga.Clear(); textBoxStock.Clear(); comboBoxCategory.SelectedItem = null;
            }
        }
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {    
            string idCatgor = "C" + (listCategory.Count + 1).ToString();
            if (textBoxCategory.Text =="")
            {
                MessageBox.Show("Isi nama category terlebih dahulu");
            } else
            {
                bool found = false;
                foreach (Category category in listCategory)
                {
                    if (textBoxCategory.Text == category.category)
                    {
                        found = true;
                    }
                }
                if (found == false)
                {
                    Category category = new Category(idCatgor, textBoxCategory.Text);
                    listCategory.Add(category);                
                }
                else
                {
                    MessageBox.Show("Category sudah ada");
                }
            }
            updateCategory(); buttonAll.PerformClick();
            textBoxCategory.Clear();
        }
        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            int index = dgvCategory.CurrentCell.RowIndex;
            if (dgvCategory.SelectedRows.Count != 0)
            {
                for (int i = 0; i < listProduct.Count; i++)
                {
                    if (listProduct[i].category == listCategory[index].category)
                    {
                        listProduct.RemoveAt(i);
                        i = -1;
                    }
                }
                listCategory.RemoveAt(index);
            }
            buttonAll.PerformClick(); updateCategory(); updateList(); textBoxCategory.Clear(); comboBoxCategory.SelectedItem = null;
        }
    }
}

