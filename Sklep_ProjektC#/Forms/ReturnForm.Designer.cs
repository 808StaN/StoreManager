using System.Drawing;
using System.Windows.Forms;

namespace SklepProjektC.Forms
{
    partial class ReturnForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewReturns;
        private Panel topPanel;
        private Label titleLabel;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelOrderID;
        private NumericUpDown numericUpDownOrderID;
        private Label labelPowod;
        private TextBox textBoxPowod;
        private Label labelStatus;
        private ComboBox comboBoxStatus;
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
            dataGridViewReturns = new DataGridView();
            topPanel = new Panel();
            titleLabel = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            labelOrderID = new Label();
            numericUpDownOrderID = new NumericUpDown();
            labelPowod = new Label();
            textBoxPowod = new TextBox();
            labelStatus = new Label();
            comboBoxStatus = new ComboBox();
            buttonPanel = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturns).BeginInit();
            topPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOrderID).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();

            // dataGridViewReturns
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewReturns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReturns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReturns.BackgroundColor = Color.White;
            dataGridViewReturns.BorderStyle = BorderStyle.None;
            dataGridViewReturns.Location = new Point(20, 80);
            dataGridViewReturns.Name = "dataGridViewReturns";
            dataGridViewReturns.Size = new Size(760, 300);
            dataGridViewReturns.TabIndex = 2;
            dataGridViewReturns.SelectionChanged += dataGridViewReturns_SelectionChanged;

            // topPanel
            topPanel.BackColor = Color.FromArgb(33, 150, 243);
            topPanel.Controls.Add(titleLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 60);
            topPanel.TabIndex = 3;

            // titleLabel
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Bahnschrift", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(20, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(240, 27);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Zarz¹dzanie Zwrotami";

            // tableLayoutPanel
            tableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelOrderID, 0, 0);
            tableLayoutPanel.Controls.Add(numericUpDownOrderID, 1, 0);
            tableLayoutPanel.Controls.Add(labelPowod, 0, 1);
            tableLayoutPanel.Controls.Add(textBoxPowod, 1, 1);
            tableLayoutPanel.Controls.Add(labelStatus, 0, 2);
            tableLayoutPanel.Controls.Add(comboBoxStatus, 1, 2);
            tableLayoutPanel.Location = new Point(20, 400);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(5);
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(760, 120);
            tableLayoutPanel.TabIndex = 1;

            // labelOrderID
            labelOrderID.Dock = DockStyle.Fill;
            labelOrderID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelOrderID.Location = new Point(8, 5);
            labelOrderID.Name = "labelOrderID";
            labelOrderID.Size = new Size(144, 40);
            labelOrderID.TabIndex = 0;
            labelOrderID.Text = "ID Zamówienia:";
            labelOrderID.TextAlign = ContentAlignment.MiddleRight;

            // numericUpDownOrderID
            numericUpDownOrderID.Dock = DockStyle.Fill;
            numericUpDownOrderID.Font = new Font("Segoe UI", 10F);
            numericUpDownOrderID.Location = new Point(160, 13);
            numericUpDownOrderID.Margin = new Padding(5, 8, 5, 8);
            numericUpDownOrderID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownOrderID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownOrderID.Name = "numericUpDownOrderID";
            numericUpDownOrderID.Size = new Size(590, 25);
            numericUpDownOrderID.TabIndex = 1;
            numericUpDownOrderID.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // labelPowod
            labelPowod.Dock = DockStyle.Fill;
            labelPowod.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPowod.Location = new Point(8, 45);
            labelPowod.Name = "labelPowod";
            labelPowod.Size = new Size(144, 40);
            labelPowod.TabIndex = 2;
            labelPowod.Text = "Powód:";
            labelPowod.TextAlign = ContentAlignment.MiddleRight;

            // textBoxPowod
            textBoxPowod.Dock = DockStyle.Fill;
            textBoxPowod.Font = new Font("Segoe UI", 10F);
            textBoxPowod.Location = new Point(160, 53);
            textBoxPowod.Margin = new Padding(5, 8, 5, 8);
            textBoxPowod.Name = "textBoxPowod";
            textBoxPowod.Size = new Size(590, 25);
            textBoxPowod.TabIndex = 3;

            // labelStatus
            labelStatus.Dock = DockStyle.Fill;
            labelStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatus.Location = new Point(8, 85);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(144, 40);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status Zwrotu:";
            labelStatus.TextAlign = ContentAlignment.MiddleRight;

            // comboBoxStatus
            comboBoxStatus.Dock = DockStyle.Fill;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 10F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Zgloszony", "W realizacji", "Zaakceptowany", "Odrzucony", "Zwrócono pieniadze" });
            comboBoxStatus.Location = new Point(160, 93);
            comboBoxStatus.Margin = new Padding(5, 8, 5, 8);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(590, 25);
            comboBoxStatus.TabIndex = 5;

            // buttonPanel
            buttonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPanel.Controls.Add(buttonAdd);
            buttonPanel.Controls.Add(buttonUpdate);
            buttonPanel.Controls.Add(buttonDelete);
            buttonPanel.Controls.Add(buttonRefresh);
            buttonPanel.Location = new Point(20, 530);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(760, 50);
            buttonPanel.TabIndex = 0;

            // buttonAdd
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

            // buttonUpdate
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

            // buttonDelete
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
            buttonDelete.Text = "Usuñ";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;

            // buttonRefresh
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
            buttonRefresh.Text = "Odœwie¿";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;

            // ReturnForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(800, 600);
            Controls.Add(buttonPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(dataGridViewReturns);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 600);
            Name = "ReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zwroty";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturns).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOrderID).EndInit();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
