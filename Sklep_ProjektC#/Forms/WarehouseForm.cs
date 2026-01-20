using System;
using System.Windows.Forms;
using SklepProjektC.DataAccess;
using SklepProjektC.Models;
using System.Drawing;

namespace SklepProjektC.Forms
{
    public partial class WarehouseForm : Form
    {
        private ProductVariantRepository variantRepo;
        private ProductRepository productRepo;

        public WarehouseForm()
        {
            InitializeComponent();
            variantRepo = new ProductVariantRepository();
            productRepo = new ProductRepository();
            ConfigureDataGridView();
            LoadVariants();
            LoadProducts();
        }

        private void ConfigureDataGridView()
        {
            // Ustaw czcionkê bez kursywy
            dataGridViewVariants.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dataGridViewVariants.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Wy³¹cz edycjê komórek
            dataGridViewVariants.ReadOnly = true;
        }

        private void LoadVariants()
        {
            try
            {
                var variants = variantRepo.ReadAll();
                dataGridViewVariants.DataSource = variants;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading warehouse data: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                var products = productRepo.ReadAll();
                comboBoxProduct.DataSource = products;
                comboBoxProduct.DisplayMember = "Nazwa";
                comboBoxProduct.ValueMember = "ID_Produktu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var variant = new ProductVariant
                {
                    ID_Produktu = (int)comboBoxProduct.SelectedValue,
                    ID_Rozmiaru = (int)numericUpDownRozmiar.Value,
                    ID_Koloru = (int)numericUpDownKolor.Value,
                    StanMagazynowy = (int)numericUpDownStan.Value,
                    KodEAN = textBoxKodEAN.Text
                };
                variantRepo.Create(variant);
                LoadVariants();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding variant: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewVariants.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedVariant = (ProductVariant)dataGridViewVariants.SelectedRows[0].DataBoundItem;
                    selectedVariant.ID_Produktu = (int)comboBoxProduct.SelectedValue;
                    selectedVariant.ID_Rozmiaru = (int)numericUpDownRozmiar.Value;
                    selectedVariant.ID_Koloru = (int)numericUpDownKolor.Value;
                    selectedVariant.StanMagazynowy = (int)numericUpDownStan.Value;
                    selectedVariant.KodEAN = textBoxKodEAN.Text;
                    variantRepo.Update(selectedVariant);
                    LoadVariants();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating variant: " + ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewVariants.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedVariant = (ProductVariant)dataGridViewVariants.SelectedRows[0].DataBoundItem;
                    variantRepo.Delete(selectedVariant.ID_Wariantu);
                    LoadVariants();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting variant: " + ex.Message);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadVariants();
        }

        private void dataGridViewVariants_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVariants.SelectedRows.Count > 0)
            {
                var selectedVariant = (ProductVariant)dataGridViewVariants.SelectedRows[0].DataBoundItem;
                comboBoxProduct.SelectedValue = selectedVariant.ID_Produktu;
                numericUpDownRozmiar.Value = selectedVariant.ID_Rozmiaru;
                numericUpDownKolor.Value = selectedVariant.ID_Koloru;
                numericUpDownStan.Value = selectedVariant.StanMagazynowy;
                textBoxKodEAN.Text = selectedVariant.KodEAN;
            }
        }

        private void ClearFields()
        {
            comboBoxProduct.SelectedIndex = -1;
            numericUpDownRozmiar.Value = 1;
            numericUpDownKolor.Value = 1;
            numericUpDownStan.Value = 0;
            textBoxKodEAN.Clear();
        }
    }
}
