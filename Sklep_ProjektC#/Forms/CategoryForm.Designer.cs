using System.Drawing;

namespace SklepProjektC.Forms
{
    partial class CategoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewCategories;
        private Panel topPanel;
        private Label titleLabel;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelIDRodzica;
        private NumericUpDown numericUpDownIDRodzica;
        private Label labelNazwa;
        private TextBox textBoxNazwa;
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
            dataGridViewCategories = new DataGridView();
            topPanel = new Panel();
            titleLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            labelIDRodzica = new Label();
            numericUpDownIDRodzica = new NumericUpDown();
            labelNazwa = new Label();
            textBoxNazwa = new TextBox();
            buttonPanel = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            topPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDRodzica).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.BackgroundColor = Color.White;
            dataGridViewCategories.BorderStyle = BorderStyle.None;
            dataGridViewCategories.Location = new Point(20, 80);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.Size = new Size(760, 300);
            dataGridViewCategories.TabIndex = 2;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged;
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
            titleLabel.Size = new Size(260, 27);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Zarz¹dzanie Kategoriami";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelIDRodzica, 0, 0);
            tableLayoutPanel.Controls.Add(numericUpDownIDRodzica, 1, 0);
            tableLayoutPanel.Controls.Add(labelNazwa, 0, 1);
            tableLayoutPanel.Controls.Add(textBoxNazwa, 1, 1);
            tableLayoutPanel.Location = new Point(20, 400);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(760, 80);
            tableLayoutPanel.TabIndex = 1;
            // 
            // labelIDRodzica
            // 
            labelIDRodzica.Dock = DockStyle.Fill;
            labelIDRodzica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelIDRodzica.Location = new Point(8, 5);
            labelIDRodzica.Name = "labelIDRodzica";
            labelIDRodzica.Size = new Size(114, 40);
            labelIDRodzica.TabIndex = 0;
            labelIDRodzica.Text = "ID Rodzica:";
            labelIDRodzica.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownIDRodzica
            // 
            numericUpDownIDRodzica.Dock = DockStyle.Fill;
            numericUpDownIDRodzica.Font = new Font("Segoe UI", 10F);
            numericUpDownIDRodzica.Location = new Point(130, 13);
            numericUpDownIDRodzica.Margin = new Padding(5, 8, 5, 8);
            numericUpDownIDRodzica.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownIDRodzica.Name = "numericUpDownIDRodzica";
            numericUpDownIDRodzica.Size = new Size(620, 25);
            numericUpDownIDRodzica.TabIndex = 1;
            // 
            // labelNazwa
            // 
            labelNazwa.Dock = DockStyle.Fill;
            labelNazwa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelNazwa.Location = new Point(8, 45);
            labelNazwa.Name = "labelNazwa";
            labelNazwa.Size = new Size(114, 40);
            labelNazwa.TabIndex = 2;
            labelNazwa.Text = "Nazwa:";
            labelNazwa.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxNazwa
            // 
            textBoxNazwa.Dock = DockStyle.Fill;
            textBoxNazwa.Font = new Font("Segoe UI", 10F);
            textBoxNazwa.Location = new Point(130, 53);
            textBoxNazwa.Margin = new Padding(5, 8, 5, 8);
            textBoxNazwa.Name = "textBoxNazwa";
            textBoxNazwa.Size = new Size(620, 25);
            textBoxNazwa.TabIndex = 3;
            // 
            // buttonPanel
            // 
            buttonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPanel.Controls.Add(buttonAdd);
            buttonPanel.Controls.Add(buttonUpdate);
            buttonPanel.Controls.Add(buttonDelete);
            buttonPanel.Controls.Add(buttonRefresh);
            buttonPanel.Location = new Point(20, 490);
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
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(800, 600);
            Controls.Add(buttonPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridViewCategories);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 600);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategorie";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDRodzica).EndInit();
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