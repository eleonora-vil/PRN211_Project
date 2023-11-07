namespace SalesWinApp
{
    partial class frmMember
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
            dgvMemberManagement = new DataGridView();
            lbMemberManagement = new Label();
            btnNew = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            tbSearch = new TextBox();
            label7 = new Label();
            cbFilterCity = new ComboBox();
            btnUpdate = new Button();
            label1 = new Label();
            cbFilterCountry = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMemberManagement).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMemberManagement
            // 
            dgvMemberManagement.AllowUserToAddRows = false;
            dgvMemberManagement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMemberManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMemberManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberManagement.Location = new Point(11, 125);
            dgvMemberManagement.MultiSelect = false;
            dgvMemberManagement.Name = "dgvMemberManagement";
            dgvMemberManagement.ReadOnly = true;
            dgvMemberManagement.RowHeadersWidth = 51;
            dgvMemberManagement.RowTemplate.Height = 29;
            dgvMemberManagement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberManagement.Size = new Size(776, 201);
            dgvMemberManagement.TabIndex = 0;
            dgvMemberManagement.CellClick += dgvMemberManagement_CellClick;
            // 
            // lbMemberManagement
            // 
            lbMemberManagement.Anchor = AnchorStyles.Top;
            lbMemberManagement.AutoSize = true;
            lbMemberManagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbMemberManagement.Location = new Point(260, 20);
            lbMemberManagement.Name = "lbMemberManagement";
            lbMemberManagement.Size = new Size(283, 31);
            lbMemberManagement.TabIndex = 1;
            lbMemberManagement.Text = "MEMBER MANAGEMENT";
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top;
            btnNew.Location = new Point(279, 21);
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
            btnDelete.Location = new Point(540, 21);
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
            btnLoad.Location = new Point(152, 21);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top;
            tbSearch.Location = new Point(575, 80);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(182, 27);
            tbSearch.TabIndex = 7;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(513, 80);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 8;
            label7.Text = "Search:";
            // 
            // cbFilterCity
            // 
            cbFilterCity.AllowDrop = true;
            cbFilterCity.Anchor = AnchorStyles.Top;
            cbFilterCity.FormattingEnabled = true;
            cbFilterCity.Items.AddRange(new object[] { "--City--" });
            cbFilterCity.Location = new Point(96, 77);
            cbFilterCity.Name = "cbFilterCity";
            cbFilterCity.Size = new Size(115, 28);
            cbFilterCity.TabIndex = 9;
            cbFilterCity.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.Location = new Point(416, 21);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(45, 80);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 12;
            label1.Text = "Filter:";
            // 
            // cbFilterCountry
            // 
            cbFilterCountry.AllowDrop = true;
            cbFilterCountry.Anchor = AnchorStyles.Top;
            cbFilterCountry.FormattingEnabled = true;
            cbFilterCountry.Items.AddRange(new object[] { "--Country--" });
            cbFilterCountry.Location = new Point(217, 77);
            cbFilterCountry.Name = "cbFilterCountry";
            cbFilterCountry.Size = new Size(123, 28);
            cbFilterCountry.TabIndex = 13;
            cbFilterCountry.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 15;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 451);
            Controls.Add(panel1);
            Controls.Add(cbFilterCountry);
            Controls.Add(label1);
            Controls.Add(cbFilterCity);
            Controls.Add(label7);
            Controls.Add(tbSearch);
            Controls.Add(lbMemberManagement);
            Controls.Add(dgvMemberManagement);
            Name = "frmMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMemberManagement_FormClosing;
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberManagement).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberManagement;
        private Label lbMemberManagement;
        private Button btnNew;
        private Button btnDelete;
        private Button btnLoad;
        private TextBox tbSearch;
        private Label label7;
        private ComboBox cbFilterCity;
        private Button btnUpdate;
        private Label label1;
        private ComboBox cbFilterCountry;
        private Panel panel1;
    }
}