using System;
using System.Windows.Forms;
using SklepProjektC.DataAccess;
using SklepProjektC.Models;
using System.Drawing;

namespace SklepProjektC.Forms
{
    public partial class UserForm : Form
    {
        private UserRepository userRepo = new UserRepository();

        public UserForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadUsers();
        }

        private void ConfigureDataGridView()
        {
            // Ustaw czcionkê bez kursywy
            dataGridViewUsers.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dataGridViewUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            
            // Wy³¹cz edycjê komórek
            dataGridViewUsers.ReadOnly = true;
        }

        private void LoadUsers()
        {
            try
            {
                var users = userRepo.ReadAll();
                dataGridViewUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User
                {
                    Imie = textBoxImie.Text,
                    Nazwisko = textBoxNazwisko.Text,
                    Rola = comboBoxRola.SelectedItem?.ToString() ?? string.Empty,
                    Email = textBoxEmail.Text,
                    HasloHash = textBoxHaslo.Text
                };
                userRepo.Create(user);
                LoadUsers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedUser = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                    selectedUser.Imie = textBoxImie.Text;
                    selectedUser.Nazwisko = textBoxNazwisko.Text;
                    selectedUser.Rola = comboBoxRola.SelectedItem?.ToString() ?? string.Empty;
                    selectedUser.Email = textBoxEmail.Text;
                    selectedUser.HasloHash = textBoxHaslo.Text;
                    userRepo.Update(selectedUser);
                    LoadUsers();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedUser = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                    userRepo.Delete(selectedUser.ID_Uzytkownika);
                    LoadUsers();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var selectedUser = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                textBoxImie.Text = selectedUser.Imie;
                textBoxNazwisko.Text = selectedUser.Nazwisko;
                
                // Ustaw wybran¹ rolê w ComboBox
                int index = comboBoxRola.FindStringExact(selectedUser.Rola);
                if (index != -1)
                {
                    comboBoxRola.SelectedIndex = index;
                }
                else
                {
                    comboBoxRola.SelectedIndex = -1;
                }
                
                textBoxEmail.Text = selectedUser.Email;
                textBoxHaslo.Text = selectedUser.HasloHash;
            }
        }

        private void ClearFields()
        {
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            comboBoxRola.SelectedIndex = -1;
            textBoxEmail.Text = "";
            textBoxHaslo.Text = "";
        }
    }
}