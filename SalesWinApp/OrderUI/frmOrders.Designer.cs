namespace SalesWinApp
{
    partial class frmOrders
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
            dgvOrders = new DataGridView();
            lbFrom = new Label();
            lbTo = new Label();
            btnFilter = new Button();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(11, 92);
            dgvOrders.Margin = new Padding(2);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.RowTemplate.Height = 33;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(658, 306);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;
            // 
            // lbFrom
            // 
            lbFrom.Anchor = AnchorStyles.Top;
            lbFrom.AutoSize = true;
            lbFrom.Location = new Point(44, 16);
            lbFrom.Margin = new Padding(2, 0, 2, 0);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(43, 20);
            lbFrom.TabIndex = 1;
            lbFrom.Text = "From";
            // 
            // lbTo
            // 
            lbTo.Anchor = AnchorStyles.Top;
            lbTo.AutoSize = true;
            lbTo.Location = new Point(44, 52);
            lbTo.Margin = new Padding(2, 0, 2, 0);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(25, 20);
            lbTo.TabIndex = 2;
            lbTo.Text = "To";
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Top;
            btnFilter.Location = new Point(238, 48);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(90, 27);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Anchor = AnchorStyles.Top;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(92, 16);
            dtpFrom.Margin = new Padding(2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(142, 27);
            dtpFrom.TabIndex = 4;
            dtpFrom.Value = new DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            dtpTo.Anchor = AnchorStyles.Top;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(92, 48);
            dtpTo.Margin = new Padding(2);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(142, 27);
            dtpTo.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom;
            btnClose.Location = new Point(284, 420);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 30);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 462);
            Controls.Add(btnClose);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(btnFilter);
            Controls.Add(lbTo);
            Controls.Add(lbFrom);
            Controls.Add(dgvOrders);
            Margin = new Padding(2);
            Name = "frmOrders";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmOrders";
            WindowState = FormWindowState.Maximized;
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Label lbFrom;
        private Label lbTo;
        private Button btnFilter;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnClose;
    }
}