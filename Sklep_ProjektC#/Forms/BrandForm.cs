using System;
using System.Windows.Forms;
using SklepProjektC.DataAccess;
using SklepProjektC.Models;
using System.Drawing;

namespace SklepProjektC.Forms
{
    public partial class BrandForm : Form
    {
        private BrandRepository brandRepo;

        public BrandForm()
        {
            InitializeComponent();
            brandRepo = new BrandRepository();
            ConfigureDataGridView();
            LoadBrands();
        }

        private void ConfigureDataGridView()
        {
            // Ustaw czcionkê bez kursywy
            dataGridViewBrands.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dataGridViewBrands.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            
            // Wy³¹cz edycjê komórek
            dataGridViewBrands.ReadOnly = true;
        }

        private void LoadBrands()
        {
            try
            {
                var brands = brandRepo.ReadAll();
                dataGridViewBrands.DataSource = brands;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading brands: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                var brand = new Brand
                {
                    Nazwa = textBoxNazwa.Text,
                    Opis = textBoxOpis.Text
                };
                brandRepo.Create(brand);
                LoadBrands();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding brand: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewBrands.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedBrand = (Brand)dataGridViewBrands.SelectedRows[0].DataBoundItem;
                    selectedBrand.Nazwa = textBoxNazwa.Text;
                    selectedBrand.Opis = textBoxOpis.Text;
                    brandRepo.Update(selectedBrand);
                    LoadBrands();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating brand: " + ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBrands.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedBrand = (Brand)dataGridViewBrands.SelectedRows[0].DataBoundItem;
                    brandRepo.Delete(selectedBrand.ID_Marki);
                    LoadBrands();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting brand: " + ex.Message);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadBrands();
        }

        private void dataGridViewBrands_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBrands.SelectedRows.Count > 0)
            {
                var selectedBrand = (Brand)dataGridViewBrands.SelectedRows[0].DataBoundItem;
                textBoxNazwa.Text = selectedBrand.Nazwa;
                textBoxOpis.Text = selectedBrand.Opis;
            }
        }

        private void ClearFields()
        {
            textBoxNazwa.Clear();
            textBoxOpis.Clear();
        }
    }
}
