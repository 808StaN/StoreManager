using System;
using System.Windows.Forms;
using SklepProjektC.DataAccess;
using SklepProjektC.Models;
using System.Drawing;

namespace SklepProjektC.Forms
{
    public partial class ReturnForm : Form
    {
        private ReturnRepository returnRepo;

        public ReturnForm()
        {
            InitializeComponent();
            returnRepo = new ReturnRepository();
            ConfigureDataGridView();
            LoadReturns();
        }

        // Ustawia wygl¹d tabeli
        private void ConfigureDataGridView()
        {
            dataGridViewReturns.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dataGridViewReturns.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewReturns.ReadOnly = true;
        }

        // £aduje wszystkie zwroty z bazy
        private void LoadReturns()
        {
            try
            {
                var returns = returnRepo.ReadAll();
                dataGridViewReturns.DataSource = returns;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading returns: " + ex.Message);
            }
        }

        // Dodaje nowy zwrot do bazy
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var returnItem = new Return
                {
                    ID_Zamowienia = (int)numericUpDownOrderID.Value,
                    Powod = textBoxPowod.Text,
                    StatusZwrotu = comboBoxStatus.SelectedItem?.ToString() ?? string.Empty
                };
                returnRepo.Create(returnItem);
                LoadReturns();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding return: " + ex.Message);
            }
        }

        // Aktualizuje zaznaczony zwrot
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewReturns.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedReturn = (Return)dataGridViewReturns.SelectedRows[0].DataBoundItem;
                    selectedReturn.ID_Zamowienia = (int)numericUpDownOrderID.Value;
                    selectedReturn.Powod = textBoxPowod.Text;
                    selectedReturn.StatusZwrotu = comboBoxStatus.SelectedItem?.ToString() ?? string.Empty;
                    returnRepo.Update(selectedReturn);
                    LoadReturns();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating return: " + ex.Message);
                }
            }
        }

        // Usuwa zaznaczony zwrot
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewReturns.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedReturn = (Return)dataGridViewReturns.SelectedRows[0].DataBoundItem;
                    returnRepo.Delete(selectedReturn.ID_Zwrotu);
                    LoadReturns();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting return: " + ex.Message);
                }
            }
        }

        // Odœwie¿a listê zwrotów
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadReturns();
        }

        // Wype³nia formularz danymi zaznaczonego zwrotu
        private void dataGridViewReturns_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewReturns.SelectedRows.Count > 0)
            {
                var selectedReturn = (Return)dataGridViewReturns.SelectedRows[0].DataBoundItem;
                numericUpDownOrderID.Value = selectedReturn.ID_Zamowienia;
                textBoxPowod.Text = selectedReturn.Powod;
                
                // Ustaw status w ComboBox
                if (!string.IsNullOrEmpty(selectedReturn.StatusZwrotu))
                {
                    int index = comboBoxStatus.FindStringExact(selectedReturn.StatusZwrotu.Trim());
                    if (index != -1)
                    {
                        comboBoxStatus.SelectedIndex = index;
                    }
                    else
                    {
                        comboBoxStatus.SelectedIndex = -1;
                    }
                }
                else
                {
                    comboBoxStatus.SelectedIndex = -1;
                }
            }
        }

        // Czyœci wszystkie pola formularza
        private void ClearFields()
        {
            numericUpDownOrderID.Value = 1;
            textBoxPowod.Clear();
            comboBoxStatus.SelectedIndex = -1;
        }
    }
}
