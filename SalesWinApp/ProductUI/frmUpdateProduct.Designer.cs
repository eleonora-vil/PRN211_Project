﻿namespace SalesWinApp
{
    partial class frmUpdateProduct
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
            components = new System.ComponentModel.Container();
            cbCategory = new ComboBox();
            tbUnitsInStock = new TextBox();
            lbInStock = new Label();
            label7 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            tbUnitPrice = new TextBox();
            tbProductWeight = new TextBox();
            tbProductName = new TextBox();
            tbProductID = new TextBox();
            lbUnitPrice = new Label();
            lbProductWeight = new Label();
            lbProductCategory = new Label();
            labelProductName = new Label();
            lbProductName = new Label();
            errorProviderID = new ErrorProvider(components);
            errorProviderName = new ErrorProvider(components);
            errorProviderWeight = new ErrorProvider(components);
            errorProviderPrice = new ErrorProvider(components);
            errorProviderInStock = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInStock).BeginInit();
            SuspendLayout();
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(236, 181);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(298, 28);
            cbCategory.TabIndex = 60;
            // 
            // tbUnitsInStock
            // 
            tbUnitsInStock.Anchor = AnchorStyles.None;
            tbUnitsInStock.Location = new Point(236, 327);
            tbUnitsInStock.Name = "tbUnitsInStock";
            tbUnitsInStock.Size = new Size(298, 27);
            tbUnitsInStock.TabIndex = 55;
            tbUnitsInStock.Validating += tbUnitsInStock_Validating;
            // 
            // lbInStock
            // 
            lbInStock.Anchor = AnchorStyles.None;
            lbInStock.AutoSize = true;
            lbInStock.Location = new Point(128, 330);
            lbInStock.Name = "lbInStock";
            lbInStock.Size = new Size(92, 20);
            lbInStock.TabIndex = 58;
            lbInStock.Text = "Unit In Stock";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(286, 48);
            label7.Name = "label7";
            label7.Size = new Size(183, 31);
            label7.TabIndex = 57;
            label7.Text = "Update Product";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(428, 432);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(192, 432);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 56;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbUnitPrice
            // 
            tbUnitPrice.Anchor = AnchorStyles.None;
            tbUnitPrice.Location = new Point(236, 277);
            tbUnitPrice.Name = "tbUnitPrice";
            tbUnitPrice.Size = new Size(298, 27);
            tbUnitPrice.TabIndex = 54;
            tbUnitPrice.Validating += tbUnitPrice_Validating;
            // 
            // tbProductWeight
            // 
            tbProductWeight.Anchor = AnchorStyles.None;
            tbProductWeight.Location = new Point(236, 228);
            tbProductWeight.Name = "tbProductWeight";
            tbProductWeight.Size = new Size(298, 27);
            tbProductWeight.TabIndex = 53;
            tbProductWeight.Validating += tbProductWeight_Validating;
            // 
            // tbProductName
            // 
            tbProductName.Anchor = AnchorStyles.None;
            tbProductName.Location = new Point(236, 133);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(298, 27);
            tbProductName.TabIndex = 52;
            tbProductName.Validating += tbProductName_Validating;
            // 
            // tbProductID
            // 
            tbProductID.Anchor = AnchorStyles.None;
            tbProductID.Location = new Point(236, 89);
            tbProductID.Name = "tbProductID";
            tbProductID.Size = new Size(298, 27);
            tbProductID.TabIndex = 51;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.Anchor = AnchorStyles.None;
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(128, 280);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 50;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbProductWeight
            // 
            lbProductWeight.Anchor = AnchorStyles.None;
            lbProductWeight.AutoSize = true;
            lbProductWeight.Location = new Point(128, 231);
            lbProductWeight.Name = "lbProductWeight";
            lbProductWeight.Size = new Size(56, 20);
            lbProductWeight.TabIndex = 49;
            lbProductWeight.Text = "Weight";
            // 
            // lbProductCategory
            // 
            lbProductCategory.Anchor = AnchorStyles.None;
            lbProductCategory.AutoSize = true;
            lbProductCategory.Location = new Point(128, 184);
            lbProductCategory.Name = "lbProductCategory";
            lbProductCategory.Size = new Size(69, 20);
            lbProductCategory.TabIndex = 48;
            lbProductCategory.Text = "Category";
            // 
            // labelProductName
            // 
            labelProductName.Anchor = AnchorStyles.None;
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(128, 136);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(49, 20);
            labelProductName.TabIndex = 47;
            labelProductName.Text = "Name";
            // 
            // lbProductName
            // 
            lbProductName.Anchor = AnchorStyles.None;
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(128, 92);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(24, 20);
            lbProductName.TabIndex = 46;
            lbProductName.Text = "ID";
            // 
            // errorProviderID
            // 
            errorProviderID.ContainerControl = this;
            // 
            // errorProviderName
            // 
            errorProviderName.ContainerControl = this;
            // 
            // errorProviderWeight
            // 
            errorProviderWeight.ContainerControl = this;
            // 
            // errorProviderPrice
            // 
            errorProviderPrice.ContainerControl = this;
            // 
            // errorProviderInStock
            // 
            errorProviderInStock.ContainerControl = this;
            // 
            // frmUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 566);
            Controls.Add(cbCategory);
            Controls.Add(tbUnitsInStock);
            Controls.Add(lbInStock);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbUnitPrice);
            Controls.Add(tbProductWeight);
            Controls.Add(tbProductName);
            Controls.Add(tbProductID);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbProductWeight);
            Controls.Add(lbProductCategory);
            Controls.Add(labelProductName);
            Controls.Add(lbProductName);
            MaximizeBox = false;
            Name = "frmUpdateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUpdateProduct";
            Load += frmUpdateProduct_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderID).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCategory;
        private TextBox tbUnitsInStock;
        private Label lbInStock;
        private Label label7;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbUnitPrice;
        private TextBox tbProductWeight;
        private TextBox tbProductName;
        private TextBox tbProductID;
        private Label lbUnitPrice;
        private Label lbProductWeight;
        private Label lbProductCategory;
        private Label labelProductName;
        private Label lbProductName;
        private ErrorProvider errorProviderID;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderWeight;
        private ErrorProvider errorProviderPrice;
        private ErrorProvider errorProviderInStock;
    }
}