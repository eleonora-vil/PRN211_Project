namespace SalesWinApp
{
    partial class frmProductsUser
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
            dgvProductManagement=new DataGridView();
            btnLogOut=new Button();
            btnLoad=new Button();
            cbSearchField=new ComboBox();
            btnViewCart=new Button();
            btnViewOrder=new Button();
            tbSearch=new TextBox();
            lbOrder=new Label();
            label1=new Label();
            btnSearch=new Button();
            lbEmail=new Label();
            btnProfile=new Button();
            btnCustom=new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductManagement).BeginInit();
            SuspendLayout();
            // 
            // dgvProductManagement
            // 
            dgvProductManagement.AllowUserToAddRows=false;
            dgvProductManagement.AllowUserToDeleteRows=false;
            dgvProductManagement.AllowUserToResizeRows=false;
            dgvProductManagement.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgvProductManagement.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductManagement.BackgroundColor=SystemColors.Control;
            dgvProductManagement.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.None;
            dgvProductManagement.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductManagement.Cursor=Cursors.Hand;
            dgvProductManagement.Location=new Point(13, 53);
            dgvProductManagement.Margin=new Padding(2, 3, 2, 3);
            dgvProductManagement.MultiSelect=false;
            dgvProductManagement.Name="dgvProductManagement";
            dgvProductManagement.ReadOnly=true;
            dgvProductManagement.RowHeadersBorderStyle=DataGridViewHeaderBorderStyle.None;
            dgvProductManagement.RowHeadersVisible=false;
            dgvProductManagement.RowHeadersWidth=62;
            dgvProductManagement.RowTemplate.Height=33;
            dgvProductManagement.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgvProductManagement.ShowEditingIcon=false;
            dgvProductManagement.Size=new Size(798, 391);
            dgvProductManagement.TabIndex=0;
            dgvProductManagement.CellClick+=dgvProductManagement_CellContentClick;
            dgvProductManagement.CellContentClick+=dgvProductManagement_CellContentClick_1;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            btnLogOut.Location=new Point(725, 536);
            btnLogOut.Margin=new Padding(2, 3, 2, 3);
            btnLogOut.Name="btnLogOut";
            btnLogOut.Size=new Size(86, 31);
            btnLogOut.TabIndex=1;
            btnLogOut.Text="Log out";
            btnLogOut.UseVisualStyleBackColor=true;
            btnLogOut.Click+=btnLogOut_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor=AnchorStyles.Bottom|AnchorStyles.Left;
            btnLoad.Location=new Point(13, 449);
            btnLoad.Margin=new Padding(2, 3, 2, 3);
            btnLoad.Name="btnLoad";
            btnLoad.Size=new Size(86, 31);
            btnLoad.TabIndex=2;
            btnLoad.Text="Load";
            btnLoad.UseVisualStyleBackColor=true;
            btnLoad.Click+=frmProducts_Load;
            // 
            // cbSearchField
            // 
            cbSearchField.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            cbSearchField.FormattingEnabled=true;
            cbSearchField.Location=new Point(496, 16);
            cbSearchField.Margin=new Padding(2, 3, 2, 3);
            cbSearchField.Name="cbSearchField";
            cbSearchField.Size=new Size(95, 28);
            cbSearchField.TabIndex=3;
            // 
            // btnViewCart
            // 
            btnViewCart.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            btnViewCart.Location=new Point(611, 449);
            btnViewCart.Margin=new Padding(2, 3, 2, 3);
            btnViewCart.Name="btnViewCart";
            btnViewCart.Size=new Size(93, 31);
            btnViewCart.TabIndex=4;
            btnViewCart.Text="View cart";
            btnViewCart.UseVisualStyleBackColor=true;
            btnViewCart.Click+=btnViewCart_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            btnViewOrder.Location=new Point(708, 449);
            btnViewOrder.Margin=new Padding(2, 3, 2, 3);
            btnViewOrder.Name="btnViewOrder";
            btnViewOrder.Size=new Size(101, 31);
            btnViewOrder.TabIndex=5;
            btnViewOrder.Text="View Order";
            btnViewOrder.UseVisualStyleBackColor=true;
            btnViewOrder.Click+=btnViewOrder_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            tbSearch.Location=new Point(597, 16);
            tbSearch.Margin=new Padding(2, 3, 2, 3);
            tbSearch.Name="tbSearch";
            tbSearch.Size=new Size(121, 27);
            tbSearch.TabIndex=6;
            tbSearch.TextChanged+=tbSearch_TextChanged;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize=true;
            lbOrder.Font=new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrder.Location=new Point(13, 12);
            lbOrder.Name="lbOrder";
            lbOrder.Size=new Size(99, 32);
            lbOrder.TabIndex=7;
            lbOrder.Text="Product";
            // 
            // label1
            // 
            label1.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            label1.AutoSize=true;
            label1.Location=new Point(442, 21);
            label1.Name="label1";
            label1.Size=new Size(53, 20);
            label1.TabIndex=8;
            label1.Text="Search";
            // 
            // btnSearch
            // 
            btnSearch.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            btnSearch.Location=new Point(723, 16);
            btnSearch.Margin=new Padding(3, 4, 3, 4);
            btnSearch.Name="btnSearch";
            btnSearch.Size=new Size(86, 31);
            btnSearch.TabIndex=9;
            btnSearch.Text="Search";
            btnSearch.UseVisualStyleBackColor=true;
            // 
            // lbEmail
            // 
            lbEmail.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            lbEmail.Location=new Point(547, 541);
            lbEmail.Name="lbEmail";
            lbEmail.RightToLeft=RightToLeft.No;
            lbEmail.Size=new Size(170, 20);
            lbEmail.TabIndex=10;
            lbEmail.TextAlign=ContentAlignment.MiddleRight;
            // 
            // btnProfile
            // 
            btnProfile.Location=new Point(104, 450);
            btnProfile.Name="btnProfile";
            btnProfile.Size=new Size(94, 29);
            btnProfile.TabIndex=11;
            btnProfile.Text="Profile";
            btnProfile.UseVisualStyleBackColor=true;
            btnProfile.Click+=btnProfile_Click;
            // 
            // btnCustom
            // 
            btnCustom.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            btnCustom.Location=new Point(514, 449);
            btnCustom.Margin=new Padding(2, 3, 2, 3);
            btnCustom.Name="btnCustom";
            btnCustom.Size=new Size(93, 31);
            btnCustom.TabIndex=4;
            btnCustom.Text="Custom";
            btnCustom.UseVisualStyleBackColor=true;
            btnCustom.Click+=btnCustom_Click;
            // 
            // frmProductsUser
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(823, 581);
            Controls.Add(btnProfile);
            Controls.Add(lbEmail);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(lbOrder);
            Controls.Add(tbSearch);
            Controls.Add(btnViewOrder);
            Controls.Add(btnCustom);
            Controls.Add(btnViewCart);
            Controls.Add(cbSearchField);
            Controls.Add(btnLoad);
            Controls.Add(btnLogOut);
            Controls.Add(dgvProductManagement);
            Margin=new Padding(2, 3, 2, 3);
            MinimumSize=new Size(839, 618);
            Name="frmProductsUser";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Product";
            FormClosing+=frmProductsUser_FormClosing;
            Load+=frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductManagement;
        private Button btnLogOut;
        private Button btnLoad;
        private ComboBox cbSearchField;
        private Button btnViewCart;
        private Button btnViewOrder;
        private TextBox tbSearch;
        private Label lbOrder;
        private Label label1;
        private Button btnSearch;
        private Label lbEmail;
        private Button btnProfile;
        private Button btnCustom;
    }
}