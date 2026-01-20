using System.Drawing;

namespace SklepProjektC.Forms
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewUsers;
        private Panel topPanel;
        private Label titleLabel;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelImie;
        private TextBox textBoxImie;
        private Label labelNazwisko;
        private TextBox textBoxNazwisko;
        private Label labelRola;
        private ComboBox comboBoxRola;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelHaslo;
        private TextBox textBoxHaslo;
        private FlowLayoutPanel buttonPanel;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewUsers = new DataGridView();
            topPanel = new Panel();
            titleLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            labelImie = new Label();
            textBoxImie = new TextBox();
            labelNazwisko = new Label();
            textBoxNazwisko = new TextBox();
            labelRola = new Label();
            comboBoxRola = new ComboBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelHaslo = new Label();
            textBoxHaslo = new TextBox();
            buttonPanel = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            topPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.Location = new Point(20, 80);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(760, 300);
            dataGridViewUsers.TabIndex = 2;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(33, 150, 243);
            topPanel.Controls.Add(titleLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 60);
            topPanel.TabIndex = 3;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Bahnschrift", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(20, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(290, 27);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Zarz¹dzanie U¿ytkownikami";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(labelImie, 0, 0);
            tableLayoutPanel.Controls.Add(textBoxImie, 1, 0);
            tableLayoutPanel.Controls.Add(labelNazwisko, 2, 0);
            tableLayoutPanel.Controls.Add(textBoxNazwisko, 3, 0);
            tableLayoutPanel.Controls.Add(labelRola, 0, 1);
            tableLayoutPanel.Controls.Add(comboBoxRola, 1, 1);
            tableLayoutPanel.Controls.Add(labelEmail, 2, 1);
            tableLayoutPanel.Controls.Add(textBoxEmail, 3, 1);
            tableLayoutPanel.Controls.Add(labelHaslo, 0, 2);
            tableLayoutPanel.Controls.Add(textBoxHaslo, 1, 2);
            tableLayoutPanel.Location = new Point(20, 400);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(760, 120);
            tableLayoutPanel.TabIndex = 1;
            // 
            // labelImie
            // 
            labelImie.Dock = DockStyle.Fill;
            labelImie.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelImie.Location = new Point(8, 5);
            labelImie.Name = "labelImie";
            labelImie.Size = new Size(114, 40);
            labelImie.TabIndex = 0;
            labelImie.Text = "Imie:";
            labelImie.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxImie
            // 
            textBoxImie.Dock = DockStyle.Fill;
            textBoxImie.Font = new Font("Segoe UI", 10F);
            textBoxImie.Location = new Point(130, 13);
            textBoxImie.Margin = new Padding(5, 8, 5, 8);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(245, 25);
            textBoxImie.TabIndex = 1;
            // 
            // labelNazwisko
            // 
            labelNazwisko.Dock = DockStyle.Fill;
            labelNazwisko.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelNazwisko.Location = new Point(383, 5);
            labelNazwisko.Name = "labelNazwisko";
            labelNazwisko.Size = new Size(114, 40);
            labelNazwisko.TabIndex = 2;
            labelNazwisko.Text = "Nazwisko:";
            labelNazwisko.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Dock = DockStyle.Fill;
            textBoxNazwisko.Font = new Font("Segoe UI", 10F);
            textBoxNazwisko.Location = new Point(505, 13);
            textBoxNazwisko.Margin = new Padding(5, 8, 5, 8);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(245, 25);
            textBoxNazwisko.TabIndex = 3;
            // 
            // labelRola
            // 
            labelRola.Dock = DockStyle.Fill;
            labelRola.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRola.Location = new Point(8, 45);
            labelRola.Name = "labelRola";
            labelRola.Size = new Size(114, 40);
            labelRola.TabIndex = 4;
            labelRola.Text = "Rola:";
            labelRola.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxRola
            // 
            comboBoxRola.Dock = DockStyle.Fill;
            comboBoxRola.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRola.Font = new Font("Segoe UI", 10F);
            comboBoxRola.Items.AddRange(new object[] { "W³aœciciel", "Pracownik", "Klient" });
            comboBoxRola.Location = new Point(130, 53);
            comboBoxRola.Margin = new Padding(5, 8, 5, 8);
            comboBoxRola.Name = "comboBoxRola";
            comboBoxRola.Size = new Size(245, 25);
            comboBoxRola.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.Dock = DockStyle.Fill;
            labelEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelEmail.Location = new Point(383, 45);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(114, 40);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            labelEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Font = new Font("Segoe UI", 10F);
            textBoxEmail.Location = new Point(505, 53);
            textBoxEmail.Margin = new Padding(5, 8, 5, 8);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(245, 25);
            textBoxEmail.TabIndex = 7;
            // 
            // labelHaslo
            // 
            labelHaslo.Dock = DockStyle.Fill;
            labelHaslo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelHaslo.Location = new Point(8, 85);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(114, 40);
            labelHaslo.TabIndex = 8;
            labelHaslo.Text = "Haslo:";
            labelHaslo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Dock = DockStyle.Fill;
            textBoxHaslo.Font = new Font("Segoe UI", 10F);
            textBoxHaslo.Location = new Point(130, 93);
            textBoxHaslo.Margin = new Padding(5, 8, 5, 8);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.PasswordChar = '*';
            textBoxHaslo.Size = new Size(245, 25);
            textBoxHaslo.TabIndex = 9;
            // 
            // buttonPanel
            // 
            buttonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPanel.Controls.Add(buttonAdd);
            buttonPanel.Controls.Add(buttonUpdate);
            buttonPanel.Controls.Add(buttonDelete);
            buttonPanel.Controls.Add(buttonRefresh);
            buttonPanel.Location = new Point(20, 530);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(760, 50);
            buttonPanel.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(76, 175, 80);
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(5, 5);
            buttonAdd.Margin = new Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 40);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(33, 150, 243);
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(125, 5);
            buttonUpdate.Margin = new Padding(5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(110, 40);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Aktualizuj";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(244, 67, 54);
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(245, 5);
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(110, 40);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Usun";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(158, 158, 158);
            buttonRefresh.Cursor = Cursors.Hand;
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(365, 5);
            buttonRefresh.Margin = new Padding(5);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(110, 40);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Odswiez";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(800, 600);
            Controls.Add(buttonPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridViewUsers);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 600);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uzytkownicy";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button CreateStyledButton(string text, Color color)
        {
            var btn = new Button
            {
                Text = text,
                FlatStyle = FlatStyle.Flat,
                BackColor = color,
                ForeColor = Color.White,
                Size = new Size(110, 40),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Margin = new Padding(5),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }
    }
}