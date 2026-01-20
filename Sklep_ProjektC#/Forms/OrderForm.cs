using System;
using System.Windows.Forms;
using SklepProjektC.DataAccess;
using SklepProjektC.Models;
using System.Drawing;

namespace SklepProjektC.Forms
{
    public partial class OrderForm : Form
    {
        private OrderRepository orderRepo = new OrderRepository();
        private StatusRepository statusRepo = new StatusRepository();

        public OrderForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadOrders();
            LoadStatuses();
        }

        private void ConfigureDataGridView()
        {
            // Ustaw czcionkê bez kursywy
            dataGridViewOrders.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dataGridViewOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            
            // Wy³¹cz edycjê komórek
            dataGridViewOrders.ReadOnly = true;
        }

        private void LoadOrders()
        {
            try
            {
                var orders = orderRepo.ReadAll();
                dataGridViewOrders.DataSource = orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void LoadStatuses()
        {
            try
            {
                var statuses = statusRepo.ReadAll();
                comboBoxStatus.DataSource = statuses;
                comboBoxStatus.DisplayMember = "Nazwa";
                comboBoxStatus.ValueMember = "ID_Statusu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statuses: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new Order
                {
                    ID_Uzytkownika = (int)numericUpDownUserID.Value,
                    DataZamowienia = dateTimePickerData.Value,
                    ID_Statusu = (int)comboBoxStatus.SelectedValue,
                    WartoscCalkowita = numericUpDownWartosc.Value
                };
                orderRepo.Create(order);
                LoadOrders();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedOrder = (Order)dataGridViewOrders.SelectedRows[0].DataBoundItem;
                    selectedOrder.ID_Uzytkownika = (int)numericUpDownUserID.Value;
                    selectedOrder.DataZamowienia = dateTimePickerData.Value;
                    selectedOrder.ID_Statusu = (int)comboBoxStatus.SelectedValue;
                    selectedOrder.WartoscCalkowita = numericUpDownWartosc.Value;
                    orderRepo.Update(selectedOrder);
                    LoadOrders();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating order: " + ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedOrder = (Order)dataGridViewOrders.SelectedRows[0].DataBoundItem;
                    orderRepo.Delete(selectedOrder.ID_Zamowienia);
                    LoadOrders();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting order: " + ex.Message);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selectedOrder = (Order)dataGridViewOrders.SelectedRows[0].DataBoundItem;
                numericUpDownUserID.Value = selectedOrder.ID_Uzytkownika;
                dateTimePickerData.Value = selectedOrder.DataZamowienia;
                comboBoxStatus.SelectedValue = selectedOrder.ID_Statusu;
                numericUpDownWartosc.Value = selectedOrder.WartoscCalkowita;
            }
        }

        private void ClearFields()
        {
            numericUpDownUserID.Value = 1;
            dateTimePickerData.Value = DateTime.Now;
            comboBoxStatus.SelectedIndex = -1;
            numericUpDownWartosc.Value = 0;
        }
    }
}