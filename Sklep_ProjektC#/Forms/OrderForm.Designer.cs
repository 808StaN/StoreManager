using System.Drawing;
namespace SklepProjektC.Forms
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewOrders;
        private Panel topPanel;
        private Label titleLabel;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelUser;
        private NumericUpDown numericUpDownUserID;
        private Label labelData;
        private DateTimePicker dateTimePickerData;
        private Label labelStatus;
        private ComboBox comboBoxStatus;
        private Label labelWartosc;
        private NumericUpDown numericUpDownWartosc;
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
            dataGridViewOrders = new DataGridView();
            topPanel = new Panel();
            titleLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            labelUser = new Label();
            numericUpDownUserID = new NumericUpDown();
            labelData = new Label();
            dateTimePickerData = new DateTimePicker();
            labelStatus = new Label();
            comboBoxStatus = new ComboBox();
            labelWartosc = new Label();
            numericUpDownWartosc = new NumericUpDown();
            buttonPanel = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            topPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWartosc).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.BackgroundColor = Color.White;
            dataGridViewOrders.BorderStyle = BorderStyle.None;
            dataGridViewOrders.Location = new Point(20, 80);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(760, 300);
            dataGridViewOrders.TabIndex = 2;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
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
            titleLabel.Size = new Size(284, 27);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Zarz¹dzanie Zamówieniami";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(labelUser, 0, 0);
            tableLayoutPanel.Controls.Add(numericUpDownUserID, 1, 0);
            tableLayoutPanel.Controls.Add(labelData, 2, 0);
            tableLayoutPanel.Controls.Add(dateTimePickerData, 3, 0);
            tableLayoutPanel.Controls.Add(labelStatus, 0, 1);
            tableLayoutPanel.Controls.Add(comboBoxStatus, 1, 1);
            tableLayoutPanel.Controls.Add(labelWartosc, 2, 1);
            tableLayoutPanel.Controls.Add(numericUpDownWartosc, 3, 1);
            tableLayoutPanel.Location = new Point(20, 400);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(760, 80);
            tableLayoutPanel.TabIndex = 1;
            // 
            // labelUser
            // 
            labelUser.Dock = DockStyle.Fill;
            labelUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelUser.Location = new Point(8, 5);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(114, 40);
            labelUser.TabIndex = 0;
            labelUser.Text = "ID Uzytkownika:";
            labelUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownUserID
            // 
            numericUpDownUserID.Dock = DockStyle.Fill;
            numericUpDownUserID.Font = new Font("Segoe UI", 10F);
            numericUpDownUserID.Location = new Point(130, 13);
            numericUpDownUserID.Margin = new Padding(5, 8, 5, 8);
            numericUpDownUserID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownUserID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownUserID.Name = "numericUpDownUserID";
            numericUpDownUserID.Size = new Size(245, 25);
            numericUpDownUserID.TabIndex = 1;
            numericUpDownUserID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelData
            // 
            labelData.Dock = DockStyle.Fill;
            labelData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelData.Location = new Point(383, 5);
            labelData.Name = "labelData";
            labelData.Size = new Size(114, 40);
            labelData.TabIndex = 2;
            labelData.Text = "Data:";
            labelData.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Dock = DockStyle.Fill;
            dateTimePickerData.Font = new Font("Segoe UI", 10F);
            dateTimePickerData.Location = new Point(505, 13);
            dateTimePickerData.Margin = new Padding(5, 8, 5, 8);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(245, 25);
            dateTimePickerData.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.Dock = DockStyle.Fill;
            labelStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatus.Location = new Point(8, 45);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(114, 40);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status:";
            labelStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Dock = DockStyle.Fill;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 10F);
            comboBoxStatus.Location = new Point(130, 53);
            comboBoxStatus.Margin = new Padding(5, 8, 5, 8);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(245, 25);
            comboBoxStatus.TabIndex = 5;
            // 
            // labelWartosc
            // 
            labelWartosc.Dock = DockStyle.Fill;
            labelWartosc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelWartosc.Location = new Point(383, 45);
            labelWartosc.Name = "labelWartosc";
            labelWartosc.Size = new Size(114, 40);
            labelWartosc.TabIndex = 6;
            labelWartosc.Text = "Wartosc:";
            labelWartosc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownWartosc
            // 
            numericUpDownWartosc.DecimalPlaces = 2;
            numericUpDownWartosc.Dock = DockStyle.Fill;
            numericUpDownWartosc.Font = new Font("Segoe UI", 10F);
            numericUpDownWartosc.Location = new Point(505, 53);
            numericUpDownWartosc.Margin = new Padding(5, 8, 5, 8);
            numericUpDownWartosc.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownWartosc.Name = "numericUpDownWartosc";
            numericUpDownWartosc.Size = new Size(245, 25);
            numericUpDownWartosc.TabIndex = 7;
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
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(800, 600);
            Controls.Add(buttonPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridViewOrders);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 600);
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zamowienia";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWartosc).EndInit();
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