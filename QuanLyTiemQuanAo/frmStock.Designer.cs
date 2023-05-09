﻿namespace QuanLyTiemQuanAo
{
    partial class frmStock
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.branch_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1278, 47);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyTiemQuanAo.Properties.Resources.Action_Close_32x32;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 44);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 47);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.dgvStock);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1278, 463);
            this.splitContainerControl1.SplitterPosition = 102;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branch_id,
            this.product_id,
            this.quantity});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(1278, 349);
            this.dgvStock.TabIndex = 1;
            // 
            // branch_id
            // 
            this.branch_id.DataPropertyName = "branch_id";
            this.branch_id.HeaderText = "Chi nhánh";
            this.branch_id.MinimumWidth = 6;
            this.branch_id.Name = "branch_id";
            this.branch_id.Width = 125;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Sản phẩm";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.Width = 125;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1278, 102);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin kho hàng";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbSearch);
            this.layoutControl1.Controls.Add(this.txtSearch);
            this.layoutControl1.Controls.Add(this.btnTim);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 28);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 0, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1274, 72);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1274, 72);
            this.Root.TextVisible = false;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(404, 12);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(91, 24);
            this.cbSearch.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbSearch;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "Tìm kiếm";
            this.layoutControlItem6.Location = new System.Drawing.Point(327, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(160, 52);
            this.layoutControlItem6.Text = "Tìm kiếm";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(53, 16);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(499, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 25);
            this.txtSearch.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtSearch;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(487, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(292, 52);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // btnTim
            // 
            this.btnTim.ImageOptions.Image = global::QuanLyTiemQuanAo.Properties.Resources.Search_16x16;
            this.btnTim.Location = new System.Drawing.Point(791, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(93, 27);
            this.btnTim.StyleController = this.layoutControl1;
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnTim;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(779, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(97, 52);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(327, 52);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(876, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(378, 52);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 510);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmStock";
            this.Text = "Danh sách sản phẩm trong kho";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewComboBoxColumn branch_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.ComboBox cbSearch;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}