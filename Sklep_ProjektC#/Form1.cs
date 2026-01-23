using SklepProjektC.DataAccess;
using SklepProjektC.Forms;
using System.Drawing;
using System.IO;

namespace SklepProjektC
{
    public partial class Form1 : Form
    {
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
            InitializeMenuIcons();
            
            // SprawdŸ czy po³¹czenie ju¿ istnieje
            isConnected = DatabaseHelper.IsConnected();
            btnConnect.ForeColor = isConnected ? Color.FromArgb(94, 212, 59) : Color.White;
            UpdateMenuButtonsState();
            
            btnConnect.FlatAppearance.BorderColor = Color.FromArgb(33, 150, 243);
            btnConnect.FlatAppearance.BorderSize = 0;
            
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.FromArgb(0x46, 0x82, 0xB3);
                    break;
                }
            }
        }

        // £aduje ikony do przycisków menu
        private void InitializeMenuIcons()
        {
            try
            {
                string imgPath = Path.Combine(Application.StartupPath, "Img");
                Size iconSize = new Size(24, 24);
                
                SetButtonIcon(btnConnect, Path.Combine(imgPath, "connectDatabase.png"), "Po³¹cz z Baz¹", iconSize);
                SetButtonIcon(btnWarehouse, Path.Combine(imgPath, "warehouse.png"), "Magazyn", iconSize);
                SetButtonIcon(btnProducts, Path.Combine(imgPath, "priceTag.png"), "Produkty", iconSize);
                SetButtonIcon(btnCategories, Path.Combine(imgPath, "productCategory.png"), "Kategorie", iconSize);
                SetButtonIcon(btnBrands, Path.Combine(imgPath, "registeredTrademark.png"), "Marki", iconSize);
                SetButtonIcon(btnUsers, Path.Combine(imgPath, "users.png"), "U¿ytkownicy", iconSize);
                SetButtonIcon(btnOrders, Path.Combine(imgPath, "shoppingBasket.png"), "Zamówienia", iconSize);
                SetButtonIcon(btnReturns, Path.Combine(imgPath, "return.png"), "Zwroty", iconSize);
                SetButtonIcon(btnDisconnect, Path.Combine(imgPath, "disconect.png"), "Roz³¹cz z Baz¹", iconSize);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Nie mo¿na za³adowaæ ikon: {ex.Message}");
            }
        }

        // Ustawia ikonê dla przycisku
        private void SetButtonIcon(Button button, string iconPath, string text, Size iconSize)
        {
            try
            {
                if (File.Exists(iconPath))
                {
                    Image originalImage = Image.FromFile(iconPath);
                    Image resizedImage = new Bitmap(originalImage, iconSize);
                    
                    button.Image = resizedImage;
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.TextAlign = ContentAlignment.MiddleLeft;
                    button.TextImageRelation = TextImageRelation.ImageBeforeText;
                    button.Text = "   " + text;
                    button.Padding = new Padding(15, 0, 0, 0);
                }
                else
                {
                    button.Text = "  " + text;
                    System.Diagnostics.Debug.WriteLine($"Brak pliku ikony: {iconPath}");
                }
            }
            catch (Exception ex)
            {
                button.Text = "  " + text;
                System.Diagnostics.Debug.WriteLine($"B³¹d ³adowania ikony {iconPath}: {ex.Message}");
            }
        }

        // £¹czy z baz¹ danych
        private void ConnectItem_Click(object sender, EventArgs e)
        {
            // SprawdŸ czy okno logowania ju¿ nie jest otwarte
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm is LoginForm)
                {
                    childForm.Activate();
                    return;
                }
            }

            // Otwórz LoginForm jako okno MDI
            var loginForm = new LoginForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            
            // Obs³uga zdarzenia po pomyœlnym zalogowaniu
            loginForm.FormClosed += (s, args) =>
            {
                if (loginForm.LoginSuccessful)
                {
                    isConnected = true;
                    btnConnect.ForeColor = Color.FromArgb(94, 212, 59);
                    UpdateMenuButtonsState();
                    MessageBox.Show("Po³¹czenie z baz¹ danych zosta³o nawi¹zane pomyœlnie!", 
                        "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            
            loginForm.Show();
        }

        // Roz³¹cza z baz¹ danych
        private void DisconnectItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllMdiChildren();
                DatabaseHelper.ClearConnection();
                isConnected = false;
                btnConnect.ForeColor = Color.White;
                UpdateMenuButtonsState();
                MessageBox.Show("Po³¹czenie z baz¹ danych zosta³o zakoñczone.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Zamyka wszystkie otwarte okna
        private void CloseAllMdiChildren()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        // W³¹cza/wy³¹cza przyciski menu
        private void UpdateMenuButtonsState()
        {
            btnConnect.Enabled = !isConnected;
            btnWarehouse.Enabled = isConnected;
            btnProducts.Enabled = isConnected;
            btnCategories.Enabled = isConnected;
            btnBrands.Enabled = isConnected;
            btnUsers.Enabled = isConnected;
            btnOrders.Enabled = isConnected;
            btnReturns.Enabled = isConnected;
            btnDisconnect.Enabled = isConnected;
        }

        private void WarehouseItem_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm<WarehouseForm>();
        }

        private void ProductItem_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm<ProductForm>();
        }

        private void CategoryItem_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm<CategoryForm>();
        }

        private void BrandItem_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm<BrandForm>();
        }

        private void UserItem_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm<UserForm>();
        }

        private void OrderItem_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm<OrderForm>();
        }

        private void ReturnItem_Click(object sender, EventArgs e)
        {
            OpenOrActivateForm<ReturnForm>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Otwiera okno lub aktywuje jeœli ju¿ jest otwarte
        private void OpenOrActivateForm<T>() where T : Form, new()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm is T)
                {
                    childForm.Activate();
                    return;
                }
            }

            var form = new T
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            form.Show();
        }
    }
}
