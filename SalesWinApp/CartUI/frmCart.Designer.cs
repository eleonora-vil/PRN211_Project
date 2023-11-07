namespace SalesWinApp
{
    partial class frmCart
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
            dgvCart = new DataGridView();
            btnSaveOrder = new Button();
            btnUpdateQuantity = new Button();
            btnDelete = new Button();
            label1 = new Label();
            lbTotal = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToOrderColumns = true;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = SystemColors.Control;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCart.Location = new Point(13, 15);
            dgvCart.Margin = new Padding(2, 3, 2, 3);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 62;
            dgvCart.RowTemplate.Height = 33;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.ShowEditingIcon = false;
            dgvCart.Size = new Size(619, 295);
            dgvCart.TabIndex = 0;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveOrder.Location = new Point(546, 315);
            btnSaveOrder.Margin = new Padding(2, 3, 2, 3);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(86, 31);
            btnSaveOrder.TabIndex = 1;
            btnSaveOrder.Text = "Save Order";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateQuantity.Location = new Point(13, 315);
            btnUpdateQuantity.Margin = new Padding(2, 3, 2, 3);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new Size(86, 31);
            btnUpdateQuantity.TabIndex = 2;
            btnUpdateQuantity.Text = "Update";
            btnUpdateQuantity.UseVisualStyleBackColor = true;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(103, 315);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(378, 320);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 5;
            label1.Text = "Total";
            // 
            // lbTotal
            // 
            lbTotal.Location = new Point(426, 315);
            lbTotal.Name = "lbTotal";
            lbTotal.RightToLeft = RightToLeft.Yes;
            lbTotal.Size = new Size(114, 31);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "0";
            lbTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Location = new Point(193, 315);
            btnClose.Margin = new Padding(2, 3, 2, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnClose);
            Controls.Add(lbTotal);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdateQuantity);
            Controls.Add(btnSaveOrder);
            Controls.Add(dgvCart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimumSize = new Size(656, 396);
            Name = "frmCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart List";
            Load += frmCart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCart;
        private Button btnSaveOrder;
        private Button btnUpdateQuantity;
        private Button btnDelete;
        private Label label1;
        private Label lbTotal;
        private Button btnClose;
    }
}