using System;
using System.Windows.Forms;
using System.Drawing;
using SklepProjektC.DataAccess;

namespace SklepProjektC.Forms
{
    public partial class LoginForm : Form
    {
        public bool LoginSuccessful { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterLoginPanel();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterLoginPanel();
        }

        private void CenterLoginPanel()
        {
            // Wyœrodkowanie panelu w pionie i poziomie
            loginPanel.Left = (this.ClientSize.Width - loginPanel.Width) / 2;
            loginPanel.Top = (this.ClientSize.Height - loginPanel.Height) / 2;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxServer.Text) ||
                string.IsNullOrWhiteSpace(textBoxDatabase.Text) ||
                string.IsNullOrWhiteSpace(textBoxUserId.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Wszystkie pola s¹ wymagane!", "B³¹d", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            labelStatus.Text = "£¹czenie z baz¹...";
            labelStatus.ForeColor = Color.Orange;
            Application.DoEvents();

            string server = textBoxServer.Text.Trim();
            string database = textBoxDatabase.Text.Trim();
            string userId = textBoxUserId.Text.Trim();
            string password = textBoxPassword.Text;

            DatabaseHelper.SetConnectionString(server, database, userId, password);

            if (DatabaseHelper.TestConnection())
            {
                LoginSuccessful = true;
                labelStatus.Text = "Po³¹czono pomyœlnie!";
                labelStatus.ForeColor = Color.Green;
                
                // Zamknij okno po pomyœlnym po³¹czeniu
                this.Close();
            }
            else
            {
                LoginSuccessful = false;
                labelStatus.Text = "B³¹d po³¹czenia. SprawdŸ dane logowania.";
                labelStatus.ForeColor = Color.Red;
                DatabaseHelper.ClearConnection();
                MessageBox.Show("Nie uda³o siê po³¹czyæ z baz¹ danych.\nSprawdŸ poprawnoœæ danych logowania.", 
                    "B³¹d po³¹czenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoginSuccessful = false;
            this.Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
    }
}
