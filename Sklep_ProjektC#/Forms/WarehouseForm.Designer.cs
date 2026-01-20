using System.Drawing;

namespace SklepProjektC.Forms
{
    partial class WarehouseForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewVariants;
        private Panel topPanel;
        private Label titleLabel;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelProduct;
        private ComboBox comboBoxProduct;
        private Label labelRozmiar;
        private NumericUpDown numericUpDownRozmiar;
        private Label labelKolor;
        private NumericUpDown numericUpDownKolor;
        private Label labelStan;
        private NumericUpDown numericUpDownStan;
        private Label labelKodEAN;
        private TextBox textBoxKodEAN;
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
            dataGridViewVariants = new DataGridView();
            topPanel = new Panel();
            titleLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            labelProduct = new Label();
            comboBoxProduct = new ComboBox();
            labelRozmiar = new Label();
            numericUpDownRozmiar = new NumericUpDown();
            labelKolor = new Label();
            numericUpDownKolor = new NumericUpDown();
            labelStan = new Label();
            numericUpDownStan = new NumericUpDown();
            labelKodEAN = new Label();
            textBoxKodEAN = new TextBox();
            buttonPanel = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVariants).BeginInit();
            topPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRozmiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKolor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStan).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewVariants
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewVariants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVariants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVariants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVariants.BackgroundColor = Color.White;
            dataGridViewVariants.BorderStyle = BorderStyle.None;
            dataGridViewVariants.Location = new Point(20, 80);
            dataGridViewVariants.Name = "dataGridViewVariants";
            dataGridViewVariants.Size = new Size(760, 300);
            dataGridViewVariants.TabIndex = 2;
            dataGridViewVariants.SelectionChanged += dataGridViewVariants_SelectionChanged;
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
            titleLabel.Size = new Size(257, 27);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Zarz¹dzanie Magazynem";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(labelProduct, 0, 0);
            tableLayoutPanel.Controls.Add(comboBoxProduct, 1, 0);
            tableLayoutPanel.Controls.Add(labelRozmiar, 2, 0);
            tableLayoutPanel.Controls.Add(numericUpDownRozmiar, 3, 0);
            tableLayoutPanel.Controls.Add(labelKolor, 0, 1);
            tableLayoutPanel.Controls.Add(numericUpDownKolor, 1, 1);
            tableLayoutPanel.Controls.Add(labelStan, 2, 1);
            tableLayoutPanel.Controls.Add(numericUpDownStan, 3, 1);
            tableLayoutPanel.Controls.Add(labelKodEAN, 0, 2);
            tableLayoutPanel.Controls.Add(textBoxKodEAN, 1, 2);
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
            // labelProduct
            // 
            labelProduct.Dock = DockStyle.Fill;
            labelProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelProduct.Location = new Point(8, 5);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(114, 40);
            labelProduct.TabIndex = 0;
            labelProduct.Text = "Produkt:";
            labelProduct.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.Dock = DockStyle.Fill;
            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.Font = new Font("Segoe UI", 10F);
            comboBoxProduct.Location = new Point(130, 13);
            comboBoxProduct.Margin = new Padding(5, 8, 5, 8);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(245, 25);
            comboBoxProduct.TabIndex = 1;
            // 
            // labelRozmiar
            // 
            labelRozmiar.Dock = DockStyle.Fill;
            labelRozmiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRozmiar.Location = new Point(383, 5);
            labelRozmiar.Name = "labelRozmiar";
            labelRozmiar.Size = new Size(114, 40);
            labelRozmiar.TabIndex = 2;
            labelRozmiar.Text = "ID Rozmiaru:";
            labelRozmiar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownRozmiar
            // 
            numericUpDownRozmiar.Dock = DockStyle.Fill;
            numericUpDownRozmiar.Font = new Font("Segoe UI", 10F);
            numericUpDownRozmiar.Location = new Point(505, 13);
            numericUpDownRozmiar.Margin = new Padding(5, 8, 5, 8);
            numericUpDownRozmiar.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownRozmiar.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRozmiar.Name = "numericUpDownRozmiar";
            numericUpDownRozmiar.Size = new Size(245, 25);
            numericUpDownRozmiar.TabIndex = 3;
            numericUpDownRozmiar.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelKolor
            // 
            labelKolor.Dock = DockStyle.Fill;
            labelKolor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelKolor.Location = new Point(8, 45);
            labelKolor.Name = "labelKolor";
            labelKolor.Size = new Size(114, 40);
            labelKolor.TabIndex = 4;
            labelKolor.Text = "ID Koloru:";
            labelKolor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownKolor
            // 
            numericUpDownKolor.Dock = DockStyle.Fill;
            numericUpDownKolor.Font = new Font("Segoe UI", 10F);
            numericUpDownKolor.Location = new Point(130, 53);
            numericUpDownKolor.Margin = new Padding(5, 8, 5, 8);
            numericUpDownKolor.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownKolor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKolor.Name = "numericUpDownKolor";
            numericUpDownKolor.Size = new Size(245, 25);
            numericUpDownKolor.TabIndex = 5;
            numericUpDownKolor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelStan
            // 
            labelStan.Dock = DockStyle.Fill;
            labelStan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStan.Location = new Point(383, 45);
            labelStan.Name = "labelStan";
            labelStan.Size = new Size(114, 40);
            labelStan.TabIndex = 6;
            labelStan.Text = "Stan Magazynowy:";
            labelStan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownStan
            // 
            numericUpDownStan.Dock = DockStyle.Fill;
            numericUpDownStan.Font = new Font("Segoe UI", 10F);
            numericUpDownStan.Location = new Point(505, 53);
            numericUpDownStan.Margin = new Padding(5, 8, 5, 8);
            numericUpDownStan.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownStan.Name = "numericUpDownStan";
            numericUpDownStan.Size = new Size(245, 25);
            numericUpDownStan.TabIndex = 7;
            // 
            // labelKodEAN
            // 
            labelKodEAN.Dock = DockStyle.Fill;
            labelKodEAN.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelKodEAN.Location = new Point(8, 85);
            labelKodEAN.Name = "labelKodEAN";
            labelKodEAN.Size = new Size(114, 40);
            labelKodEAN.TabIndex = 8;
            labelKodEAN.Text = "Kod EAN:";
            labelKodEAN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxKodEAN
            // 
            textBoxKodEAN.Dock = DockStyle.Fill;
            textBoxKodEAN.Font = new Font("Segoe UI", 10F);
            textBoxKodEAN.Location = new Point(130, 93);
            textBoxKodEAN.Margin = new Padding(5, 8, 5, 8);
            textBoxKodEAN.Name = "textBoxKodEAN";
            textBoxKodEAN.Size = new Size(245, 25);
            textBoxKodEAN.TabIndex = 9;
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
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(800, 600);
            Controls.Add(buttonPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridViewVariants);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 600);
            Name = "WarehouseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Magazyn";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVariants).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRozmiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKolor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStan).EndInit();
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
