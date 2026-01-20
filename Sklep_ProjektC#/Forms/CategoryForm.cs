using System;
using System.Windows.Forms;
using SklepProjektC.DataAccess;
using SklepProjektC.Models;
using System.Drawing;

namespace SklepProjektC.Forms
{
    public partial class CategoryForm : Form
    {
        private CategoryRepository categoryRepo = new CategoryRepository();

        public CategoryForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadCategories();
        }

        private void ConfigureDataGridView()
        {
            // Ustaw czcionkê bez kursywy
            dataGridViewCategories.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dataGridViewCategories.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            
            // Wy³¹cz edycjê komórek
            dataGridViewCategories.ReadOnly = true;
        }

        private void LoadCategories()
        {
            try
            {
                var categories = categoryRepo.ReadAll();
                dataGridViewCategories.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category
                {
                    ID_Rodzica = numericUpDownIDRodzica.Value == 0 ? (int?)null : (int)numericUpDownIDRodzica.Value,
                    Nazwa = textBoxNazwa.Text
                };
                categoryRepo.Create(category);
                LoadCategories();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedCategory = (Category)dataGridViewCategories.SelectedRows[0].DataBoundItem;
                    selectedCategory.ID_Rodzica = numericUpDownIDRodzica.Value == 0 ? (int?)null : (int)numericUpDownIDRodzica.Value;
                    selectedCategory.Nazwa = textBoxNazwa.Text;
                    categoryRepo.Update(selectedCategory);
                    LoadCategories();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating category: " + ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedCategory = (Category)dataGridViewCategories.SelectedRows[0].DataBoundItem;
                    categoryRepo.Delete(selectedCategory.ID_Kategorii);
                    LoadCategories();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count > 0)
            {
                var selectedCategory = (Category)dataGridViewCategories.SelectedRows[0].DataBoundItem;
                numericUpDownIDRodzica.Value = selectedCategory.ID_Rodzica ?? 0;
                textBoxNazwa.Text = selectedCategory.Nazwa;
            }
        }

        private void ClearFields()
        {
            numericUpDownIDRodzica.Value = 0;
            textBoxNazwa.Text = "";
        }
    }
}