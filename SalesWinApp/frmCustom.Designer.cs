namespace SalesWinApp
{
    partial class frmCustom
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
            label1=new Label();
            txtProductName=new TextBox();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            label8=new Label();
            cbCategory=new ComboBox();
            cbShape=new ComboBox();
            cbMaterial=new ComboBox();
            txtWeight=new TextBox();
            btnAddToCart=new Button();
            lkCancel=new LinkLabel();
            txtPrice=new TextBox();
            label9=new Label();
            label10=new Label();
            txtID=new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(34, 83);
            label1.Name="label1";
            label1.Size=new Size(104, 20);
            label1.TabIndex=0;
            label1.Text="Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location=new Point(144, 80);
            txtProductName.Name="txtProductName";
            txtProductName.Size=new Size(280, 27);
            txtProductName.TabIndex=1;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(34, 133);
            label2.Name="label2";
            label2.Size=new Size(69, 20);
            label2.TabIndex=0;
            label2.Text="Category";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(34, 183);
            label3.Name="label3";
            label3.Size=new Size(56, 20);
            label3.TabIndex=0;
            label3.Text="Weight";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(34, 228);
            label4.Name="label4";
            label4.Size=new Size(50, 20);
            label4.TabIndex=0;
            label4.Text="Shape";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(34, 274);
            label5.Name="label5";
            label5.Size=new Size(64, 20);
            label5.TabIndex=0;
            label5.Text="Material";
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Location=new Point(34, 325);
            label8.Name="label8";
            label8.Size=new Size(41, 20);
            label8.TabIndex=0;
            label8.Text="Price";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled=true;
            cbCategory.Location=new Point(144, 133);
            cbCategory.Name="cbCategory";
            cbCategory.Size=new Size(280, 28);
            cbCategory.TabIndex=2;
            // 
            // cbShape
            // 
            cbShape.FormattingEnabled=true;
            cbShape.Location=new Point(144, 228);
            cbShape.Name="cbShape";
            cbShape.Size=new Size(280, 28);
            cbShape.TabIndex=2;
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled=true;
            cbMaterial.Location=new Point(144, 274);
            cbMaterial.Name="cbMaterial";
            cbMaterial.Size=new Size(280, 28);
            cbMaterial.TabIndex=2;
            // 
            // txtWeight
            // 
            txtWeight.Location=new Point(144, 183);
            txtWeight.Name="txtWeight";
            txtWeight.Size=new Size(280, 27);
            txtWeight.TabIndex=1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location=new Point(326, 386);
            btnAddToCart.Name="btnAddToCart";
            btnAddToCart.Size=new Size(94, 29);
            btnAddToCart.TabIndex=3;
            btnAddToCart.Text="Add to Cart";
            btnAddToCart.UseVisualStyleBackColor=true;
            btnAddToCart.Click+=btnAddToCart_Click;
            // 
            // lkCancel
            // 
            lkCancel.AutoSize=true;
            lkCancel.Location=new Point(257, 390);
            lkCancel.Name="lkCancel";
            lkCancel.Size=new Size(53, 20);
            lkCancel.TabIndex=4;
            lkCancel.TabStop=true;
            lkCancel.Text="Cancel";
            lkCancel.LinkClicked+=lkCancel_LinkClicked;
            // 
            // txtPrice
            // 
            txtPrice.Location=new Point(144, 325);
            txtPrice.Name="txtPrice";
            txtPrice.Size=new Size(280, 27);
            txtPrice.TabIndex=1;
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Location=new Point(34, 35);
            label9.Name="label9";
            label9.Size=new Size(24, 20);
            label9.TabIndex=0;
            label9.Text="ID";
            // 
            // label10
            // 
            label10.AutoSize=true;
            label10.Location=new Point(34, -19);
            label10.Name="label10";
            label10.Size=new Size(104, 20);
            label10.TabIndex=0;
            label10.Text="Product Name";
            // 
            // txtID
            // 
            txtID.Location=new Point(144, 28);
            txtID.Name="txtID";
            txtID.Size=new Size(280, 27);
            txtID.TabIndex=1;
            // 
            // frmCustom
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(453, 471);
            Controls.Add(lkCancel);
            Controls.Add(btnAddToCart);
            Controls.Add(cbMaterial);
            Controls.Add(cbShape);
            Controls.Add(cbCategory);
            Controls.Add(txtWeight);
            Controls.Add(txtPrice);
            Controls.Add(txtID);
            Controls.Add(txtProductName);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label1);
            Name="frmCustom";
            Text="frmCustom";
            Load+=frmCustom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private ComboBox cbCategory;
        private ComboBox cbShape;
        private ComboBox cbMaterial;
        private TextBox txtWeight;
        private Button btnAddToCart;
        private LinkLabel lkCancel;
        private TextBox txtPrice;
        private Label label9;
        private Label label10;
        private TextBox txtID;
    }
}