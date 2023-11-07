using BusinessObject.Models;
using DataAccess.Repository;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using BusinessObject;

namespace SalesWinApp
{
    public partial class frmCustom : Form
    {
        ICategoryRepository categoryRepository = new CategoryRepository();
        IProductRepository repository = new ProductRepository();
        public ShoppingCart Cart { get; set; }
        public Product Product { get; set; }

        private Boolean isNewItem = true;

        public frmCustom()
        {
            InitializeComponent();
        }

        private void lkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Close();

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                Product = new Product()
                {
                    ProductId = int.Parse(txtID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    Shape = cbShape.Text,
                    CategoryId = int.Parse(cbCategory.SelectedValue.ToString()),
                    Material = cbMaterial.Text,
                    UnitPrice = int.Parse(txtPrice.Text),
                    UnitsInStock = 1,
                    
                }; 
                Cart.AddToCart(Product, 1);
              
                Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCustom_Load(object sender, EventArgs e)
        {
            int productID = repository.GetMaxProductID() + 1;
            txtID.Text = productID.ToString();
            
               
                /*if (found == null)
                {
                    
                }
                else
                {
                    txtQuantity.Text = found.Quantity.ToString();
                    this.Text = "Update Item";
                    btnAddToCart.Text = "Update";
                    isNewItem = false;
                }*/

            
            LoadComboBoxCategory();
        }
        private void LoadComboBoxCategory()
        {
            List<Product> shape = repository.GetProducts();
            Dictionary<int, string> shapeDic = new Dictionary<int, string>();
            Dictionary<int, string> materialDic = new Dictionary<int, string>();

            List<Category> categories = categoryRepository.GetCategories();
            Dictionary<int, string> categoryDic = new Dictionary<int, string>();
            foreach (Category category in categories)
            {
                categoryDic.Add(category.CategoryId, category.CategoryName);

            }
            foreach (Product shapes in shape)
            {
                shapeDic.Add(shapes.ProductId,shapes.Shape);
                materialDic.Add(shapes.ProductId, shapes.Material);
            }

            cbShape.DataSource = shapeDic.ToList();
            cbShape.DisplayMember = "value";
            cbShape.ValueMember = "key";
            cbShape.SelectedIndex = 0;
            cbCategory.DataSource = categoryDic.ToList();
            cbCategory.DisplayMember = "value";
            cbCategory.ValueMember = "key";
            cbCategory.SelectedIndex = 0;
            cbMaterial.DataSource = materialDic.ToList();
            cbMaterial.DisplayMember = "value";
            cbMaterial.ValueMember = "key";
            cbMaterial.SelectedIndex = 0;
        }
    }
}
