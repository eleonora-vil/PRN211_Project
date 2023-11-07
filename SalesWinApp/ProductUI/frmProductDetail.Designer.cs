namespace SalesWinApp
{
    partial class frmProductDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lbProductName = new Label();
            lbCategory = new Label();
            lbWeight = new Label();
            lbUnitsInStock = new Label();
            lbPrice = new Label();
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtWeight = new TextBox();
            txtUnitsInStock = new TextBox();
            txtPrice = new TextBox();
            btnAddToCart = new Button();
            lbQuantity = new Label();
            txtQuantity = new TextBox();
            lkCancel = new LinkLabel();
            lbQtyMsg = new Label();
            label1 = new Label();
            txtDiscount = new TextBox();
            lbDiscount = new Label();
            SuspendLayout();
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(35, 39);
            lbProductName.Margin = new Padding(2, 0, 2, 0);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(104, 20);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(35, 93);
            lbCategory.Margin = new Padding(2, 0, 2, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(69, 20);
            lbCategory.TabIndex = 1;
            lbCategory.Text = "Category";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(35, 148);
            lbWeight.Margin = new Padding(2, 0, 2, 0);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(56, 20);
            lbWeight.TabIndex = 2;
            lbWeight.Text = "Weight";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(35, 203);
            lbUnitsInStock.Margin = new Padding(2, 0, 2, 0);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(84, 20);
            lbUnitsInStock.TabIndex = 3;
            lbUnitsInStock.Text = "UnitInStock";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(35, 312);
            lbPrice.Margin = new Padding(2, 0, 2, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "Price";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(136, 35);
            txtProductName.Margin = new Padding(2, 3, 2, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(341, 27);
            txtProductName.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(136, 89);
            txtCategory.Margin = new Padding(2, 3, 2, 3);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(341, 27);
            txtCategory.TabIndex = 6;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(136, 144);
            txtWeight.Margin = new Padding(2, 3, 2, 3);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(341, 27);
            txtWeight.TabIndex = 7;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(136, 199);
            txtUnitsInStock.Margin = new Padding(2, 3, 2, 3);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.ReadOnly = true;
            txtUnitsInStock.Size = new Size(341, 27);
            txtUnitsInStock.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(136, 308);
            txtPrice.Margin = new Padding(2, 3, 2, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(341, 27);
            txtPrice.TabIndex = 9;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(299, 407);
            btnAddToCart.Margin = new Padding(2, 3, 2, 3);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(114, 31);
            btnAddToCart.TabIndex = 10;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(35, 257);
            lbQuantity.Margin = new Padding(2, 0, 2, 0);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(65, 20);
            lbQuantity.TabIndex = 11;
            lbQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(136, 253);
            txtQuantity.Margin = new Padding(2, 3, 2, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(341, 27);
            txtQuantity.TabIndex = 0;
            // 
            // lkCancel
            // 
            lkCancel.AutoSize = true;
            lkCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lkCancel.LinkColor = Color.Black;
            lkCancel.Location = new Point(158, 412);
            lkCancel.Name = "lkCancel";
            lkCancel.Size = new Size(53, 20);
            lkCancel.TabIndex = 13;
            lkCancel.TabStop = true;
            lkCancel.Text = "Cancel";
            lkCancel.VisitedLinkColor = Color.Black;
            lkCancel.LinkClicked += lkCancel_LinkClicked;
            // 
            // lbQtyMsg
            // 
            lbQtyMsg.AutoSize = true;
            lbQtyMsg.Location = new Point(136, 287);
            lbQtyMsg.Name = "lbQtyMsg";
            lbQtyMsg.Size = new Size(0, 20);
            lbQtyMsg.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 338);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 17;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(136, 359);
            txtDiscount.Margin = new Padding(2, 3, 2, 3);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(341, 27);
            txtDiscount.TabIndex = 16;
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(35, 363);
            lbDiscount.Margin = new Padding(2, 0, 2, 0);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(67, 20);
            lbDiscount.TabIndex = 15;
            lbDiscount.Text = "Discount";
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 519);
            Controls.Add(label1);
            Controls.Add(txtDiscount);
            Controls.Add(lbDiscount);
            Controls.Add(lbQtyMsg);
            Controls.Add(lkCancel);
            Controls.Add(txtQuantity);
            Controls.Add(lbQuantity);
            Controls.Add(btnAddToCart);
            Controls.Add(txtPrice);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtWeight);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Controls.Add(lbPrice);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbWeight);
            Controls.Add(lbCategory);
            Controls.Add(lbProductName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProductDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Item";
            TopMost = true;
            Load += frmProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductName;
        private Label lbCategory;
        private Label lbWeight;
        private Label lbUnitsInStock;
        private Label lbPrice;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtWeight;
        private TextBox txtUnitsInStock;
        private TextBox txtPrice;
        private Button btnAddToCart;
        private Label lbQuantity;
        private TextBox txtQuantity;
        private LinkLabel lkCancel;
        private Label lbQtyMsg;
        private Label label1;
        private TextBox txtDiscount;
        private Label lbDiscount;
    }
}