using System.Drawing;

namespace SklepProjektC.Forms
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel topPanel;
        private Label titleLabel;
        private DataGridView dataGridViewProducts;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelNazwa;
        private TextBox textBoxNazwa;
        private Label labelOpis;
        private TextBox textBoxOpis;
        private Label labelCena;
        private NumericUpDown numericUpDownCena;
        private Label labelKategoria;
        private ComboBox comboBoxCategory;
        private Label labelMarka;
        private ComboBox comboBoxMarka;
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
            dataGridViewProducts = new DataGridView();
            topPanel = new Panel();
            titleLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            labelNazwa = new Label();
            textBoxNazwa = new TextBox();
            labelCena = new Label();
            numericUpDownCena = new NumericUpDown();
            labelOpis = new Label();
            textBoxOpis = new TextBox();
            labelKategoria = new Label();
            comboBoxCategory = new ComboBox();
            labelMarka = new Label();
            comboBoxMarka = new ComboBox();
            buttonPanel = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            topPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCena).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.Location = new Point(20, 80);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(760, 300);
            dataGridViewProducts.TabIndex = 2;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
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
            titleLabel.Size = new Size(253, 27);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Zarządzanie Produktami";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(labelNazwa, 0, 0);
            tableLayoutPanel.Controls.Add(textBoxNazwa, 1, 0);
            tableLayoutPanel.Controls.Add(labelCena, 2, 0);
            tableLayoutPanel.Controls.Add(numericUpDownCena, 3, 0);
            tableLayoutPanel.Controls.Add(labelOpis, 0, 1);
            tableLayoutPanel.Controls.Add(textBoxOpis, 1, 1);
            tableLayoutPanel.Controls.Add(labelKategoria, 2, 1);
            tableLayoutPanel.Controls.Add(comboBoxCategory, 3, 1);
            tableLayoutPanel.Controls.Add(labelMarka, 0, 2);
            tableLayoutPanel.Controls.Add(comboBoxMarka, 1, 2);
            tableLayoutPanel.Location = new Point(20, 390);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(760, 120);
            tableLayoutPanel.TabIndex = 1;
            // 
            // labelNazwa
            // 
            labelNazwa.Dock = DockStyle.Fill;
            labelNazwa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelNazwa.Location = new Point(8, 5);
            labelNazwa.Name = "labelNazwa";
            labelNazwa.Size = new Size(114, 40);
            labelNazwa.TabIndex = 0;
            labelNazwa.Text = "Nazwa:";
            labelNazwa.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxNazwa
            // 
            textBoxNazwa.Dock = DockStyle.Fill;
            textBoxNazwa.Font = new Font("Segoe UI", 10F);
            textBoxNazwa.Location = new Point(130, 13);
            textBoxNazwa.Margin = new Padding(5, 8, 5, 8);
            textBoxNazwa.Name = "textBoxNazwa";
            textBoxNazwa.Size = new Size(245, 25);
            textBoxNazwa.TabIndex = 1;
            // 
            // labelCena
            // 
            labelCena.Dock = DockStyle.Fill;
            labelCena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCena.Location = new Point(383, 5);
            labelCena.Name = "labelCena";
            labelCena.Size = new Size(114, 40);
            labelCena.TabIndex = 2;
            labelCena.Text = "Cena:";
            labelCena.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownCena
            // 
            numericUpDownCena.DecimalPlaces = 2;
            numericUpDownCena.Dock = DockStyle.Fill;
            numericUpDownCena.Font = new Font("Segoe UI", 10F);
            numericUpDownCena.Location = new Point(505, 13);
            numericUpDownCena.Margin = new Padding(5, 8, 5, 8);
            numericUpDownCena.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownCena.Name = "numericUpDownCena";
            numericUpDownCena.Size = new Size(245, 25);
            numericUpDownCena.TabIndex = 3;
            // 
            // labelOpis
            // 
            labelOpis.Dock = DockStyle.Fill;
            labelOpis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelOpis.Location = new Point(8, 45);
            labelOpis.Name = "labelOpis";
            labelOpis.Size = new Size(114, 40);
            labelOpis.TabIndex = 4;
            labelOpis.Text = "Opis:";
            labelOpis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxOpis
            // 
            textBoxOpis.Dock = DockStyle.Fill;
            textBoxOpis.Font = new Font("Segoe UI", 10F);
            textBoxOpis.Location = new Point(130, 53);
            textBoxOpis.Margin = new Padding(5, 8, 5, 8);
            textBoxOpis.Name = "textBoxOpis";
            textBoxOpis.Size = new Size(245, 25);
            textBoxOpis.TabIndex = 5;
            // 
            // labelKategoria
            // 
            labelKategoria.Dock = DockStyle.Fill;
            labelKategoria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelKategoria.Location = new Point(383, 45);
            labelKategoria.Name = "labelKategoria";
            labelKategoria.Size = new Size(114, 40);
            labelKategoria.TabIndex = 6;
            labelKategoria.Text = "Kategoria:";
            labelKategoria.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Dock = DockStyle.Fill;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.Location = new Point(505, 53);
            comboBoxCategory.Margin = new Padding(5, 8, 5, 8);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(245, 25);
            comboBoxCategory.TabIndex = 7;
            // 
            // labelMarka
            // 
            labelMarka.Dock = DockStyle.Fill;
            labelMarka.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelMarka.Location = new Point(8, 85);
            labelMarka.Name = "labelMarka";
            labelMarka.Size = new Size(114, 40);
            labelMarka.TabIndex = 8;
            labelMarka.Text = "Marka:";
            labelMarka.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxMarka
            // 
            comboBoxMarka.Dock = DockStyle.Fill;
            comboBoxMarka.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarka.Font = new Font("Segoe UI", 10F);
            comboBoxMarka.Location = new Point(130, 93);
            comboBoxMarka.Margin = new Padding(5, 8, 5, 8);
            comboBoxMarka.Name = "comboBoxMarka";
            comboBoxMarka.Size = new Size(245, 25);
            comboBoxMarka.TabIndex = 9;
            // 
            // buttonPanel
            // 
            buttonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPanel.Controls.Add(buttonAdd);
            buttonPanel.Controls.Add(buttonUpdate);
            buttonPanel.Controls.Add(buttonDelete);
            buttonPanel.Controls.Add(buttonRefresh);
            buttonPanel.Location = new Point(20, 520);
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
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(800, 600);
            Controls.Add(buttonPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridViewProducts);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 600);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produkty";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCena).EndInit();
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