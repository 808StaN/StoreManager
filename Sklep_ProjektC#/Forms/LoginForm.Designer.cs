using System.Drawing;
using System.Windows.Forms;

namespace SklepProjektC.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel loginPanel;
        private Panel topPanel;
        private Label titleLabel;
        private Label labelServer;
        private TextBox textBoxServer;
        private Label labelDatabase;
        private TextBox textBoxDatabase;
        private Label labelUserId;
        private TextBox textBoxUserId;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private CheckBox checkBoxShowPassword;
        private Button buttonLogin;
        private Button buttonCancel;
        private Label labelStatus;

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
            this.loginPanel = new Panel();
            this.topPanel = new Panel();
            this.titleLabel = new Label();
            this.labelServer = new Label();
            this.textBoxServer = new TextBox();
            this.labelDatabase = new Label();
            this.textBoxDatabase = new TextBox();
            this.labelUserId = new Label();
            this.textBoxUserId = new TextBox();
            this.labelPassword = new Label();
            this.textBoxPassword = new TextBox();
            this.checkBoxShowPassword = new CheckBox();
            this.buttonLogin = new Button();
            this.buttonCancel = new Button();
            this.labelStatus = new Label();
            this.loginPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();

            // loginPanel - g≥Ûwny panel zawierajπcy wszystko
            this.loginPanel.BackColor = Color.FromArgb(250, 250, 250);
            this.loginPanel.Controls.Add(this.labelStatus);
            this.loginPanel.Controls.Add(this.buttonCancel);
            this.loginPanel.Controls.Add(this.buttonLogin);
            this.loginPanel.Controls.Add(this.checkBoxShowPassword);
            this.loginPanel.Controls.Add(this.textBoxPassword);
            this.loginPanel.Controls.Add(this.labelPassword);
            this.loginPanel.Controls.Add(this.textBoxUserId);
            this.loginPanel.Controls.Add(this.labelUserId);
            this.loginPanel.Controls.Add(this.textBoxDatabase);
            this.loginPanel.Controls.Add(this.labelDatabase);
            this.loginPanel.Controls.Add(this.textBoxServer);
            this.loginPanel.Controls.Add(this.labelServer);
            this.loginPanel.Controls.Add(this.topPanel);
            this.loginPanel.Location = new Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new Size(450, 460);
            this.loginPanel.TabIndex = 0;

            // topPanel
            this.topPanel.BackColor = Color.FromArgb(33, 150, 243);
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Dock = DockStyle.Top;
            this.topPanel.Location = new Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new Size(450, 60);
            this.topPanel.TabIndex = 0;

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new Font("Bahnschrift", 16F, FontStyle.Bold);
            this.titleLabel.ForeColor = Color.White;
            this.titleLabel.Location = new Point(20, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new Size(250, 27);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Logowanie do Bazy Danych";

            // labelServer
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelServer.Location = new Point(30, 80);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new Size(60, 19);
            this.labelServer.TabIndex = 1;
            this.labelServer.Text = "Serwer:";

            // textBoxServer
            this.textBoxServer.Font = new Font("Segoe UI", 10F);
            this.textBoxServer.Location = new Point(30, 105);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new Size(390, 25);
            this.textBoxServer.TabIndex = 2;
            this.textBoxServer.Text = "polska.database.windows.net";

            // labelDatabase
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelDatabase.Location = new Point(30, 145);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new Size(92, 19);
            this.labelDatabase.TabIndex = 3;
            this.labelDatabase.Text = "Baza danych:";

            // textBoxDatabase
            this.textBoxDatabase.Font = new Font("Segoe UI", 10F);
            this.textBoxDatabase.Location = new Point(30, 170);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new Size(390, 25);
            this.textBoxDatabase.TabIndex = 4;
            this.textBoxDatabase.Text = "72420_Sklep Internetowy - odzieø + obuwie";

            // labelUserId
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelUserId.Location = new Point(30, 210);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new Size(121, 19);
            this.labelUserId.TabIndex = 5;
            this.labelUserId.Text = "Nazwa uøytkownika:";

            // textBoxUserId
            this.textBoxUserId.Font = new Font("Segoe UI", 10F);
            this.textBoxUserId.Location = new Point(30, 235);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new Size(390, 25);
            this.textBoxUserId.TabIndex = 6;

            // labelPassword
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.labelPassword.Location = new Point(30, 275);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new Size(50, 19);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Has≥o:";

            // textBoxPassword
            this.textBoxPassword.Font = new Font("Segoe UI", 10F);
            this.textBoxPassword.Location = new Point(30, 300);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new Size(390, 25);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.UseSystemPasswordChar = true;

            // checkBoxShowPassword
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new Font("Segoe UI", 9F);
            this.checkBoxShowPassword.Location = new Point(30, 335);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new Size(110, 19);
            this.checkBoxShowPassword.TabIndex = 9;
            this.checkBoxShowPassword.Text = "Pokaø has≥o";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;

            // buttonLogin
            this.buttonLogin.BackColor = Color.FromArgb(76, 175, 80);
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = FlatStyle.Flat;
            this.buttonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonLogin.ForeColor = Color.White;
            this.buttonLogin.Location = new Point(30, 375);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new Size(180, 40);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += buttonLogin_Click;

            // buttonCancel
            this.buttonCancel.BackColor = Color.FromArgb(158, 158, 158);
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = FlatStyle.Flat;
            this.buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonCancel.ForeColor = Color.White;
            this.buttonCancel.Location = new Point(240, 375);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(180, 40);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += buttonCancel_Click;

            // labelStatus
            this.labelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            this.labelStatus.ForeColor = Color.Gray;
            this.labelStatus.Location = new Point(30, 425);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new Size(390, 20);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Wprowadü dane logowania";
            this.labelStatus.TextAlign = ContentAlignment.MiddleCenter;

            // LoginForm
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(70, 130, 179);
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.loginPanel);
            this.Font = new Font("Segoe UI", 9F);
            this.Name = "LoginForm";
            this.Text = "Logowanie do Bazy";
            this.Load += LoginForm_Load;
            this.Resize += LoginForm_Resize;
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
