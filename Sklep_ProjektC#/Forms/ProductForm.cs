using System;
using System.Windows.Forms;
using SklepProjektC.DataAccess;
using SklepProjektC.Models;
using System.Drawing;

namespace SklepProjektC.Forms
{
    public partial class ProductForm : Form
    {
        private ProductRepository productRepo;
        private CategoryRepository categoryRepo;
        private BrandRepository brandRepo;

        public ProductForm()
        {
            InitializeComponent();
            productRepo = new ProductRepository();
            categoryRepo = new CategoryRepository();
            brandRepo = new BrandRepository();
            ConfigureDataGridView();
            LoadProducts();
            LoadCategories();
            LoadBrands();
        }

        // Ustawia wygl¹d tabeli
        private void ConfigureDataGridView()
        {
            dataGridViewProducts.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewProducts.ReadOnly = true;
        }

        // £aduje wszystkie produkty z bazy
        private void LoadProducts()
        {
            try
            {
                var products = productRepo.ReadAll();
                dataGridViewProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        // Wype³nia listê rozwijan¹ kategoriami
        private void LoadCategories()
        {
            try
            {
                var categories = categoryRepo.ReadAll();
                comboBoxCategory.DataSource = categories;
                comboBoxCategory.DisplayMember = "Nazwa";
                comboBoxCategory.ValueMember = "ID_Kategorii";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        // Wype³nia listê rozwijan¹ markami
        private void LoadBrands()
        {
            try
            {
                var brands = brandRepo.ReadAll();
                comboBoxMarka.DataSource = brands;
                comboBoxMarka.DisplayMember = "Nazwa";
                comboBoxMarka.ValueMember = "ID_Marki";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading brands: " + ex.Message);
            }
        }

        // Dodaje nowy produkt do bazy
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    Nazwa = textBoxNazwa.Text,
                    Opis = textBoxOpis.Text,
                    CenaBazowa = numericUpDownCena.Value,
                    ID_Kategorii = (int)comboBoxCategory.SelectedValue,
                    ID_Marki = (int)comboBoxMarka.SelectedValue
                };
                productRepo.Create(product);
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        // Aktualizuje zaznaczony produkt
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                    selectedProduct.Nazwa = textBoxNazwa.Text;
                    selectedProduct.Opis = textBoxOpis.Text;
                    selectedProduct.CenaBazowa = numericUpDownCena.Value;
                    selectedProduct.ID_Kategorii = (int)comboBoxCategory.SelectedValue;
                    selectedProduct.ID_Marki = (int)comboBoxMarka.SelectedValue;
                    productRepo.Update(selectedProduct);
                    LoadProducts();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product: " + ex.Message);
                }
            }
        }

        // Usuwa zaznaczony produkt
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                    productRepo.Delete(selectedProduct.ID_Produktu);
                    LoadProducts();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message);
                }
            }
        }

        // Odœwie¿a listê produktów
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // Wype³nia formularz danymi zaznaczonego produktu
        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                textBoxNazwa.Text = selectedProduct.Nazwa;
                textBoxOpis.Text = selectedProduct.Opis;
                numericUpDownCena.Value = selectedProduct.CenaBazowa;
                comboBoxCategory.SelectedValue = selectedProduct.ID_Kategorii;
                comboBoxMarka.SelectedValue = selectedProduct.ID_Marki;
            }
        }

        // Czyœci wszystkie pola formularza
        private void ClearFields()
        {
            textBoxNazwa.Clear();
            textBoxOpis.Clear();
            numericUpDownCena.Value = 0;
            comboBoxCategory.SelectedIndex = -1;
            comboBoxMarka.SelectedIndex = -1;
        }
    }
}