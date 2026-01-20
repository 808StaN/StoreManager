using System.Drawing;

namespace SklepProjektC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnBrands;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDisconnect;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            btnConnect = new Button();
            btnWarehouse = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            btnBrands = new Button();
            btnUsers = new Button();
            btnOrders = new Button();
            btnDisconnect = new Button();
            titlePanel = new Panel();
            titleLabel = new Label();
            sidePanel.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(33, 150, 243);
            sidePanel.Controls.Add(flowLayoutPanel);
            sidePanel.Controls.Add(titlePanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(280, 800);
            sidePanel.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = Color.FromArgb(33, 150, 243);
            flowLayoutPanel.Controls.Add(btnConnect);
            flowLayoutPanel.Controls.Add(btnWarehouse);
            flowLayoutPanel.Controls.Add(btnProducts);
            flowLayoutPanel.Controls.Add(btnCategories);
            flowLayoutPanel.Controls.Add(btnBrands);
            flowLayoutPanel.Controls.Add(btnUsers);
            flowLayoutPanel.Controls.Add(btnOrders);
            flowLayoutPanel.Controls.Add(btnDisconnect);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(0, 120);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(10, 20, 10, 10);
            flowLayoutPanel.Size = new Size(280, 680);
            flowLayoutPanel.TabIndex = 1;
            flowLayoutPanel.WrapContents = false;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(33, 150, 243);
            btnConnect.Cursor = Cursors.Hand;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            btnConnect.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Bahnschrift", 11F);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(10, 25);
            btnConnect.Margin = new Padding(0, 5, 0, 5);
            btnConnect.Name = "btnConnect";
            btnConnect.Padding = new Padding(20, 0, 0, 0);
            btnConnect.Size = new Size(260, 50);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "  Połącz z Bazą";
            btnConnect.TextAlign = ContentAlignment.MiddleLeft;
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += ConnectItem_Click;
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = Color.FromArgb(33, 150, 243);
            btnWarehouse.Cursor = Cursors.Hand;
            btnWarehouse.FlatAppearance.BorderSize = 0;
            btnWarehouse.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            btnWarehouse.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.Font = new Font("Bahnschrift", 11F);
            btnWarehouse.ForeColor = Color.White;
            btnWarehouse.Location = new Point(10, 85);
            btnWarehouse.Margin = new Padding(0, 5, 0, 5);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Padding = new Padding(20, 0, 0, 0);
            btnWarehouse.Size = new Size(260, 50);
            btnWarehouse.TabIndex = 1;
            btnWarehouse.Text = "  Magazyn";
            btnWarehouse.TextAlign = ContentAlignment.MiddleLeft;
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += WarehouseItem_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(33, 150, 243);
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            btnProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Bahnschrift", 11F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(10, 145);
            btnProducts.Margin = new Padding(0, 5, 0, 5);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(20, 0, 0, 0);
            btnProducts.Size = new Size(260, 50);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "  Produkty";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += ProductItem_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(33, 150, 243);
            btnCategories.Cursor = Cursors.Hand;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            btnCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Bahnschrift", 11F);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(10, 205);
            btnCategories.Margin = new Padding(0, 5, 0, 5);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(20, 0, 0, 0);
            btnCategories.Size = new Size(260, 50);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "  Kategorie";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += CategoryItem_Click;
            // 
            // btnBrands
            // 
            btnBrands.BackColor = Color.FromArgb(33, 150, 243);
            btnBrands.Cursor = Cursors.Hand;
            btnBrands.FlatAppearance.BorderSize = 0;
            btnBrands.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            btnBrands.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnBrands.FlatStyle = FlatStyle.Flat;
            btnBrands.Font = new Font("Bahnschrift", 11F);
            btnBrands.ForeColor = Color.White;
            btnBrands.Location = new Point(10, 265);
            btnBrands.Margin = new Padding(0, 5, 0, 5);
            btnBrands.Name = "btnBrands";
            btnBrands.Padding = new Padding(20, 0, 0, 0);
            btnBrands.Size = new Size(260, 50);
            btnBrands.TabIndex = 4;
            btnBrands.Text = "  Marki";
            btnBrands.TextAlign = ContentAlignment.MiddleLeft;
            btnBrands.UseVisualStyleBackColor = false;
            btnBrands.Click += BrandItem_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(33, 150, 243);
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Bahnschrift", 11F);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(10, 325);
            btnUsers.Margin = new Padding(0, 5, 0, 5);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(20, 0, 0, 0);
            btnUsers.Size = new Size(260, 50);
            btnUsers.TabIndex = 5;
            btnUsers.Text = "  Użytkownicy";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += UserItem_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.FromArgb(33, 150, 243);
            btnOrders.Cursor = Cursors.Hand;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            btnOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Bahnschrift", 11F);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(10, 385);
            btnOrders.Margin = new Padding(0, 5, 0, 5);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(20, 0, 0, 0);
            btnOrders.Size = new Size(260, 50);
            btnOrders.TabIndex = 6;
            btnOrders.Text = "  Zamówienia";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += OrderItem_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.FromArgb(33, 150, 243);
            btnDisconnect.Cursor = Cursors.Hand;
            btnDisconnect.FlatAppearance.BorderSize = 0;
            btnDisconnect.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            btnDisconnect.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnDisconnect.FlatStyle = FlatStyle.Flat;
            btnDisconnect.Font = new Font("Bahnschrift", 11F);
            btnDisconnect.ForeColor = Color.White;
            btnDisconnect.Location = new Point(10, 445);
            btnDisconnect.Margin = new Padding(0, 5, 0, 5);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Padding = new Padding(20, 0, 0, 0);
            btnDisconnect.Size = new Size(260, 50);
            btnDisconnect.TabIndex = 7;
            btnDisconnect.Text = "  Rozłącz z Bazą";
            btnDisconnect.TextAlign = ContentAlignment.MiddleLeft;
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += DisconnectItem_Click;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.FromArgb(25, 118, 210);
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Padding = new Padding(20);
            titlePanel.Size = new Size(280, 120);
            titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(20, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(240, 80);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "MENEDŻER SKLEPU";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 130, 179); // #4682B3
            ClientSize = new Size(1200, 800);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 9F);
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menedżer Sklepu";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            flowLayoutPanel.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
    }
}
