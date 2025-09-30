using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormUI
{
    public partial class ProductForm : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnAddProduct;
        private Button btnGetProduct;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private TextBox txtProductId;
        private DataGridView dataGridView1;
        private Label label4;
        private readonly ProductService _productService;

        public ProductForm()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text)
            };
            _productService.AddProduct(product);
            MessageBox.Show("Product added successfully!");
            LoadProducts();
        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductId.Text, out int productId))
            {
                var product = _productService.GetProduct(productId);
                if (product != null)
                {
                    txtName.Text = product.Name;
                    txtPrice.Text = product.Price.ToString();
                }
                else
                {
                    MessageBox.Show("Product not found!");
                }
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = _productService.GetAllProducts();
            dataGridView1.DataSource = products;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductId.Text, out int productId))
            {
                var product = new Product
                {
                    Id = productId,
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text)
                };
                _productService.UpdateProduct(product);
                MessageBox.Show("Product updated successfully!");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Please enter a valid Product ID!");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductId.Text, out int productId))
            {
                _productService.DeleteProduct(productId);
                MessageBox.Show("Product deleted successfully!");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Please enter a valid Product ID!");
            }
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnGetProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(450, 192);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 31);
            this.txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(450, 266);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 31);
            this.txtPrice.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(683, 108);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(252, 44);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnGetProduct
            // 
            this.btnGetProduct.Location = new System.Drawing.Point(683, 199);
            this.btnGetProduct.Name = "btnGetProduct";
            this.btnGetProduct.Size = new System.Drawing.Size(252, 44);
            this.btnGetProduct.TabIndex = 7;
            this.btnGetProduct.Text = "Get Product";
            this.btnGetProduct.UseVisualStyleBackColor = true;
            this.btnGetProduct.Click += new System.EventHandler(this.btnGetProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(683, 289);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(252, 44);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(1026, 108);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(252, 44);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(450, 100);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 31);
            this.txtProductId.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1365, 498);
            this.dataGridView1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1095, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Developed by Thiha Aung";
            // 
            // ProductForm
            // 
            this.ClientSize = new System.Drawing.Size(1757, 1010);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnGetProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }







    }
}
