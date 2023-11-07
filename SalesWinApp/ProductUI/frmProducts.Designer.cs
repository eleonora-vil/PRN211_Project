namespace SalesWinApp
{
    partial class frmProducts
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
            lbMemberManagement = new Label();
            dgvProductManagement = new DataGridView();
            btnNew = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            label7 = new Label();
            tbSearch = new TextBox();
            btnUpdate = new Button();
            panel1 = new Panel();
            cbSearchField = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductManagement).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbMemberManagement
            // 
            lbMemberManagement.Anchor = AnchorStyles.Top;
            lbMemberManagement.AutoSize = true;
            lbMemberManagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbMemberManagement.Location = new Point(298, 10);
            lbMemberManagement.Name = "lbMemberManagement";
            lbMemberManagement.Size = new Size(292, 31);
            lbMemberManagement.TabIndex = 17;
            lbMemberManagement.Text = "PRODUCT MANAGEMENT";
            // 
            // dgvProductManagement
            // 
            dgvProductManagement.AllowUserToAddRows = false;
            dgvProductManagement.AllowUserToOrderColumns = true;
            dgvProductManagement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductManagement.Location = new Point(11, 115);
            dgvProductManagement.MultiSelect = false;
            dgvProductManagement.Name = "dgvProductManagement";
            dgvProductManagement.ReadOnly = true;
            dgvProductManagement.RowHeadersWidth = 51;
            dgvProductManagement.RowTemplate.Height = 29;
            dgvProductManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductManagement.Size = new Size(853, 338);
            dgvProductManagement.TabIndex = 16;
            dgvProductManagement.CellClick += dgvProductManagement_CellClick;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top;
            btnNew.Location = new Point(320, 16);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.Location = new Point(581, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top;
            btnLoad.Location = new Point(193, 16);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(487, 64);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 19;
            label7.Text = "Search:";
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(682, 61);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(182, 27);
            tbSearch.TabIndex = 18;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.Location = new Point(457, 16);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 480);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 68);
            panel1.TabIndex = 24;
            // 
            // cbSearchField
            // 
            cbSearchField.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbSearchField.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchField.FormattingEnabled = true;
            cbSearchField.Location = new Point(549, 61);
            cbSearchField.Name = "cbSearchField";
            cbSearchField.Size = new Size(127, 28);
            cbSearchField.TabIndex = 25;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(877, 548);
            Controls.Add(cbSearchField);
            Controls.Add(lbMemberManagement);
            Controls.Add(dgvProductManagement);
            Controls.Add(label7);
            Controls.Add(tbSearch);
            Controls.Add(panel1);
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducts";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmProducts_FormClosing;
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductManagement).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberManagement;
        private DataGridView dgvProductManagement;
        private Button btnNew;
        private Button btnDelete;
        private Button btnLoad;
        private Label label7;
        private TextBox tbSearch;
        private Button btnUpdate;
        private Panel panel1;
        private ComboBox cbSearchField;
    }
}