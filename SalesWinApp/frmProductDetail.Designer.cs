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
            lbProductName=new Label();
            lbCategory=new Label();
            lbWeight=new Label();
            lbUnitsInStock=new Label();
            lbPrice=new Label();
            txtProductName=new TextBox();
            txtCategory=new TextBox();
            txtWeight=new TextBox();
            txtUnitsInStock=new TextBox();
            txtPrice=new TextBox();
            btnAddToCart=new Button();
            lbQuantity=new Label();
            txtQuantity=new TextBox();
            lkCancel=new LinkLabel();
            lbQtyMsg=new Label();
            label1=new Label();
            txtDiscount=new TextBox();
            lbDiscount=new Label();
            lblShape=new Label();
            txtMaterial=new TextBox();
            label2=new Label();
            txtShape=new TextBox();
            SuspendLayout();
            // 
            // lbProductName
            // 
            lbProductName.AutoSize=true;
            lbProductName.Location=new Point(11, 38);
            lbProductName.Margin=new Padding(2, 0, 2, 0);
            lbProductName.Name="lbProductName";
            lbProductName.Size=new Size(104, 20);
            lbProductName.TabIndex=0;
            lbProductName.Text="Product Name";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize=true;
            lbCategory.Location=new Point(11, 92);
            lbCategory.Margin=new Padding(2, 0, 2, 0);
            lbCategory.Name="lbCategory";
            lbCategory.Size=new Size(69, 20);
            lbCategory.TabIndex=1;
            lbCategory.Text="Category";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize=true;
            lbWeight.Location=new Point(11, 147);
            lbWeight.Margin=new Padding(2, 0, 2, 0);
            lbWeight.Name="lbWeight";
            lbWeight.Size=new Size(56, 20);
            lbWeight.TabIndex=2;
            lbWeight.Text="Weight";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize=true;
            lbUnitsInStock.Location=new Point(11, 320);
            lbUnitsInStock.Margin=new Padding(2, 0, 2, 0);
            lbUnitsInStock.Name="lbUnitsInStock";
            lbUnitsInStock.Size=new Size(84, 20);
            lbUnitsInStock.TabIndex=3;
            lbUnitsInStock.Text="UnitInStock";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize=true;
            lbPrice.Location=new Point(11, 429);
            lbPrice.Margin=new Padding(2, 0, 2, 0);
            lbPrice.Name="lbPrice";
            lbPrice.Size=new Size(41, 20);
            lbPrice.TabIndex=4;
            lbPrice.Text="Price";
            // 
            // txtProductName
            // 
            txtProductName.Location=new Point(136, 35);
            txtProductName.Margin=new Padding(2, 3, 2, 3);
            txtProductName.Name="txtProductName";
            txtProductName.ReadOnly=true;
            txtProductName.Size=new Size(219, 27);
            txtProductName.TabIndex=5;
            // 
            // txtCategory
            // 
            txtCategory.Location=new Point(136, 89);
            txtCategory.Margin=new Padding(2, 3, 2, 3);
            txtCategory.Name="txtCategory";
            txtCategory.ReadOnly=true;
            txtCategory.Size=new Size(219, 27);
            txtCategory.TabIndex=6;
            // 
            // txtWeight
            // 
            txtWeight.Location=new Point(136, 144);
            txtWeight.Margin=new Padding(2, 3, 2, 3);
            txtWeight.Name="txtWeight";
            txtWeight.ReadOnly=true;
            txtWeight.Size=new Size(219, 27);
            txtWeight.TabIndex=7;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location=new Point(136, 317);
            txtUnitsInStock.Margin=new Padding(2, 3, 2, 3);
            txtUnitsInStock.Name="txtUnitsInStock";
            txtUnitsInStock.ReadOnly=true;
            txtUnitsInStock.Size=new Size(219, 27);
            txtUnitsInStock.TabIndex=8;
            // 
            // txtPrice
            // 
            txtPrice.Location=new Point(136, 426);
            txtPrice.Margin=new Padding(2, 3, 2, 3);
            txtPrice.Name="txtPrice";
            txtPrice.ReadOnly=true;
            txtPrice.Size=new Size(219, 27);
            txtPrice.TabIndex=9;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location=new Point(218, 525);
            btnAddToCart.Margin=new Padding(2, 3, 2, 3);
            btnAddToCart.Name="btnAddToCart";
            btnAddToCart.Size=new Size(137, 31);
            btnAddToCart.TabIndex=10;
            btnAddToCart.Text="Add to cart";
            btnAddToCart.UseVisualStyleBackColor=true;
            btnAddToCart.Click+=btnAddToCart_Click;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize=true;
            lbQuantity.Location=new Point(11, 374);
            lbQuantity.Margin=new Padding(2, 0, 2, 0);
            lbQuantity.Name="lbQuantity";
            lbQuantity.Size=new Size(65, 20);
            lbQuantity.TabIndex=11;
            lbQuantity.Text="Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location=new Point(136, 371);
            txtQuantity.Margin=new Padding(2, 3, 2, 3);
            txtQuantity.Name="txtQuantity";
            txtQuantity.Size=new Size(219, 27);
            txtQuantity.TabIndex=0;
            // 
            // lkCancel
            // 
            lkCancel.AutoSize=true;
            lkCancel.Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lkCancel.LinkColor=Color.Black;
            lkCancel.Location=new Point(160, 530);
            lkCancel.Name="lkCancel";
            lkCancel.Size=new Size(53, 20);
            lkCancel.TabIndex=13;
            lkCancel.TabStop=true;
            lkCancel.Text="Cancel";
            lkCancel.VisitedLinkColor=Color.Black;
            lkCancel.LinkClicked+=lkCancel_LinkClicked;
            // 
            // lbQtyMsg
            // 
            lbQtyMsg.AutoSize=true;
            lbQtyMsg.Location=new Point(136, 405);
            lbQtyMsg.Name="lbQtyMsg";
            lbQtyMsg.Size=new Size(0, 20);
            lbQtyMsg.TabIndex=14;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(136, 456);
            label1.Name="label1";
            label1.Size=new Size(0, 20);
            label1.TabIndex=17;
            // 
            // txtDiscount
            // 
            txtDiscount.Location=new Point(136, 477);
            txtDiscount.Margin=new Padding(2, 3, 2, 3);
            txtDiscount.Name="txtDiscount";
            txtDiscount.ReadOnly=true;
            txtDiscount.Size=new Size(219, 27);
            txtDiscount.TabIndex=16;
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize=true;
            lbDiscount.Location=new Point(11, 480);
            lbDiscount.Margin=new Padding(2, 0, 2, 0);
            lbDiscount.Name="lbDiscount";
            lbDiscount.Size=new Size(67, 20);
            lbDiscount.TabIndex=15;
            lbDiscount.Text="Discount";
            // 
            // lblShape
            // 
            lblShape.AutoSize=true;
            lblShape.Location=new Point(11, 259);
            lblShape.Margin=new Padding(2, 0, 2, 0);
            lblShape.Name="lblShape";
            lblShape.Size=new Size(64, 20);
            lblShape.TabIndex=2;
            lblShape.Text="Material";
            // 
            // txtMaterial
            // 
            txtMaterial.Location=new Point(136, 260);
            txtMaterial.Margin=new Padding(2, 3, 2, 3);
            txtMaterial.Name="txtMaterial";
            txtMaterial.ReadOnly=true;
            txtMaterial.Size=new Size(219, 27);
            txtMaterial.TabIndex=7;
            // 
            // label2
            // 
            label2.AccessibleRole=AccessibleRole.Clock;
            label2.AutoSize=true;
            label2.Location=new Point(11, 204);
            label2.Margin=new Padding(2, 0, 2, 0);
            label2.Name="label2";
            label2.Size=new Size(50, 20);
            label2.TabIndex=2;
            label2.Text="Shape";
            // 
            // txtShape
            // 
            txtShape.AccessibleRole=AccessibleRole.Clock;
            txtShape.Location=new Point(136, 205);
            txtShape.Margin=new Padding(2, 3, 2, 3);
            txtShape.Name="txtShape";
            txtShape.ReadOnly=true;
            txtShape.Size=new Size(219, 27);
            txtShape.TabIndex=7;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(368, 617);
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
            Controls.Add(txtShape);
            Controls.Add(txtMaterial);
            Controls.Add(txtWeight);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Controls.Add(lbPrice);
            Controls.Add(lbUnitsInStock);
            Controls.Add(label2);
            Controls.Add(lblShape);
            Controls.Add(lbWeight);
            Controls.Add(lbCategory);
            Controls.Add(lbProductName);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Margin=new Padding(2, 3, 2, 3);
            MaximizeBox=false;
            MinimizeBox=false;
            Name="frmProductDetail";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Add Item";
            TopMost=true;
            Load+=frmProductDetail_Load;
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
        private Label lblShape;
        private TextBox txtMaterial;
        private Label label2;
        private TextBox txtShape;
    }
}